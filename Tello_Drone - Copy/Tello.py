from calendar import c
import tkinter as tk
from tkinter import filedialog, Text
import os

root = tk.Tk()


def connectDB():
    os.system("python3 connectDB.py")
    root.destroy()
    
global dbName
dbName = filedialog.askopenfilename()
print(dbName)
if dbName == "": print("No file selected")
else: print("File selected")
print(dbName)
os.system("python3 main.py " + dbName)
print("Done")
def closeApp(): root.destroy()


canvas = tk.Canvas(root, height=700, width=700, bg="#263D42") 
canvas.pack() 

frame = tk.Frame(root, bg="white") 
frame.place(relwidth=0.8, relheight=0.8, relx=0.1, rely=0.1) 

openFile = tk.Button(root, text="Connect to DB", padx=10, pady=5, fg="blue", bg="#263D42", command=connectDB) #, command=openFile 
openFile.pack() 
openFile = tk.Button(root, text="Close", padx=10, pady=5, fg="red", bg="#263D42", command=closeApp) #, command=openFile 
openFile.pack() 
root.mainloop()
