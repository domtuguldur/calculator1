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
        public void harah()
        {
            if(toonuud.Count == 0)
            {
                Console.WriteLine("memory baihgui");
                return;
            }
            else
            {
                Console.WriteLine("memory:");
                for (int i = 0; i < toonuud.Count; i++)
                {
                    Console.WriteLine($"{i + 1}-r too: {toonuud[i]}");
                }
            }
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
