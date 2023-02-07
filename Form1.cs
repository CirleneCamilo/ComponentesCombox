namespace ComponentesCombox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt01_Click(object sender, EventArgs e)
        {
            string nome, idade, nascimento, frutas;

            nome = Txt01.Text;
            idade = NumUpDown.Value.ToString();
            nascimento = Mask01.Text;
            frutas = Combox01.Text;

            MessageBox.Show("Nome : " + nome + "\n" + "Idade : " + idade + "\n" + "Data de Nascimento : " + nascimento + "\n" + "Fruta Favorita : " + frutas);

        }
    }
}