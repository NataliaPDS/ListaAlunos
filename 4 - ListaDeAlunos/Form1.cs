namespace _4___ListaDeAlunos
{
    public partial class Form1 : Form
    {
        List<CalcProduto> produto = new List<CalcProduto>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

          

                CalcProduto a = new CalcProduto();

                a.Codigo = textBox1.Text;

                a.Descricao = textBox4.Text;

                a.PrecoAquisicao = Convert.ToDouble(textBox2.Text);//preço

                a.Lucro = Convert.ToDouble(textBox5.Text);

                //a.ValorDeVenda = Convert.ToDouble(Console.ReadLine());

                produto.Add(a);

           

                double porcentagem = (a.PrecoAquisicao * a.Lucro) / 100.00;
                double totalValorVenda = porcentagem + a.PrecoAquisicao;
                textBox3.Text = totalValorVenda.ToString();

               a.ValorDeVenda = totalValorVenda;





          //  Console.Clear();//limpar a tela
          //alunos.Sort();//ordernar em ordem alfabetica ou por numero
            /*foreach (CalcProduto a in produto)
            {
                Console.WriteLine("O nome é " + a.Nome + "CPF: " + a.Cpf);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}