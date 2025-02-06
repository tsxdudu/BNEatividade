using System;

class Program
{
    static void Main()
    {
        Name.WriteTitle();
        while (true)
        {
            Console.WriteLine("·············································································");
            Console.WriteLine("Escolha qual você deseja executar:" +
            "\n- 1) Primeiro Teste de Mesa (atividade 1)" +
            "\n- 2) Segundo Teste de Mesa (atividade 1)" +
            "\n- 3) Terceiro Teste de Mesa (atividade 1)");
            Console.Write(":");
            int numberIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("·············································································");
            switch (numberIndex)
            {
                case 1:
                    TesteDeMesa.Part1();
                    break;
                case 2:
                    TesteDeMesa.Part2();
                    break;
                case 3:
                    TesteDeMesa.Part3();
                    break;
                case 4:
                default:
                    Console.WriteLine("ERRO: O programa não foi encontrado, tente outro.");
                    break;
            }
        }
    }
}
