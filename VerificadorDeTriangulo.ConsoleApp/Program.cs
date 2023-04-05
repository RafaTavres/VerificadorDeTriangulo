namespace VerificadorDeTriangulo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Classificador de Triangulos----");
            string resposta = "";
            while (resposta.ToUpper() != "N")
            {
                Triangulo triangulo = new Triangulo();
                PegaDadosDoTriangulo(triangulo);
                Console.WriteLine("O Triangulo é " + triangulo.VerificaTipoDeTriangulo());

                Console.WriteLine("Continuar S/N");
                resposta = Console.ReadLine();
            }
        }

        private static void PegaDadosDoTriangulo(Triangulo triangulo)
        {
            Console.WriteLine("- Qual o Tamanho do Lado 1?");
            triangulo.lado_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("- Qual o Tamanho do Lado 2?");
            triangulo.lado_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("- Qual o Tamanho do Lado 3?");
            triangulo.lado_3 = Convert.ToDouble(Console.ReadLine());
        }
    }
}