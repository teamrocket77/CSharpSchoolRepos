Concept Summary:
CSE1322 Lab 2
1. Class design
2. Encapsulation, modularity and reusability
<br>
Build the StockItem Class:
<br>
Design and implement a class named StockItem that can be used to keep track of items in stock at a store.
<br>
Each stock item object must include the following:
	- A variable named ​description​ which will hold a description of a stock item.
	- A variable named ​id​ which holds a unique integer.
	- A variable named ​price​ which holds the price rounded to the nearest penny.
	- A variable named ​quantity​ which indicates how many are in stock.
<br>
Each stock item must have a unique ID number generated for each newly instantiated stock item object. In order to do this, you’ll need a static variable.
<br>
StockItem class must include a:
<br>
	- Default constructor.
	- Overloaded constructor that takes description, a price, and a current quantity.
	- Overridden toString/ToString method that prints all details of the stock item.
<br>
Methods of the StockItem object must include the following:
- Getter Methods:
	- Retrieve the description of the item
	- Retrieve the id number of the item
	- Retrieve the price of the item
	- Retrieve the quantity of the item that is currently in stock
<br>
- Setter Methods:
	- Set a new price for the item
	- Should take in a new price and set it.
	- If the new price is below 0, print an error.
- Lower the quantity in stock
	- Should take in a quantity and lower the objects quantity.
	- If the quantity would drop below 0, print an error.
- Raise the quantity in stock
	- Should take in a quantity and increase the objects quantity.
<br>
Building the Driver:
- Design a Driver program which can be used by a tiny convenience store that only sells Milk and Bread.
- Create an object called milk. Set its description to “1 Gallon of Milk”, its price to $3.60 and its quantity to 15.
- Create an object called bread. Set its description to “1 Loaf of Bread”, its price to $1.98 and its quantity to 30.
