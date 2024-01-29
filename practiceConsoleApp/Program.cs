Console.WriteLine("Enter your age: ");
string nameInput = Console.ReadLine();

int age = 0; // Initialize age as 0 in case of conversion failure

if (Int32.TryParse(nameInput, out age))
{
    Console.WriteLine("Your age is: " + age);
    Console.WriteLine("The data type of age is now: " + age.GetType());
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer for your age.");
}
