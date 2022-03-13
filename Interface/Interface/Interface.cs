using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICar
    {
        void Speed();
    }
    class Ab:ICar
    {
        public void Speed()
        {
            Console.WriteLine(  "Speed is the "  );
        }
    }
    internal class Interface
    {
        public static void Main (string[] args)
        {
          ICar obj=new Ab();
            obj.Speed();
          Console.ReadLine();
        }
    }
}
