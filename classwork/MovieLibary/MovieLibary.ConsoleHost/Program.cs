// Get movie
// Titel, genre, description, mpaa rating
// Length, release year, budget
// IsBlackAndWhite
// Operation: Add, edit, view, delete

/* ------------------------------------------------08-29-23-----------------------------------------------------------
 * variable: - name - type - value
 * Variable-deta ::= T id { , id}*; 
 * asn (assign)::=   Vt = Et
 * E (expression): value, type           
 * S (stament): does something, no value
 * -------------------------------------------------------
 * 
 * Signned------------------------------------------
 *  Type                size            range(storage)
 *  sbyte               1               -128 toi 127
 *  short               2               -16k to 16k
 *  int                 4               -2Bil to 2Bil
 *  long                8               2^64
 *  -------------------------------------------------------
 *  Unsigned-----------------------------------------
 *  byte                1               0-255
 *  ushort              2               0-32k
 *  uint                4               0-4Bil
 *  ulong               8               0-2^64
 *  --------------------------------------------------------
 *  float               4               5-7 (38 value)      should use double than float --> for storage in furture
 *  double              8               7-15(308 value)
 *  decimal             16              use for money
 *  ---------------------------------------------------------
 *  bool                1               true or false       can not use "int" in this value T or F
 *  char                2               'A', '1', 'f'
 *  string              *               text
 *  DateTime
 *   -DateOnly
 *   -TimeOnly
 *  TimeSpan
 *  ----------------------------------------------------------------------------------------------------
 *  
 *  dont use "_" or short name, single letter in code EX: first_name --> firstName
 *  
 *  
 *  
 */

string title = "", decription = "";
//title = "";

string genre = "", rating = "";

int length = 0, releaseYear = 1900 ;

decimal budget = 125.45M; /// decimal can not storage samething like double. we have to add "M" behind the number.
bool isBlackAndWhite = false;

//Get the title
Console.WriteLine("Enter a title: ");
title = Console.ReadLine();   // read the value --> expression

Console.WriteLine("Enter a decription: ");
decription = Console.ReadLine();


//T000: Fix length --> if you need to fix it, put the note like that
Console.WriteLine("Enter the run length (in mins): ");
string lengthString = Console.ReadLine();


Console.WriteLine(title);
Console.WriteLine(length);
Console.WriteLine(lengthString);

/*double someFloatingValue = 3.14159;
char letterGrade = 'A';


{
    int hours = 5;
    //int title = 54; // that value is block in this scope, can not load the value from the scope outside.

    title = "Jaws";

    Console.WriteLine(title);
    Console.WriteLine(length);
}
*/


