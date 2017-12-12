using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoTech.ClassesAuxiliares
{
    class UnderZeroException : Exception
    {
        public override string ToString() { return "Valor menor que zero detectado"; }
    }
}
