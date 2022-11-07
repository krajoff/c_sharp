Console.Clear();
string text = "(1,2) (3,4) (5,6) (7,8)"
                .Replace("(", "")
                .Replace(")", "");

var data = text.Split(" ")
            .Select(text => text.Split(','))
            .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
//            .Where(e => e.x % 2 == 0)
//            .Select(point => (point.x * 10, point.y + 1))
            .ToArray();
//Console.WriteLine(data);
for (int i = 0; i < data.Length; i++)
{
    
//        for (int k = 0; k < data[i].Length; k++)
//        {
            Console.WriteLine(data[i]);
//        }
}