using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.GrigorjanAM.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        private const string V = " ";

        public string CollectTextFromFile(string str, string path)
        {
            string text = File.ReadAllText(path);
            string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' });
            int len = words.Length;
            string result = "";
            for (int i = 0; i < len; i++)
            {
                if (words[i].Contains(str))
                {
                    result = result + " " + words[i];
                }
            }
            return result;

        }
    }
}
