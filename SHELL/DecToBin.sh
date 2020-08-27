#!/bin/bash

read -p "Enter DEC number : " dec
echo "obase=2;$dec" | bc
$SHELL