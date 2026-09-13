using estudos.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudos
{
    public partial class Form1 : Form
    {
        private PessoaController pessoaController = new PessoaController();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Maria";
            pessoa1.CPF = "123.456.789-00";
            pessoa1.Idade = 25;

            pessoaController.Inserir(pessoa1); 
            MessageBox.Show(pessoa1.Nome + "-" + pessoa1.CPF + "-" + pessoa1.Idade);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Caue";
            pessoa2.CPF = "123.456.444.00";
            pessoa2.Idade = 21;
            pessoa2.Email = "caue@gmail.com";

            pessoaController.Inserir(pessoa2);
            MessageBox.Show(pessoa2.Nome + "-" + pessoa2.CPF + "-" + pessoa2.Idade + "-" + pessoa2.Email );

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aluno aluno1 = new Aluno();
            aluno1.Nome = "Pedro";
            aluno1.CPF = "111.222.333.44";
            aluno1.Idade = 19;
            aluno1.Email = "pedro@gmail.com";
            aluno1.Matricula = "2026001";
            aluno1.Curso = "SI";

            pessoaController.Inserir(aluno1);
            MessageBox.Show(aluno1.Nome + " - " + aluno1.CPF + " - " + aluno1.Idade + " - " + aluno1.Email + " - " + aluno1.Matricula + " - " + aluno1.Curso);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Professor professor1 = new Professor();
            professor1.Nome = "Igor";
            professor1.CPF = "123.456.789.00";
            professor1.Idade = 30;
            professor1.Email = "igor@gmail.com";
            professor1.Materia = "Matemática";
            professor1.CargaHoraria = 20;

            pessoaController.Inserir(professor1);
            MessageBox.Show(professor1.Nome + " - " + professor1.CPF + " - " + professor1.Idade + " - " + professor1.Email + " - " + professor1.Materia + " - " + professor1.CargaHoraria + "h");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string todos = "";
            foreach (Pessoa p in pessoaController.Listar())
            {
                todos += p.Nome + "\n";
            }
            MessageBox.Show(todos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool apagou = pessoaController.Apagar(textBox1.Text);

            if (apagou)
            {
                MessageBox.Show("removido: " + textBox1.Text);
            }
            else
            {
                MessageBox.Show("Não encotrei ninguém com esse nome.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int novaIdade = Convert.ToInt32(textBox2.Text);
                bool alterou = pessoaController.AlterarIdade(textBox1.Text, novaIdade);

                if (alterou)
                    MessageBox.Show("Idade atualizada: " + textBox1.Text + " agora tem " + textBox2.Text + " anos.");
                else
                    MessageBox.Show("Não encontrei ninguém com esse nome.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido para a idade.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = pessoaController.Consultar(textBox1.Text);
            if (pessoa != null)
            { 
                MessageBox.Show(pessoa.Apresentacao());
            }
        }
    }
}
