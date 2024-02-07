namespace Consultorio_Legal.CORE.Domain
{
#nullable disable
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
        public string Documento { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime? UltimaAtualizacao { get; set; }
        public Enderecos Endereco { get; set; }
    }
}