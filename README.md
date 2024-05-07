AB_Game draws inspiration from anothe game called Bulls and Cows game.
AB Game Instructions
The AB Game is a code-breaking game where the codebreaker tries to guess the codemaker's secret code.

The secret code is a sequence of 4 unique digits (0-9).
After each guess, the codemaker provides a hint:
"A" indicates a correct digit in the correct position.
"B" indicates a correct digit in the wrong position.
The hint format is "xAyB", where:
"x" is the number of correct digits in the correct position (A).
"y" is the number of correct digits in the wrong position (B).
For example, if the secret code is "1234" and the guess is "1327", the hint would be "1A2B".

This game has 2 modes; code-maker and code-breaker which a user can choose from. If you are playing as the codemaker, your opponent on another system would be playing as the codebreaker 
where they would give you their guess and you would try it and give them back the produced hint (format:xAyB) which they would supply to their system in that exact format(case sensitive)
and the game would churn out another guess. This will go on till 4A0B is achieved which means all values are correct and in the right position. There is an in-project db that stores previous games. 

Goodluck, and hope you enjoy!
