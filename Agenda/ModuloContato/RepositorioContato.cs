using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloContato {
    public class RepositorioContato {

        List<Contato> contatos = new List<Contato>();
        private static int contador = 0;
        public void Inserir(Contato contato) {

            contador++;
            contato.id = contador;
            contatos.Add(contato);
        }

        public List<Contato> SelecionarTodos() {
            return contatos;
        }

        public void Editar(Contato contato) {

            Contato contatoSelecionado = SelecionarPorId(contato.id);
            contatoSelecionado.nome = contato.nome;
            contatoSelecionado.email = contato.email;
            contatoSelecionado.telefone = contato.telefone;
            contatoSelecionado.cargo = contato.cargo;
            contatoSelecionado.empresa = contato.empresa;

        }


        private Contato SelecionarPorId(int id) {
            return contatos.FirstOrDefault(x => x.id == id);
        }

        internal void Excluir(Contato contato) {
            contatos.Remove(contato);
        }
    }
}
