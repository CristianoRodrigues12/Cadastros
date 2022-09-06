namespace Cadastros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadProfessor_Click(object sender, EventArgs e)
        {
            lblMedia.Visible = false;
            txtMedia.Visible = false;

            Professor objProfessor = new Professor();

            objProfessor.Matricula = int.Parse(txtMatricula.Text);

            objProfessor.Nome = txtNome.Text; 

            objProfessor.Salario = float.Parse(txtSalario.Text);


            MessageBox.Show("Professor Cadastrado com sucesso", "CLASSE PROFESSOR");
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            lblSalario.Visible = false;
            txtSalario.Visible = false;

            Aluno objAluno = new Aluno();

            objAluno.Matricula = int.Parse(txtMatricula.Text);

            objAluno.Nome = txtNome.Text;

            objAluno.Media = float.Parse(txtMedia.Text);

            MessageBox.Show("Aluno Cadastrado com Sucesso", "CLASSE ALUNO" );

        }

        private void rdbProfessor_CheckedChanged(object sender, EventArgs e)
        {
            lblSalario.Visible = true;
            txtSalario.Visible = true;
            btnCadProfessor.Enabled = true;
        }

        private void rdbAluno_CheckedChanged(object sender, EventArgs e)
        {
            lblMedia.Visible = true;
            txtMedia.Visible = true;
            btnCadAluno.Enabled = true;
        }
    }
}