using Agenda.ModuloCategorias;
using Agenda.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloDespesas {
    internal class ControladorDespesa : ControladorBase {

        private IRepositorioDespesa repositorioDespesa;
        private IRepositorioCategoria repositorioCategoria;
        private TabelaDespesaControl tabelaDespesa;

        public ControladorDespesa(IRepositorioDespesa repositorioDespesa, IRepositorioCategoria repositorioCategoria) {
            this.repositorioDespesa = repositorioDespesa;
            this.repositorioCategoria = repositorioCategoria;
        }

        public override string ToolTipInserir => "Inserir nova Despesa";
        public override string ToolTipExcluir => "Excluir Despesa Existente";
        public override string ToolTipEditar => "Editar Despesa Existente";
        public override string LabelTipoCadastro => "Cadastro de Despesas";

        public override void Editar() {

            Despesa despesaSelecionada = ObterDespesaSelecionada();

            if (despesaSelecionada == null) {
                MessageBox.Show("Nenhuma Despesa Selecionada!", "Editar Despesas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaDespesaForm telaDespesa = new TelaDespesaForm(repositorioCategoria.SelecionarTodos());
            telaDespesa.ConfigurarTela(despesaSelecionada);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Despesa despesa = telaDespesa.ObterDespesa();

                repositorioDespesa.Editar(despesa.id, despesa);

                CarregarDespesas();
            }
        }

        private Despesa ObterDespesaSelecionada() {
            int id = tabelaDespesa.ObterIdSelecionado();
            return repositorioDespesa.SelecionarPorId(id);
        }

        public override void Excluir() {
            Despesa despesaSelecionada = ObterDespesaSelecionada();

            if (despesaSelecionada == null) {
                MessageBox.Show("Nenhuma Despesa Selecionada!", "Editar Despesas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcao = MessageBox.Show($"Deseja excluir a despesa {despesaSelecionada.descricao}? ", "Excluir Despesas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK) {
                repositorioDespesa.Excluir(despesaSelecionada);
                CarregarDespesas();
            }
        }

        public override void Inserir() {
            TelaDespesaForm telaDespesa = new TelaDespesaForm(repositorioCategoria.SelecionarTodos());
            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Despesa novaDespesa = telaDespesa.ObterDespesa();

                repositorioDespesa.Inserir(novaDespesa);

                CarregarDespesas();
            }
        }

        public override UserControl ObterListagem() {
            if (tabelaDespesa == null) {
                tabelaDespesa = new TabelaDespesaControl();
            }

            CarregarDespesas();

            return tabelaDespesa;
        }

        private void CarregarDespesas() {
            List<Despesa> despesas = repositorioDespesa.SelecionarTodos();
            tabelaDespesa.AtualizarRegistros(despesas);
        }
    }
}
