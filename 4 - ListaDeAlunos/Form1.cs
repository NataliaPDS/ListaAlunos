namespace _4___ListaDeAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<CalcProduto> produto = new List<CalcProduto>();


            CalcProduto a = new CalcProduto();
            Console.WriteLine("Digite o número do código: ");
            a.Codigo = Console.ReadLine();
            Console.WriteLine("Digite a descricão: ");
            a.Descricao = Console.ReadLine();
            Console.WriteLine("Digite o preço da aquisição: ");
            a.PrecoAquisicao = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número do lucro: ");
            a.Lucro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número do valor da venda: ");
            a.ValorDeVenda = Convert.ToDouble(Console.ReadLine());

            produto.Add(a);
            
            label7.Text = a.Porcentagem.ToString());

            //  double porcentagem = (a.PrecoAquisicao * a.Lucro) / 100.00;
            // MessageBox.Show(porcentagem.ToString());



            Console.Clear();//limpar a tela
                            //alunos.Sort();//ordernar em ordem alfabetica ou por numero
            /* foreach (CalcProduto a in produto)
             {
                / Console.WriteLine("O nome é " + a.Nome + "CPF: " + a.Cpf);
             }*/
        }


    }
}