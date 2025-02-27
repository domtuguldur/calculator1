using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculatorlibrary1
{
    public class Calculator : Result, IOperation
    {
        /// <summary>
        /// hasah uildel ni result d hadaglagdsan utga deer hiigdene. Neg utga awna
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Sub(int x)
        {
            return results -= x;
        }

        /// <summary>
        /// nemeh uildel ni result d hadaglagdsan utga deer hiigdene. Neg utga awna
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Sum(int x)
        {
            return results += x;
        }


    }
}
