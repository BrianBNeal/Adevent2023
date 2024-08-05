using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adevent2023;
public class Day1 {

    private static readonly string[] NumbersAsWords =
        ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];

    private static readonly Dictionary<string, string> numbersFromWord = NumbersAsWords
        .Select((word, index) => new { word, index })
        .ToDictionary(pair => pair.word, pair => pair.index.ToString());

    public int Execute() {

        var lines = File.ReadAllLines(".\\day1.txt");
        return lines.Sum(line => ExtractFirstAndLastDigit(line));
    }

    private int ExtractFirstAndLastDigit(string line) {
        string? first = null, last = null;
        var lettersFromFront = "";
        var lettersFromEnd = "";

        for (int i = 0, j = line.Length - 1; i < line.Length && (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last)); i++, j--) {

            var fromFront = line[i];
            var fromEnd = line[j];

            if (string.IsNullOrWhiteSpace(first)) {
                if (char.IsDigit(fromFront)) {
                    first = fromFront.ToString();
                } else {
                    lettersFromFront += fromFront;
                    if (numbersFromWord.TryGetValue(NumbersAsWords.FirstOrDefault(n => lettersFromFront.Contains(n)) ?? "", out string? value)) {
                        first = value;
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(last)) {
                if (char.IsDigit(fromEnd)) {
                    last = fromEnd.ToString();
                } else {
                    lettersFromEnd = fromEnd + lettersFromEnd;
                    if (numbersFromWord.TryGetValue(NumbersAsWords.FirstOrDefault(n => lettersFromEnd.Contains(n)) ?? "", out string? value)) {
                        last = value;
                    }
                }
            }
        }
        return Convert.ToInt32($"{first}{last}");
    }

    public int getNumberFromLine(string line) {
        var first = line.First(char.IsDigit);
        var last = line.Reverse().First(char.IsDigit);
        return Convert.ToInt32($"{first}{last}");
    }
}
