using Agenda.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloTarefa {

    public class ItemTarefa {
        public string titulo;
        public bool concluido;

        public ItemTarefa(string titulo) {
            this.titulo = titulo;
        }

        public override string ToString() {
            return titulo;
        }

        public void Concluir() {
            concluido = true;
        }

        public override bool Equals(object? obj) {
            return obj is ItemTarefa tarefa &&
                   titulo == tarefa.titulo &&
                   concluido == tarefa.concluido;
        }

        internal void Desmarcar() {
            concluido = false;
        }
    }
    public class Tarefa : EntidadeBase<Tarefa> {


        public string titulo;
        public PrioridadeTarefaEnum prioridade;
        public DateTime dataCriacao;
        public List<ItemTarefa> itens;
        public decimal percentual;

        public Tarefa(int id, string titulo, PrioridadeTarefaEnum prioridade, DateTime dataCriacao) {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
            this.dataCriacao = dataCriacao;
            itens = new List<ItemTarefa>();
        }

        public override void AtualizarInformacoes(Tarefa registroAtualizado) {
            id = registroAtualizado.id;
            titulo = registroAtualizado.titulo;
            prioridade = registroAtualizado.prioridade;
            
        }

        public override string[] Validar() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "ID: " + id + ", " + titulo + ",Prioridade " + prioridade + ", Percentual Concluído: " + percentual + " %";
        }

        internal void AdicionarItem(ItemTarefa item) {
            itens.Add(item);
        }

        public void ConcluirItem(ItemTarefa item) {

           ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));
            itemSelecionado.Concluir();

            CalcularPercentualConcluido();
        }


        internal void DesmarcarItem(ItemTarefa item) {

            ItemTarefa itemSelecionado = itens.FirstOrDefault(x => x.Equals(item));
            itemSelecionado.Desmarcar();

            CalcularPercentualConcluido();
        }
        private void CalcularPercentualConcluido() {

            decimal qtdConcluidos = itens.Count(x => x.concluido == true);
            decimal quantidadeItens = itens.Count();

            decimal resultado = (qtdConcluidos / quantidadeItens) * 100;

            percentual = Math.Round(resultado,2);
            
        }
    }
}
