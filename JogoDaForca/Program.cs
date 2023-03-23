namespace JogoDaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jogo da Forca!");
            String[] apenasPalavras = { "ABACATE", "ABACAXI", "ACEROLA", "AÇAÍ", "ARAÇA", "ABACATE", "BACABA", "BACURI", "BANANA", "CAJÁ", "CAJÚ", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MAÇÃ", "MANGABA", "MANGA", " ", "MARACUJÁ", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA" };
            Random numeroRandom = new Random();
            int escolhePalavra = numeroRandom.Next(0, apenasPalavras.Length);
            String palavraEscolhida = apenasPalavras[escolhePalavra];
            int cont = 0;
            Char chute;
            String preencheUnderline = "";
            Char[] resultado = preencheUnderline.PadLeft(palavraEscolhida.Length, '_').ToCharArray();
            bool errou;
            while(cont < 5)
            {
                Console.WriteLine($"DICA: A palavra contem {palavraEscolhida.Length} letras. :3");
                Console.WriteLine("Resultado: " + new string(resultado));
                Console.Write("Qual seu chute?");
                chute = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                errou = true;
                for (int i = 0; i < palavraEscolhida.Length; i++)
                {
                    if (chute == palavraEscolhida[i])
                    {
                        resultado[i] = chute;
                        errou = false;
                    }
                }
                if (errou) {
                    Console.WriteLine($"A palavra secreta não contem a letra {chute} :(");
                    cont++;
                }
                if(resultado.SequenceEqual(palavraEscolhida.ToCharArray()))
                {
                    Console.WriteLine("Parabéns! Você venceu!");
                    break;
                }
                
            }
            if(cont == 5)
            {
                Console.WriteLine("Você utilizou todas as suas chances :(");
            }
        }
    }
}