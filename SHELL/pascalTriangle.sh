#!/bin/bash

read -p "Enter number of rows: " rows
scale="^[0-9]+$"
if [ $rows -eq $rows ] 2> /dev/null;
then
coef=1
echo "Pascal triangle: "
for((i=0;i<rows;i++))
do
  for((space=1;space<=rows-i; space++))
  do
    echo -n "  "
  done
  for((j=0;j<=i;j++))
  do
    if [ $j -eq 0 -o $i -eq 0 ]
    then
        coef=1;
    else
        coef=$((coef*(i-j+1)/j))
    fi
    echo -n $coef "   "
  done
  echo
done
else
echo "it is not int number!"
fi