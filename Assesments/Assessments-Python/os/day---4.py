import os,re
dir = "C:/Users/hs55/Documents/Training/Python/Assessments-Python/os"
for root, dirs, files in os.walk(dir):
    for file in files:
        if file.endswith('.log'):
            fo=open(file,"r")
            data=fo.read()
            pattern='[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+'
            matches=re.findall(pattern,data)
            if(matches):
                for match in matches:
                    print(match)
            else:
                print("none found")


number=input("enter the phone number:\n")
pattern='^[0-9]{10}$'
matches=re.match(pattern,number)
if matches:
    print("valid number")
else:
    print("invalid number")

