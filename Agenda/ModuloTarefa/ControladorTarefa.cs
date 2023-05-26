using Agenda.Compartilhado;

namespace Agenda.ModuloTarefa {
    internal class ControladorTarefa : ControladorBase {

        private RepositorioTarefa repositorioTarefa;
        private TabelaTarefaControl tabelaTarefas;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa) {

            this.repositorioTarefa = repositorioTarefa;
        }
        public override string ToolTipInserir => "Inserir nova Tarefa";
        public override string ToolTipExcluir => "Excluir Tarefa Existente";
        public override string ToolTipEditar => "Editar Tarefa Existente";
        public override string ToolTipFiltrar => "Filtar Tarefas";
        public override string ToolTipAdicionar => "Adicionar Itens na Tarefa Selecionada";
        public override string ToolTipConcluir => "Concluir Itens na Tarefa Selecionada";

        public override string LabelTipoCadastro => "Cadastro de Tarefas";

        public override bool filtrarHabilitado => true;
        public override bool adicionarHabilitado => true;
        public override bool concluirHabilitado => true;




        public override void Inserir() {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK) {

                Tarefa novaTarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Inserir(novaTarefa);

                CarregarTarefas();
            }
        }

        public override void Editar() {

            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null) {
                MessageBox.Show("Nenhuma Tarefa Selecionada!","Editar Tarefas",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            telaTarefa.ConfigurarTela(tarefaSelecionada);

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {

                Tarefa tarefa = telaTarefa.ObterTarefa();

                repositorioTarefa.Editar(tarefa.id,tarefa);

                CarregarTarefas();
            }


        }

        public override void Excluir() {
            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null) {
                MessageBox.Show("Nenhuma Tarefa Selecionada!", "Excluir Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult opcao = MessageBox.Show($"Deseja excluir a tarefa {tarefaSelecionada.titulo}? ", "Excluir Tarefas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(opcao == DialogResult.OK) {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }


        public override void Adicionar() {

            Tarefa tarefaSelecionada = ObterTarefaSelecionada();

            if (tarefaSelecionada == null) {
                MessageBox.Show("Nenhuma Tarefa Selecionada!", "Adição de itens da Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroItensTarefaForm telaCadastroItensTarefaForm = new TelaCadastroItensTarefaForm(tarefaSelecionada);

             DialogResult opcao = telaCadastroItensTarefaForm.ShowDialog();

            if(opcao == DialogResult.OK) {
                List<ItemTarefa> itensParaAdicionar = telaCadastroItensTarefaForm.ObterItensCadastrados();

                foreach (ItemTarefa item in itensParaAdicionar) {

                    tarefaSelecionada.AdicionarItem(item);

                }

                repositorioTarefa.Editar(tarefaSelecionada.id, tarefaSelecionada);

                CarregarTarefas();
            }
        }

        private Tarefa ObterTarefaSelecionada() {
            int id = tabelaTarefas.ObterIdSelecionado();
            return repositorioTarefa.SelecionarPorId(id);
        }

        public override void Concluir() {

            Tarefa tarefaSelecionada =ObterTarefaSelecionada();

            if (tarefaSelecionada == null) {
                MessageBox.Show("Nenhuma Tarefa Selecionada!", "Conclusão de itens da Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TelaAtualizacaoItensTarefaForm telaAtualizacao = new TelaAtualizacaoItensTarefaForm(tarefaSelecionada);

            DialogResult opcao = telaAtualizacao.ShowDialog();

            if (opcao == DialogResult.OK) {


                List<ItemTarefa> itensMarcados = telaAtualizacao.ObterItensMarcados();
                List<ItemTarefa> itensPendentes = telaAtualizacao.ObterItensPendentes();

                foreach (ItemTarefa item in itensMarcados) {

                    tarefaSelecionada.ConcluirItem(item);
                }
                
                foreach (ItemTarefa item in itensPendentes) {

                    tarefaSelecionada.DesmarcarItem(item);
                }

                repositorioTarefa.Editar(tarefaSelecionada.id, tarefaSelecionada);

                CarregarTarefas();
            }
        }

        public override void Filtrar() {
            TelaFiltroTarefaForm telaFiltroTarefa = new TelaFiltroTarefaForm();
            DialogResult opcao = telaFiltroTarefa.ShowDialog();

            if (opcao == DialogResult.OK) {
                List<Tarefa> tarefas = null;

                StatusEnum status = telaFiltroTarefa.ObterFiltroTarefa();

                switch (status) {
                    case StatusEnum.Concluidas:
                        tarefas = repositorioTarefa.SelecionarConcluidas();
                        break;
                    case StatusEnum.Pendentes:
                        tarefas = repositorioTarefa.SelecionarPendentes();
                        break;
                    default:
                        tarefas = repositorioTarefa.SelecionarPorPrioridade();
                        break;
                }

                CarregarTarefas(tarefas);
            }
        }

        private void CarregarTarefas(List<Tarefa> tarefas) {

            
            tabelaTarefas.AtualizarRegistros(tarefas);
        }

        private void CarregarTarefas() {

            List<Tarefa> tarefas = repositorioTarefa.SelecionarPorPrioridade();
            tabelaTarefas.AtualizarRegistros(tarefas);
        }

        public override UserControl ObterListagem() {
            if (tabelaTarefas == null) {
                tabelaTarefas = new TabelaTarefaControl();
            }

            CarregarTarefas();

            return tabelaTarefas;
        }
    }
}
