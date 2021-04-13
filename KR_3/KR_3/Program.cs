using System;
using System.Collections.Generic;
using System.Linq;

namespace KR_3
{
    class Program
    {
        static string[] GetAllKeys(Dictionary<string, int>[] dicts)
        {
            var temp = new HashSet<string>();
            foreach (var i in dicts)
            {
                foreach (var j in i)
                {
                    temp.Add(j.Key);
                }    
            }

            return temp.ToArray();
        }
        
        static Dictionary<string, int> MaxDict(Dictionary<string, int>[] dicts)
        {
            var keys = GetAllKeys(dicts);

            var tempDict = new Dictionary<string, int>();
            foreach (var i in keys)
            {
                int maxValue = int.MinValue;
                foreach (var j in dicts)
                {
                    if (j.ContainsKey(i))
                    {
                        maxValue = Math.Max(j[i], maxValue);
                    }
                }
                tempDict.Add(i, maxValue);
            }

            return tempDict;
        }
        
        static Dictionary<string, int> SumDict(Dictionary<string, int>[] dicts)
        {
            var keys = GetAllKeys(dicts);

            var tempDict = new Dictionary<string, int>();
            foreach (var i in keys)
            {
                int sum = 0;
                foreach (var j in dicts)
                {
                    if (j.ContainsKey(i))
                    {
                        sum += j[i];
                    }
                }
                tempDict.Add(i, sum);
            }

            return tempDict;
        }
        
        static void Main(string[] args)
        {
            var dictArray = new Dictionary<string, int>[]
            {
                new Dictionary<string, int>()
                {
                    {"1231", 23},
                    {"122331", 233}
                },
                new Dictionary<string, int>()
                {
                    {"1231", 1232},
                    {"123", 1}
                },
                new Dictionary<string, int>()
                {
                    {"2", 23},
                    {"5", 233}
                }
            };

            var maxDict = MaxDict(dictArray);

            foreach (var i in maxDict)
            {
                Console.WriteLine($"{i.Key} {i.Value}");
            }
            
            var sumDict = SumDict(dictArray);
            
            foreach (var i in sumDict)
            {
                Console.WriteLine($"{i.Key} {i.Value}");
            }
        }
    }
}