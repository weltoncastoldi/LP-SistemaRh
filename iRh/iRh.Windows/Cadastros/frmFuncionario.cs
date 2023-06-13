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


        //AGORA ADICIONE UM COMBOX NA TELA para um campo: Documento
        //de identificação dentro dele você deverá colocar uma LISTA de Documentos
        //de identificação contendo ID (número sequencial) e
        //Descricao (Texto que vai aparecer
        //dentro do combobox que será o mesmo do documento
        //ex.: 
        //{Id = 1, Descricao="Carteira Nacional de Habilitação"};


    }
}
