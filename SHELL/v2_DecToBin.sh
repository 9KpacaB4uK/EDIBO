#!/bin/bash
##Need to do ...
read -p "Enter DEC number: " dec
array=()
prev_dec=$dec
while [[ $prev_dec > 0 ]]
	do
	prev_dec=$dec
	dec=$((dec / 2))
		if [ $dec != 0 ];
			then
			if [ $(($prev_dec % $dec)) != 0 ]; 
				then
				echo 1
				#array+=('${array[@]}' '1')
				else
				echo 0
				#array+=('${array[@]}' '0')
			fi
			echo "prec_dec = $prev_dec" "dec = $dec"
		else
		echo 1
		break
	fi
done
#echo ${array[@]}
echo "done"


