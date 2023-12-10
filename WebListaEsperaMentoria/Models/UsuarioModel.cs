﻿using WebListaEsperaMentoria.Enums;

namespace WebListaEsperaMentoria.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }


        public string Senha { get; set; }
        public PerfilEnum Perfil { get; set; }
        public virtual List<PacienteModel> Pacientes { get; set; }
    }
}
