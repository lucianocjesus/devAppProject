using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using devAppProject.Common.Configuration;
using devAppProject.Domain.Contracts.Repositories;
using devAppProject.Domain.Models;

namespace devAppProject.Data
{
    //public class UsuarioData : IUsuarioRepository
    //{
    //    private readonly SqlConnection _objSqlConnection;
    //    private string Metodo { get; set; }
    //    private string Linha { get; set; }

    //    public UsuarioData()
    //    {
    //        _objSqlConnection = new SqlConnection
    //        {
    //            ConnectionString = ConfigurationManager.ConnectionStrings["AppCnnStr"].ToString()
    //        };
    //        Assembly.GetExecutingAssembly().GetName().Version.ToString();
    //        Tools.LocalIpAddress();
    //    }

    //    public Usuario Get(int id, string codigo, string email)
    //    {
    //        var usuario = new Usuario(codigo, email);
    //        using (_objSqlConnection)
    //        {
    //            try
    //            {
    //                _objSqlConnection.Open();
    //                const string queryString = "SELECT * FROM dbo.Usuario WHERE id = @pId";
    //                var command = new SqlCommand(queryString, _objSqlConnection);
    //                command.Parameters.AddWithValue("@pId", id);
    //                var reader = command.ExecuteReader();
    //                if (reader.Read())
    //                {
    //                    usuario.Id = Convert.ToInt32(reader["id"]);
    //                    usuario.Codigo = reader["Codigo"].ToString();
    //                    usuario.Nome = reader["Nome"].ToString();
    //                    usuario.Sobrenome = reader["Sobrenome"].ToString();
    //                    usuario.SetSenha(reader["Senha"].ToString());
    //                    usuario.Rg = Convert.ToInt32(reader["RG"]);
    //                    usuario.Cpf = Convert.ToInt32(reader["CPF"]);
    //                    usuario.Email = reader["Email"].ToString();
    //                    usuario.Telefone = Convert.ToInt32(reader["Telefone"]);
    //                    usuario.Celular = Convert.ToInt32(reader["Celular"]);
    //                    usuario.Facebook = reader["Facebook"].ToString();
    //                    usuario.Twitter = reader["Twitter"].ToString();
    //                    usuario.LinkedIn = reader["LinkedIn"].ToString();
    //                    usuario.Status = Convert.ToInt32(reader["Status"]);
    //                    usuario.Data = Convert.ToDateTime(reader["Cadastro"]);
    //                }
    //            }
    //            catch (Exception ex)
    //            {
    //                var trace = new StackTrace(ex, true);
    //                Linha = trace.GetFrame(trace.FrameCount - 1).GetFileLineNumber().ToString();
    //                Metodo = trace.GetFrame(trace.FrameCount - 1).GetMethod().Name;
    //                throw;
    //            }
    //            finally
    //            {
    //                if (_objSqlConnection.State == ConnectionState.Open)
    //                {
    //                    _objSqlConnection.Close();
    //                }
    //            }
    //        }
    //        return usuario;
    //    }

    //    public Usuario GetCodigo(string codigo)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Usuario GetNome(string nome)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Usuario GetEmail(string email)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Usuario> Get(Usuario usuario)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Create(Usuario usuario)
    //    {
    //        using (_objSqlConnection)
    //        {
    //            try
    //            {
    //                _objSqlConnection.Open();
    //                SqlCommand cmd = new SqlCommand();
    //                cmd.Connection = _objSqlConnection;
    //                cmd.CommandTimeout = 0;

    //                const string strQuery = "INSERT INTO dbo.Usuario VALUES " +
    //                                        " (@Codigo, @Nome, @Sobrenome, @Senha, @RG, @CPF, @Email, @Telefone, @Celular, @Facebook, @Twitter, @LinkedIn, @Status, @Cadastro";
    //                cmd.CommandText = strQuery;
    //                cmd.CommandType = CommandType.Text;

    //                cmd.Parameters.Add("@Codigo", SqlDbType.VarChar, 50);
    //                cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50);
    //                cmd.Parameters.Add("@Sobrenome", SqlDbType.VarChar, 50);
    //                cmd.Parameters.Add("@Senha", SqlDbType.VarChar, 50);
    //                cmd.Parameters.Add("@RG", SqlDbType.Int);
    //                cmd.Parameters.Add("@CPF", SqlDbType.Int);
    //                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 150);
    //                cmd.Parameters.Add("@Telefone", SqlDbType.Int);
    //                cmd.Parameters.Add("@Celular", SqlDbType.Int);
    //                cmd.Parameters.Add("@Facebook", SqlDbType.VarChar, 200);
    //                cmd.Parameters.Add("@Twitter", SqlDbType.VarChar, 50);
    //                cmd.Parameters.Add("@LinkedIn", SqlDbType.VarChar, 200);
    //                cmd.Parameters.Add("@Status", SqlDbType.Bit);
    //                cmd.Parameters.Add("@Cadastro", SqlDbType.DateTime);

    //                cmd.Parameters["@Codigo"].Value = usuario.Codigo;
    //                cmd.Parameters["@Nome"].Value = usuario.Nome;
    //                cmd.Parameters["@Sobrenome"].Value = usuario.Sobrenome;
    //                cmd.Parameters["@Senha"].Value = usuario.Senha;
    //                cmd.Parameters["@RG"].Value = usuario.Rg;
    //                cmd.Parameters["@CPF"].Value = usuario.Cpf;
    //                cmd.Parameters["@Email"].Value = usuario.Email;
    //                cmd.Parameters["@Telefone"].Value = usuario.Telefone;
    //                cmd.Parameters["@Celular"].Value = usuario.Celular;
    //                cmd.Parameters["@Facebook"].Value = usuario.Facebook;
    //                cmd.Parameters["@Twitter"].Value = usuario.Twitter;
    //                cmd.Parameters["@LinkedIn"].Value = usuario.LinkedIn;
    //                cmd.Parameters["@Status"].Value = usuario.Status;
    //                cmd.Parameters["@Cadastro"].Value = usuario.Data;
    //                cmd.ExecuteNonQuery();
    //            }
    //            finally
    //            {
    //                if (_objSqlConnection.State == ConnectionState.Open)
    //                {
    //                    _objSqlConnection.Close();
    //                }
    //            }
    //        }
    //    }

    //    public void Update(Usuario usuario)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Dispose()
    //    {
    //        _objSqlConnection.Close();
    //        _objSqlConnection.Dispose();
    //    }
    //}
}
