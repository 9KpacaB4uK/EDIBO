class PartyAnimal:
 x = 0
 def __init__(self): #when class has been created
  print("constructed")
 def plusParty(self,x):
  x = x + 1
  print("x =",x)
 def minusParty(self):
  self.x = self.x - 10
  print("new x =",self.x)
 def __del__(self): #happens at some point after all references to the object have been deleted.
  print("destructed",self.x)
an = PartyAnimal()
an.x = 50
an.plusParty(9)
an.minusParty()
an.minusParty()
an = 1
#print(type(an))
#print(dir(an))
#print(type(an.x))
#print(type(an.plusParty))

