using System;

namespace DesafioEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] equipamentos = new string[1000];
            string[] chamados = new string[1000];
            string[] nome = new string[1000];
            string[] fabricante = new string[1000];
            string[] preco = new string[1000];
            string[] datadefabricacao = new string[1000];
            string[] numerodeserie = new string[1000];
            string[] chamadoTitulo = new string[1000];
            string[] chamadoDescrição = new string[1000];
            string[] chamadoData = new string[1000];
            string[] chamadoEquipamento = new string[1000];
            string opcao = "";
            int DiasChamadoAtivo = 0;
            string menu = "";

            do
            {
            menu:
                Console.WriteLine("PRUDUTOS\n\nDigite 1 para inserir um produto\nDigite 2 ver o historico dos produtos\ndigite 3 para editar um produto/ digite 4 para excluir um produto\n\nCHAMADOS\ndigite 5 para registrar um chamado\n" +
                    "digite 6 para editar um chamado\ndigite 7 para excluir um chamado\ndigite 8 para ver hitorico de chamados");

                opcao = Console.ReadLine();
                if (!(opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "6" || opcao == "7" || opcao == "8"))
                {

                    Console.WriteLine("Opção inválida");
                    goto menu;
                }


                if (opcao == "1") // colocar outro produto
                {

                    for (int i = 0; i < equipamentos.Length; i++)
                    {
                        NomeEquipamentos(nome, i);

                        Preco(preco, i);

                        NumeroDeSerie(numerodeserie, i);

                        DataDeFabricacao(datadefabricacao, i);

                        Fabricante(fabricante, i);
                        Console.Clear();
                        break;
                    }
                }


                if (opcao == "2") // historico
                {


                    for (int i = 0; i < equipamentos.Length; i++)
                    {
                        if (nome[i] != null)
                        {
                            Console.WriteLine("Nome do equipamento: " + nome[i]);



                            Console.WriteLine("Numero de série do equipamento: " + numerodeserie[i]);



                            Console.WriteLine("Produto fabricado pelo(a): " + fabricante[i]);
                        }


                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }


                if (opcao == "3")
                {
                    Console.WriteLine("Digite o produto que queira modificar");

                    int editar1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nome do equipamento: " + nome[editar1]);

                    Console.WriteLine("preço do equipamento: " + preco[editar1]);

                    Console.WriteLine("Numero de serie do equipamento: " + numerodeserie[editar1]);

                    Console.WriteLine("data de fabricação do equipamento: " + datadefabricacao[editar1]);

                    Console.WriteLine("fabricante do equipamento: " + fabricante[editar1]);
                    Console.WriteLine();
                    Console.WriteLine("Qual Invormação deseja editar\nPara editar o Nome digite N\nPara editar o preço digite P\n para editar o numero de serie digite S" +
                        "\nPara editar a data de fabricação digite D\nPara editar o fabricante digite F\n\nPara Sair digite S");
                    string opcaoeditar = Console.ReadLine().ToUpper();
                    if (opcaoeditar == "N")
                    {
                        Console.WriteLine("Digite o novo nome");
                        string nomeeditado = Console.ReadLine();
                        nome[editar1] = nomeeditado;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Item editado com sucesso :-)");
                        Console.ResetColor();
                        break;
                    }
                    if (opcaoeditar == "P")
                    {
                        Console.WriteLine("Digite o novo preço");
                        string precoeditado = Console.ReadLine();
                        preco[editar1] = precoeditado;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Item editado com sucesso :-)");
                        Console.ResetColor();
                        break;
                    }
                    if (opcaoeditar == "S")
                    {
                        Console.WriteLine("Digite o novo numero de serie");
                        string nmrserieeditado = Console.ReadLine();
                        numerodeserie[editar1] = nmrserieeditado;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Item editado com sucesso :-)");
                        Console.ResetColor();
                        break;
                    }
                    if (opcaoeditar == "D")
                    {
                        Console.WriteLine("Digite a nova data de fabricação");
                        string dataeditada = Console.ReadLine();
                        datadefabricacao[editar1] = dataeditada;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Item editado com sucesso :-)");
                        Console.ResetColor();
                        break;
                    }
                    if (opcaoeditar == "F")
                    {
                        Console.WriteLine("Digite o novo fabricante");
                        string fabricanteeditado = Console.ReadLine();
                        fabricante[editar1] = fabricanteeditado;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Item editado com sucesso :-)");
                        Console.ResetColor();
                        break;
                    }
                    if (opcaoeditar == "S")
                    {
                        break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;





                }

                if (opcao == "4")
                {

                    Console.WriteLine("Digite o produto que queira excluir");
                    int excluir = Convert.ToInt32(Console.ReadLine());


                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"item {excluir} Excluido com sucesso");
                    Console.ResetColor();
                    Console.ReadLine();
                    nome[excluir] = "Item Excluido anteriormente";
                    preco[excluir] = "Item Excluido anteriormente";
                    numerodeserie[excluir] = "Item Excluido anteriormente";
                    datadefabricacao[excluir] = "Item Excluido anteriormente";
                    fabricante[excluir] = "Item Excluido anteriormente";

                    Console.Clear();
                    goto menu;




                }

                if (opcao == "5")
                {
                    for (int i = 0; i < chamados.Length; i++)

                    {

                    volta3:
                        Console.WriteLine("Qual o titulo do chamado?");
                        string nomes = Console.ReadLine();

                        if (nomes.Length < 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("nome muito pequeno, reescreva.");
                            Console.ResetColor();
                            goto volta3;
                        }
                        else
                        {
                            chamadoTitulo[i] = nomes;
                        }

                        Console.WriteLine("Descrição do chamado");
                        chamadoDescrição[i] = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Qual o equipamento do chamapo");
                        chamadoEquipamento[i] = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Qual a data do chamado (dd/mm/aaa)");
                        chamadoData[i] = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                        break;
                    }
                }
                if (opcao == "6")
                {
                    Console.WriteLine("Digite o chamado que queira editar");


                    int editar2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("titulo do chamado: " + chamadoTitulo[editar2]);

                    Console.WriteLine("descrição do chamado: " + chamadoDescrição[editar2]);

                    Console.WriteLine("equipamento do chamado: " + chamadoEquipamento[editar2]);

                    Console.WriteLine("data do chamado: " + chamadoData[editar2]);


                    Console.WriteLine("Qual Informação deseja editar\nPara editar o Titulo digite T\nPara editar a Descrição digite D\n para editar o Equipamento digite E" +
                        "\nPara editar a data do chamado A\n\nPara Sair digite S");
                    string opcaoeditar = Console.ReadLine().ToUpper();
                    if (opcaoeditar == "T")
                    {
                        Console.WriteLine("Digite o novo titulo");
                        string tituloeditado = Console.ReadLine();
                        chamadoTitulo[editar2] = tituloeditado;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Item editado com sucesso :-)");
                        Console.ResetColor();
                        break;
                    }
                    if (opcaoeditar == "D")
                    {
                        Console.WriteLine("Digite a nova descrição");
                        string descricaoeditado = Console.ReadLine();
                        chamadoDescrição[editar2] = descricaoeditado;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Item editado com sucesso :-)");
                        Console.ResetColor();
                        break;
                    }
                    if (opcaoeditar == "E")
                    {
                        Console.WriteLine("Digite o novo equipamento");
                        string equipamentoeditado = Console.ReadLine();
                        chamadoEquipamento[editar2] = equipamentoeditado;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Item editado com sucesso :-)");
                        Console.ResetColor();
                        break;
                    }
                    if (opcaoeditar == "D")
                    {
                        Console.WriteLine("Digite a nova data de fabricação");
                        string datachamadoeditada = Console.ReadLine();
                        chamadoData[editar2] = datachamadoeditada;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Item editado com sucesso :-)");
                        Console.ResetColor();
                        break;
                    }
                    if (opcaoeditar == "S")
                    {
                        break;
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;


                }

                if (opcao == "7")
                {
                    Console.WriteLine("Digite o chamado que queira excluir");
                    int Excluirchamado = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"item {Excluirchamado} Excluido com sucesso");
                    Console.ResetColor();
                    Console.ReadLine();
                    chamadoTitulo[Excluirchamado] = "Item Excluido anteriormente";
                    chamadoDescrição[Excluirchamado] = "Item Excluido anteriormente";
                    chamadoEquipamento[Excluirchamado] = "Item Excluido anteriormente";
                    chamadoData[Excluirchamado] = "Item Excluido anteriormente";

                    Console.Clear();
                    goto menu;

                }



                if (opcao == "8") // historico chamados
                {


                    for (int j = 0; j < chamados.Length; j++)
                    {

                        if (chamadoTitulo[j] != null)
                        {
                            Console.WriteLine("Nome do equipamento: " + chamadoTitulo[j]);



                            Console.WriteLine("equipamento do chamado: " + chamadoEquipamento[j]);



                            Console.WriteLine("chamdo feito em: " + chamadoData[j]);




                        }
                        if (chamadoData[j] == "Item Excluido anteriormente")
                        {
                            Console.WriteLine("Dias ativo: Item Excluido anteriormente");
                        }
                        else
                        {
                            string strdata = chamadoData[j].ToString();
                            string[] dataseparada = strdata.Split("/");

                            int dia = Convert.ToInt32(dataseparada[0]);
                            int mes = Convert.ToInt32(dataseparada[1]);
                            int ano = Convert.ToInt32(dataseparada[2]);
                            DateTime criacaoChamado = new DateTime(ano, mes, dia);

                            DateTime diaHoje = DateTime.Now;

                            DiasChamadoAtivo = (diaHoje - criacaoChamado).Days;
                            Console.WriteLine($"O chamados está à {DiasChamadoAtivo} dias ativo");
                        }


                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }

                }













            } while (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5" || opcao == "6" || opcao == "7" || opcao == "8");

            static string Preco(string[] preco, int i)
            {
                Console.WriteLine("Qual o preço do produto?");
                preco[i] = Convert.ToString(Console.ReadLine());
                return preco[i];
            }

            static string NumeroDeSerie(string[] numerodeserie, int i)
            {
                Console.WriteLine("Qual o numero de serie do produto?");
                numerodeserie[i] = Convert.ToString(Console.ReadLine());
                return numerodeserie[i];
            }

            static string DataDeFabricacao(string[] datadefabricacao, int i)
            {
                Console.WriteLine("Qual a data de fabricação do produto?");
                datadefabricacao[i] = Convert.ToString(Console.ReadLine());
                return datadefabricacao[i];
            }

            static string Fabricante(string[] fabricante, int i)
            {
                Console.WriteLine("Qual o fabricante do produto?");
                fabricante[i] = Convert.ToString(Console.ReadLine());
                return fabricante[i];


            }
            static string NomeEquipamentos(string[] nome, int i)
            {
            volta:
                Console.WriteLine("Qual o nome do produto?");
                string nomes = Console.ReadLine();

                if (nomes.Length < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nome muito pequeno, reescreva.");
                    Console.ResetColor();
                    goto volta;
                }
                else
                {
                    nome[i] = nomes;
                }
                return nome[i];
            }
        }
    }
}
