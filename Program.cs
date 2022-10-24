

int num1;
int num2;
string choice;
bool playagain = true;

while(playagain == true)
{
Console.WriteLine("Please enter a number.");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter another number.");
num2 = Convert.ToInt32(Console.ReadLine());
if(num1 >= num2)
{
    Console.WriteLine($"{num1} is greater than {num2}.");
}
if(num2 <= num1)
{
    Console.WriteLine($"{num2} is less than {num1}.");
}
if(num1 <= num2)
{
    Console.WriteLine($"{num1} is less than {num2}.");
}
if(num2 >= num1)
{
    Console.WriteLine($"{num2} is greater than {num1}.");
}
if(num1 == num2)
{
    Console.WriteLine($"{num1} is equal to {num2}.");
}
if(num2 == num1)
{
    Console.WriteLine($"{num2} is equal to {num1}.");
}
Console.WriteLine("Would you like to try again?Type Y to try again or N to end.");
 choice = Console.ReadLine().ToUpper();
 //if the user wanted to try again, pressing "Y" will send them to the beginning
 if(choice == "Y")
    {
      playagain = true;
    }
    else if(choice == "N")
    {
      //if the user wanted to stop pressing "N" will end the program
      playagain = false;
    }
    else
    {
        Console.WriteLine("Please pick a valid option.");
    }  
}       