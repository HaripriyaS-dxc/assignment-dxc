class Products:
    def __init__(self,Id,Name,Category,Brand,Cost,Rating,Discount):
        self.Id=Id
        self.Name=Name
        self.Category=Category
        self.Brand=Brand
        self.Cost=Cost
        self.Rating=Rating
        self.Discount=Discount


product1=Products(101,"Laptop","Electronics","HP",50000,8.9,30)
product2=Products(102,"Mobile","Electronics","1+",30000,9.1,20)
product3=Products(103,"Dress  ","Clothing    ","Zara",3000,9.1,40)
product4=Products(104,"Shoes  ","Clothing    ","Nike",5000,8.5,20)
product5=Products(105,"Shirt  ","Clothing    ","LV",4000,7.3,40)

products=[product1,product2,product3,product4,product5]


choice=int(input("1.Sort\n2.Filter\n"))
if choice==1:

    c1=int(input("1.Sort by cost Low to High\n2.Sort to cost High to Low\n3.Sort by rating\n4.Sort by discount Low to high\n5.Sort by discount High to low\n"))
    sorting=[["temp"],["Cost",False],["Cost",True],["Rating",True],["Discount",False],["Discount",True]]

    products.sort(key=(lambda el: el.__dict__[(sorting[c1][0])]),reverse=sorting[c1][1])
 

    print("Id\tName\t\tCategory\tBrand\tCost\tRating\tDiscount\n")
    for i in products:
        print(i.Id,"\t",i.Name,"\t",i.Category,"\t",i.Brand,"\t",i.Cost,"\t",i.Rating,"\t",i.Discount)
        
elif choice == 2:

    c2=int(input("1.Filter by Category\n2.Filter by Name\n3.Filter by Brand\n"))
    data=input("Enter required filter\n")
    fil=["temp","Category","Name","Brand"]

    obj=filter(lambda el: el.__dict__[fil[c2]]==data,products)
    
    print("Id\tName\t\tCategory\tBrand\tCost\tRating\tDiscount\n")
    for i in obj:
        print(i.Id,"\t",i.Name,"\t",i.Category,"\t",i.Brand,"\t",i.Cost,"\t",i.Rating,"\t",i.Discount)

else:
    print("Invalid Choice!")

input()
