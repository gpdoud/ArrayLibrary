using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace TestArrayLibrary {
	class Program {

		void AvgHighTempForSept2017() {
			LearningArrays.HighTemps.Add(64);  // 9/1
			LearningArrays.HighTemps.Add(63);  // 9/2
			LearningArrays.HighTemps.Add(81);  // 9/3
			LearningArrays.HighTemps.Add(86);  // 9/4
			LearningArrays.HighTemps.Add(77);  // 9/5
			LearningArrays.HighTemps.Add(70);  // 9/6
			LearningArrays.HighTemps.Add(70);  // 9/7
			LearningArrays.HighTemps.Add(75);  // 9/8
			LearningArrays.HighTemps.Add(73);  // 9/9
			LearningArrays.HighTemps.Add(73);  // 9/10
			LearningArrays.HighTemps.Add(71);  // 9/11

			var SumTemps = 0;
			foreach(var temp in LearningArrays.HighTemps) {
				SumTemps += temp;
			}
			Console.WriteLine($"On Sept 11, the avg Cincinnati temp in Sept 2017 is {SumTemps / 11}");
			
		}

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

			LearningArrays.GradingScores.Add(97);
			LearningArrays.GradingScores.Add(89);
			LearningArrays.GradingScores.Add(88);
			LearningArrays.GradingScores.Add(78);
			LearningArrays.GradingScores.Add(63);
			LearningArrays.GradingScores.Remove(97);
			var idx2 = LearningArrays.GradingScores.IndexOf(63);
			LearningArrays.GradingScores[idx2] = 65;
			Console.WriteLine($"There are {LearningArrays.GradingScores.Count()} items in the list");

			foreach(var score in LearningArrays.GradingScores) {
				Console.WriteLine($"A score is {score}");
			}
		}
		static void Main(string[] args) {
			new Program().AvgHighTempForSept2017();
		}
	}
}
