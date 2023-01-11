using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency_Of_Registration
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] arr = new int[] { 0002020, 2020002, 2020003, 0012020, 0022020, 2020004 };
			int[] dup = new int[]{ 0002020, 2020002, 2020003, 0012020, 0022020, 2020004 }; ;

			int n, i, j, cnt;


			Console.Write("Enter the array Number:");
			n = int.Parse(Console.ReadLine());

			Console.Write("Enter the Elements in array Number: ");
			for (i = 0; i < n; i++)



			{

				arr[i] = int.Parse(Console.ReadLine());
				dup[i] = -1;
			}
			for (i = 0; i < n; i++)

			{
				cnt = 1;
				for (j = i + 1; j < n; j++)
				{

					if (arr[i] == arr[j])
					{

						cnt++;
						dup[j] = 0;

					}

					if (dup[i] != 0)
					{

						dup[i] = cnt;


					}




				}
				Console.WriteLine("Duplicate Numbers in Array:");

				for (i = 0; i < n; i++)
				{

					if (dup[i] != 0)

					{
						Console.WriteLine("Number" + arr[i] + "has occured" + dup[i] + "Times");



					}

				}
				Console.ReadLine();
			}
		}
	}
}