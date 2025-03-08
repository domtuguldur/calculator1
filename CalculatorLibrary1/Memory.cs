using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorlibrary1
{
    public class Memory
    {
        public List<int> toonuud = new List<int>();

        /// <summary>
        /// int turliin ugugdul hadgalah listend too nemeh uildel. 
        /// </summary>
        /// <param name="too"></param>
        public void hadgalah(int too)
        {
            toonuud.Add(too);
        }
        /// <summary>
        /// listiig hewleh uildel
        /// </summary>
        public string harah()
        {
            if (toonuud.Count == 0)
            {
                return "Memory baihgui";
            }

            StringBuilder result = new StringBuilder(); 

            for (int i = 0; i < toonuud.Count; i++)
            {
                result.AppendLine($"{i + 1}-р тоо: {toonuud[i]}");
            }

            return result.ToString();
        }

        /// <summary>
        /// listiig hoosloh buyu ustgah uildel
        /// </summary>
        public void tsewereh()
        {
            toonuud.Clear();
            Console.WriteLine("Memory tsewerlsen");
        }
    }
}
