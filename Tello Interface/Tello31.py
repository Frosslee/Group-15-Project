#
# Tello Python3 Control Demo 
#
# http://www.ryzerobotics.com/
#
# 1/1/2018

import threading 
import socket
import sys
import time
import platform
import win32file
import win32pipe

host = ''
port = 9000
locaddr = (host,port)
sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)

tello_address = ('192.168.10.1', 8889)

sock.bind(locaddr)
# Create a UDP socket

def recv():
    count = 0
    while True: 
        try:
            data, server = sock.recvfrom(1518)
            print(data.decode(encoding="utf-8"))
        except Exception:
            print ('\nExit . . .\n')
            break



#Pipe Server To Communicate With C#
pipeName="CSServer"
pipe_handle = win32pipe.CreateNamedPipe(
        r'\\.\pipe\\'+pipeName,
        win32pipe.PIPE_ACCESS_DUPLEX,
        win32pipe.PIPE_TYPE_MESSAGE | win32pipe.PIPE_READMODE_MESSAGE | win32pipe.PIPE_WAIT,
        1, 65536, 65536,
        0,
        None)
win32pipe.ConnectNamedPipe(pipe_handle, None)
ret, length = win32file.WriteFile(pipe_handle, 'Hello from Python\n'.encode())
print(F'{ret = }, {length = } from WriteFile')
ret, length = win32file.WriteFile(pipe_handle, 'Tello Python3 Demo.\n'.encode())
print(F'{ret = }, {length = } from WriteFile')
ret, length = win32file.WriteFile(pipe_handle, 'Tello: command takeoff land flip forward back left right \r\n       up down cw ccw speed speed?\n'.encode())
print(F'{ret = }, {length = } from WriteFile')
ret, length = win32file.WriteFile(pipe_handle, 'Press ~ to quit demo.\n'.encode())
print(F'{ret = }, {length = } from WriteFile')


#recvThread create
recvThread = threading.Thread(target=recv)
recvThread.start()
win32file.FlushFileBuffers(pipe_handle)
   # win32pipe.DisconnectNamedPipe(pipe_handle)
    #win32file.CloseHandle(pipe_handle)

while True: 
    msg = ""
    try:
        python_version = str(platform.python_version())
        version_init_num = int(python_version.partition('.')[0]) 
       # print (version_init_num)
        if version_init_num == 3:
            ret, read_message = win32file.ReadFile(pipe_handle, 1000)
            print(read_message.decode('utf-8'))
            msg = read_message.decode('utf-8');
        
        
        if not msg:
            break  

        if 'end' in msg:
            print ('...quitting')
            sock.close()  
            break

        # Send data
        msg = msg.encode(encoding="utf-8") 
        sent = sock.sendto(msg, tello_address)
    except KeyboardInterrupt:
        print ('\n . . .\n')
        sock.close()  
        break
    





