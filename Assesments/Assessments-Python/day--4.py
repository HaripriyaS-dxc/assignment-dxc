def strval(a):
    def inner(*pargs,**kwargs):
        for i in (pargs):
            if i.__class__.__name__ != "str":
                print("Invalid Input")
                break
        else:
            for i in (kwargs.values()):
                if i.__class__.__name__ != "str":
                    print("Invalid Input")
                    break
            else:
                a(*pargs,**kwargs)
    return inner

@strval#shortcut(decorator) to assign as wrapper
def sayhi(name):
    print("Hi",name)
@strval
def sayhello(name,place):
    print("Hello",name,"from",place)
#wrapper function
    #inner functions wraps a

sayhi("Jan")#sent to *args as positional arguments in the form of tuple
sayhello(place="Blore",name="Jan")#sent to *kwargs as keyworded arguments in the form of a dictionary
sayhello("May","Chennai")#sent to *args as positional arguments in the form of tuple
sayhello("Jan",place="Mysore")

input()
