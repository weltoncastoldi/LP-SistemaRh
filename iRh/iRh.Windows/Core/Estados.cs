using System.Collections.Generic;

namespace iRh.Windows.Core
{
    public class Estados
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public IList<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();

            listaDeEstados.Add(new Estados
            {
                Nome = "Rondônia",
                Sigla = "RO"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Acre",
                Sigla = "AC"
            });
            listaDeEstados.Add(new Estados
            {
                Nome = "Espirito Santo",
                Sigla = "ES"
            });

            return listaDeEstados;
        }
    }
}
