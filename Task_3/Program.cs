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