# WordleAPI

This is a open source wordle API which is meant for easy integration into a web application. The goal is to provide a service which can:
- Generate a new 5 etter word from a word list on demand
- Set a configurable timer to update the word
- Answer requests to confirm word correctness

# Current Endpoints
api/Wordle
---
Parameters: None\
Response: string

api/Wordle/{guess}
---
Parameters: guess - string\
Response: Wordle Object {\
guess - current guess\
correct - bool - whether guess == word\
curCorrect - ArrayList - Array of ints representing the status of a letter. 0 = letter not in word, 1 = letter in word but in a different location, 2 = letter in word and in correct location. \
}


## To-Do list
- api/Wordle/Update
- api/Wordle/SetTimer
- api/Wordle/GetMetadata
