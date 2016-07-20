namespace devAppProject.Api.Models
{
    public class RegisterUsuarioViewModel
    {
        public int IdPerfil { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public long Rg { get; set; }
        public long Cpf { get; set; }
        public string Email { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string Senha { get; set; }
        public string ConfirmSenha { get; set; }
    }
}