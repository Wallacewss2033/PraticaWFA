using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaWFA.Model
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string email { get; set; }


        public Cliente(int id_cliente, string nome, string cpf_cnpj, string email)
        {
            this.id_cliente = id_cliente;
            this.nome = nome;
            this.cpf_cnpj = cpf_cnpj;
            this.email = email;


        }

    }

}
