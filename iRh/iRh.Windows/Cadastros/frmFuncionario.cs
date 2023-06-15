using iRh.Windows.Core;
using System.Linq;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, System.EventArgs e)
        {
            CarregarEstados();
            CarregarDocumentos();
        }

        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();
            cmbEstados.Items.Clear();
            cmbEstados.DataSource = estadosAz;            
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";            
        }

        private void CarregarDocumentos()
        {
            var documentos = new DocumentoIndentificacao();
            var listaDocumentos = documentos.ObterTodos();

            cmbDocumentoIdentidade.Items.Clear();
            cmbDocumentoIdentidade.DataSource = listaDocumentos.OrderBy(x => x.Descricao).ToList();
            cmbDocumentoIdentidade.DisplayMember = "Descricao";
            cmbDocumentoIdentidade.ValueMember = "Id";
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            var cepDigitado = txtCep.Text;
            if(cepDigitado.Length < 9)
            {
                MessageBox.Show("Digite um cep válido");
                txtCep.Focus();
                return;
            }

            var endereco = new Endereco();

            var enderecoCompleto = endereco.ObterPorCep(cepDigitado);

            if(enderecoCompleto.Erro == true)
            {
                MessageBox.Show("O cep informado não existe");
                txtCep.Focus();
                return;
            }

            if(endereco.Localidade != "")
            {
                txtCidade.Enabled = false;
            }

            if(endereco.Uf != "")
            {
                cmbEstados.Enabled = false;
            }


            txtLogradouro.Text = enderecoCompleto.Logradouro;
            txtBairro.Text = enderecoCompleto.Bairro;
            txtCidade.Text = enderecoCompleto.Localidade;
            txtDdd.Text = enderecoCompleto.Ddd;
            cmbEstados.SelectedValue = enderecoCompleto.Uf;


        }
    }
}
