class InvalidCredentials(Exception):
    def __init__(self,msg="Invalid credentials. Enter correct username and password!"):
        Exception.__init__(self,msg)

try:
    cred={"April":"passApr","May":"passMay","Jan":"passJan","June":"passJun"}
    uname=input("Enter Username: ")
    pword=input("Enter Password: ")
    if uname not in cred or pword != cred[uname]:
            raise InvalidCredentials
    print("Hello",uname,"Welcome to whatever page!")
except Exception as e:
    print("Generic Handler: ",e)
        
input()
