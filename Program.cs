// Console.WriteLine("Signed integral types:");
// //goes to negative numbers of the same amount
// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");
// //starts at 0 index to 255, then 255 * 255
// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

//Precision is the number of value places stored after the decimal point.
//float and double values are stored internally in a binary (base 2) format,
// while decimal is stored in a decimal (base 10) format.
//float and double are useful because large numbers can be stored using a small memory footprint
//When you need a more precise answer, you should use decimal
//you should use decimal when working with financial data or any scenario where you need an accurate result from a calculation
//a value like 5E+2 would be the value 500 because it's the equivalent of 5 * 10^2, or 5 x 102
// floating-point type is a simple value data type that can hold fractional numbers.

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

//Reference types include arrays, classes, and strings.
//A value type variable stores its values directly in an area of storage called the stack
//When the stack frame has finished executing, the values in the stack are removed.
//A reference type variable stores its values in a separate memory region called the heap
//Instances of classes are allocated on the heap when created with the new keyword

// //INTERGERS::
// int[] data;        
// data = new int[3]; // - creates an instance on an array
// //OR
// int[] data = new int[3];
// //STRINGS::
// string shortenedString = "Hello World!";  //the "new" operator doesn't need to be used, its already initialised
// Console.WriteLine(shortenedString);       //a new instance of System.String is created and initialized to "Hello World!"

//VALUE TYPES::
// int val_A = 2;
// int val_B = val_A;  //- the value of val_B is now 2
// val_B = 5;          //- the value changes to 5

// Console.WriteLine("--Value Types--");
// Console.WriteLine($"val_A: {val_A}");
// Console.WriteLine($"val_B: {val_B}");

//REFERENCE TYPES::
// int[] ref_A= new int[1];
// ref_A[0] = 2;              //- ref_A[0] is 2
// int[] ref_B = ref_A;       //- ref_B points to the same memory location as ref_A
// ref_B[0] = 5;              //- when ref_B[0] is changed, ref_A[0] also changes because they both point to the same memory location

// Console.WriteLine("--Reference Types--");
// Console.WriteLine($"ref_A[0]: {ref_A[0]}");
// Console.WriteLine($"ref_B[0]: {ref_B[0]}");

//Reference type variables hold a reference (the memory address) to the actual value stored in the heap
//byte: working with encoded data that comes from other computer systems or using different character sets.
// double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
// System.DateTime for a specific date and time value.
// System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.

//en-US culture settings, and use a period (.) as the decimal separator. 
//replace the period decimal separators in the code samples with your local decimal separator (such as ,)
//OR
using System.Globalization;
using System.Net;
CultureInfo.CurrentCulture = new CultureInfo("en-US");


// int first = 2;
// string second = "4";    // the string number is added to the int number as a string, not as a calculation
// string result = first + second;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;     //the compiler can convert the int to a decimal without conversion
// Console.WriteLine($"decimal: {myDecimal}");

//The term widening conversion means that you're attempting to convert a value from a data type 
//that could hold less information to a data type that can hold more information

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;   //the value of the decimal loses information after the decimal point when converted to a string 
// Console.WriteLine($"int: {myInt}");
//By adding the casting instruction (int), you're telling the C# compiler that you understand it's possible you'll lose that precision
//you're performing an intentional conversion, an explicit conversion

//narrowing conversion means that you're attempting to convert a value from a data type that can 
//hold more information to a data type that can hold less information.

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");  //the float rounds off at the 7th decimal point 

//When you know you're performing a narrowing conversion, you need to perform a *cast* 
//'casting' a decimal into a float is a narrowing conversion because you're losing precision.

// For data conversions, there are three techniques you can use:

// - Use a helper method on the variable
// - Use a helper method on the data type
// - Use the Convert class' methods

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();  // method that converts the var's value to a string type
// Console.WriteLine(message);                             //puts them together instead of adding them (concatenates)

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second); //converts both strings to an int then adds them
// Console.WriteLine(sum);                          

//Parse() method converts a string into given data type
//TryParse(), which is a better version of the Parse() method.
//Convert class has many helper methods to convert a value from one type into another

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

//System.Int32 is the name of the underlying data type in the .NET Class Library that the C# programming language maps to the keyword int.
//Convert.ToInt32() method with a string here, but you should probably use TryParse() when possible.
//The Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up the way you would expect.

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value); // = 1

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2); // = 2

//You could change the literal float to 1.999m and the result of casting would be the same.
//If you changed the literal value to 1.499m, it would be rounded down to 1.
//() cast operator and the data type to perform a cast (for example, (int)myDecimal)
//Convert class when you want to perform a narrowing conversion, but want to perform rounding, not a truncation of information

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }

// The int variable *result* is declared and initialized before this line of code, so it should be accessible both inside the 
// code blocks that belong to the if and else statements, as well as outside of them.
//TryParse() returns TRUE if the conversion is successful, FALSE if it's unsuccessful
//decimal.TryParse(myInput, out myInputDecimal); --convert from string to decimal

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}"); //it still picks up the value of inside the code block after its been closed


//MY CODE//////////////////////////////////////////////////////////

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// string message = " ";
// decimal total = 0;

// for (int i = 0; i < values.Length; i++)
// {
//     if (decimal.TryParse(values[i], out decimal sum))
//     {
//         total += sum;
//     }
//     else
//     {
//         message += values[i];
//     }
// }
// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: " + (total));

//OR
////MS SOLUTION///////////////////////////////////////////////////

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");

// RESPONSE:::
// Message:  ABCDEF
// Total: 68.3

//////////////////////////////////////////////////////////////////

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;
// bool value4 = true; 

// decimal result1 = value1 / value2;
// result1 = Convert.ToInt32(result1);
// // OR // int result1 = Convert.ToInt32(value1 / value2);0
// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// decimal result2 = value2 / (decimal)value3;

// // Your code here to set result2
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");


// float result3 = value3 / value1;


// // Your code here to set result3
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

////////////////////////////////////////////////////////////////////
//Here you're using the Sort() method of the Array class to sort the items in the array alphanumerically.
//SORT():::: is an Array method

// string[] pallets = [ "B14", "A11", "B12", "A13" ];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// to make a gap between arrays //
////////////////////////////////////////////////////////////////////////////
// REVERSE():::

// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
/////////////////////////////////////////////////////
// CLEAR()::::
//if you clear an element in a string array, the cleared value is replaced with null. 
//Similarly, when you clear an element in an int array, the replacement is 0 (zero).

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2);
// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}"); //to get the null values to show as well

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

////////////////////////////////////////////////////////////////////////////
//RESIZE():::::

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// //resizes the array "ref"
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

///////////////////////////////////////////////////////////////////////
/// ToCharArray() - where each element of the array represents one character of the original string

// string value = "abc123";
// char[] valueArray = value.ToCharArray(); // --use char data type when there is ints and strings together 
// Array.Reverse(valueArray);
// string result = new string(valueArray); // -- converted the value into a char array, reversed it then back to a string 
// Console.WriteLine(result);

/// JOIN():::::
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

/// SPLIT()::::
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

//To create an array, use methods like ToCharArray() and Split()
//To turn the array back into a single string, use methods like Join(), or create a new string passing in an array of char


// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] items = pangram.Split(' ');     //splits it up by the space


// foreach (string item in items)               //iterate through each split item(each word)
// {
//     char[] itemsArray = item.ToCharArray();   //each item(word) becomes part of a char array

//     Array.Reverse(itemsArray);               //reverse each item(word) in the array

//     string result = String.Join("", itemsArray);  //joins them all back into a single string instead of array

//     Console.Write(result + " ");                 //pops out each word but with a space after each word
// }
    

// RESPONSE::::
//ehT kciuq nworb xof spmuj revo eht yzal god

//OR MicroSoft CODE::::::
// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' ');

// //Step 2
// string[] newMessage = new string[message.Length];

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);
///////////////MY CODE::///////////////////////////////////////////////////////////////////////

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] OrderID = orderStream.Split(",");
// Array.Sort(OrderID);
// foreach(string IDs in OrderID)
// {
//     char[] IDArray = IDs.ToCharArray();  //don't need this, picks up the characters length already
//     if(IDArray.Length != 4 )
//     {
//         Console.WriteLine(IDs + "\t - Error");
//     }
//     else
//     {
//         Console.WriteLine(IDs);
//     }
// }

//////////////////////////////////////////////////////////////////////////////////////////////
//RESPONSE::

// A345
// B123
// B177
// B179
// C15      - Error
// C234
// C235
// G3003    - Error
/////////////////////////////////////////////////////

//////////////////FORMAT()//////////////////////////
//COMPOSITE FORMATTING::::


// string first = "Hello";
// string second = "World";
// string third = "Honey";
// string result = string.Format("{0} {1}!", first, second); //the order the strings are in doesn't matter because of the numbers in the curly brackets, {0} is whatever the first string is, {1} is whatever the second string is, and so on. The numbers in the curly brackets are placeholders for the values that are passed in as arguments to the Format() method. The first argument is the format string, which contains the text and the placeholders, and the subsequent arguments are the values that will replace those placeholders in the final output string.
// Console.WriteLine(result);

// Console.WriteLine("{2} {1} {0}!", first, third, second);  //how does it know that the first value is second and the second value is first? because of the numbers in the curly brackets, it knows to swap them around
// Console.WriteLine("{0} {0} {0}!", first, second); //the first value is repeated three times because of the {0} in the curly brackets, it knows to use the first value for all three of those placeholders, and ignores the second value because there is no placeholder for it


// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

//String Interpolation// - better practice than Composite formatting, more concise and readable
//String interpolation is a more concise and readable way to format strings in C#. It allows you to embed expressions directly within string literals, using the syntax $"{expression}". The expressions inside the curly braces are evaluated and their results are included in the final string. This approach can make your code cleaner and easier to understand compared to using String.Format().
//FORMATTING CURRENCY:::    

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})"); //you get $dollars if your language is set to en-US, but if your language is set to something else, you would get the currency symbol for that language instead. The "C" format specifier formats the number as a currency value, including the appropriate currency symbol and decimal places based on the current culture settings of the system.


// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units"); //The "N" format specifier formats the number with thousands separators and a specified number of decimal places. By default, it includes two decimal places, but you can specify a different number of decimal places by using "N" followed by the desired number (e.g., "N3" for three decimal places). The output will also include the appropriate thousands separators based on the current culture settings of the system.
// //Measurement: 123,456.79 units

// decimal measurement = 123456.78912m; // the "m" suffix indicates that this is a decimal literal, which is important for ensuring that the value is treated as a decimal type rather than a double or float. This allows for higher precision and is particularly useful when working with financial data or any scenario where you need an accurate result from a calculation.
// Console.WriteLine($"Measurement: {measurement:N4} units");
// //Measurement: 123,456.7891 units
////////////////////////////////////
// //FORMATTING PERCENTAGES:::

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}"); //The "P" format specifier formats the number as a percentage value, multiplying it by 100 and appending the percent sign (%). The number of decimal places can be specified after the "P" (e.g., "P2" for two decimal places).
//Tax rate: 36.79%

// decimal tax =.12051m;
// Console.WriteLine($"Tax rate: {tax:P1}");
// //Tax rate: 12.1%
///////////////////////////////////
// //COMBINING FORMAT SPECIFIERS:::
// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);
//You saved $7.56 off the regular $67.55 price. A discount of 11.19%!

//CHALLENGE:::

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product"); //shows 3 numbers after the decimal point and rounds off the last number
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

//RESPONSE:::
// Invoice Number: 1201
//    Shares: 25.457 Product
//      Sub Total: $2,750.00
//            Tax: 15.83%
//      Total Billed: $3,185.19

//////////////////////////////
/// string.Format() method is used to perform composite formatting

/// PadLeft(), PadRight() -- adds blank spacing for formatting purposes
/// (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property) -- compare two strings or facilitate string manipulation
/// (Contains(), StartsWith(), EndsWith(), Substring()) -- search for specific characters or substrings within a string
/// (Replace(), Insert(), Remove()) -- modify the contents of a string
/// (Split(), ToCharArray()) -- break a string into an array of substrings or characters
/////////////////////////////

// string input = "Pad this";
//  Console.WriteLine(input.PadLeft(12)); //the last four characters are preserved at the end of the 12 spaces for the string
// Console.WriteLine(input.PadRight(12));

//Overloaded methods: PadLeft() and PadRight() have overloaded versions that allow you to specify a custom padding character instead of the default space character. For example, input.PadLeft(12, '-') would pad the string with hyphens instead of spaces. This can be useful for creating visually distinct formatting or for aligning text in a specific way.
// -> they have multiple versions of the method with different arguments that affect their functionality
// += operator concatenates a new string on the right to the existing string on the left.

// Console.WriteLine(input.PadLeft(12, '-'));
//  Console.WriteLine(input.PadRight(12, '-'));

//RESPONSE:::
//     Pad this
// Pad this    
// ----Pad this
// Pad this----

// string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";
//  string paymentAmount = "$5,000.00";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24);
//  formattedLine += paymentAmount.PadLeft(10);
//  Console.WriteLine("1234567890123456789012345678901234567890");
//  Console.WriteLine(formattedLine);

////////CHALLENGE:::

// string customerName = "Ms. Barros"; //0

// string currentProduct = "Magic Yield"; //1
// int currentShares = 2975000;            //2
// decimal currentReturn = 0.1275m;         //3
// decimal currentProfit = 55000000.0m;     //6

// string newProduct = "Glorious Future";  //4
// decimal newReturn = 0.13125m;           //5
// decimal newProfit = 63000000.0m;         //7

// //MY CODE:::
// string firstSentence = String.Format($"Dear {customerName},");
// string secondSentence = String.Format($"\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");

// string thirdSentence = String.Format($"\n\nCurrently, you own {currentShares:C} shares at a return of {currentReturn:P2}.");

// string fourthSentence = String.Format($"\n\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");

// string sentence = firstSentence + secondSentence + thirdSentence + fourthSentence;
// // Your logic here

// Console.WriteLine(sentence);
// Console.WriteLine("Here's a quick comparison:\n");

// //Microsoft solution:::
// Console.WriteLine("Dear {0},", customerName);

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);
// //Broken down:::

// Magic Yield
// Magic Yield         12.75%
// Magic Yield         12.75%    $55,000,000.00

//use String.Format() when using padRight() and padLeft() 

/////////////////////////////////INDEXOF() and SUBSTRING()/////////////////////////////////////////////////////////////

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// string sentence = message.Substring(14, 36);//MY CODE
//why doesn't 13 work if you want to start from the middle of the parentheses? because the index starts at 0, so the first character is at index 0, the second character is at index 1, and so on. Therefore, the opening parenthesis is at index 13, and if you want to start from the middle of the parentheses, you would need to use index 14 to get the first character inside the parentheses. If you use index 13, you would get the opening parenthesis itself instead of the content inside it.
//14 doesn't work because the length of the substring is 36, which goes beyond the closing parenthesis. The closing parenthesis is at index 36, so if you start at index 14 and try to get a substring of length 36, it will go out of bounds of the string. You need to calculate the length of the substring based on the positions of the opening and closing parentheses. The length should be closingPosition - openingPosition - 1, which gives you the number of characters between the parentheses.
// Console.WriteLine(sentence);

//MicroS SOLUTION:::
// openingPosition += 1;

//MicrS and MY SOLUTION:::
// int length = closingPosition - openingPosition - 1; 
// Console.WriteLine(message.Substring(openingPosition + 1, length));//The Substring() method needs the starting position and the number of characters, or length, to retrieve

//I added a 1 to the openingPosition to start the substring from the character after the opening parenthesis, and then subtracting 1 to exclude the parentheses at the end. This way, you get only the content inside the parentheses.
//use a string variable with an index position instead of inserting a number thats more than 1 to get the correct substring length, because the length of the substring can change depending on where the parentheses are located in the string. By calculating the length based on the positions of the opening and closing parentheses, you can ensure that you get the correct substring regardless of where the parentheses are in the message.


// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");
// //Hardcoded strings like "<span>" in the previous code listing are known as "magic strings" and hardcoded numeric values like 6 are known as "magic numbers". These "Magic" values are undesirable for many reasons and you should try to avoid them if possible.

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

////////////OR:::

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>"; //made a const so that if there is a discrepancy on the name of the variable you calling to index, it shoots an error and you'll know where it needs to be fixed
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length; //instead of adding 6, you can add the length of the openSpan variable, which is 6, but if you change the name of the variable or the value of the variable, it will still work because it's based on the length of the variable rather than a hardcoded number. This makes your code more maintainable and less error-prone.
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//////////////LastIndexOf()////////////////////////////////
// - also returns -1 if value isn't found

// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

//////////////////////////////////////////////////

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

///RESPONSE:::

//set of parentheses
//////////////////////////////////////////////////

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;// If there are no more opening parentheses, exit the loop therefore skips the "?"

//     openingPosition += 1; // Move past the opening parenthesis
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition; // Calculate the length of the substring between the parentheses
//     Console.WriteLine(message.Substring(openingPosition, length));//the first argument is the starting position of the substring, and the second argument is the length of the substring, which is calculated as the difference between the closing and opening positions. This way, you can extract the content inside each pair of parentheses in the message.

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1); // we add 1 to start after the closing parenthesis for the next iteration
// }

//When you use Substring() without specifying a length input parameter, it will return every character after the starting position you specify


////////////////IndexOfAny()//////////////////////////////////
//- The IndexOfAny() reports the index of the first occurrence of any character in a supplied array of characters. The method returns -1 if all characters in the array of characters are not found

// string message = "Hello, world!";
// char[] charsToFind = { 'a', 'e', 'i' };//the method will return the index of the first occurrence of any of the characters in the charsToFind array, which in this case is 'e' at index 1. If none of the characters in the charsToFind array were found in the message string, the method would return -1.

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
//////////////////////////////////////////////

string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");









