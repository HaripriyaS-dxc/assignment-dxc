import urllib.request as urllib
from bs4 import BeautifulSoup
import re
import pymysql

data=urllib.urlopen('https://www.moneycontrol.com/').read()
soup = BeautifulSoup(data,'lxml')
x=0;
li1=[]

for i in soup.find_all("div",attrs={"id" :'tlSensex'}):
    for j in i.find_all("td"):
        print(j.string)
        li1.append(j.string)
  
for i in soup.find_all("div",attrs={"id" :'tlNifty'}):
    for j in i.find_all("td"):
        print(j.string)

for i in soup.find_all("div",attrs={"id" :'tgSensex'}):
    for j in i.find_all("td"):
        print(j.string)
  
for i in soup.find_all("div",attrs={"id" :'tgNifty'}):
    for j in i.find_all("td"):
        print(j.string)
        
db = pymysql.connect("localhost","root","","test" )
cursor = db.cursor()

for i in range(1,5):
    
cursor.execute("""INSERT INTO SENLOSER
         VALUES (%s,%s,%s,%s)""",(li1[0],li1[1],li1[2],li1[3]))
db.commit()
db.close()
