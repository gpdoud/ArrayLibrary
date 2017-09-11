using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary {

	public class LearningArrays {

		public static string[] Students = { "a", "b", "c", "d", "e" };

		public static int[] TestScores = { 95, 87, 99, 92, 100 };

		public static int[] Frames = { 1,    5,   21,  0,   1,   16,  13,  29,  27,  30 };

		public static int[,] BowlingScores = new int[,] {
			{1,5,21,0,1,16,13,29,27,30 }, // first game of 10 frames
			{5,3,7,6,9,3,5,2,6,8 }, // second game of 10 frames
			{ 3,6,5,9,8,6,3,7,5,2} // third game of 10 frames
		};

		public static List<int> GradingScores = new List<int>();

		public static List<int> HighTemps = new List<int>();

	}
}
