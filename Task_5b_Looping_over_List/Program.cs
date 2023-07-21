List<string> list1 = new List<string> { "fan", "bulls", "high-", "barrel-o-", "slap" };
List<string> list2 = new List<string> { "fare", "eye", "horse", "monkeys", "stick" };

for (int i = 0; i < list1.Count; i++)
{
    Console.WriteLine(list1[i] + list2[i]);
}