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


