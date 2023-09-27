using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices2
{
    abstract class Matriz
    {
        public abstract void MostrarMatriz();
        public abstract void CalcularCeros();
        public virtual void MostrarMatrizModificada() { }
        public virtual void PedirValores() { }
    }
}
