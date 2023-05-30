﻿

using Agenda.ModuloContato;

namespace Agenda.ModuloDespesas {
    public interface IRepositorioDespesa {
        void Inserir(Despesa novaDespesa);
        void Editar(int id, Despesa despesa);
        void Excluir(Despesa despesaSelecionada);

        Despesa SelecionarPorId(int id);
        List<Despesa> SelecionarTodos();
    }
}
