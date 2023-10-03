using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.LeetCode.ArrayOrString
{
    internal class MergeSortedArray
    {
        public MergeSortedArray()
        {
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            try
            {
                //int[] tmp = nums1.ToList().GetRange(0, m).ToArray();
                //int[] tmp1 = nums2.ToList().GetRange(0, n).ToArray();

                //int[] tmp3 = new int[m + n];
                //for (int i = 0; i < m; i++)
                //{
                //    tmp3[i] = tmp[i];
                //}

                //int len = tmp.Length;

                //for (int i = 0; i < n; i++)
                //{
                //    tmp3[i + len] = tmp1[i];
                //}
                //List<int> tmp3ls = tmp3.ToList();
                //tmp3ls.Sort();

                //nums1 = tmp3ls.ToArray();

                int i = m - 1;
                int j = n - 1;
                int k = (m + n) - 1;

                while (i > 0 && j > 0)
                {
                    if (nums1[i] > nums2[j])
                    {
                        nums1[k] = nums1[i];
                        i--;
                    }
                    else
                    {
                        nums1[k] = nums2[j];
                        j--;
                    }
                    k--;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            try
            {

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != val)
                    {
                        nums[k] = nums[i];
                        k++;
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return k;
        }
    }
}
