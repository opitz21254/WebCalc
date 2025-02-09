// See https://aka.ms/new-console-template for more information
using CalcLogic;

string[] validCommands =
{
    "Rad",
    "Deg",
    "Tan",
    "!",
    "1/x",
    "Sin",
    "ArcSin",
    "Ln",
    "E",
    "Pi",
    "Cos",
    "ArcCos",
    "Log",
    "10^x",
    "e^x",
    "ArcTan",
    "√",
    "^2",
    "Ans",
    "Rand",
    "^",
    "y√x",
    "(",
    ")",
    "%",
    "AC",
    "CE",
    "7",
    "8",
    "9",
    "/",
    "*",
    "4",
    "5",
    "6",
    "-",
    "+",
    "1",
    "2",
    "3",
    ".",
    "=",
    "0",
};

Console.Clear();
Console.WriteLine("Hello, welcome to Super_Normal_Calculator");

 TakeUserInput();
string userInput = null;
do
{
    Console.Write("Please type a valid command or \'help\' for a list of commands: ");
    string input = Console.ReadLine();

    if (input == null)
    {
        Console.WriteLine("Input cannot be null. Try again.");
    }

    if (validCommands.Contains(input))
    {
        userInput = input;
    }
    else
    {
        Console.WriteLine("Invalid input. Try again.");
    }
} while (!validCommands.Contains(userInput));

switch (userInput)
{
    case "Rad":
        FunctionBot.addRad();
        break;
    case "Deg":
        FunctionBot.addDeg();
        break;
    case "Tan":
        FunctionBot.addTan();
        break;
    case "!":
        FunctionBot.addFactorial();
        break;
    case "1/x":
        FunctionBot.addInverse();
        break;
    case "Sin":
        FunctionBot.addSin();
        break;
    case "ArcSin":
        FunctionBot.addArcSin();
        break;
    case "Ln":
        FunctionBot.addLn();
        break;
    case "E":
        FunctionBot.addE();
        break;
    case "Pi":
        FunctionBot.addPi();
        break;
    case "Cos":
        FunctionBot.addCosine();
        break;
    case "ArcCos":
        FunctionBot.addArccosine();
        break;
    case "Log":
        FunctionBot.addLog();
        break;
    case "10^x":
        FunctionBot.add10ToTheX();
        break;
    case "e^x":
        FunctionBot.addEulersNumber();
        break;
    case "ArcTan":
        FunctionBot.addArcTan();
        break;
    case "√":
        FunctionBot.addSquareRoot();
        break;
    case "^2":
        FunctionBot.addSquare();
        break;
    case "Ans":
        FunctionBot.addAnswer();
        break;
    case "Rand":
        FunctionBot.addRandom();
        break;
    case "^":
        FunctionBot.addXtoTheY();
        break;
    case "y√x":
        FunctionBot.addYrootsOfX();
        break;
    case "(":
        FunctionBot.addLeftParenthesis();
        break;
    case ")":
        FunctionBot.addRightParenthesis();
        break;
    case "%":
        FunctionBot.addPercentage();
        break;
    case "AC":
        FunctionBot.addAllClear();
        break;
    case "CE":
        FunctionBot.addClearEntry();
        break;
    case "7":
        FunctionBot.add7();
        break;
    case "8":
        FunctionBot.add8();
        break;
    case "9":
        FunctionBot.add9();
        break;
     case "/":
        FunctionBot.addDivide();
        break;
    case "*":
        FunctionBot.addMultiply();
        break;
    case "4":
        FunctionBot.add4();
        break;
    case "5":
        FunctionBot.add5();
        break;
    case "6":
        FunctionBot.add6();
        break;
    case "-":
        FunctionBot.addMinus();
        break;
    case "+":
        FunctionBot.addPlus();
        break;
    case "1":
        FunctionBot.add1();
        break;
    case "2":
        FunctionBot.add2();
        break;
    case "3":
        FunctionBot.add3();
        break;
    case ".":
        FunctionBot.addPoint();
        break;
    case "=":
         FunctionBot.addEquals(); 
        	break; 
	case"0": 
		FunctionBot.add0(); 
		break;
    default:
        Console.WriteLine($"Unknown command: {userInput}");
        break;
}