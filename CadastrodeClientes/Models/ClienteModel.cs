using CadastrodeCliente.Enums;

namespace CadastrodeCliente.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        public int CPF { get; set; }
        public string Nome { get; set; }

        public int DataNasc { get; set; }

        public string Endereco { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public SexoEnum Sexo { get; set; }
    }
}
