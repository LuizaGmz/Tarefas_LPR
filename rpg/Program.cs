// See https://aka.ms/new-console-template for more information


int num, escolha, cor;



Console.WriteLine("Vamos contruir seu personagem!!");
Console.WriteLine("Escolha uma classe ");
Console.WriteLine("1 - Guerreiro ");
Console.WriteLine("2 - Mago  ");
Console.WriteLine("3 - Arqueiro ");
escolha = Convert.ToInt32(Console.ReadLine());

switch(escolha){
    case 1:

        Console.WriteLine(" Você escolheu a classe Guerreiro. Eis aqui suas habilidades: ");
        Console.WriteLine("Ataque Pesado");
        Console.WriteLine("Defesa total"); 
        Console.WriteLine("Retaliação com a espada");
        Console.WriteLine("ULT SUPREMA: Golpe do Dragão");
        
        break;

    case 2:

        Console.WriteLine(" Você escolheu a classe Mago. Eis aqui suas habilidades: ");
        Console.WriteLine("Bola de Fogo");
        Console.WriteLine("Escudo de Gelo"); 
        Console.WriteLine("Redemoinho de vento");
        Console.WriteLine("ULT SUPREMA: Tempestade de Raios");

        break;

    case 3:

        Console.WriteLine(" Você escolheu a classe Arqueiro. Eis aqui suas habilidades: ");
        Console.WriteLine("Flecha Precisa");
        Console.WriteLine("Disparo Triplo"); 
        Console.WriteLine("Tempestade de Flechas");
        Console.WriteLine("ULT SUPREMA: Olho Morto");

        break;

        case 4:

        Console.WriteLine(" Você desbloqueou uma classe secreta");
        Console.WriteLine("Deseja prosseguir?");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");

        num = Convert.ToInt32(Console.ReadLine());

        if(num == 1){
            
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

            if(cor == 1){
                Console.WriteLine("Seu sabre de luz é azul");
                Console.WriteLine("Que a força esteja com você");
            }

            else {
                Console.WriteLine("Seu sabre de luz é vermelho");
                Console.WriteLine("Que a força esteja com você");
            }
                     
              
        }

        else {
            Console.WriteLine("Você escolheu não prosseguir...volte a tela inicial e escolha uma classe");
        }
        break;
}


