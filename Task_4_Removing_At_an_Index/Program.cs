List<string> instructors = new List<string> { "Brett", "Nevin", "JJ", "Dan", "Megan" };
instructors.Add("Dan");
instructors.Add("Amy");
instructors.Add("Ted");

instructors[3] = "Danimal";

instructors.Remove("Ted");

for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i]);
}

// there is no Mike , probobly it was Megan
Console.WriteLine($"Count before {instructors.Count}");

instructors.RemoveAt(4);

Console.WriteLine();
Console.WriteLine($"Count after {instructors.Count}\n");

for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i]);
}
