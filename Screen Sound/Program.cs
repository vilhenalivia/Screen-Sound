//Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaBandas = new List<string> { "U2", "Pink Floyd","Beatles"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());



void ExibirMensgemDeBoasVindas()
{
    Console.WriteLine("============================");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("============================");
}

void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("Digite a sua opção: ");
    string escolha = Console.ReadLine()!;
    int escolhaNumerica = int.Parse(escolha);

    switch (escolhaNumerica)
    {
        case 1 : RegistrarBandas();
            break;

        case 2 : MostrarBandasRegistradas();
            break;

        case 3 : AvaliarBanda();
            break;

        case 4 : ExibirMedia();
            break;
        
        case -1 : Console.WriteLine("Até a próxima <3");
            break;

        default : Console.WriteLine("Opção inválida!");
            break;
    }
}


void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas: \n");
    Console.WriteLine("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);

    ExibirMensgemDeBoasVindas();
    ExibirMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Bandas Registradas: \n");
    foreach (var banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu princial");
    Console.ReadKey();
    Console.Clear();

    ExibirMensgemDeBoasVindas();
    ExibirMenu();

}

void AvaliarBanda()
{
    //ditar qual banda deseja avaliar
    // se a banda existir no funcionario >> atribui uma nota
    // se nao volta ao menu

    Console.Clear();
    Console.WriteLine("Avalições da banda: ");
    Console.WriteLine("Digite o nome da banda que seja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi regitrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();

        ExibirMensgemDeBoasVindas();
        ExibirMenu();

    } else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

        ExibirMensgemDeBoasVindas();
        ExibirMenu();
    }
}


void ExibirMedia()
{
    Console.Clear();
    Console.WriteLine("Média da Banda: ");
    Console.Write("Digite o nome da banda que você deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey (nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda{nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

        ExibirMensgemDeBoasVindas();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A média da banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();

        ExibirMensgemDeBoasVindas();
        ExibirMenu();
    }
}



ExibirMensgemDeBoasVindas();
ExibirMenu();
