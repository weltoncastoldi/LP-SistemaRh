using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class DocumentoIndentificacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public List<DocumentoIndentificacao> ObterTodos()
        {
            var listaDocumentos = new List<DocumentoIndentificacao>();

            listaDocumentos.Add(new DocumentoIndentificacao() { Id = 1, Descricao = "Registro Geral" });
            listaDocumentos.Add(new DocumentoIndentificacao() { Id = 2, Descricao = "Passaporte" });
            listaDocumentos.Add(new DocumentoIndentificacao() { Id = 3, Descricao = "Carteira Nacional de Habilitação" });

            return listaDocumentos;
        }
    }
}
