using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TretyakovDV.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string firstWords = "";

            foreach (string line in lines)
            {
                string[] words = line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                if (words.Length > 0)
                {
                    firstWords += words[0] + " ";
                }
            }

            return firstWords.Trim();
        }
    }
}