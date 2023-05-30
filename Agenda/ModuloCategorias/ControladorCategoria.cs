using Agenda.ModuloContato;
using Agenda.ModuloDespesas;
using Agenda.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloCategorias {
    internal class ControladorCategoria : ControladorBase {

        private IRepositorioCategoria repositorioCategoria;
        private IRepositorioDespesa repositorioDespesa;
        private TabelaCategoriaControl tabelaCategoria;

        public ControladorCategoria(IRepositorioCategoria repositorioCategoria, IRepositorioDespesa repositorioDespesa) {
            this.repositorioCategoria = repositorioCategoria;
            this.repositorioDespesa = repositorioDespesa;
        }

        public override string ToolTipInserir => "Inserir nova Categoria";

        public override string ToolTipExcluir => "Excluir Categoria Existente";

        public override string ToolTipEditar => "Editar Categoria Existente";

        public override string ToolTipDespesasCategoria => "Visualização de Despesas da Categoria";

        public override string LabelTipoCadastro => "Cadastro de Categorias de Despesas";

        public override bool DespesasCategoriaHabilitado { get { return true; } }


        public override void Inserir() {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();
            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Categoria novaCategoria = telaCategoria.ObterCategoria();

                repositorioCategoria.Inserir(novaCategoria);

                CarregarCategorias();
            }
        }

        public override void Editar() {
            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null) {
                MessageBox.Show("Nenhuma Categoria Selecionada!", "Editar Categorias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();
            telaCategoria.ConfigurarTela(categoriaSelecionada);

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Categoria novaCategoria = telaCategoria.ObterCategoria();

                repositorioCategoria.Editar(novaCategoria.id,novaCategoria);

                CarregarCategorias();
            }
        }

        public override void Excluir() {
            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null) {
                MessageBox.Show("Nenhuma Categoria Selecionada!", "Editar Categorias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcao = MessageBox.Show($"Deseja excluir a Categoria {categoriaSelecionada.titulo}? ", "Excluir Categorias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.OK) {
                repositorioCategoria.Excluir(categoriaSelecionada);
                CarregarCategorias();
            }
        }

        public override void DespesasPorCategoria() {
            Categoria categoriaSelecionada = ObterCategoriaSelecionada();

            if (categoriaSelecionada == null) {
                MessageBox.Show("Nenhuma Categoria Selecionada!", "Editar Categorias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TelaDespesasPorCategoria tela = new TelaDespesasPorCategoria();

            List<Despesa> listaDespesa = repositorioDespesa.SelecionarTodos();
            tela.ConfigurarTela(categoriaSelecionada,listaDespesa);

            DialogResult opcaoEscolhida = tela.ShowDialog();
        }

        public override UserControl ObterListagem() {
            if (tabelaCategoria == null) {
                tabelaCategoria = new TabelaCategoriaControl();
            }

            CarregarCategorias();

            return tabelaCategoria;
        }
        private Categoria ObterCategoriaSelecionada() {
            int id = tabelaCategoria.ObterIdSelecionado();
            return repositorioCategoria.SelecionarPorId(id);
        }
        private void CarregarCategorias() {
            List<Categoria> categorias = repositorioCategoria.SelecionarTodos();
            tabelaCategoria.AtualizarRegistros(categorias);
        }
    }
}
