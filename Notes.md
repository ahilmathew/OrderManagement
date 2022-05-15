No unit tests
Not readily extensible
    * Increasing the color options available will result in changing a lot of code. A lot of hardcoded strings and print statements. Use an interface.
    * Hardcoded array indexes being used to fetch array values instead of using loops.
Insufficient input validation.
Access modifiers not properly used. Most of the public methods can be private since they are only needed in that class.
Code Repetition
    * Getting input for each shape
    * Calculating totals
Override ToString method in Order class.
Unwanted methods.
Can move some constant values to a 'Constants' class. - tableWidth , TrianglePrice, CirclePrice, SquarePrice
No error handling
No order number is generated.
Use string interpolation instead of concatenation.
netcoreapp3.0 is not supported anymore. latest available is 6.0