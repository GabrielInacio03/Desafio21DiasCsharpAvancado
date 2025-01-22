using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace PrincipiosSolid.Generics
{
    public abstract class ABase<T>
    {
        public long Id { get; set; }

        public void Salvar()
        {
            if (!this.ValidandoDados()) throw new Exception("Erro na validação dos dados");
            Console.WriteLine("Salvando o objeto no banco de dados");
            //EnviarSMS();
        }
        private bool ValidandoDados()
        {
            Console.WriteLine("Validando classe");
            return true;
        }
        private static string NomeTable<T>(T item)
        {
            var table = "";
            TableAttribute tableAttribute = (TableAttribute)item.GetType().GetCustomAttributes<TableAttribute>();
            if (tableAttribute != null) 
            {
                table = tableAttribute.Name;
            }

            return table;
        }
        public void Excluir()
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MInha conexao";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"delete from {this.GetType().Name} where id = " + 1;

                cn.Open();
                cmd.ExecuteScalar();
                cn.Close();
                Console.WriteLine("Excluindo o objeto no banco de dados");

            }
        }
    }
}
