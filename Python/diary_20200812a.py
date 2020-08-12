Python 3.6.8 (default, Jan 14 2019, 11:02:34) 
[GCC 8.0.1 20180414 (experimental) [trunk revision 259383]] on linux
Type "help", "copyright", "credits" or "license()" for more information.
>>> a=4
>>> d=1
>>> a+d+d+a
10
>>> vars()
{'__name__': '__main__', '__doc__': None, '__package__': None, '__loader__': <class '_frozen_importlib.BuiltinImporter'>, '__spec__': None, '__annotations__': {}, '__builtins__': <module 'builtins' (built-in)>, 'a': 4, 'd': 1}
>>> vars()
{'__name__': '__main__', '__doc__': None, '__package__': None, '__loader__': <class '_frozen_importlib.BuiltinImporter'>, '__spec__': None, '__annotations__': {}, '__builtins__': <module 'builtins' (built-in)>, 'a': 4, 'd': 1}
>>> type(a)
<class 'int'>
>>> type(aa)
Traceback (most recent call last):
  File "<pyshell#6>", line 1, in <module>
    type(aa)
NameError: name 'aa' is not defined
>>> clear
Traceback (most recent call last):
  File "<pyshell#7>", line 1, in <module>
    clear
NameError: name 'clear' is not defined
>>> print(a.__doc__)
int(x=0) -> integer
int(x, base=10) -> integer

Convert a number or string to an integer, or return 0 if no arguments
are given.  If x is a number, return x.__int__().  For floating point
numbers, this truncates towards zero.

If x is not a number or if base is given, then x must be a string,
bytes, or bytearray instance representing an integer literal in the
given base.  The literal can be preceded by '+' or '-' and be surrounded
by whitespace.  The base defaults to 10.  Valid bases are 0 and 2-36.
Base 0 means to interpret the base from the string as an integer literal.
>>> int('0b100', base=0)
4
>>> date
Traceback (most recent call last):
  File "<pyshell#9>", line 1, in <module>
    date
NameError: name 'date' is not defined
>>> 
>>> 
