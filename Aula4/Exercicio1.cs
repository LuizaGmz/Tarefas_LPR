// See https://aka.ms/new-console-template for more information
// Modelo padrão do .NET para programas console

int num, escolha, cor;
// Declaração de variáveis inteiras:
// num -> usada para confirmações dentro de escolhas secretas
// escolha -> armazenará a escolha da classe do personagem
// cor -> armazenará a cor do sabre de luz

Console.WriteLine("Vamos contruir seu personagem!!");
// Mensagem inicial

Console.WriteLine("Escolha uma classe ");
Console.WriteLine("1 - Guerreiro ");
Console.WriteLine("2 - Mago  ");
Console.WriteLine("3 - Arqueiro ");
escolha = Convert.ToInt32(Console.ReadLine());
// Mostra as opções de classe e lê a escolha do usuário

switch(escolha){
    case 1:
        // Caso o usuário escolha Guerreiro
        Console.WriteLine(" Você escolheu a classe Guerreiro. Eis aqui suas habilidades: ");
        Console.WriteLine("Ataque Pesado");
        Console.WriteLine("Defesa total"); 
        Console.WriteLine("Retaliação com a espada");
        Console.WriteLine("ULT SUPREMA: Golpe do Dragão");
        break;

    case 2:
        // Caso o usuário escolha Mago
        Console.WriteLine(" Você escolheu a classe Mago. Eis aqui suas habilidades: ");
        Console.WriteLine("Bola de Fogo");
        Console.WriteLine("Escudo de Gelo"); 
        Console.WriteLine("Redemoinho de vento");
        Console.WriteLine("ULT SUPREMA: Tempestade de Raios");
        break;

    case 3:
        // Caso o usuário escolha Arqueiro
        Console.WriteLine(" Você escolheu a classe Arqueiro. Eis aqui suas habilidades: ");
        Console.WriteLine("Flecha Precisa");
        Console.WriteLine("Disparo Triplo"); 
        Console.WriteLine("Tempestade de Flechas");
        Console.WriteLine("ULT SUPREMA: Olho Morto");
        break;

    case 4:
        // Caso especial de classe secreta
        Console.WriteLine(" Você desbloqueou uma classe secreta");
        Console.WriteLine("Deseja prosseguir?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");

        num = Convert.ToInt32(Console.ReadLine());
        // Lê se o usuário quer prosseguir com a classe secreta

        if(num == 1){
            // Usuário escolheu prosseguir
            Console.WriteLine("Você desbloqueo a classe JEDI!!! ");
            Console.WriteLine("Eis aqui suas habilidades: ");
            Console.WriteLine("Refletir Tiros");
            Console.WriteLine("Força");
            Console.WriteLine("Estilo Shii-Cho");
            Console.WriteLine("ULT SUPREMA: Despertar da Força");

            Console.WriteLine("Voce adquiriu o item: Sabre de Luz");
            Console.WriteLine("Escolha uma cor para seu sabre de luz: ");
            Console.WriteLine("1 - Azul");
            Console.WriteLine("2 - Vermelho");

            cor = Convert.ToInt32(Console.ReadLine());
            // Lê a escolha de cor do sabre de luz

            if(cor == 1){
                // Sabre azul
                Console.WriteLine("Seu sabre de luz é azul");
                Console.WriteLine("Que a força esteja com você");
            }
            else {
                // Sabre vermelho
                Console.WriteLine("Seu sabre de luz é vermelho");
                Console.WriteLine("Que a força esteja com você");
            }                 
        }
        else {
            // Usuário escolheu não prosseguir
            Console.WriteLine("Você escolheu não prosseguir...volte a tela inicial e escolha uma classe");
        }
        break;
}
