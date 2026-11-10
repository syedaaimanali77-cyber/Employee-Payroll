

# Employee Payroll Project 

// Questions About Project 

1. Class is a blueprint or template and the objects is its instance . In our Counter.cs
file we created a class named Counter and then in our program.cs file in Main function we created
its objects  named (apples,grapes and ornges). 

2. Counter.Increment is an instance method so we requires objects for calling this method
but we created GetTotalCounter as an static method which means it belongs to the class itself
so, we can call it directly from class without creating object.

3. Static means it belongs to the class directly rather than objects. In counter each object has its own count but the
method of total count is static which means its belong to the class that's why our output is

#OUTPUT
----------------------------
| Apples: 3                |
| Oranges : 2              |
| Grrapes: 1               |          // WARM UP
| Total Counters : 3       |
|                          |
---------------------------

4. Employee is our base/parent class in which we represents general Employee while in actual
   we have specific types of employees .Like full time employee, part time employee and Intern.
   So, if we try to generte abstract class object compiler will give us error bcz abstract classes
   can't instantiate we have to create object of its child classes as we do in Main ()
   function by creating object of all types of Employees.


   5. Program.cs file canot set Monthly salary directly bcz in FullTimeEmployee.cs file
     we created a field and set it private which simply means other classes can see it 
     but can't change it directly that's why we call a method named GiveRaise with the 
     condition that the Raise must be in between 1 to 50 percent otherwise throw an 
     argument (Invalid).

     6. We call PrintPayroll() method in Company.cs file in which we apply for each loop 
     which means a loop go through from each employee in the collection CalculateMonthlyPay()
     is an abstract method created in Employee.cs here we use Polymorphism which means same 
     method but classes can behave differently.

     FOR INSTANCE :
     Full time employee : get pay monthly.
     Part time employee : get pay hourly acording how much and how long he/she worked.
     Intern : get fixed pay after month.

     7. We use Sealed key word which means another class can'tbe inherit by Intern class 
     For Instance if we create classes like Senior Inter or Junior Intern we can't inherit them
     with Intern class. But we can create object of Intern class.

     8. 
      ---------------------------------------------------------------------------------
      |      # INTERFACE                                      #ABSTRACT CLASS          |
      | 1. Interface is a Contract implemented     1. Abstract class is an Incomplete  |
      |    by classes.                                 base class.                     |
      | 2. We can do multiple inheritance by        2. A class can inherit one class   |
      |    using interface.                            only.                           |
      |                                                                                |                                                                         
      ----------------------------------------------------------------------------------
      
      So, we use bonus an interface name (IBonusEligible) instead of using an abstract 
      class bcz not every employee in ou program recieves bonus it allow us to check eligibility 
      without forcing every employee type to implement bonus calculation method.
      In our program FullTime and PartTime Employees are eligible for bonus.
