# Objective:
In this lab, you’ll be creating software for the world's smallest bank. This bank can have only one customer. The customer will have a checking account and a savings account. The account types have some specific rules:
## Checking Accounts:
- Allows unlimited deposits and withdrawals for free.
- Provides no interest payments.
- If the account balance ever drops below $0, the customer is charged a $20 overdraft fee.
## Saving Accounts:
- Must maintain a $500 balance at all times, otherwise the customer is charged $10 each time they make a withdrawal that lowers their balance below $500.
- Earns 1.5% interest every year
- The first 5 deposits are free, after that there is a fee of $10 per deposit.
You’ll provide the bank teller with a simple menu which will allow them to make changes to their customer’s accounts.
<br>
You’ll use your IDE to generate UML diagrams of your classes. See UML section below.
Account Numbers:
Each account will have an account number. You should use a static variable to keep track of the next account number. At the start set this number to 10001.
<br>
In your driver you’ll create a Checking account, and a Savings account. The checking account will end up with a account_number of 10001, while the Savings account will end up with an account_number of 10002.
  
## Classes:
  - Create a class called “Account”. This will hold things that are true for all account types. Be sure
  to include at least:
	  - An attribute which will hold the account number.
	  - An attribute which will hold the account balance. (e.g. $500.22)
	  - A constructor method which opens the account with a balance of 0.
  - It should set the account number using the static variable described above.
  	- An overloaded constructor which opens the account with a specific amount which is
  passed to the constructor.
  - It should set the account number using the static variable described above.
	  - Getter method for accessing the account_number.
	  - Getter/Setter method for accessing the account balance.
	  - A withdrawal method which takes a parameter of the amount to be withdrawn and
  deducts it from the balance.
	  - A deposit method which takes a parameter of the amount to be deposited and adds it to the balance.
  - Create a class called “Checking” which should inherit from Account.
	  - You will need an appropriate constructor to set the account balance.
	  - Modify the withdrawal method you inherited to check for the condition where they try to overdraft their account.
  - If an overdraft condition occurs you should print out “Charging an overdraft fee
  of $20 because account is below $0”
  - Deduct $20 from their balance.
  - Create a class called “Savings” which should inherit from Account.
	  - You will need an appropriate constructor to set the account balance.
	  - Modify the withdrawal method so it implements the rules about dropping below $500
  - If they drop below $500, you should print “Charging a fee of $10 because you are below $500”
  - Deduct $10 from their balance.
  	- Modify the deposit method so it implements the charge for more than 5 deposits.
  - As you do the deposit you should print “This is deposit 1 to this account”, where 1 would be updated to reflect what number deposit this is.
  - If you are doing the 6th or later deposit, print “Charging a fee of $10”, and deduct $10 from their balance.
  	- Add a method which adds 1.5% interest to the account. (This method will be called by the teller manually once per year).
  - Print out how much the customer earned in interest as follows “Customer earned 15.25 in interest”. Of course it should reflect the actual amount.
  - Add the interest earned to their balance.
  All classes should be created with appropriate encapsulation. i.e. account balances and account numbers should be private and only accessible via getters/setters.
