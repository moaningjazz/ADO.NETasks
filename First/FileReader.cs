using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace First
{
    public class FileReader
    {
        public string Path { get; set; }

        private Round GetRoundInString(string stringInfo)
        {
            var splitingData = stringInfo.Split(' ');

            double x;
            double y;
            double radius;

            if (splitingData.Length == 3 &&
                double.TryParse(splitingData[0], out x) &&
                double.TryParse(splitingData[1], out y) &&
                double.TryParse(splitingData[2], out radius))
                return new Round(new Point(x, y), radius);
            else
                throw new FormatException("File format error!");
        }

        public Round GetRound()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                return GetRoundInString(input.ReadLine());
            }
        }

        public IEnumerable<Round> GetRounds()
        {
            using (StreamReader input = new StreamReader(Path))
            {
                List<Round> rounds = new List<Round>();
                while (!input.EndOfStream)
                {
                    rounds.Add(GetRoundInString(input.ReadLine()));
                }
                return rounds;
            }
        }

        public FileReader(string path) => Path = path;
    }
}
