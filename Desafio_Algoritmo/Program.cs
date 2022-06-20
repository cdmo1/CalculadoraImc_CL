using System;
using System.Globalization;

namespace Desafio_Algoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criacao e atribuicao de variaveis
            string name = "", sex = "";
            int age = 0;
            double height = 0.0, weight = 0.0;
            bool verificador = false;
            // Bem vindo ao imc calculador
            Console.WriteLine("Bem-vindo a Calculadora de IMC");
            Console.WriteLine("\n\nÍndice de Massa Corporal. Você já deve ter ouvido falar nisso. Talvez apenas a sigla IMC. Mas você sabe que índice é este e o que ele pode dizer sobre a sua saúde? Criado no século 19 pelo matemático Lambert Quételet, o Índice de Massa Corporal, conhecido pela sigla IMC, é um cálculo simples que permite medir se alguém está ou não com o peso ideal.Ele aponta se o peso está adequado ou se está abaixo ou acima do peso. O calculo pode ser feito em casa, e agora mesmo, aqui, e dependendo do resultado, é importante procurar um médico para avaliar o grau de sobrepeso ou obesidade");
            Console.WriteLine("\nDigite 'C' para calcularmos teu imc, lembre-se de escrever todos os dados corretamente.");
            string checador = Console.ReadLine();

            if (checador == "C" && verificador == false)
            {
                verificador = true;
            }
            else
            {
                Console.WriteLine("Até a próxima, usuario(a)!!!");
                return;
            }
            Console.Clear();
            Console.WriteLine("*************************************************************");
            Console.WriteLine("DIAGNÓSTICO ");
            string nome = VerificadorDeNome(name);//chamada da funcao, criando e atribuindo a variavel nome, recebendo como parametro name, que foi inicializado "com vazio" ("").
            string sexo = VerificadorDeSexo(sex);//chamada da funcao, criando e atribuindo a variavel sexo, recebendo como parametro sex, que foi inicializado "com vazio" ("").
            int idade = VerificadorDeIdade(age);//chamada da funcao, criando e atribuindo a variavel idade, recebendo como parametro age, que foi inicializado 0.
            double altura = VerificadorDeAltura(height);//chamada da funcao, criando e atribuindo a variavel altura, recebendo como parametro height, que foi inicializado 0.0
            double peso = VerificadorDePeso(weight);//chamada da funcao, criando e atribuindo a variavel peso, recebendo como parametro weight, que foi inicializado 0.0
            string categoria = VerificadorDeCategoria(idade);//chamada da funcao, criando e atribuindo a variavel categoria, recebendo como parametro a idade que fora digitada pelo usuario anteriormente.
            Console.WriteLine($"Sua categoria eh {categoria} ");//impressao previa
            double imc = CalculadorDeImc(peso, altura);//chamada da funcao para calcular o imc, e passando como parametro duas variaveis, cria-se e atribuir a variavel imc.
            double imcOut = Math.Round(imc, 2); //Utilizacao de metodo C# para "cortar" casa decimal
            Console.WriteLine($"Seu imc eh {imc} ");//impressao previa
            string imcdesejavel = VerificadorDeImcDesejavel(idade);//chamada da funcao, e passando como parametro a idade, cria-se e atribuir a variavel imcdesejavel.
            Console.WriteLine($"IMC Desejavel: {imcdesejavel} ");//impressao previa
            string riscos = VerificadorDeRiscos(imc);//chamada da funcao, e passando como parametro o imc, cria-se e atribuir a variavel riscos.
            Console.WriteLine($"Riscos para tu se atentar: {riscos} ");//impresasao previa
            string recomendacaoinicial = VerificadorDeRecomendacoes(imc);//chamada da funcao, e passando como parametro o imc, cria-se e atribuir a variavel recomendacaoinicial..
            Console.WriteLine($"Algumas recomendacoes para ti: {recomendacaoinicial} ");//impressao previa
            Console.Clear();//limpa o console
            //impressao final
            Console.WriteLine("*************************************************************");
            Console.WriteLine("DIAGNÓSTICO PRÉVIO");
            Console.WriteLine ($"\nNome: {nome}");
            Console.WriteLine($"\nSexo: {sexo}");
            Console.WriteLine($"\nAltura: {altura} m");
            Console.WriteLine($"\nPeso: {peso} Kg");
            Console.WriteLine($"\nCategoria: {categoria}");
            Console.WriteLine($"\nIMC Desejável: {imcdesejavel}");
            Console.WriteLine($"\nResultado IMC: {imcOut} ");
            Console.WriteLine($"\nRiscos: {riscos}");
            Console.WriteLine($"\nRecomendação inicial: {recomendacaoinicial}");
            Console.WriteLine("\n***********************************************************");

        }
        /// <summary>
        /// Função recebe como parâmetro o nome, que é do tipo string, e, ao chamar a função ela irá executar todo o bloco, desde que o parametro sejam inseriodo corretamente na chamada.
        /// </summary>
        /// <param name="nome"></param>
        /// <returns> Retornaremos uma variavel do tipo string, nome, que é o nome do usuario </returns>
        static string VerificadorDeNome(string nome)
        {
            //criamos uma variavel para fazer a verificação do nome.
            bool verificador = true;
            //a variavel auxiliar para guardarmos temporariamente o nome.
            string aux = "";
            while (verificador)
            {
                //aqui o usuario digita seu nome
                Console.Write("Nome: ");
                //Retorna o valor da linha inteira, e atribui-se a variavel auxiliar
                aux = Console.ReadLine();
                //enquanto nossa variavel verificadora, for verdadeira, executaremos o bloco, ate que saia a negacao da variavel, o que ocorre quando o nome é um valor valido.
                //null é o valor padrão de variáveis do tipo de referência, entretanto, nao queremos um valor nulo, entao verificamos se o que o usuario digitou esta dentro de nossa condicao pre estabelecida.String Length é uma propriedade no objeto String que retorna o número de caracteres em uma string, logo precisamos que esse valor digitado pelo usuario sexa maior que zero caracteres.
                if (aux != null && aux.Length > 0)
                {
                    nome = aux;//variavel nome recebe a variavel auxiliar
                    verificador = false;//para um valor valido
                }
                else
                {
                    Console.WriteLine("Nome invalido");//caso o usuario nao digite um nome valido, retornaremos uma mensagem para eleate que qele digite um nome valido
                }
            }
            return nome;

        }
        /// <summary>
        /// Função recebe como parâmetro o sexo, que é do tipo string, e, ao chamar a função ela irá executar todo o bloco, desde que os parametro seja inseriodo corretamente na chamada.
        /// </summary>
        /// <param name="sexo"></param>
        /// <returns> Retornaremos uma variavel do tipo string, nome, que é o sexo do usuario </returns>
        static string VerificadorDeSexo(string sexo)
        {
            string aux = "";
            bool verificacao = false;
            //faz a execucao do bloco primeiro, depois testamos se a variavel verificacao é a negacao de false, logo, o usuario digitou um valor correto;
            do
            {
                Console.Write("Por gentileza, digite o seu sexo estreitamente restrito as duas seguntes palavras: MASCULINO OU FEMININO): \n");
                aux = Console.ReadLine();

                // Verifica a entrada convertendo a string para minúsculo e faz a comparacao com a string digitado
                if (aux.ToLower() == "masculino")
                {
                    sexo = aux;//variavel sexo recebe a variavel auxiliar
                    sexo = "Masculino";//faz a substituicao do (MASCULINO) ou outras maneiras de escrita, para uma forma padronizada.
                    verificacao = true;//para um valor valido

                }
                else if (aux.ToLower() == "feminino")
                {
                    sexo = aux;
                    sexo = "Feminino";
                    verificacao = true;
                }
                // Caso o usuário tenha digiatdo de maneira incorreta, exibe-se a mensagem para ele, informando
                else
                {
                    Console.WriteLine("Voce digitou um sexo invalido, digite conforme as especificacoes......");
                    
                }
            } while (!verificacao);

            return sexo;
        }
        /// <summary>
        /// Função recebe como parâmetro a idade, que é do tipo inteiro, e, ao chamar a função ela irá executar todo o bloco, desde que o parametro seja inseriodo corretamente na chamada.
        /// </summary>
        /// <param name="idade"></param>
        /// <returns> Retornaremos uma variavel do tipo inteiro, idade, que é a idade do usuario </returns>
        static int VerificadorDeIdade(int idade)
        {
            //criamos uma variavel para fazer a verificação a idade.
            bool verificacao = false;
            //a variavel auxiliar para guardarmos temporariamente a idade, aqui fazemnos a inicializacao dela, onde ela recebe o valor dde zero.
            int aux = 0;
            //testamos se a variavel verificacao é a negacao de false, logo, o usuario digitou um valor correto;
            while (!verificacao)
            {
                Console.Write("Idade (Por gentileza, digite a idade em anos, e com numeros inteiros maiores que zero): \n");
                verificacao = int.TryParse(Console.ReadLine(), out aux);
                if (!verificacao || aux <= 0)
                {
                    Console.WriteLine("Por gentileza, digite a idade em anos, e com numeros inteiros maiores que zero ");
                    verificacao = false;
                }
            }
            idade = aux;
            return idade;
        }
        /// <summary>
        /// Função recebe como parâmetro o peso, que é do tipo double, e, ao chamar a função ela irá executar todo o bloco, verificando o peso digitado pelo usuario, desde que o parametro seja inserido corretamente na chamada
        /// </summary>
        /// <param name="peso"></param>
        /// <returns> Retornaremos uma variavel do tipo double, peso, que é o peso do usuario </returns>
        static double VerificadorDePeso(double peso)
        {
            bool verificador = true;
            string aux;
            while (verificador)
            {
                    Console.Write("Peso: digite o seu peso em quilogramas, com a separacao de quilos e gramas usando ponto ou virgula. Por exemplo: 80,5 \n");
                aux = Console.ReadLine();
                    // Converte o valor digitado pelo usuário para double com ponto ou vírgula, aceita tanto ponto ou virgula
                    if (double.TryParse(aux.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out double pes))
                    {
                        if (pes > 0)
                        {
                            Console.WriteLine("Por gentileza, digite a idade em anos, e com numeros inteiros maiores que zero ");
                            verificador = false;
                        }
                        else
                        {
                            Console.WriteLine("Insercao invalida!");
                        }
                    }
                    peso = pes;
            }
            return peso;
        }
        /// <summary>
        /// Função recebe como parâmetro a altura, que é do tipo double, e, ao chamar a função ela irá executar todo o bloco, verificando a altura digitada pelo usuario, desde que o parametro seja inseriodos corretamente na chamada
        /// </summary>
        /// <param name="altura"></param>
        /// <returns> Retornaremos uma variavel do tipo double, peso, que é o peso do usuario </returns>
        static double VerificadorDeAltura(double altura)
        {
            bool verificador = true;
            string aux;
            while (verificador)//enquanto o verificador for verdadeiro, executar o bloco
            {
                Console.Write("Altura: Por gentileza, digite em metros sua altura. Por exemplo: 1,80. \n");
                aux = Console.ReadLine();//pega o valor digitado pelo usuario, faz a leitura, e guarda na variavel auxiliar.
                // Converte o valor digitado pelo usuário para double com ponto ou vírgula, aceita tanto ponto ou virgula
                if (double.TryParse(aux.Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out double alt)){
                   if (alt > 0 && verificador == true){
                            altura = alt;
                            verificador = false;//para um valor valido
                   }
                   else{
                        Console.WriteLine("Insercao invalida!");
                   }
                }      
            }
            return altura;
        }
        /// <summary>
        /// Função recebe como parâmetro o peso, e altura, que sao do tipo double, e, ao chamar a função ela irá executar todo o bloco, calculando o imc, desde que os parametros sejam inseriodos corretamente na chamada
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        /// <returns> Retornaremos uma variavel do tipo double, peso, que é o peso do usuario </returns>
        static double CalculadorDeImc(double peso, double altura)
        { 
            double imc = (peso / (altura * altura));//(float)Math.Pow(altura, 2) poderia ser usado, porem, como o calculo eh somente com o quadrado, visando legibilidade e compreensao do codigo, optei por fazer altura por altura
            return imc;

        }
        /// <summary>
        /// Função recebe como parâmetro a idade, que eh do tipo inteiro, e, ao chamar a função ela irá executar todo o bloco, verificando a idade digitada pelo usuario, desde que o parametro seja inseriodo corretamente na chamada.
        /// </summary>
        /// <param name="idade"></param>
        /// <returns> Retornaremos uma variavel do tipo string, de acordo com a idade do usuario, para assim verificarmos qual eh a categoria do usuario </returns>
        static string VerificadorDeCategoria(int idade)
        {
            if (idade > 0 && idade < 12)
            {
                return "Infantil";
            }
            else if ((idade >= 12) && (idade <= 20))
            {
                return "Juvenil";
            }
            else if ((idade >= 21) && (idade <= 65))
            {
                return "Adulto";
            }
            else
            {
                return "Idoso";
            }
        }
        /// <summary>
        /// Função recebe como parâmetro a idade, que eh do tipo inteiro, e, ao chamar a função ela irá executar todo o bloco, verificando a idade digitada pelo usuario, desde que o parametro seja inseriodo corretamente na chamada.
        /// </summary>
        /// <param name="idade"></param>
        /// <returns> Retornaremos uma variavel do tipo string, de acordo com a idade do usuario, para assim verificarmos qual eh o imc desejavel do usuario </returns>
        static string VerificadorDeImcDesejavel(int idade)
        {
            if (idade < 20)
            {
                return "abaixo de 20";
            }
            else if ((idade >= 20) && (idade < 25))
            {
                return "entre 20 e 24";
            }
            else if ((idade >= 25) && (idade < 30))
            {
                return "entre 25 e 29";
            }
            else if ((idade >= 30) && (idade < 36))
            {
                return "entre 30 e 35";
            }
            else
            {
                return "acima de 35";
            }
        }
        /// <summary>
        /// Função recebe como parâmetro o imc, que eh do tipo double, e, ao chamar a função ela irá executar todo o bloco, verificando o resultado do calculo do imc, desde que o parametro seja inseriodo corretamente na chamada.
        /// </summary>
        /// <param name="imc"></param>
        /// <returns> Retornaremos uma variavel do tipo string, de acordo com o imc do usuario, para assim verificarmos quais sao os riscos do usuario</returns>
        static string VerificadorDeRiscos(double imc)
        {
            if (imc < 20)
            {
                return "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.";
            }
            else if ((imc >= 20) && (imc < 25))
            {
                return "Seu peso está ideal para suas referências.";
            }
            else if ((imc >= 25) && (imc < 30))
            {
                return "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
            }
            else if ((imc >= 30) && (imc < 35))
            {
                return "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
            }
            else
            {
                return "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
            }
        }
        /// <summary>
        /// Função recebe como parâmetro o imc, que eh do tipo double, e, ao chamar a função ela irá executar todo o bloco, verificando o resultado do calculo do imc, desde que o parametro seja inseriodo corretamente na chamada.
        /// </summary>
        /// <param name="imc"></param>
        /// <returns> Retornaremos uma variavel do tipo string, de acordo com o imc do usuario, para assim verificarmos quais resomendacoes podemos dar ao usuario usuario</returns>
        static string VerificadorDeRecomendacoes(double imc)
        {
            if (imc < 20)
            {
                return "Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra.Procure um profissional.";
            }
            else if ((imc >= 20) && (imc < 25))
            {
                return "Mantenha uma dieta saudável e faça seus exames periódicos.";
            }
            else if ((imc >= 25) && (imc < 30))
            {
                return "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação.A ajuda de um profissional pode ser interessante.";
            }
            else if ((imc >= 30) && (imc < 35))
            {
                return "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista(endócrino).";
            }
            else
            {
                return "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista(endócrino).";
            }
        }

    }
}
