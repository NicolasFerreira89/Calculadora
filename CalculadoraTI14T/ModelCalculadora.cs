using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI14T
{
    class ModelCalculadora
    {
        //public - todo o projeto enxerga essa variável
        //private - Apenas a classe que ela foi criada enxerga a variável
        //protected - somente a família enxerga a variável
        private double num1;
        private double num2;

        public ModelCalculadora()
        {
            //Instanciando as variáveis
            ModificarNum1 = 0;
            ModificarNum2 = 0;
        }//fim do método Construtor

        //Métodos de Acesso - GET(Consultar) e SET(Modificar)
        public double ModificarNum1
        {
            get
            {
                return num1;
            }
            set
            {
                this.num1 = value;
            }
        }//fim do método modificarNum1

        public double ModificarNum2
        {
            get
            {
                return num2;
            }
            set
            {
                this.num2 = value;
            }
        }//fim do método de acesso

        //Operações
        public double Somar(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return ModificarNum1 + ModificarNum2;
        }//fim do método soma

        public double Subtrair(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return ModificarNum1 - ModificarNum2;
        }//fim do método subtrair

        public double Multiplicar(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return ModificarNum1 * ModificarNum2;
        }//fim do método Multiplicar

        public double Dividir(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            //Validação
            if(ModificarNum2 == 0)
            {
                return -1;
            }
            return ModificarNum1 / ModificarNum2;
        }//fim do método dividir

        public double Potencia(double num1, double num2)
        {
            ModificarNum1 = num1;
            ModificarNum2 = num2;
            return Math.Pow(ModificarNum1, ModificarNum2);
        }//fim do método potência

        public double Raiz(double num1)
        {
            ModificarNum1 = num1;
            if(ModificarNum1 < 0)
            {
                return -1;
            }
            return Math.Sqrt(ModificarNum1);
        }//fim do método raiz
        











    }//fim da classe
}//Fim do projeto
