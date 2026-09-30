using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GojtievTK.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] words = value.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(1);

            }
            string res = string.Join(" ", words);
            return res;
        }
    }
}
