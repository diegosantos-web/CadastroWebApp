using System.ComponentModel.DataAnnotations;

namespace CadastroWebApp.Models
{
    public class ClienteViewModel
    {
        [Display(Name = "Código")]
        public int ClienteId { get; set; }
        
        [Display(Name = "Empresa")]
        public string Empresa { get; set; }
        
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Preenchimento obrigatório !")]
        [DataType(DataType.Text, ErrorMessage = "o campo está vazio !")]
        public string Endereço { get; set; }
        
        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Preenchimento obrigatório !")]
        [DataType(DataType.Text, ErrorMessage = "o campo está vazio !")]
        public string Telefone { get; set; }

        public ClienteViewModel()
        {
            ClienteId = 0;
        }
    }
}
