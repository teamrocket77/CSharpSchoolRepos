# Concept Summary:

## CSE1322L Lab 6
 1. Object Oriented programming concepts 
 2. Interfaces

## Objective:
In this lab you will compute Fibonacci numbers using two different classes, each of which implements the same FindFib interface.
<br>
Fibonacci is an interesting sequence. The first fibonacci number is 1. The second is 1, every subsequent number is the sum of the previous 2. To put it in math terms:
<br>
F(n) = F (n – 1) + F(n – 2). The sequence looks like:
1, 1, 2, 3, 5, 8, 13, 21, 34, 55...
<br>
Hence Fibonacci(10) is 55. Fibonacci(6) = 8 etc.
Assignment Requirements:
* Begin by creating an interface FindFib. It should have one method calculate_fib(). - calculate_fib() should take in an integer, and should return an integer.
* Next, create a class FibIteration that implements FindFib.
	- calculate_fib() should take in the same parameters and return the same type as the
interface version.
	- To calculate Fibonacci iteratively you start by checking if you are being asked to
calculate the Fibonacci of 1 or 2, if so you return 1. Otherwise, you’ll use a loop
to keep adding up the previous numbers until you arrive at the answer.
* Next, create a class FibFormula that implements FindFib.
	- calculate_fib() should take in the same parameters and return the same type as the interface version.
	- To calculate Fibonacci by formula, plug in to Binet's Formula:
	- F(n) = (((1+sqrt(5))/2)^n - ((1-sqrt(5))/2)^n) / sqrt(5)
* Create a driver program which prompts the user to enter a number, then calculate the fibonacci using both methods, and print the results.
* Create UML diagrams of the interface, 2 classes and driver program. Submit as a PDF along with the code.
