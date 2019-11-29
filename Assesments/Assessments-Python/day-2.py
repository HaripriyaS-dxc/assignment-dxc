#products

products=[{"Id":"101",
"Name":"Laptop",
"Category":"Electronics",
"Brand":"HP",
"Cost":"500000",
"Rating":"8.9",
"Discount":"30"
},
{"Id":"102",
"Name":"Mobile",
"Category":"Electronics",
"Brand":"Oneplus",
"Cost":"30000",
"Rating":"9.1",
"Discount":"20"},
{"Id":"103",
"Name":"Dress",
"Category":"Clothing",
"Brand":"Zara",
"Cost":"3000",
"Rating":"9.1",
"Discount":"40"},
{"Id":"104",
"Name":"Shoes",
"Category":"Clothing",
"Brand":"Nike",
"Cost":"5000",
"Rating":"8.5",
"Discount":"20"},
{"Id":"105",
"Name":"Shirt",
"Category":"Clothing",
"Brand":"LV",
"Cost":"4000",
"Rating":"7.3",
"Discount":"40"}
]

choice=int(input("1.Sort\n2.Filter\n"))
if choice==1:

    c1=int(input("1.Sort by cost Low to High\n2.Sort to cost High to Low\n3.Sort by rating\n4.Sort by discount Low to high\n5.Sort by discount High to low\n"))
    sorting=[["temp"],["Cost",False],["Cost",True],["Rating",True],["Discount",False],["Discount",True]]

    products.sort(key=(lambda el: int(el[(sorting[c1][0])])),reverse=sorting[c1][1])
    for i in products[1]:
        print(i,end="\t")
    print("\n")
    for i in products:
        print('{Id}\t{Name}\t{Category}\t{Brand}\t{Cost}\t{Rating}\t{Discount}'.format(**i))
    
        
elif choice == 2:

    c2=int(input("1.Filter by Category\n2.Filter by Name\n3.Filter by Brand\n"))
    data=input("Enter required filter\n")
    fil=["temp","Category","Name","Brand"]

    obj=filter(lambda el: el[fil[c2]]==data,products)
    for i in products[1]:
        print(i,end="\t")
    print("\n")
    for j in obj:
        print('{Id}\t{Name}\t{Category}\t{Brand}\t{Cost}\t{Rating}\t{Discount}'.format(**j))

else:
    print("Invalid Choice!")

input()
    


        

