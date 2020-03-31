
namespace IRPF.Lib.Declaracao
{
    public class Identificador
    {
        public enum TipoDeclaracao
        {
            Completa = 0,
            Simplificada = 1,
        }

        public Identificador() { } // Serializar

        public TipoDeclaracao Tipo { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public int Exercicio { get; set; }
        public bool Retificadora { get; set; }
        public string NumeroReciboRetificadora { get; set; }
        public string NumeroReciboAnterior { get; set; }
        public bool EnderecoDiferente { get; set; }
        public string EnderecoMACRede { get; set; }

    }
}
