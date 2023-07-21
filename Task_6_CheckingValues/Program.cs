Console.WriteLine("Please, enter a name:");
string newName = Console.ReadLine();
//Console.WriteLine();
//string newName = "Jos";

bool duplicateFound = false;

List<string> instructors = new List<string> { "Brett", "Nevin", "JJ", "Dan", "Megan", "Dan", "Amy", "Ted" };

for (int i = 0; i < instructors.Count; i++)
{
    if (instructors[i] == newName)
    {
        duplicateFound = true;
    }
}

if (duplicateFound != true)
{
    instructors.Add(newName);
    foreach (string name in instructors)
    {
        Console.WriteLine(name);
    }
    Console.WriteLine($"_______ {newName} was added to to list");
    Console.WriteLine($"_______ Length of the List: {instructors.Count}");
}
else
{
    Console.WriteLine("“Sorry that name has been taken, please provide a nickname”.");
}



