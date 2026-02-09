using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Abstract.Clases
{
    public class Mensaje : AbstractSample
    {
        public override void PrintMessage(string text)
        {
            Message = text;
            Console.WriteLine(Message);
        }
    }

}
