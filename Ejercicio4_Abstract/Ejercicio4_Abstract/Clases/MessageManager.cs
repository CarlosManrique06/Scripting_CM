using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Abstract.Clases
{
    internal class MessageManager
    {
        public void Ejecutar()
        {
           
            AbstractSample m1 = new Mensaje();
            AbstractSample m2 = new MensajeInvertido();

           
           
            m1.PrintMessage("Saludoooos");
            
            m1.InvertMessage("Saludoooos");

            m2.PrintMessage("OLA");
            m2.InvertMessage("OLA");

           
        }
    }
}
