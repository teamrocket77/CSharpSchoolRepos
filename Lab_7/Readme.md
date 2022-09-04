# CSE1322L - Lab 7
 1. Object-Oriented programming concepts 
 2. Interfaces

<br>
For this project you will develop a calculator that can do simple arithmetic operations such as addition, subtraction, multiplication and division.
<br>

### You’ll begin by creating an interface CalcOp which has 4 methods: 
- add()
- subtract()
- multiply()
- divide()
<br>

Next you’ll create a Calculator class which implements the interface. This class should be concrete, as such all methods should be concrete.
<br>
Finally you’ll write a main method which instantiates a calculator, and presents the user with a menu. Prompt the user for 2 numbers and perform the appropriate operation based on their choice. Continue until the user chooses to exit.
<br>
## Specifications:
The ​CalcOp ​interface should include the following items:
• Four methods: add( ), subtract( ), multiply( ) and divide( )
• Each method should take in two floating point numbers and return a float.
The ​Calculator ​class should:
* Implement the methods defined in the interface.
Write a driver program which contains the following items:
* A menu with options for exiting the program, addition, subtraction, multiplication and
division.
* All Input / Output statements should be in the driver program only.
Test your program by running through all operations at least once.
