using BLL;

namespace ListaTel
{
    public partial class ListaTel : Form
    {
        public Repositorio repositorio { get; set; } = new Repositorio();


        public ListaTel()
        {
            InitializeComponent();
        }

        private void Form1load(object sender,EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            Contato num = new Contato();

            num.Nome = txtNome.Text;
            num.Telefone = txtTel.Text;

            repositorio.Incluir(num);
            MessageBox.Show("Contato incluido com sucesso");

            txtNome.Text = "";
            txtTel.Text = "";
        }

        private void btnListar_Click_1(object sender, EventArgs e)
        {
            listAl.Items.Clear();
            foreach (var list in repositorio.Contatos)
            {
                listAl.Items.Add(list);
            }
        }
    }

}