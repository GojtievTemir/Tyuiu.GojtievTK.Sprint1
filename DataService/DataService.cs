using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace DataService
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] words = value.Split(' ');
            for ( int i = 0; i < words.Length; i++)
            {
                words[i].Remove(words[i][0]);
              
            }
            string res = string.Join(" ", words);
            return res;
        }
    }
}
