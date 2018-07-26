using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			Console.WriteLine("Ingrese numero:");
			
			n = int.Parse(Console.ReadLine());
			

			if ((n %2) == 0)

				Console.WriteLine("el numero es par");

			else
				Console.WriteLine("el numero es impar");

			Console.ReadKey(); 
		}
	}
}

