using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._11._17_KPYP_Test_Inheritence_Interface
{
    public abstract class Engine
    {
        public delegate void EngineStateHandler(string message);
        public EngineStateHandler engineStateHandler;
               
        public void RegisterHandler(EngineStateHandler del)
        {
            engineStateHandler += del;
        }
        public void UnRegisterHandler(EngineStateHandler del)
        {
            engineStateHandler -= del;
        }

        public Engine(EngineStateHandler del) => engineStateHandler += del;
    }

    public class ElectricEngine : Engine, IEngine
    {
        public ElectricEngine(EngineStateHandler del) : base(del) { }

        public void Equip()
        {
            engineStateHandler?.Invoke("Этот механизм движется на электродвигателе.");
        }
    }

    public class PetroleumEngine : Engine, IEngine
    {
        public PetroleumEngine(EngineStateHandler del) : base(del) { }

        public void Equip()
        {
            engineStateHandler?.Invoke("Эта машина движется на бензиновом двигателе.");
        }
    }

    public class NuclearEngine : Engine, IEngine
    {
        public NuclearEngine(EngineStateHandler del) : base(del) { }

        public void Equip()
        {
            engineStateHandler?.Invoke("Этот механизм движется на атомном двигателе.");
        }
    }

    public class DarkMatterEngine: NuclearEngine, IEngine
    {
        public DarkMatterEngine(EngineStateHandler del) : base(del) { }

        void IEngine.Equip()
        {
            engineStateHandler?.Invoke("Этот космический корабль движется на двигателе, преобразующем темную материю!");
        }
    }

}
