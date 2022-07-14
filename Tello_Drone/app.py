
import threading  # for threading
import socket # Import socket module
import sys # for exit()
import time # Importing the time module
import platform  # For getting the operating system name
from calendar import c 
from multiprocessing import connection
import tkinter as tk
from tkinter import filedialog, Text
import os


host = '' # Get local machine name
port = 9000 # Port number
locaddr = (host,port)  # Define the server address
root = tk.Tk() # Create a window
root.title("Tello Drone")

# Create a UDP socket
sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)

tello_address = ('192.168.10.1', 8889)

sock.bind(locaddr)

def recv():
    count = 0
    while True: 
        try:
            data, server = sock.recvfrom(1518)
            print(data.decode(encoding="utf-8"))
        except Exception:
            print ('\nExit . . .\n')
            break


#recvThread create
recvThread = threading.Thread(target=recv)
recvThread.start()

while True: 
    try:
        python_version = str(platform.python_version())
        version_init_num = int(python_version.partition('.')[0]) 
       # print (version_init_num)
        if version_init_num == 3:
            msg = input("");
        elif version_init_num == 2:
            msg = raw_input("");
        
        if not msg:
            break  

        if 'end' in msg:
            print ('...')
            sock.close()  
            break

        # Send data
        msg = msg.encode(encoding="utf-8") 
        sent = sock.sendto(msg, tello_address)
    except KeyboardInterrupt:
        print ('\n . . .\n')
        sock.close()  
        break

from djitellopy import Tello

drone = Tello()

# plot lawn with 1, house with 2. Each element represents a 40 by 40 cm area.
plot = [[0, 0, 0, 0, 0],
        [0, 0, 0, 0, 0],
        [0, 1, 1, 1, 0],
        [0, 1, 1, 1, 0],
        [0, 0, 2, 0, 0]]


# scroll through list to find location of house
def findHouse():
    for r in plot:
        for c in r:
            if c == 2:
                return[plot.index(r), r.index(c)]


# sets drone starting position for first move
prevPos = findHouse()

# takeoff
drone.connect()
time.sleep(5)
drone.takeoff()
time.sleep(5)
drone.move_up(40)
time.sleep(5)

# scroll through list and find unwatered lawn
for r in plot:
    for c in r:
        if c == 1:
            x = (plot.index(r) - prevPos[0]) * 40
            y = (r.index(c) - prevPos[1]) * 40
            drone.go_xyz_speed(x, y, 0, 20)  # move to unwatered lawn space
            time.sleep(5)
            prevPos = [plot.index(r), r.index(c)]  # set starting pos for next move to current location
            r[r.index(c)] = 0  # mark current space as empty to tell drone to move on

time.sleep(3)
x = (findHouse()[0] - prevPos[0]) * 40
y = (findHouse()[1] - prevPos[1]) * 40
drone.go_xyz_speed(x, y, 0, 20)  # moves back to initial position (house)
time.sleep(3)
drone.land()



print ('\r\n\r\nTello Python3 Demo.\r\n')

print ('Tello: command takeoff land flip forward back left right \r\n       up down cw ccw speed speed?\r\n')

print ('end -- quit demo.\r\n')