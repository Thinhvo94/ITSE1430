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
 *  ------------------------------------------------------09-07-23-------------------------------------------------------------
 *  using for  menu point
 *  switch (Et)
 *  {
 *   {case Ect : S} --> it must be unit statement,
 *   [default : S]
 *  };
 *  --> No fallthrough --> all crosses have break
 *  each case has only 1 statement, not include break statement
 *  if we have multi statements in case, use "{}"
 *  Fallthough allow: unless preprious --> case is empty (if 2 cases or more have the same statement, we can leave empty the statement, and keep the last case has stament)
 *  
 *  ReadKey: retun the complex object and doesnt care ab key
 *  
 *  null is nothing
 *  
 * \n: get a new line
 * \t: tab
 * Escape character:
 *      someValue = "Hello\"Bob";
 *      string filePath = "C:\\Windows\\temp"; or filePath = @"C:\Windows\temp"; --> verbatim string
 */




string title = "", decription = "";
//title = "";

string genre = "", rating = "";

int length = 0, releaseYear = 1900;

decimal budget = 125.45M; /// decimal can not storage samething like double. we have to add "M" behind the number.
bool isBlackAndWhite = false;


// Entry Point

// 2 option to create Menu point 
/* Ver1: Using If - else if   (if we use "IF", it needs to check each condition until it find the result. It u type wrong, it 'll break your app
var done = false;
do { 
    int command = DisplayMenu();
    if (command ==1)
        AddMovie();
    else if (command == 2)
        EditMovie();
    else if (command == 3)
        DeleteMovie();
    else if (command == 4)
        ViewMovie();
    else if (command == 0)
        done = true;
} while (!done);
*/

// Ver2: using switch
var done = false;
do
{
    int command = DisplayMenu();
    switch (DisplayMenu())
    {
        case 1: AddMovie(); break;
        case 2: EditMovie(); break;
        case 3: DeleteMovie(); break;
        case 4: ViewMovie(); break;
        case 0:
        {
            done = true;
            break;
        }

        default: Console.WriteLine("Unknow option"); break;

    }
} while (!done);

    /*Get movie details and display (After you create Main, you can delete poit 
    AddMovie();
    ViewMovie();
    */

int DisplayMenu ()
{
    Console.WriteLine("-------------");
    Console.WriteLine("A)dd Movie");
    Console.WriteLine("E)dit Movie");
    Console.WriteLine("D)ellete Movie");
    Console.WriteLine("V)iew Movie");
    Console.WriteLine("Q)uit");

   do
   {
            /*
        var input = Console.ReadLine();
        if (input == "A" || input == "a")
            return 1;
        else if (input == "E" || input == "e")
            return 2;
        else if (input == "D" || input == "d")
            return 3;
        else if (input == "V" || input == "v")
            return 4;
        else if (input == "Q" || input == "q")
            return 0;
            */

           /* switch (Console.ReadLine())
            {
                case "A": //return 1;
                case "a": return 1;

                case "E": //return 2;
                case "e": return 2;

                case "D": //return 3;
                case "d": return 3;

                case "V": //return 4;
                case "v": return 4;

                case "Q": //return 0;
                case "q": return 0;

            };*/

        switch (Console.ReadKey(true).Key)
        {
               
            case ConsoleKey.A: return 1;

            case ConsoleKey.E: return 2;

            
            case ConsoleKey.D: return 3;

           
            case ConsoleKey.V: return 4;

            
            case ConsoleKey.Q: return 0;
        };
    } while (true);
}



// Functions
void AddMovie ()
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
    rating = ReadRating("Enter a rating: ");

    isBlackAndWhite = ReadBoolean("Black and White (Y/N)? "); 
}

void EditMovie () 
{
    Console.WriteLine("Not implemented yet");
}

void DeleteMovie () 
    {
        if (!Confirm("Are you sure you want to delete the movie (Y/N)?"))
            return;

        Console.WriteLine("Not implemmented yet");
    }


//Display the movie details
void ViewMovie ()
{
    /*
    Console.WriteLine();
    Console.WriteLine("-*---------------*-");
    */
    Console.WriteLine("\n-*----------------*-\n");
  

    Console.WriteLine(title);

    // Run Length: ## mins
    //Console.WriteLine("Run Length: " + length + " mins");
    Console.WriteLine("Run Length: " + length.ToString() + " mins"); //every Expression supports ToString()


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

bool Confirm (string message)
{
        return ReadBoolean(message);
}

/* 
 * function run in isolation
 * parameter: geting data into a function
 * return type: Getting data out of a function
*/


bool ReadBoolean (string message)
{
    Console.WriteLine(message);

    while (true)
    {
            /*string value = Console.ReadLine();
            if (value == "Y" || value == "y")
                return true;
            else if (value == "N" || value == "n")  // value == "N" || "n"
                return false;
            */

            /*switch(Console.ReadKey())
            {
               case "Y"
               case "y": return true;

               case "N"
               case "n": return false;
            };
            */
            // --> upgrade code using ReadKey
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y: return true;

                case ConsoleKey.N: return false;


            };

            //Console.WriteLine("Please enter Y/N");

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

string ReadRating ( string message)
{
    Console.WriteLine(message);

    do
    {
        string value = Console.ReadLine();

        if (value == "PG")
            return "PG";
        else if (value == "G")
            return "G";
        else if (value == "PG-13")
            return "PG-13";
        else if (value == "R")
            return "R";
        //else if (value == "")  // else if (value == String.Empty
        //else if (value == "" || value == null) --> DO NOT DO THIS
        else if (String.IsNullOrEmpty(value))
            return "";
        
        Console.WriteLine("Invalid Rating");
    } while (true);

    string emptyValue;
    var areEqual = "" == String.Empty; //true
    areEqual = "" == null; // value


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

        if (!isRequired || value != "") //--> beacuse we add more code for no empty string
        //if (!isRequired || )
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


