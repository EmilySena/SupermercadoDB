using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Supermercado.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Nome { get; set; }
        /*
         * [StringLength(50,MinimumLength=5, ErrorMessage="minimo é 5 e maximo é 50 caracteres")
         */
        [Range(18, 50, ErrorMessage = "Idade entre 18 e 50 anos")]
        [Required(ErrorMessage = "A idade deve ser preenchido")]
        public int Idade { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras, 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login deve ser preenchido")]
        [Remote("LoginUnico", "Pessoa", ErrorMessage = "Esse nome de login já existe")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha deve ser informada")]
        public string Senha { get; set; }
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmarSenha { get; set; }
    }
}