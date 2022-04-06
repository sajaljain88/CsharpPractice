using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PrimeNumber
{
    public Boolean primeNumber(int n)
    {   Boolean result = true;
        for (int i = 2; i <= n / 2; i++)
        {

            if (n % i == 0)
            {
                result = false;
            }
        }

        return result;
    }
}
