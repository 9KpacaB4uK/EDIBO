inputNumber = input(("Input decimal number: "))
if inputNumber.isdigit():
    print(inputNumber,"=",bin(int(inputNumber))[2:])
else:
    print("Error 1: It's not decimal number!")
