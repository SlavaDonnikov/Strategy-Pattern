using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._11._17_KPYP_Test_Inheritence_Interface
{
    class Mashine
    {
        public IEngine Engine { get; set; }

        public Mashine(IEngine engine)
        { Engine = engine; }

        public void Move()
        {
            Engine.Equip();
        }
    }
}
