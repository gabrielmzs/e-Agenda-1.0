
using Agenda.ModuloCategoria;
using Agenda.ModuloCompromisso;
using Agenda.ModuloContato;
using Agenda.ModuloTarefa;
using Agenda.ModuloDespesa;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Agenda.Compartilhado {
    public class ContextoDados {

        private const string NOME_ARQUIVO = "Compartilhado\\e-Agenda.json";
        //private const string NOME_ARQUIVO = "C:\\Users\\gabri\\Desktop\\Academia do Progamador\\Agenda\\Agenda\\Compartilhado\\e-Agenda.json";

        public List<Contato> contatos;
        public List<Compromisso> compromissos;
        public List<Tarefa> tarefas;
        public List<Categoria> categorias;
        public List<Despesa> despesas;

        public ContextoDados() {

            categorias = new List<Categoria>();
            contatos = new List<Contato>();
            compromissos = new List<Compromisso>();
            despesas = new List<Despesa>();
            tarefas = new List<Tarefa>();
        }

        public ContextoDados(bool carregarDados) : this() {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson() {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson() {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO)) {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0) {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    this.contatos = ctx.contatos;
                    this.compromissos = ctx.compromissos;
                    this.tarefas = ctx.tarefas;
                    this.categorias = ctx.categorias;
                    this.despesas = ctx.despesas;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes() {

            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }

    }
}
