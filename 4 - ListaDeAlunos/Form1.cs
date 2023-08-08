using System.Windows.Forms;

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

            try
            {
                CalcProduto a = new CalcProduto();

                a.Codigo = textBox1.Text;

                a.Descricao = textBox4.Text;

                a.PrecoAquisicao = Convert.ToDouble(textBox2.Text);//preço

                a.Lucro = Convert.ToDouble(textBox5.Text);


                double porcentagem = (a.PrecoAquisicao * a.Lucro) / 100.00;
                double totalValorVenda = porcentagem + a.PrecoAquisicao;
                textBox3.Text = totalValorVenda.ToString();
                produto.Add(a);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produto;

                a.ValorDeVenda = totalValorVenda;

            }

            catch (Exception ex)
            {
                MessageBox.Show("ERRO!");
            }
            finally
            {
                MessageBox.Show("BYE!!");
            }
            
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;//numero da celula //exclui a celula que o usuario escolher
            produto.RemoveAt(index);//remove
           
            //zerando a tabela e atualizando
            dataGridView1.DataSource = null;//deixar sem elemento
            dataGridView1.Refresh();//atualizar
            dataGridView1.DataSource = produto;
        }
    }
}