using ClassesEInterfaces.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesEInterfaces.Dominio
{
    class Ninja :IAcao
    {
        public string Nome { get; set; }
        public int Forca { get; set; }

        public string ArmaAtaque()
        {
            return "Estrelas";
        }
    }
}
