using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	class Трапеция : Формулы
	{
		public Трапеция(int side1, int side2, int height, int radius, int diagonal, int side3, int side4) :
			base(side1, side2, height, radius, diagonal, side3, side4)
		{
		}
		internal override void square()
		{
			int a = Side1;
			int b = Side2;
			int h = Height;
			int S = ((a + b) / 2) * h;
			Console.WriteLine("Плошадь трапеции: " + S);
		}

		internal override void Perimetr()
		{
			int a = Side1;
			int b = Side2;
			int c = Side3;
			int d = Side4;
			int P = a + b + c + d;
			Console.WriteLine("Периметр трапеции: " + P);
		}
	}
}
