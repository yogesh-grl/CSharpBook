using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.LeetCode.ArrayOrString
{
    internal class ContainsDuplicate
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> retVal = new List<IList<string>>();
            List<string> orderedStringArray = new List<string>();


            for (int i = 0; i < strs.Length; i++)
            {
                orderedStringArray.Add(String.Concat(strs[i].OrderBy(c => c)));
            }

            IList<string> strings = new List<string>();
            List<string> distictStr = orderedStringArray.Distinct().ToList();
            for (int i = 0; i < distictStr.Count; i++)
            {
                strings = new List<string>();
                for (int j = 0; j < orderedStringArray.Count; j++)
                {
                    if (orderedStringArray[j] == distictStr[i])
                    {
                        strings.Add(strs[j]);
                    }
                }
                retVal.Add(strings);
            }
            return retVal;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] retVal = null;

            for (int i = 0; i < nums.Length; i++)
            {
                // if (nums[i] > target == false)
                {
                    int val = target - nums[i];
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (val == nums[j])
                        {
                            retVal = new int[] { i, j };
                            break;
                        }
                    }
                }
            }

            return retVal;
        }

        public bool IsAnagram(string s, string t)
        {
            bool retVal = false;
            if (s.Length == t.Length)
            {
                string orderedS = String.Concat(s.OrderBy(c => c));
                string orderedT = String.Concat(t.OrderBy(c => c));
                if (orderedS == orderedT)
                {
                    Console.WriteLine(orderedS);
                    retVal = true;
                }
            }

            return retVal;
        }

        public bool ContainsDuplicateValue(int[] nums)
        {
            // var mapping = new HashSet<int>(nums);
            // if (mapping.Count != nums.Length)
            //     return true;
            // return false;

            //int[] disctArray = nums.ToList().Distinct().ToArray();
            //if (disctArray.Length == nums.Length)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}


            bool retVal = false;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (retVal == true)
                {
                    break;
                }
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        retVal = true;
                        break;
                    }
                }
            }
            return retVal;
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Count the frequency of each element
            foreach (var num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            // Select the k most frequent elements
            var result = frequencyMap
                .OrderByDescending(pair => pair.Value)
                .Take(k)
                .Select(pair => pair.Key)
                .ToArray();

            return result;
        }

        public bool PalindromeNumber(int number)
        {
            string strnum = number.ToString();
            string revString = new string(strnum.Reverse().ToArray());
            if (strnum == revString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }

            string finalPrefix = "";
            string currentPrefix = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                currentPrefix += strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    string crntStr = strs[j].ToString();
                    if (crntStr.StartsWith(currentPrefix))
                    {
                        // starts with expected prefix
                    }
                    else
                    {
                        return finalPrefix;
                    }
                }
                finalPrefix = currentPrefix;
            }
            return finalPrefix;
        }

    }
}
