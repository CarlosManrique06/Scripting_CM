using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Abstract
{
   public abstract class AbstractSample
    {
        private string message;

   
        public AbstractSample()
        {
            message = "";
        }

        
        protected string Message
        {
            get { return message; }
            set { message = value; }
        }

   
        public abstract void PrintMessage(string text);

       
        public virtual void InvertMessage(string text)
        {
            message = new string(text.Reverse().ToArray());
            Console.WriteLine(message);
        }
    }

}
