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
 *--------------------------------------------------------08-31-23------------------------------------------------------
 *  
 * Parameter kind                           direct          parameter                 argument
 * 1. input (pass by value)                 T ID            read-write                 any var
 * 2. input/output (pass by reference)      T ref ID           rw
 * 3. output                                T out ID           w
 *   
 *
 *--------------------------------------------------------09-05-23------------------------------------------------------
 * 
 * arith-expr:: Et op Et --> T
 * arith-op::  + - * / % : do * / % frist, then do + -
 * 
 * bool <-- relationaloop ::=  >  >=  <  <=  ==  !=
 * 
 * combo-op::   +=  -=  *=  /=  %=
 *  ex: hour = 40; hour *=1.5;
 *  
 * fix-op::  ++var(var +=1)  var++(var +=1 --> count before modify the value - 1)  --var(var -=1)  var--(var -=1 --> count before modify the value + 1)
 *  ex: count = 5; ++count --> result = 6
 *  ex: (X++) + (++Y)
 *  ex: x +=4 +5 --> have to do 4+ 5 = 9, then +=9 is 10
 *  
 *  log-oporator:: && (And)  || (Or)        ! (NOT)
 *      X       Y       &&      || 
 *      F       F       F       F
 *      F       T       F       T
 *      T       F       F       T
 *      T       T       T       T
 *      
 * While loop: if condition is true, return, if false --> skip
 * while (Eb)
 *  statement
 *  
 *  do - while(Eb): do something then check, if true --> redo again (post test / retest)  If false: return the result
 *  
 *  break statemnt:: break;
 *  
 *  continue_statment: continue;
 *  
 *  var is just keywork that does not mean anything, it makes combine needs to figure out the value. (optional)
 *   --> less think and choose the kind for value
 *   --> if the statement is clear, you can use "var" (only local variable, not up level)
 *  
 *  
 *  -------------------------------------------------------------------------------------------------------------------
 *  
 *  
 */



string title = "", decription = "";
//title = "";

string genre = "", rating = "";

int length = 0, releaseYear = 1900;

decimal budget = 125.45M; /// decimal can not storage samething like double. we have to add "M" behind the number.
bool isBlackAndWhite = false;


//Get movie details and display
GetMovie();
DisplayMovie();


// Functions
void GetMovie ()
{
    //Get the title
    //Console.WriteLine("Enter a title: ");
    // title = Console.ReadLine();   // read the value --> expression 
    // replace to the line below
    title = ReadString("Enter a title: ", true);

    //Console.WriteLine("Enter a decription: ");
    //decription = Console.ReadLine();
    decription = ReadString("Enter a decription: ", false);


    //T000: Fix length --> if you need to fix it, put the note like that
    //Console.WriteLine("Enter the run length (in mins): ");
    //string lengthString = Console.ReadLine();
    //replace
    length = ReadInt("Enter the run length(in mins): ",0);
    releaseYear = ReadInt("Enter the release year: ", 1900);

    genre = ReadString("Enter a genre: ", false);
    rating = ReadString("Enter a rating: ", false);

    isBlackAndWhite = ReadBoolean("Black and White (Y/N)? "); 
}


//Display the movie details
void DisplayMovie ()
{
    Console.WriteLine();
    Console.WriteLine("-*---------------*-");
    Console.WriteLine(title);
  
    // Run Length: ## mins
    Console.WriteLine("Run Length: " + length + " mins");

    // Released yyy
    Console.WriteLine("Release " + releaseYear);

    Console.WriteLine(genre);

    //MPPA Ratting
    Console.WriteLine("MPAA Ratting: " + rating);

    // Black and White
    //Version 1
    /*
     * string format = "color";                             
     * if (isBlackAndWhite)
     *   format = "Black and White";
    */
    //version 2 
    // you can replace EB ? Et : Ef  
    string format = isBlackAndWhite ? "Black and White" : "Color";
    Console.WriteLine("Format: " + format);

    //version 3: if you have short condition, you can use this statement.
    //Console.WriteLine("Format: " + (isBlackAndWhite ? "Black and White" : "Color"));
   

    Console.WriteLine(decription);
}

/* 
 * function run in isolation
 * parameter: geting data into a function
 * return type: Getting data out of a function
*/


bool ReadBoolean (string message)
{
    Console.WriteLine(message);

    //T000 Handle errors;
    while (true)
    {
        string value = Console.ReadLine();
        if (value == "Y" || value == "y")
            return true;
        else if (value == "N" || value == "n")  // value == "N" || "n"
            return false;

        Console.WriteLine("Please enter Y/N");

        /*
        if (false)
        break; // stops current iteration, exits loop

        if(false)
        continue; //stops current iteration, lopps arround and tries again (stop that value and continue next value)
        */
    };
}


int ReadInt (string message, int minimumValue)
{
    Console.WriteLine(message);

    do
    {
        string value = Console.ReadLine();

        //int result = Int32.Parse(value); // Int32.Parse(string) --> int, but can not trust that value when you put
        // --> replace
        /*int result;
        if (Int32.TryParse(value, out result)) // if we put "out" --> if False, can not return result, it will be returned "0".
        */
        //if (Int32.TryParse(value, out int result)) // add the value in local value
        if (Int32.TryParse(value, out var result))   // upgrade int to var

            if (result >= minimumValue)
                return result;

        Console.WriteLine("Value must be at least " + minimumValue);
    }
    while (true);
}

string ReadString (string message, bool isRequired )    //  funct-decl
{
    Console.WriteLine(message);

    do
    {
        string value = Console.ReadLine();

        /*
        if (!isRequired)
            return value;    // return-stament ::= return[Et];

        // Is it empty
        if (value != "")
            return value;
        */
        // we can combine 2 statement

        if (!isRequired || value != "")
            return value;


        Console.WriteLine("Value is required");
    } while (true);               
    //else
    //    return "";

    /*
    if (false)
        if (true)
            Console.WriteLine(""); 
        else
            Console.WriteLine("");
    if you want to block second if, you have to add {} to create a new stament
   */

    //T000: Input validation for required

    //return value;
    //return Console.ReadLine()  --> can you this code to replace the value
}



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


