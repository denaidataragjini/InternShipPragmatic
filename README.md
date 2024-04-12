# EXERCISE 4 
In Camelot, friendship is reciprocal. The Round Table is located in a huge hall, rounded by N chairs.
Each knight wants to sit near his friends, otherwise he refuses to sit.
Everyone is waiting for the wizard Merlin to solve this problem, but Merlin cannot find the magic
formula. Help Merlin to sit all the knights, so that each sitting knight has friends in his two sides.

## Input
In the first line is given an integer number n, where n is the number of the Knights of the Round Table
(3<=n<=100 ). The knights are numbered from 1 to n.
Each of the following n lines contains a sequence of n values 0 or 1, separated by a space. The i-th
sequence shows the friendship relations of the i-th knight. The j-th value determines if the i-th knight
is a friend of the j-th knight. They are friends if the value is 1, and not friends if the value is 0.
Since friendship is reciprocal, if I is a friend of j, j is also friend of i.

## Output
If the knights can be sit around the round table, show ‘YES’, otherwise show ‘NO’.
