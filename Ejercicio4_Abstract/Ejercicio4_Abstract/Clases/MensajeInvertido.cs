using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Abstract.Clases
{
    internal class MensajeInvertido : AbstractSample
    {


        public override void PrintMessage(string text)
        {
            Message = InvertirCase(text);
            Console.WriteLine(Message);
        }

     
        public override void InvertMessage(string text)
        {
          
            string invertido = new string(text.Reverse().ToArray());
          
            Message = InvertirCase(invertido);
            Console.WriteLine(Message);
        }

        private string InvertirCase(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                    chars[i] = char.ToLower(chars[i]);
                else if (char.IsLower(chars[i]))
                    chars[i] = char.ToUpper(chars[i]);
            }
            return new string(chars);
        }
    }
}
