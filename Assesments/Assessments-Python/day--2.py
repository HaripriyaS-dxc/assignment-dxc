#returning multiple objects
def createWallet(user,balance):
    def deposit(amount):
        nonlocal balance
        balance=balance+amount
        print("Deposited for",user,". New Balance:",balance)
    def withdraw(amount):
        nonlocal balance
        if balance>amount:
            balance=balance-amount
            print("Withdrawl from",user,"New balance:",balance)
        else:
            print("Insufficient balance:",balance)
    def statement():
        print("Current balance :",balance)
    def transfer(recipient,amount):
        nonlocal balance
        if balance>amount:
            balance=balance-amount
            recipient[0](amount)
        else:
            print("Insufficient balance")
        print("Deposited",amount,"by",user)
    return [deposit,withdraw,statement,transfer]


user1=createWallet("user1",1000)
user2=createWallet("user2",1000)

#deposit
user1[0](500)
#withdrawl
user1[1](450)
#statement
user1[2]()
#transfer
user1[3](user2,150)

input()
