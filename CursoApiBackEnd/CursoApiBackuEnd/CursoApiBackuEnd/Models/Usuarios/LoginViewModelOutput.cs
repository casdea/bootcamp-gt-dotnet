using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoApiBackuEnd.Models.Usuarios
{
    public class LoginViewModelOutput
    {   
        public string Token { get; set; }
        
        public UsuarioViewModelOutput Usuario { get; set; }
    }
}
