using DIO.Series.Entities;
using DIO.Series.Enum;
using DIO.Series.Repositories;
using System;

namespace DIO
{
    class Program
    {
        static SerieRepository serieRepository = new SerieRepository();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string opcao = ObterOpcao();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        CadastrarSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        DeletarSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcao = ObterOpcao();
            }




        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = serieRepository.List();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Série Cadastrada");
                return;
            }

            foreach (var serie in lista)
                Console.WriteLine(@"#iD {0}: - {1}", serie.RetornaId(), serie.RetornaTitulo());

        }

        private static void CadastrarSerie()
        {
            Console.WriteLine("Cadastrar nova Séries");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine(@"{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o Ano da Série: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string descricao = Console.ReadLine();

            Serie serie = new Serie(id: serieRepository.NextId(),
                                        genero: (Genero)genero,
                                        titulo: titulo,
                                        ano: ano,
                                        descricao: descricao);

            serieRepository.Insert(serie);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Informe o id da série: ");
            int idSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine(@"{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite o Ano da Série: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string descricao = Console.ReadLine();

            Serie serie = new Serie(id: serieRepository.NextId(),
                                        genero: (Genero)genero,
                                        titulo: titulo,
                                        ano: ano,
                                        descricao: descricao);

            serieRepository.Update(idSerie, serie);
        }

        private static void DeletarSerie()
        {
            Console.Write("Informe o id da série: ");
            int id = int.Parse(Console.ReadLine());

            serieRepository.DeleteById(id);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Informe o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var serie = serieRepository.GetById(id);

            Console.WriteLine(serie);
        }


        private static string ObterOpcao()
        {

            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ DIO Séries ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗    ");
            Console.WriteLine("║ 1- LISTAR SÉRIES                              ║    ");
            Console.WriteLine("║                                               ║    ");
            Console.WriteLine("║ 2- CADASTRAR SÉRIE                            ║    ");
            Console.WriteLine("║                                               ║    ");
            Console.WriteLine("║ 3- ATUALIZAR SÉRIE                            ║    ");
            Console.WriteLine("║                                               ║    ");
            Console.WriteLine("║ 4- DELETAR                                    ║    ");
            Console.WriteLine("║                                               ║    ");
            Console.WriteLine("║ 5- VISUALIZAR SÉRIE                           ║    ");
            Console.WriteLine("║                                               ║    ");
            Console.WriteLine("║ C- LIMPAR TELA                                ║    ");
            Console.WriteLine("║                                               ║    ");
            Console.WriteLine("║ X- SAIR                                       ║    ");
            Console.WriteLine("╚═══════════════════════════════════════════════╝    ");

            Console.WriteLine(" ");


            Console.Write("DIGITE UMA OPÇÃO : ");

            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcao;

        }
    }
}
