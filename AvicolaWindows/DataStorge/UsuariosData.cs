using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvicolaWindows.Models;

namespace AvicolaWindows.DataStorge
{
    public class UsuariosData
    {
        Users users = new Users();

        public Users UsuariosExistentes(Users us)
        {
            us = new Users { Name = "Pablo", Pasword = "123" };

            return us;
        }

        public Users NuevoUsuario(string usuario,string pass)
        {
            Users nuevoUsuario = new Users();
            nuevoUsuario.Name = usuario;
            nuevoUsuario.Pasword = pass;
            return nuevoUsuario;
        }


    }
}
