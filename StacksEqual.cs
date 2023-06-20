using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualStacks
{
	internal class StacksEqual
	{
		public static int EqualStacks(List<int> h1, List<int> h2, List<int> h3)
		{
			int sumSt1 = h1.Sum();
			int sumSt2 = h2.Sum();
			int sumSt3 = h3.Sum();
			Stack<int> st1 = new(h1);
			Stack<int> st2 = new(h2);
			Stack<int> st3 = new(h3);
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
