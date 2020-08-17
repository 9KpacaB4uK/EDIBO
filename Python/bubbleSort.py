import timeit
import random
#bubble sort algorithm in Python
#Source of algorithm https://www.youtube.com/watch?v=xli_FI7CuzA

def listCreator(rangeList,rangeNumbers):
    for i in range(0,rangeList):
        listOfNumbers.append(random.randint(1,rangeNumbers))

listOfNumbers = []

#List for test
listCreator(5,100)

#listCreator(100,10000) #Time of 100 numbers = ~0.004
#listCreator(500,10000) #Time of 500 numbers = ~0.096 ==> time has increased x25
#listCreator(1000,10000) #Time of 1000 numbers = ~0.399 ==>time has increased x100
print("List before:",listOfNumbers, end="\n")
i = 1
sizeOfList = len(listOfNumbers)
#start = timeit.default_timer()
for i in range(sizeOfList):
    j = 0
    for j in range(sizeOfList-1):
        if listOfNumbers[j] > listOfNumbers[j+1]:
            buffer = listOfNumbers[j]
            listOfNumbers[j] = listOfNumbers[j+1]
            listOfNumbers[j+1] = buffer
            print(listOfNumbers, end="\n")
#stop = timeit.default_timer()
print("List after:",listOfNumbers, end=" ")
#print("Time: ",float("{:.5f}".format(stop - start)))
        