for i in range(4):
    print("*"*i)
print("\n")
for i in range(3,0,-1):
    print("*"*i)
print("\n")
for i in range(3,0,-1):
    print(" "*(3-i)+"*"*i)

for i in range(4):
    print(" "*(3-i)+"*"*i)

for i in range(4):
    print(" "*(3-i)+"* "*i)

data="Python"
for i in range(len(data)+1):
    print(" "*(len(data)-i)+data[0:i])

input()
