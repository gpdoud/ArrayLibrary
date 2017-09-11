using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace TestArrayLibrary {
	class Program {

		void Run() {
			var aStudent = LearningArrays.Students[4];
			Console.WriteLine($"The second student in the array is {aStudent}");

			// Iterating through all items in the array
			var Total = 0;
			for(var idx = 0; idx < LearningArrays.TestScores.Count(); idx++) {
				Total += LearningArrays.TestScores[idx];
			}
			var Average = ((double)Total) / LearningArrays.TestScores.Count();
			Console.WriteLine($"The sum of the scores is {Total}; the average is {Average}");

			// another way of iterating through an array -- FOREACH
			var FrameTotal = 0;
			foreach(var score in LearningArrays.Frames) {
				FrameTotal += score;
			}
			Console.WriteLine($"Total frame score is {FrameTotal} and average is {FrameTotal / LearningArrays.Frames.Count()}");
		}
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
