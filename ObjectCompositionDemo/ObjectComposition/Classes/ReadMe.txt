* A manager is an employee 
  - Manager inherited from emplyee class
  - "is" is represent the inheritance.

* manager uses coffee machine
  - Manage class have a association relationship with coffee machine class
  - very weak relationship between manager and coffee machine
  - dispose any one of object won't affect another


* employee owns a car
  - aggregation relationship
  - if employee get dispoes car won't get disposed, car object still excist just employee property get a value of null


* employee has a bank account
  - composition relationship (strongest relationship)
  - BankAccount class is part of Employee class
  - if employee get disposed bank account also going to dispose


* 3 kinds of injection: constructor injection, property injection and method injection
each one have pros and cons, use which is depend on context
since property injection can changed through out the life time
if you don't want the coffeeMaker object been changed may be use constructor inject will slightly better, since object was only created once, when you first time instantiate the Manager object