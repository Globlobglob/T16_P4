using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme16Pr3
{
    class Procedure
    {
        TimeSpan procedure1;
        TimeSpan procedure2;

        int count;

        public Procedure() { }
        public Procedure(TimeSpan procedure1, TimeSpan procedure2,int count)
        {
            this.procedure1 = procedure1;
            this.procedure2 = procedure2;
            this.count=count;
        }

        public void Output()
        {
            TimeSpan betwen = procedure2 - procedure1;
            TimeSpan time = procedure1;

            for (int i = 0; i < count; i++)
            {
                
                Console.WriteLine(time);
                time += betwen;
            }
        }

        
       


    }
}
