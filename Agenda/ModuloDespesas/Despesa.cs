using Agenda.ModuloCategorias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.ModuloDespesas {
    public class Despesa : EntidadeBase<Despesa> {

        public string descricao;
        public decimal valor;
        public DateTime data;
        public PagamentoEnum pagamento;
        public List<Categoria> listaCategorias;
        

        public Despesa(int id, string descricao, decimal valor, DateTime data, PagamentoEnum pagamento, List<Categoria> listaCategorias) {
            this.id = id;
            this.descricao = descricao;
            this.valor = valor;
            this.data = data;
            this.pagamento = pagamento;
            this.listaCategorias = listaCategorias;
        }

        public override void AtualizarInformacoes(Despesa registroAtualizado) {
            id = registroAtualizado.id;
            descricao = registroAtualizado.descricao;
            valor = registroAtualizado.valor;
            data = registroAtualizado.data;
            pagamento = registroAtualizado.pagamento;
            listaCategorias = registroAtualizado.listaCategorias;
        }

        public override string[] Validar() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return descricao + ". Data: " + data.ToString("dd/MM/yyyy") + ". Valor R$: " + valor;
        }
    }
}
