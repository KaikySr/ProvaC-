using System;
using System.IO;

string nome = string.Empty;
bool premiun = false;
int dia = -1;
int mes = -1;
int ano = -1;
// TODO

//Vou completar esta bela obra semana que vem,
//se não for demitido né vai que kkkk
//caracteres úteis: ─│┌┐└┘├┤┬┴┼
Console.WriteLine("┌───┐ ┌───┐");
Console.WriteLine("│┌─┐│ │┌─┐│");
Console.WriteLine("│└─┘│ ││ ││");
Console.WriteLine("│ ┌─┘ ││ ││");
Console.WriteLine("│ └─┐ ││ ││");
Console.WriteLine("│┌─┐│ ││ ││");
Console.WriteLine("│└─┘│ │└─┘│");
Console.WriteLine("└───┘ └───┘");
Console.WriteLine("\t\tTecnologia para a vida");
Console.WriteLine("");
Console.WriteLine("Pressione qualquer tecla para começar...");
Console.ReadKey(true);
bool rodando = true;
while (rodando)
{
    Console.Clear();
    Console.WriteLine("O que você quer fazer?");
    Console.WriteLine("1 - Cadastrar Novo cliente");
    Console.WriteLine("2 - Ler dados do cliente");
    Console.WriteLine("3 - Cadastrar Novo produto");
    Console.WriteLine("4 - Ler dados do produto");
    Console.WriteLine("5 - Sair");
    int id = int.Parse(Console.ReadLine());
    switch(id)
    {
        case 1:
            Console.Write("Digite o nome do Cliente:");
            nome = Console.ReadLine();
            Console.WriteLine("Cliente premium? (1 - sim | 2 - não): ");
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
                premiun = true;
            else
                premiun = false;
            Console.WriteLine("Insira o dia de nascimento do cliente: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o mês de nascimento do cliente: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o ano de nascimento do cliente: ");
            ano = int.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, premiun, dia, mes, ano);
            cliente.Save();
            break;
        
        case 2:
            Console.WriteLine("Digite o nome do cliente que deseja ler os dados: ");
            Cliente.Load(nome);
            break;
        // case 3:
        //     Cliente.Load(nome);
        //     break;
        // case 4:
        //     Cliente.Load(nome);
        //     break;
        case 5:
            Console.WriteLine("Até Logo!");
            rodando = false;
            break;
        default:
            Console.WriteLine("Opção Invalída");
            break;
    }
}

public class Cliente
{
    public Cliente(string nome, bool premium, int dia, int mes, int ano)
    {
        this.Nome = nome;
        this.Premium = premium;
        this.DiaNascimento = dia;
        this.MesNascimento = mes;
        this.AnoNascimento = ano;
    }

    public string Nome { get; set; }
    public bool Premium { get; set; }
    public int DiaNascimento { get; set; }
    public int MesNascimento { get; set; }
    public int AnoNascimento { get; set; }

    public void Save()
    {
        StreamWriter writer = new StreamWriter(this.Nome + ".txt");

        writer.WriteLine(this.Nome);
        writer.WriteLine(this.Premium);
        writer.WriteLine(this.DiaNascimento);
        writer.WriteLine(this.MesNascimento);
        writer.WriteLine(this.AnoNascimento);

        writer.Close();
    }

    public static Cliente Load(string nome)
    {
        StreamReader reader = new StreamReader(nome + ".txt");

        nome = reader.ReadLine();
        bool premiun = bool.Parse(reader.ReadLine());
        int dia = int.Parse(reader.ReadLine());
        int mes = int.Parse(reader.ReadLine());
        int ano = int.Parse(reader.ReadLine());
        
        Cliente cliente = new Cliente(nome, premiun, dia, mes, ano);
        return cliente;
        
    }
}

public class Produto
{
    public Produto(string nome, bool preco, int fabricante)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Fabricante = fabricante;
        this.MesNascimento = mes;
        this.AnoNascimento = ano;
    }

    public string Nome { get; set; }
    public float Preco { get; set; }
    public int Fabricante { get; set; }
    public int MesNascimento { get; set; }
    public int AnoNascimento { get; set; }
}