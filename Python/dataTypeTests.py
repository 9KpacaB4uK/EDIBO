#!/usr/bin/python

#List
print("#############################","List","#############################\n")
firstList = ["apple","banana","cherry","orange","kiwi"]
print(firstList)

print("first element: ",firstList[0])
print("last element: ",firstList[-0])
print("elements between 2 and last-1: ",firstList[2:(len(firstList)-1)])

print("coppy one list to other and join twi lists: ")
secondList = list(firstList)
for i in secondList:
	firstList.append(i)
print(firstList)

print("delete first element: ")
del firstList[0]
print(firstList)
print("Add element to the first and last position: ")
firstList.append("last")
firstList.insert(0,"first")
print(firstList)
#Tuples
print("#############################","Tuples","#############################\n")
firstTuple = ("apple","banana","cherry")
print(firstTuple)
print("first element:",firstTuple[0],"last element:",firstTuple[0])
print("check if banana is present in tuple: ")
if("banana" in firstTuple):
	print("yes")
print("tuple methods:,count(),index()")
#Sets
print("#############################","Sets","#############################\n")
firstSet = {"apple","banana","cherry"}
print(firstSet)
print("add new element: ")
firstSet.add("orange")
print (firstSet)
print("add a few items: ")
firstSet.update(["mango","grapes"])
print(firstSet)
print("Remove mango: ")
firstSet.discard("mango") #.remove() if not found than error
print(firstSet)
#Dictionaries
print("#############################","Dictionaries","#############################\n")
firstDict = {
	"car1":{
		"model": "Mustang",
		"brand": "Ford",
		"year": 2019
	},
	"car2":{
		"model": "Carvet",
		"brand": "Honda",
		"year": 1970
	}
}
print (firstDict)
#print("model: ",firstDict["model"]) #print(firstDict.get("model"))
print("change value: ")
firstDict["year"] = 1985
print("new year: ",firstDict.get("year"))
print("add new item: ")
firstDict["color"] = "red"
print(firstDict)
