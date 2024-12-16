# Screen Sound

<h2>Descrição:</h2>
O ScreenSound 2.0 é um sistema escrito em C# que fornece uma interface para gerenciamento de bandas e álbuns. Desenvolvido com um design modular, o projeto inclui recursos para registrar bandas, adicionar álbuns, avaliar bandas e álbuns, e exibir informações detalhadas de cada banda registrada.<br>
Ele utiliza estruturas como dicionários para organizar dados e classes especializadas para criar menus interativos, garantindo extensibilidade e facilidade de uso. O sistema é ideal para aprendizado em programação orientada a objetos e prática de manipulação de dados em C#.

<h2>Funcionalidades:</h2>
- Registrar Bandas: Permite adicionar novas bandas ao sistema, associando seus nomes e avaliações.<br>
- Registrar Álbuns: Adicione álbuns às bandas registradas.<br>
- Listar Bandas: Exibe todas as bandas cadastradas no sistema, juntamente com o número de álbuns e média das avaliações.<br>
- Avaliar Bandas: Insere avaliações em forma de notas para bandas específicas.<br>
- Avaliar Álbuns: Atribui notas a álbuns específicos das bandas.<br>
- Exibir Detalhes de Bandas: Exibe informações completas sobre uma banda como, nome, avaliações, média de notas e lista de álbuns <br>
- Sistema de Navegação por Menu: O sistema apresenta opções dinâmicas que guiam o usuário por meio de um menu textual.<br>
- Encerrar o Programa: Opção para finalizar a execução do sistema.

<h2> Estrutura do Código</h2>
<h4>Modelos</h4>
Banda: Classe que representa uma banda, com funcionalidades para adicionar avaliações e associar álbuns.<br>
Avaliacao: Classe que encapsula as notas atribuídas às bandas ou álbuns.<br>
Menu: Uma classe base abstrata usada para criar diferentes menus de interação.<br>
<h4>Dicionários</h4>
bandasRegistradas: Um dicionário que associa os nomes das bandas às suas respectivas instâncias.<br>
opcoes: Um dicionário que mapeia as opções numéricas do menu para os objetos Menu correspondentes.<br>
<h4>Fluxo do Programa</h4>
O sistema inicia exibindo o logo e o menu principal, implementado na função ExibirOpcoesDoMenu.
Com base na entrada do usuário, a opção selecionada é executada, delegando a funcionalidade à classe correspondente.

<h2>Tecnologias:</h2>
C#: Linguagem de programação principal.</br>
.NET: Framework utilizado para executar o aplicativo.

<h2>Pré-Requisitos:</h2>
- .NET SDK 6.0 ou superior.<br>
- Um editor ou IDE compatível com C# (Visual Studio, Visual Studio Code, Rider).

<h2>Exemplo de Uso</h2>
1- Adicionar uma Nova Banda: Escolha a opção 1 e forneça o nome da banda.<br>
2- Registrar um Álbum: Escolha a opção 2, selecione a banda e insira o nome do álbum.<br>
3- Exibir Bandas Registradas: Escolha a opção 3 para visualizar a lista de bandas cadastradas.<br>
4- Avaliar uma Banda: Escolha a opção 4, selecione uma banda e insira uma nota de 0 a 10.<br>

<h2>Extensibilidade</h2>
O sistema é modular e permite a fácil adição de novas funcionalidades:<br>
Para adicionar um novo menu, basta criar uma classe derivada de Menu e registrá-la no dicionário opcoes.<br>
O sistema utiliza encapsulamento e abstração para facilitar manutenção e extensões.

<h2>Contribuições</h2>
Contribuições são bem-vindas! Caso queira melhorar o sistema, sinta-se à vontade para criar um fork do projeto e submeter um pull request com suas alterações.<br>
<br>

<h3>Explore o ScreenSound 2.0, avalie suas bandas favoritas e gerencie seus álbuns com facilidade! 🎵</h3>
