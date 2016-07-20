namespace devAppProject.Domain.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public int IdEstado { get; set; }
        public string Nome { get; set; }
        public Estado Estado { get; set; }
    }
}
