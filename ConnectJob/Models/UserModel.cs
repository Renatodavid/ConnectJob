using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectJob.Models
{
    [Table("Usuarios")]
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Nome {  get; set; }

        public string? Senha { get; set; }

        public string? Email { get; set; }

        public  string? Cpf { get; set; }
        
       

    }
}
