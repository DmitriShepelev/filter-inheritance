## Task description ##

Analyze solutions `Filter by digit` and `Filter by palindromic` in terms of code common to them. What part of the code can be made reusable, and which part is customizable, depending on the specific way of matching the number with a certain attribute (predicate)?   
- Using the capabilities of `inheritance of classes`, propose the option of allocating reusable code.      
- Demonstrate the possibility of using common code with two different predicate of the number. Place solutions in two separate classes:
    - [Filter by digit](DerivedClasses/ContainsDigitFilter.cs);
    - [Filter by palindromic](DerivedClasses/PalindromicFilter.cs).
- Get to know about  [moq](https://github.com/Moq/moq4/wiki/Quickstart)-tests.