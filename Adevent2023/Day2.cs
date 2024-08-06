using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adevent2023;
public class Day2 {
    private readonly (int Red, int Green, int Blue) presets = (12, 13, 14);

    public int Execute() {
        var lines = File.ReadAllLines(".\\day2.txt");
        return lines.Sum(line => SumIfPossible(line));
    }

    private int SumIfPossible(string line) {
        //var split1 = line.Split(":");
        //var gameId = Convert.ToInt32(split1[0].Split(" ")[1]);
        //var scoreArr = split1[1].Split(";");
        //var scores = scoreArr.SelectMany(x => x.Trim().Split(",").Select(score => {
        //    var parts = score.Trim().Split(" ");
        //    return (Convert.ToInt32(parts[0]), parts[1].Trim());
        //}));

        //foreach ((int count, string color) score in scores) {
        //    switch (score.color) {
        //        case "red":
        //            if (score.count > presets.Red) return 0;
        //            break;
        //        case "green":
        //            if (score.count > presets.Green) return 0;
        //            break;
        //        case "blue":
        //            if (score.count > presets.Blue) return 0;
        //            break;
        //        default:
        //            break;
        //    }
        //}
        //return gameId;
    }
}
