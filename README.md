# Humber College - Web Development Program - HTTP5112 - ASP.NET - Assignment 2

This repo contains 3 controller files to solve a J1, J2 and a J3 problem of The Canadian Computing Competition (CCC) in 2006, which are stored in the [Controller](https://github.com/raymondleemv/HTTP5112-ASP.NET-Assignment1/tree/master/HTTP5112-ASP.NET-Assignment1/Controllers) folder.

## J1 Problem: The New CCC (Canadian Calories Counting)

**GET** `http://localhost/api/J1/Menu/{burger}/{drink}/{side}/{dessert}`<br/>
Returns the total calories of the meal based on the choice of {burger}, {drink}, {side}, and {dessert}<br/>
This problem is solved in [J1Controller.cs](https://github.com/raymondleemv/HTTP5112-ASP.NET-Assignment2/blob/master/HTTP5112-ASP.NET-Assignment2/Controllers/J1Controller.cs).<br/>
Please refer to the documentation in the file for more details.

## J2 Problem: Roll the Dice

**GET** `http://localhost/api/J2/DiceGame/{m}/{n}`<br/>
Returns the number of ways to roll a value of 10 given 2 dices with {m} and {n} sides respectively<br/>
This problem is solved in [J2Controller.cs](https://github.com/raymondleemv/HTTP5112-ASP.NET-Assignment2/blob/master/HTTP5112-ASP.NET-Assignment2/Controllers/J2Controller.cs).<br/>
Please refer to the documentation in the file for more details.

## J3 Problem: Cell-Phone Messaging

**GET** `http://localhost/api/J3/Menu/{word}`<br/>
Returns the amount of time needed to type the input message {word} on a cell phone{<br/>
This problem is solved in [J3Controller.cs](https://github.com/raymondleemv/HTTP5112-ASP.NET-Assignment2/blob/master/HTTP5112-ASP.NET-Assignment2/Controllers/J3Controller.cs).<br/>
Please refer to the documentation in the file for more details.
