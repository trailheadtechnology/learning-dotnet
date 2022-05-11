* Create a console application and use the following base class to define a Cat and Dog class that inherit from it
 ```
 public abstract class Animal
 {
     public abstract string Talk();
     public string Feed()
     {
         return Talk();
     }
 }
```
* Implement the Talk() method in each class
* In the Main method, create dog and cat instances, feed them, and write out the output.

Challenge 1: Add a protected field “energy’ to the Animal class. Increment it by 1 every time the cat is fed and 2 every time the dog is fed.
Challenge 2: Add a method to Animal called GetEnergy() that returns the value of the field energy and output the animals new energy every time you feed them
