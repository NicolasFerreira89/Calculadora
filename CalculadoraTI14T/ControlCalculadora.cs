using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI14T
{
    class ControlCalculadora
    {
        ModelCalculadora modelo; //Conectando a outra classe
        private int opcao;
        private double num1;
        private double num2;
        public ControlCalculadora()
        {
            modelo = new ModelCalculadora();
            ConsultarOpcao = 0;//Instanciando o método
            ConsultarNum1 = 0;
            ConsultarNum2 = 0;
        }//fim da controlCalculadora

        public int ConsultarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }//fim do consultarOpcao

        public double ConsultarNum1
        {
            get
            {
                return num1;
            }
            set
            {
                this.num1 = value;    
            }
        }//fim do ConsultarNum1

        public double ConsultarNum2
        {
            get
            {
                return num2;
            }
            set
            {
                this.num2 = value;
            }
        }//fim do ConsultarNum2

        public void Menu()
        {
            Console.WriteLine("----- Menu -----\n\n" +
                              "1. Somar\n" +
                              "2. Subtrair\n" +
                              "3. Multiplicar\n" +
                              "4. Dividir\n" +
                              "5. Potência\n" +
                              "6. Raiz\n" +
                              "0. Sair");
            Console.WriteLine("\n\nEscolha uma das opções acima");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método Menu

        public void Operacao()
        {
            do
            {
                Menu();//Chamar o método menu

                switch (ConsultarOpcao)
                {
                    case 1:
                        Coletar();//Coletar o primeiro e segundo número
                        Console.WriteLine("O Resultado da Operação é: " + modelo.Somar(ConsultarNum1, ConsultarNum2));
                        break;
                    case 2:
                        Coletar();//Coletar o primeiro e segundo número
                        Console.WriteLine("O Resultado da Operação é: " + modelo.Subtrair(ConsultarNum1, ConsultarNum2));
                        break;
                    case 3:
                        Coletar();//Coletar o primeiro e segundo número
                        Console.WriteLine("O Resultado da Operação é: " + modelo.Multiplicar(ConsultarNum1, ConsultarNum2));
                        break;
                    case 4:
                        Coletar();//Coletar o primeiro e segundo número
                        if (modelo.Dividir(ConsultarNum1, ConsultarNum2) == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero!");
                        }
                        else
                        {
                            Console.WriteLine("O Resultado da Operação é: " + modelo.Dividir(ConsultarNum1, ConsultarNum2));
                        }
                        break;
                    case 5:
                        Coletar();//Coletar o primeiro e segundo número
                        Console.WriteLine("O Resultado da Operação é: " + modelo.Potencia(ConsultarNum1, ConsultarNum2));
                        break;
                    case 6:
                        Console.WriteLine("Informe um número para calcular a raiz: ");
                        ConsultarNum1 = Convert.ToInt32(Console.ReadLine());
                        if (ConsultarNum1 < 0)
                        {
                            Console.WriteLine("Impossível calcular raiz de número negativo");
                        }
                        else
                        {
                            Console.WriteLine("O Resultado da Operação é: " + modelo.Raiz(ConsultarNum1));
                        }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado!!!");
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é valida, tente novamente!");
                        break;
                }//fim do switch

            } while (ConsultarOpcao != 0);
        }//fim do método operacao

        public void Coletar()
        {
            Console.WriteLine("Informe o primeiro número: ");
            ConsultarNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            ConsultarNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar

    }//fim da classe
}//fim do projeto
