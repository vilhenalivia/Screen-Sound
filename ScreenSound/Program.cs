using ScreenSound.Menus;
using ScreenSound.Modelos;


Banda linkinpark = new Banda("Linkin Park");
linkinpark.AdicionarNota(new Avaliacao(10));
linkinpark.AdicionarNota(new Avaliacao(9));
linkinpark.AdicionarNota(new Avaliacao(8));
Banda beatles = new Banda("The Beatles");
beatles.AdicionarNota(new Avaliacao(9));
beatles.AdicionarNota(new Avaliacao(9));
beatles.AdicionarNota(new Avaliacao(6));

// Visibilidade dictionary é publica
Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(linkinpark.Nome, linkinpark);
bandasRegistradas.Add(beatles.Nome, beatles);

//Dicionário de menus
Dictionary<int, Menu> opcoes = new();

opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuBandasRegistradas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());


void ExibirLogo()
{
    Console.WriteLine(@"SCREEN SOUND");
    Console.WriteLine("\nBoas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuExibido = opcoes[opcaoEscolhidaNumerica];
        menuExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}

//ExibirOpcoesDoMenu();