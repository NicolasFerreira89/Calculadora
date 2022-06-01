using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI14T
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conectamos a control a programa
            ControlCalculadora control = new ControlCalculadora();
            //Chamar o método que será utilizado
            control.Operacao();
            Console.ReadLine();//Manter o prompt aberto
        }//fim do método main
    }//fim da classe 
}//fim do projeto
