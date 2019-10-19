using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Conta_Corrente.entities.Db
{
    class DbController
    {
        public class Clientes
        {
            public int Id { get; set; }
            public int Conta { get; set; }
            public int Agencia { get; set; }
            public int Digito { get; set; }
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public float Saldo { get; set; }
            public float Saldo_Dolar { get; set; }
        }

        public class Clientes_Senhas
        {
            public int Id { get; set; }
            public string Cpf { get; set; }
            public int Senha { get; set; }
        }

        public string strConnection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public const string strDelete = "DELETE FROM Clientes WHERE id = @id";
        public const string strInsert = "INSERT INTO Clientes VALUES (@nome, @cpf, @conta, @agencia, @digito, @saldo)";
        public const string strSelect = "SELECT id, nome, cpf, conta, agencia, digito, saldo, saldo_dolar FROM Clientes";
        public const string strSelectSenhas = "SELECT id, cpf, senha FROM Clientes_Senhas";
        public const string strUpdate = "UPDATE Clientes SET nome = @nome, cpf = @cpf, conta = @conta, agencia = @agencia, digito = @digito, saldo = @saldo, id = @id";

        public List<Clientes_Senhas> ConsultarSenha()
        {
            List<Clientes_Senhas> list = new List<Clientes_Senhas>();

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand(strSelectSenhas, sqlConnection))
                {
                    sqlConnection.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Clientes_Senhas senhas = new Clientes_Senhas();
                            senhas.Id = int.Parse(sqlDataReader["id"].ToString());
                            senhas.Cpf = sqlDataReader["cpf"].ToString();
                            senhas.Senha = int.Parse(sqlDataReader["senha"].ToString());

                            list.Add(senhas);
                        }
                        sqlDataReader.Close();
                    }
                    sqlConnection.Close();
                }
            }
            return list;
        }

        public List<Clientes> Consultar()
        {
            List<Clientes> list = new List<Clientes>();

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand(strSelect, sqlConnection))
                {
                    sqlConnection.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if(sqlDataReader.HasRows)
                    {
                        while(sqlDataReader.Read())
                        {
                            Clientes clientes = new Clientes();
                            clientes.Id = int.Parse(sqlDataReader["id"].ToString());
                            clientes.Nome = sqlDataReader["nome"].ToString();
                            clientes.Cpf = sqlDataReader["cpf"].ToString();
                            clientes.Conta = int.Parse(sqlDataReader["conta"].ToString());
                            clientes.Agencia = int.Parse(sqlDataReader["agencia"].ToString());
                            clientes.Digito = int.Parse(sqlDataReader["digito"].ToString());
                            clientes.Saldo = int.Parse(sqlDataReader["saldo"].ToString());
                            clientes.Saldo_Dolar = int.Parse(sqlDataReader["saldo_dolar"].ToString());

                            list.Add(clientes);
                        }
                        sqlDataReader.Close();
                    }
                    sqlConnection.Close();
                }

            }
            return list;
        }

        public void Atualizar(int id, string nome, string cpf, int conta, int agencia, int digito, float saldo)
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand(strUpdate, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.Parameters.AddWithValue("@nome", nome);
                    sqlCommand.Parameters.AddWithValue("@cpf", cpf);
                    sqlCommand.Parameters.AddWithValue("@conta", conta);
                    sqlCommand.Parameters.AddWithValue("@agencia", agencia);
                    sqlCommand.Parameters.AddWithValue("@digito", digito);
                    sqlCommand.Parameters.AddWithValue("@saldo", saldo);

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
            }

        }

        public void Deletar(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand(strDelete, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", id);

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
            }
        }

        public void Inserir(string nome, string cpf, int conta, int agencia, int digito, float saldo)
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                using (SqlCommand sqlCommand = new SqlCommand(strInsert, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@nome", nome);
                    sqlCommand.Parameters.AddWithValue("@cpf", cpf);
                    sqlCommand.Parameters.AddWithValue("@conta", conta);
                    sqlCommand.Parameters.AddWithValue("@agencia", agencia);
                    sqlCommand.Parameters.AddWithValue("@digito", digito);
                    sqlCommand.Parameters.AddWithValue("@saldo", saldo);

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
            }
        }
        
    }
}



    


