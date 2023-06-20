namespace EqualStacks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] firstLine = Console.ReadLine().TrimEnd().Split(' ');
			int n1 = Convert.ToInt32(firstLine[0]);
			int n2 = Convert.ToInt32(firstLine[1]);
			int n3 = Convert.ToInt32(firstLine[2]);
			List<int> h1 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(val => Convert.ToInt32(val)).ToList();
			List<int> h2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(val => Convert.ToInt32(val)).ToList();
			List<int> h3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(val => Convert.ToInt32(val)).ToList();
            Console.WriteLine(StacksEqual.EqualStacks(h1, h2, h3));
        }
	}
}