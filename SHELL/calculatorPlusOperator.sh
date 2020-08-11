#!/bin/bash


echo "Calculator PLUS operator :"
read -p "First number = " firstNumber
read -p "Second number = " secondNumber
echo "$firstNumber + $secondNumber = $((firstNumber + secondNumber))"
