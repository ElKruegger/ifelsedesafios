namespace DesafiosErick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basico

            // verificar se um número é positivo ou negativo :

            Console.WriteLine(" Digite um número, descubra se é positivo ou negativo : ");
            var numeroA = Convert.ToInt32(Console.ReadLine());
            metodos.PositivoNegativo(numeroA);
            Console.ReadKey();
            Console.Clear();

            // Verificar se um número é par ou impar : 
            Console.WriteLine(" Digite um número aleatório, descubra se é par, ou impar : ");
            var numimput = Convert.ToInt32(Console.ReadLine());
            metodos.Parouimpar(numimput);
            Console.ReadKey();
            Console.Clear();

            // Verificar se o ano é bissexto ou não.
            Console.WriteLine(" Digite o número de um ano : ");
            var inputAno = Convert.ToInt32(Console.ReadLine());
            metodos.BissextoOuNao(inputAno);
            Console.ReadKey();
            Console.Clear();

            // Verifique se uma pessoa é maior ou menor de idade.
            Console.WriteLine("Digite sua idade! : ");
            var inputidade = Convert.ToInt32(Console.ReadLine());
            metodos.MaiorMenorIdade(inputidade);
            Console.ReadKey();
            Console.Clear();

            // Verifique se uma letra digitada é uma vogal ou consoante.
            Console.WriteLine("Digite uma letra, descubra se é uma vogal ou consoante : ");
            var vogalConsoante = Console.ReadLine();
            metodos.VogalConsoante(vogalConsoante);
            Console.ReadKey();
            Console.Clear();


            // Verificar se o numero digitado é maior que 10!

            Console.WriteLine("Digite um número e descubra se é menor que 10 : ");
            int menorquedez = Convert.ToInt32(Console.ReadLine());
            if (menorquedez < 10)
            {
                Console.WriteLine("O numero que vocÊ digitou é menor que Dez! ");
            }
            else
            {
                Console.WriteLine("O número que você digitou é maior que 10 >;(");
            }
            Console.ReadKey();
            Console.Clear();

            // Verificar se um numero é menor que 20!
            Console.WriteLine("Digite um número para descobrir se é menor que 20");
            var nummenorvinte = Convert.ToInt32(Console.ReadLine());
            if (nummenorvinte < 20)
            {
                Console.WriteLine(" Sim, é menor que vinte!");
            }
            else
            {
                Console.WriteLine("Esse número é maior que 20 o.0");
            }
            Console.ReadKey();
            Console.Clear();

            // Determine se a palavra digitada tem mais ou menos que 10 caracteres
            Console.WriteLine("Digite uma palavra aleatória :");
            string? palavra = Console.ReadLine();
            int quantidadeletras = metodos.ContarLetras(palavra);
            Console.WriteLine($"A palavra {palavra} possuí {quantidadeletras} letras ");
            Console.ReadKey();
            Console.Clear();


            //Determine se um número digitado está no intervalo entre 15 e 30.
            Console.WriteLine("Determine um numero digitado no intervalo de 15 e 30.");
            Console.WriteLine("Digite um numero: ");
            var menormaior = Convert.ToInt32(Console.ReadLine());
            if (menormaior < 30 && (menormaior > 15))
            {
                Console.WriteLine("Este número está entre os números de 15 a 30! ");
            }
            else
            {
                Console.WriteLine(" O número está fora do estipulado, ou não é um digito reconhecível");
            }
            Console.ReadKey();
            Console.Clear();


            // Determine se um número é divisível por 5
            Console.WriteLine("Digite um número para dividir por 5 :");
            int divideporcinco = int.Parse(Console.ReadLine());
            if (divideporcinco % 5 == 0)
            {
                Console.WriteLine(" Este número é divisível por 5!");
            }
            else
            {
                Console.WriteLine(" Não é ;C ");
            }
            Console.ReadKey();
            Console.Clear();

            #endregion basico

            #region Intermediario

            // Exercicios intermediários : 

            // Determine se um numero digitado está entre 10 e 20 ou entre 30 e 40.
            Console.WriteLine("Digite um número, descubra se o mesmo se encontra entre 10 - 20 e 30 - 40");
            Console.WriteLine(" Digite um número : ");
            var numerorecebido = Convert.ToInt32(Console.ReadLine());
            metodos.MarcadorDeNumero(numerorecebido);
            Console.ReadLine();
            Console.Clear();

            // Determine se a média de três números é maior que 10.
            Console.WriteLine("Digite trÊs números, e veja se sua média é superior a dez.");
            Console.WriteLine("Digite o primeiro número :");
            int numeroum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Segundo número : ");
            int numerodois = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro e último número :");
            int numerotres = Convert.ToInt32(Console.ReadLine());
            int total = numeroum + numerodois + numerotres;
            total = total / 3;
            if (total > 10)
            {
                Console.WriteLine("A média dos números é maior que dez! ");
            }
            else
            {
                Console.WriteLine("A média dos números não é maior que dez! ");
            }
            Console.ReadKey();
            Console.Clear();

            //Verifique se uma letra digitada é maiúscula ou minúscula.
            Console.WriteLine("Digite alguma letra aleatória e descubra se é maiuscula ou minuscula.");
            string? inputletra = Console.ReadLine();
            metodos.MaiusculoMinusculo(inputletra);
            Console.ReadKey();
            Console.Clear();

            // Verifique se uma string é um palíndromo.
            Console.WriteLine(" Digite uma palavra ou frase e descubra se é um palíndromo :");
            string? palindromopalavra = Console.ReadLine();
            metodos.Palindromo(palindromopalavra);
            Console.ReadKey();
            Console.Clear();


            // Determine se um aluno está aprovado, reprovado ou em recuperação com base em duas notas (aprovação >7, recuperação 5-7, reprovado <5).
            Console.WriteLine(" Digite a primeira nota do aluno : ");
            int notaum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Digite a segunda nota do aluno : ");
            int notadois = Convert.ToInt32(Console.ReadLine());
            int notasomada = (notaum + notadois) / 2;
            metodos.Mediaaluno(notasomada);
            Console.ReadKey();
            Console.Clear();

            // Determine a faixa etária de uma pessoa (criança, adolescente, adulto, idoso) com base em sua idade.
            Console.WriteLine(" Descubr a faixa etária por idade!");
            Console.WriteLine(" Insira a idade para prosseguir.");
            int faixaetaria = Convert.ToInt32(Console.ReadLine());
            metodos.FaixaEtaria(faixaetaria);
            Console.ReadKey();
            Console.Clear();

            // Verifique se um número é múltiplo de ambos 3 e 5.


            // Determine se um número digitado está fora do intervalo entre 15 e 30.
            Console.WriteLine(" Digite um número aleatório e descubra se encontra-se entre 15 e 30");
            Console.WriteLine(" Digite um número aleatório :");
            int intervalofora = Convert.ToInt32(Console.ReadLine());
            if (intervalofora >= 15 && intervalofora <= 30)
            {
                Console.WriteLine(" ERRO o numero que vocÊ digitou está dentro do intervalo");
            }
            else
            {
                Console.WriteLine(" CORRETO O numero que você inseriu se encontra fora do intervalo entre 15 e 30");
            }
            Console.ReadKey();
            Console.Clear();


            // Verifique se três números podem formar um triângulo (a soma de quaisquer dois lados deve ser maior que o terceiro lado).
            Console.WriteLine("Verificar se tres numeros podem formar um triângulo \r (A soma de quaisquer dois lados deve ser maior que o terceiro lado");
            Console.WriteLine(" Digite o primeiro número: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Digite o segundo número :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Digite o Terceiro número :");
            int c = Convert.ToInt32(Console.ReadLine());
            metodos.triangulovalido(a, b, c);
            Console.ReadKey();
            Console.Clear();


            // Determine se um triângulo é equilátero, isósceles ou escaleno, com base no comprimento de seus lados.
            Console.WriteLine("Informe 3 Números para determinar um triangulo como equilatero,isosceles ou escaleno ");
            Console.WriteLine(" Informe o valor de A :");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Agora informe o valor de B :");
            int valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Por fim informe o valor de C :");
            int valorC = Convert.ToInt32(Console.ReadLine());
            metodos.Triangulos(valorA, valorB, valorC);
            Console.ReadKey();
            Console.Clear();

            #endregion intermediario

            #region Avancados
            // Determine se uma string tem o mesmo número de caracteres 'a' e 'b'.
            Console.WriteLine(" Digite uma palavra, o programa determinará se há o mesmo número de letras A e B");
            Console.WriteLine(" Insira a palavra abaixo :");
            string? palavraAB = Console.ReadLine();
            metodos.Contaletras(palavraAB);
            Console.ReadKey();
            Console.Clear();

            // Verifique se um número é primo.

            Console.Write("Digite um número inteiro positivo: ");
            int nmrprimo = int.Parse(Console.ReadLine());

            if (nmrprimo == 2)
            {
                Console.WriteLine("O número é primo.");
            }
            else if (nmrprimo < 2 || nmrprimo % 2 == 0)
            {
                Console.WriteLine("O número não é primo.");
            }


            // Verifique se um número é perfeito (um número perfeito é um número que a soma de seus divisores, excluindo o próprio número, é igual ao número)
            // soma os divisores, exclui o número e se a soma dos divisores for o número, é um numero perfeito.
            Console.Write("Digite um número inteiro positivo: ");
            int numeroPrimo = int.Parse(Console.ReadLine());

            int somadosnumeros = 0;

            for (int i = 1; i < numeroPrimo; i++)
            {
                if (numeroPrimo % i == 0)
                {
                    somadosnumeros += i;
                }
            }

            if (somadosnumeros == numeroPrimo)
            {
                Console.WriteLine("O número é perfeito.");
            }
            else
            {
                Console.WriteLine("O número não é perfeito.");
            }

            //Determine o dia da semana (segunda-feira, terça-feira, etc.) dado um número de 1 a 7.
            Console.WriteLine("Este código determina os dias da semana de 1 a 6");
            Console.WriteLine(" Digite o número do dia da semana que gostaria de saber.");
            int numerodia = Convert.ToInt32(Console.ReadLine());
            metodos.DiaSemana(numerodia);
            Console.ReadKey();
            Console.Clear();

            // Determine se um número é uma potência de 2.

            Console.Write("Digite um número inteiro positivo: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("O número não é uma potência de 2.");
            }
            else if ((number & (number - 1)) == 0)
            {
                Console.WriteLine("O número é uma potência de 2.");
            }
            else
            {
                Console.WriteLine("O número não é uma potência de 2.");
            }


            // Determinar se um ano é um século :
            Console.WriteLine(" Digite um ano para definir se é ou não um século: ");
            int secAno = Convert.ToInt32(Console.ReadLine());
            metodos.SeculoAno(secAno);
            Console.ReadKey();
            Console.Clear();

            //Verifique se três números formam uma progressão aritmética ou uma progressão geométrica.
            Console.WriteLine("Digite três números:");

            // Ler os números digitados pelo usuário
            int anguloA = int.Parse(Console.ReadLine());
            int anguloB = int.Parse(Console.ReadLine());
            int anguloC = int.Parse(Console.ReadLine());

            // Verificar se os números formam uma progressão aritmética
            if (anguloB - anguloA == anguloC - anguloB)
            {
                Console.WriteLine("Os números formam uma progressão aritmética.");
            }
            // Verificar se os números formam uma progressão geométrica
            else if (anguloB / anguloA == anguloC / anguloB)
            {
                Console.WriteLine("Os números formam uma progressão geométrica.");
            }
            else
            {
                Console.WriteLine("Os números não formam nem uma progressão aritmética nem uma progressão geométrica.");
            }

            // Verificar se os numeros são consecutivos.


            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
            string numeroString = numero.ToString();

            bool sequenciaConsecutiva = true;
            for (int i = 0; i < numeroString.Length - 1; i++)
            {
                int digitoAtual = int.Parse(numeroString[i].ToString());
                int digitoSeguinte = int.Parse(numeroString[i + 1].ToString());

                if (digitoSeguinte != digitoAtual + 1)
                {
                    sequenciaConsecutiva = false;
                    break;
                }
            }
            // Resultado da gambiarra aqui : 

            if (sequenciaConsecutiva)
            {
                Console.WriteLine("O número é uma sequência de dígitos consecutivos.");
            }
            else
            {
                Console.WriteLine("O número não é uma sequência de dígitos consecutivos.");
            }

            // Verificar se uma string contém apénas números :
            Console.WriteLine("Digite uma string:");

            // Ler a string digitada pelo usuário
            string input = Console.ReadLine();

            bool contemApenasNumeros = true;

            // Verificar se a string contém apenas números
            foreach (char caractere in input)
            {
                if (!Char.IsDigit(caractere))
                {
                    contemApenasNumeros = false;
                    break;
                }
            }

            // Exibir o resultado
            if (contemApenasNumeros)
            {
                Console.WriteLine("A string contém apenas números.");
            }
            else
            {
                Console.WriteLine("A string não contém apenas números.");
            }

            #endregion avancados


        }
    }
}