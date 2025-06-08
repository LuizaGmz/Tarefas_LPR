class Program
{
    static void Main()
    {
        menuPrincipal();
    }

    static void menuPrincipal()
    {
        string Hero1 = "", Hero2 = "", Hero3 = "", Hero4 = "", Hero5 = "";
        string poder1 = "", poder2 = "", poder3 = "", poder4 = "", poder5 = "";
        int point1 = 0, point2 = 0, point3 = 0, point4 = 0, point5 = 0;

        string equipe1 = "", equipe2 = "", equipe3 = "";
        string poderEquipe1 = "", poderEquipe2 = "", poderEquipe3 = "";
        int pontEquipe1 = 0, pontEquipe2 = 0, pontEquipe3 = 0;

        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\n===== Menu Principal =====");
            Console.WriteLine("1 - Cadastrar Heróis");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    cadastrarHeroi(ref Hero1, ref poder1, ref point1, 1);
                    cadastrarHeroi(ref Hero2, ref poder2, ref point2, 2);
                    cadastrarHeroi(ref Hero3, ref poder3, ref point3, 3);
                    cadastrarHeroi(ref Hero4, ref poder4, ref point4, 4);
                    cadastrarHeroi(ref Hero5, ref poder5, ref point5, 5);
                    break;

                case "2":
                    selecionarEquipe(
                        Hero1, poder1, point1,
                        Hero2, poder2, point2,
                        Hero3, poder3, point3,
                        Hero4, poder4, point4,
                        Hero5, poder5, point5,
                        ref equipe1, ref poderEquipe1, ref pontEquipe1,
                        ref equipe2, ref poderEquipe2, ref pontEquipe2,
                        ref equipe3, ref poderEquipe3, ref pontEquipe3
                    );
                    break;

                case "3":
                    exibirEquipe(equipe1, poderEquipe1, pontEquipe1,
                                 equipe2, poderEquipe2, pontEquipe2,
                                 equipe3, poderEquipe3, pontEquipe3);
                    break;

                case "4":
                    sair = true;
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void cadastrarHeroi(ref string Hero, ref string poder, ref int point, int numero)
    {
        Console.WriteLine($"\nCadastro do Herói {numero}:");
        Console.Write("Hero: ");
        Hero = Console.ReadLine();
        Console.Write("Poder: ");
        poder = Console.ReadLine();
        Console.Write("Pontuação: ");
        point = int.Parse(Console.ReadLine());
    }

    static void selecionarEquipe(
        string Hero1, string poder1, int point1,
        string Hero2, string poder2, int point2,
        string Hero3, string poder3, int point3,
        string Hero4, string poder4, int point4,
        string Hero5, string poder5, int point5,
        ref string equipe1, ref string poderEquipe1, ref int pontEquipe1,
        ref string equipe2, ref string poderEquipe2, ref int pontEquipe2,
        ref string equipe3, ref string poderEquipe3, ref int pontEquipe3)
    {
        Console.WriteLine("\n===== Heróis Cadastrados =====");
        Console.WriteLine($"1 - {Hero1}" );
        Console.WriteLine($"2 - {Hero2}" );
        Console.WriteLine($"3 - {Hero3}" );
        Console.WriteLine($"4 - {Hero4}" );
        Console.WriteLine($"5 - {Hero5}" );

        Console.Write("Escolha o número do 1º herói da equipe: ");
        int escolha1 = int.Parse(Console.ReadLine());
        Console.Write("Escolha o número do 2º herói da equipe: ");
        int escolha2 = int.Parse(Console.ReadLine());
        Console.Write("Escolha o número do 3º herói da equipe: ");
        int escolha3 = int.Parse(Console.ReadLine());

        atribuirHeroi(escolha1, Hero1, poder1, point1,
                      Hero2, poder2, point2,
                      Hero3, poder3, point3,
                      Hero4, poder4, point4,
                      Hero5, poder5, point5,
                      ref equipe1, ref poderEquipe1, ref pontEquipe1);

        atribuirHeroi(escolha2, Hero1, poder1, point1,
                      Hero2, poder2, point2,
                      Hero3, poder3, point3,
                      Hero4, poder4, point4,
                      Hero5, poder5, point5,
                      ref equipe2, ref poderEquipe2, ref pontEquipe2);

        atribuirHeroi(escolha3, Hero1, poder1, point1,
                      Hero2, poder2, point2,
                      Hero3, poder3, point3,
                      Hero4, poder4, point4,
                      Hero5, poder5, point5,
                      ref equipe3, ref poderEquipe3, ref pontEquipe3);
    }

    static void atribuirHeroi(int escolha,
        string Hero1, string poder1, int point1,
        string Hero2, string poder2, int point2,
        string Hero3, string poder3, int point3,
        string Hero4, string poder4, int point4,
        string Hero5, string poder5, int point5,
        ref string equipe, ref string poderEquipe, ref int pontEquipe)
    {
        switch (escolha)
        {
            case 1:
                equipe = Hero1; poderEquipe = poder1; pontEquipe = point1; break;
            case 2:
                equipe = Hero2; poderEquipe = poder2; pontEquipe = point2; break;
            case 3:
                equipe = Hero3; poderEquipe = poder3; pontEquipe = point3; break;
            case 4:
                equipe = Hero4; poderEquipe = poder4; pontEquipe = point4; break;
            case 5:
                equipe = Hero5; poderEquipe = poder5; pontEquipe = point5; break;
            default:
                Console.WriteLine("Escolha inválida!");
                break;
        }
    }

    static void exibirEquipe(
        string equipe1, string poder1, int pont1,
        string equipe2, string poder2, int pont2,
        string equipe3, string poder3, int pont3)
    {
        Console.WriteLine("\n===== Equipe Selecionada =====");
        Console.WriteLine($"1 - {equipe1} | Poder: {poder1} | Pontuação: {pont1}");
        Console.WriteLine($"2 - {equipe2} | Poder: {poder2} | Pontuação: {pont2}");
        Console.WriteLine($"3 - {equipe3} | Poder: {poder3} | Pontuação: {pont3}");
        int total = calcularpointTotal(pont1, pont2, pont3);
        Console.WriteLine($"\nPontuação Total da Equipe: {total}");
    }

    static int calcularpointTotal(int p1, int p2, int p3)
    {
        return p1 + p2 + p3;
    }
}
