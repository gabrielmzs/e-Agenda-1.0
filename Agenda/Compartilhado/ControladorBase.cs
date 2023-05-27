using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Compartilhado {
    public abstract class ControladorBase {

        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipExcluir { get; }
        public abstract string ToolTipEditar { get; }

        public virtual string ToolTipFiltrar { get; }
        public virtual string ToolTipAdicionar { get; }
        public virtual string ToolTipConcluir { get; }
        public virtual string ToolTipDespesasCategoria { get; }

        public abstract string LabelTipoCadastro { get; }

        public virtual bool inserirHabilitado { get{ return true; } }
        public virtual bool editarHabilitado { get { return true; } }
        public virtual bool excluirHabilitado { get { return true; } }


        public virtual bool filtrarHabilitado { get { return false; } }
        public virtual bool adicionarHabilitado { get { return false; } }
        public virtual bool concluirHabilitado { get { return false; } }
        public virtual bool DespesasCategoriaHabilitado { get { return false; } }

        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();

        public virtual void Filtrar() { }

        public virtual void Adicionar() { }

        public virtual void Concluir() { }

        public virtual void DespesasPorCategoria() {

        }

        public abstract UserControl ObterListagem();
        

        
    }
}
