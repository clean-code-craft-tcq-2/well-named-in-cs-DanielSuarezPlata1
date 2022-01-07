#!/bin/bash

checkloc() {
  while read tok line
  do
    if [[ $tok =~ ^[[:digit:]] ]]
    then
      if [[ $tok -gt $1 ]]
      then
        echo $line exceeds $1 LOC;
        exit 1;
      fi
    else
      echo done;
      exit 0;
    fi
  done
}

while read line
do
    if [[ "$line" == *"file analyzed"* ]]
    then
        read heading
        read heading
        read heading
        checkloc $1
    fi
done
