using Agenda.ModuloContato;
using Agenda.ModuloTarefa;
using System.Runtime.Serialization.Formatters.Binary;


namespace Agenda.Compartilhado {
    public class RepositorioArquivoBase <TEntidade> where TEntidade : EntidadeBase<TEntidade> {

        protected int contadorRegistros = 0;
        protected List<TEntidade> listaRegistros = new List<TEntidade>();

        
        public void CarregarRegistrosDoArquivo(string caminho) {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] registrosEmBytes = File.ReadAllBytes(caminho);

            MemoryStream registroStream = new MemoryStream(registrosEmBytes);

            listaRegistros = (List<TEntidade>)serializador.Deserialize(registroStream);

            AtualizarContador();
        }

        public void AtualizarContador() {
            contadorRegistros = listaRegistros.Max(x => x.id);
        }

        public void GravarTarefasEmArquivo(string caminho) {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream registroStream = new MemoryStream();

            serializador.Serialize(registroStream, listaRegistros);

            byte[] registrosEmBytes = registroStream.ToArray();

            File.WriteAllBytes(caminho, registrosEmBytes);
        }
    }
}
