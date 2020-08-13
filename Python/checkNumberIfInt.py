#!/usr/bin/python3.6
print("#########","Check 2^n","###########")
a = 0
while (a != "1" or a != "2"):
	a = (input("Choose variant(1 or 2): "))
	if (a == "1"):
		#1 variant
		print("1.variant")
		a = (input("Enter number: "))
		if a.isdigit():
			print("2 ^",a," = ",2**int(a))
			break;
		else:
			print("error: It is not int number")
			break;
	elif (a == "2"):
		#2 variant
		print("2.variant")
		try:
			a = int(input("Enter number: "))
			print("2 ^",a," = ",2**int(a))
			break
		except:
			print("error: It is not int number")
			break
	else:
		print("Error: input only '1' or '2'")
