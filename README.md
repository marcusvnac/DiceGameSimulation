# DiceGameSimulation
## Description
There is a game that is played with 5 dice. The objective of the game is to obtain the lowest possible score. To that end, the rules of the game are as
follows:
- All dice are thrown on a board.
- If there are any 3’s, all the 3’s are taken off the board and a score of 0 is
awarded for this roll.
- If there are not any 3’s, the lowest die is taken off the board and the value
of that lowest die is awarded for this roll.
- The remaining dice are now re-thrown and the same procedure as above is
followed until there are no dice left on the board.
- The total score for the game is the sum of all the rolls.

## Example
* On the first roll you throw the following: 3,1,3,6,6
  * Since there are two 3’s, they are removed and your total is currently 0.
* On the second roll (with 3 dice now – since the 3’s have been removed) you have the following: 2, 5, 5
  * You now remove the 2, giving you a total of 2 and there are two dice remaining.
* You now roll 6,6
  * You remove one 6 giving you a total of 8 and have one dice left.
* You now roll 3.
  * This scores 0 for this roll. This game is now finished and your game score is 8.

## Task
Your task is to simulate this game over 10000 iterations and keep a count of all the possible game scores. (i.e. How many times did someone score 8? How many times did
they score 2?).
The output should look something like below. (Assuming for this sample output that only 2 dice were used for 100 simulations).

```
Number of simulations was 100 using 2 dice.
Total 0 occurred 10.0 times.
Total 1 occurred 5.0 times.
Total 2 occurred 14.0 times.
Total 3 occurred 5.0 times.
Total 4 occurred 7.0 times.
Total 5 occurred 13.0 times.
Total 6 occurred 15.0 times.
Total 7 occurred 10.0 times.
Total 8 occurred 10.0 times.
Total 9 occurred 2.0 times.
Total 10 occurred 5.0 times.
Total 11 occurred 3.0 times.
Total 12 occurred 1.0 times.
Total simulation took 0.1 seconds.
```
