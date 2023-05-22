using Agenda.Compartilhado;
using Agenda.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloCompromisso {
    public class ControladorCompromisso : ControladorBase {

        private RepositorioCompromisso repositorioCompromisso;
        private ListagemCompromissoControl listagemCompromisso;
        private RepositorioContato repositorioContato;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato) {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Compromisso"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso Existente"; } }

        public override string ToolTipEditar { get { return "Editar Compromisso Existente"; } }

        public override string LabelTipoCadastro { get { return "Cadastro de Compromissos"; } }


        public override void Editar() {

            TelaCompromisso telaCompromisso = new TelaCompromisso(repositorioContato.SelecionarTodos());

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                Compromisso compromisso = telaCompromisso.Compromisso;
                repositorioCompromisso.Inserir(compromisso);
                CarregarCompromissos();
            }
        }

        public override void Excluir() {
            Compromisso compromisso = listagemCompromisso.ObterCompromissoSelecionado();

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja Excluir o compromisso selecionado?", "Exclusão de Compromisso",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK) {

                repositorioCompromisso.Excluir(compromisso);
                CarregarCompromissos();
            }
        }

        public override void Inserir() {

            TelaCompromisso telaCompromisso = new TelaCompromisso(repositorioContato.SelecionarTodos());
            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Compromisso compromisso = telaCompromisso.Compromisso;
                repositorioCompromisso.Inserir(compromisso);
                CarregarCompromissos();
            }
        }

        public override UserControl ObterListagem() {
            if (listagemCompromisso == null) {
                listagemCompromisso = new ListagemCompromissoControl();
            }

            CarregarCompromissos();

            return listagemCompromisso;
        }

        private void CarregarCompromissos() {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();
            listagemCompromisso.AtualizarRegistros(compromissos);
        }
    }
}
