using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TargetSum
{
    public Boolean targetSumOfProblem(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++) {

            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target) {
                    return true;
                }
            }
        }

        return false;
    }
}
