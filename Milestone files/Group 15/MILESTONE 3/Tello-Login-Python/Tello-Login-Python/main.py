###########################################
#Global Variables# 

import time
granted = False
global usertype

###########################################
# Start Of Functions #

#Grants Or Revokes Access
def grant():
    global granted
    granted = True
    
def revoke():
    global granted
    granted = False
    begin()
    
def pages():
    if(granted):
     if(usertype=="admin"):
      admin()
     else:
      user()
    
#Admin Page
def admin():
    print("### USER DETAILS ###")
    print("Username: ",name)
    print("Access Type: Admin", )
    print("##############################")
    option = input("Please type 'logout' or 'register': ")
    if(option=="logout"):
        logout()
    if(option=="register"):
        adminreg()
    else:
        admin()

def adminreg():
    print("Enter the new name, password, and access level to register")
    name = input("Enter your name: ")
    password = input("Enter your password: ")
    level = input("Enter new user access level 'admin'/'user': ")
    register(name,password,level)
    admin()
    
#User Page
def user():
    print("### USER DETAILS ###")
    print("Username: ",name)
    print("Access Type: User", )
    print("##############################")
    option = input("Type 'logout' to leave: ")
    if(option=="logout"):
        logout()
    else:
        user()
    
 #Login funciton, checks txt file and cross verifies with local string   
def login(name,password):
    success = False
    file = open("user_detail.txt","r")
    for i in file:
         a,b,c = i.split(",")
         b = b.strip()
         c = c.strip()
         if(a==name and b==password):
             success = True
             global usertype
             usertype = c
             break
    file.close()
    if(success):
        print("-------------------")
        print("Login Successful")
        print("-------------------")
        grant()
        pages()
    else:
        print("-------------------")
        print("wrong user name or password")
        print("-------------------")
        begin()
        
#Logout function, takes you back to the main menu        
def logout():
        print("Logging out...")
        time.sleep(3)
        revoke()
        
#Register function, registers new user + password + access(admin/user)
def register(name,password,level):
    file = open("user_detail.txt","a")
    file.write("\n"+name+","+password+","+level)
    grant()
    
#Assigns local strings and uses them to call the login funciton
def access(option):
    global name
    if(option=="login"):
        name = input("Enter your name: ")
        password = input("Enter your password: ")
        login(name,password)
        
#The reason that there is a "begin" function and the code doesn't just start at the "access" function is because once the UI is complete the "access" function will be called via a button instead of typing "login". 
def begin():
    global option
    print("-~~--~~--~~--~~--~~--~~--~~--~~--~~-")
    print("Welcome to the BC Tello interface  |")
    print("-~~--~~--~~--~~--~~--~~--~~--~~--~~-")
    option = input("Please type 'login' to begin: ")
    if(option=="login"):
        access(option)
        
###########################################
# Start Of Code #
        
begin()

     

    
