using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorlibrary1
{
    interface IOperation
    {
        /// <summary>
        /// nemeh uildliig interface helbereer zarlaw
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Sum(int x);

        /// <summary>
        /// hasah uildliig interface helbereer zarlaw
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Sub(int x);
    }
}
