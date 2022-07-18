Dictionary<string, int> dict = new Dictionary<string, int>() {
            {"A", 1}, {"B", 2}, {"C", 3}, {"D", 4}
        };

foreach (var kvp in dict)
{
    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}