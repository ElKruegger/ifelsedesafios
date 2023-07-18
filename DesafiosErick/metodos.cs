using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosErick
{
    public class metodos
    {
        #region basico
        // Numero par ou ímpar
        public static string Parouimpar(int numinput)
        {
            if (numinput % 2 == 0)
            {
                Console.WriteLine("O número que você digitou é par! ;D");
            }
            else
            {
                Console.WriteLine(" O número que você digitou é impar! ;C");
            }
            return "";
        }

        // Numero positivo ou negativo
        public static string PositivoNegativo(int numeroA)
        {
            if (numeroA < 0)
            {
                Console.WriteLine("O numero é Negativo ;(");
            }
            else
            {
                Console.WriteLine("O número é positivo! ;D");
            }
            return "";
        }

        // Ano é ou não bissexto
        public static string BissextoOuNao(int inputAno)
        {
            if (inputAno % 4 == 0)
            {
                Console.WriteLine("O Ano que vocÊ digitou é bissexto!");
            }
            else
            {
                Console.WriteLine("O ano não é bissexto. . .");
            }
            return "";
        }

        // Descobrir se o usuário é maior ou menor de idade :
        public static string MaiorMenorIdade(int inputidade)
        {
            if (inputidade > 17)
            {
                Console.WriteLine("VocÊ é maior de idade! ");
            }
            else
            {
                Console.WriteLine("Você é um menor de idade ! ");
            }
            return "";
        }

        // Verifique se uma letra digitada é uma vogal ou consoante.
        public static string VogalConsoante(string vogalConsoante)
        {

            if (vogalConsoante == "a" || vogalConsoante == "e" || vogalConsoante == "i" || vogalConsoante == "o" || vogalConsoante == "u")
            {
                Console.WriteLine(" A letra a qual você digitou é uma vogal! ");
            }
            else
            {
                Console.WriteLine("A letra que você digitou é uma consoante. . .");
            }
            return "";
        }

        // Determine se a palavra digitada tem mais ou menos que 10 caracteres
        // Estudar mais para refazer mais tarde.

        public static int ContarLetras(string palavra)
        {
            int contador = 0;
            foreach (char c in palavra)
            {
                if (Char.IsLetter(c)) contador++;
            }
            return contador;
        }

        #endregion basico

        #region Intermediario


        // Métodos intermediários :


        // Determine se um numero digitado está entre 10 e 20 ou entre 30 e 40.
        public static string MarcadorDeNumero(int numerorecebido)
        {
            if (numerorecebido > 9 && numerorecebido < 21 || numerorecebido > 29 && numerorecebido < 41)
            {
                Console.WriteLine("O numero que você digitou está entre os números datados!");
            }
            else
            {
                Console.WriteLine("O número que você digitou está fora do esperado! ");
            }

            return "";
        }

        //  Determine se a média de três números é maior que 10.


        //Verifique se uma letra digitada é maiúscula ou minúscula.
        public static string MaiusculoMinusculo(string inputletra)
        {
            if (inputletra == inputletra.ToLower())
            {
                Console.WriteLine(" A letra que vocÊ digitou é minuscula! ");
            }
            if (inputletra == inputletra.ToUpper())
            {
                Console.WriteLine(" A letra que vocÊ digitou é maiuscula!");
            }
            else
            {
                return "Digite um char correspondente";
            }
            return "";
        }

        // Determine se um aluno está aprovado, reprovado ou em recuperação com base em duas notas (aprovação >7, recuperação 5-7, reprovado <5).
        public static int Mediaaluno(int notasomada)
        {
            if (notasomada > 7)
            {
                Console.WriteLine(" O aluno está aprovado!");
            }
            if (notasomada > 5 && notasomada < 7)
            {
                Console.WriteLine(" O aluno encontra-se em recuperação! ");
            }
            if (notasomada < 5)
            {
                Console.WriteLine(" O aluno encontra-se reprovado! ");
            }
            return 0;
        }

        // Determine a faixa etária de uma pessoa (criança, adolescente, adulto, idoso) com base em sua idade.
        public static int FaixaEtaria(int faixaetaria)
        {
            if (faixaetaria >= 60)
            {
                Console.WriteLine(" A sua faixa etária consta como idoso..");
                return 0;
            }
            if (faixaetaria >= 18 && faixaetaria <= 60)
            {
                Console.WriteLine(" Sua faixa etária consta como adulto..");
                return 0;
            }
            if (faixaetaria >= 14 && faixaetaria <= 17)
            {
                Console.WriteLine(" A sua faixa etária consta como adolescente...");
                return 0;

            }
            if (faixaetaria >= 0 && faixaetaria <= 14)
            {
                Console.WriteLine(" A sua faixa etária consta como criança..");
                return 0;
            }
            return 0;
        }

        //Verifique se três números podem formar um triângulo (a soma de quaisquer dois lados deve ser maior que o terceiro lado).
        public static int triangulovalido(int a, int b, int c)
        {
            if (a < b + c && b < b + c && c < a + b)
            {
                Console.WriteLine(" Os números podem formar um triângulo!");
            }
            else
            {
                Console.WriteLine(" Os números não podem formar um triângulo, tente outros números...");
            }
            return 0;
        }


        // Determine se um triângulo é equilátero, isósceles ou escaleno, com base no comprimento de seus lados.

        public static int Triangulos(int valorA, int valorB, int valorC)
        {
            if (valorA == valorB && valorB == valorC)
            {
                Console.WriteLine(" A sequencia que você inseriu, resulta em um triangulo EQUILATERO!");
            }
            if (valorA == valorB && valorB != valorC)
            {
                Console.WriteLine(" A sequência que você inseriu, resulta em um triangulo ISOSCELES");
            }
            if (valorA != valorB && valorB != valorC)
            {
                Console.WriteLine(" A sequência que você inseriu resulta em um triangulo ESCALENO");
            }
            else
            {

            }
            return 0;
        }

        public static string Palindromo(string palindromopalavra)
        {
            // Pegar as letras e reverter
            // jogar em um list ou array
            // comparar com if else


            char[] caracteres = palindromopalavra.ToCharArray();
            Array.Reverse(caracteres);
            string palavrainvertida = new string(caracteres);

            if (palavrainvertida == palindromopalavra)
            {
                Console.WriteLine(" A palavra que vocÊ digitou é um palindromo");
            }
            else if (palindromopalavra != palavrainvertida)
            {
                Console.WriteLine(" A palavra que você digitou não é um palindromo!");
            }
            return "";
        }

        #endregion Intermediario

        #region Avançados

        // Métodos Avançados :
        public static string Contaletras(string palavraAB)
        {
            int contaletraA = 0;
            int contaletraB = 0;

            foreach (char letra in palavraAB)        // Funciona DIabo >>>>>>>>>;(
            {
                if (letra == 'a')
                {
                    contaletraA++;

                }
                else if (letra == 'b')
                {
                    contaletraB++;

                }
            }
            Console.WriteLine($" A sua palavra possuí {contaletraA} letras 'A' !");
            Console.WriteLine($" A sua palavra Possui {contaletraB} letras 'B' !");
            return "";
        }
        /*
        public static int NumeroPerfeito(int nmrperfeito)
        {

        }
        */

        //Determine o dia da semana (segunda-feira, terça-feira, etc.) dado um número de 1 a 7.
        public static int DiaSemana(int numerodia)
        {
            List<string> diasemana = new List<string>
            {
                "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"
            };

            if (numerodia >= 0 && numerodia < diasemana.Count)
            {
                string diaescolhido = diasemana[numerodia]; // Passar o número escolhido como parametro.
                Console.WriteLine(diaescolhido);
            }
            else
            {
                Console.WriteLine("Digite um número de 1 a 7 por favor...");
            }
            return 0;

        }


        // Determine se um número é uma potência de 2.
        // inacabado
        public static int PotenciadeDois(int numeroPotencia)
        {
            return 0;
        }

        // Definir se um ano é um século :
        public static int SeculoAno(int secAno)
        {
            bool comecoSeculo = secAno / 100 == 0;
            if (comecoSeculo == true)
            {
                Console.WriteLine($" O ano {secAno} é o inicio de um século");
                return 0;
            }
            else if (comecoSeculo == false)
            {
                Console.WriteLine($"O ano {secAno} nao é o inicio de um século...");
                return 0;
            }
            return 0;
        }

        // Verificar seum numero é primo : 
        public void  NumeroPrimo(int nmrprimo)
        {
            bool primo = true;

            for (int i = 3; i * i <= nmrprimo; i += 2)
            {
                if (nmrprimo % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            if (primo)
            {
                Console.WriteLine("O número é primo.");
            }
            else
            {
                Console.WriteLine("O número não é primo.");
            }
            
        }
    }

    // Determinar o número perfeito :


    #endregion Avancados

}

