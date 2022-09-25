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
import win32pipe, win32file

class PipeServer():
    def __init__(self, pipeName):
        self.pipe = win32pipe.CreateNamedPipe(
        r'\\.\pipe\\'+pipeName,
        win32pipe.PIPE_ACCESS_OUTBOUND,
        win32pipe.PIPE_TYPE_MESSAGE | win32pipe.PIPE_READMODE_MESSAGE | win32pipe.PIPE_WAIT,
        1, 65536, 65536,
        0,
        None)
    
    #Carefull, this blocks until a connection is established
    def connect(self):
        win32pipe.ConnectNamedPipe(self.pipe, None)
    
    #Message without tailing '\n'
    def write(self, message):
        win32file.WriteFile(self.pipe, message.encode()+b'\n')

    def close(self):
        win32file.CloseHandle(self.pipe)


t = PipeServer("CSServer")
t.connect()
t.write("Hello from Python :)")
print("Hello from Python :)")
t.write("Closing now...")
print("Closing now...")
t.close()

host = '127.0.0.1'
port = 9000
locaddr = (host,port) 







