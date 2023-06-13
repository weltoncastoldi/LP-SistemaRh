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


    }
}
