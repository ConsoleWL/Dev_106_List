List<string> instructors = new List<string> { "Brett", "Nevin", "JJ", "Dan", "Megan" };
instructors.Add("Dan");
instructors.Add("Amy");
instructors.Add("Ted");

instructors[3] = "Danimal";

foreach(string instructor in instructors)
{
    Console.WriteLine(instructor);
}
