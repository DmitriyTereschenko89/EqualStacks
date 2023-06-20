namespace EqualStacks
{
	internal class StacksEqual
	{
		private static int GetSumCylinder(List<int> arr, Stack<int> st)
		{
			int sumCylinder = 0;
			for (int i = arr.Count - 1; i >= 0; --i)
			{
				sumCylinder += arr[i];
				st.Push(arr[i]);
			}
			return sumCylinder;
		}

		public static int EqualStacks(List<int> h1, List<int> h2, List<int> h3)
		{
			Stack<int> st1 = new();
			Stack<int> st2 = new();
			Stack<int> st3 = new();
			int sumSt1 = GetSumCylinder(h1, st1);
			int sumSt2 = GetSumCylinder(h2, st2);
			int sumSt3 = GetSumCylinder(h3, st3);
			while (sumSt1 != sumSt2 || sumSt2 != sumSt3)
			{
				if (sumSt1 > sumSt2 && sumSt1 > sumSt3)
				{
					sumSt1 -= st1.Pop();
				}
				else if (sumSt2 > sumSt3)
				{
					sumSt2 -= st2.Pop();
				}
				else
				{
					sumSt3 -= st3.Pop();
				}
			}
			return sumSt1;
		}
	}
}
