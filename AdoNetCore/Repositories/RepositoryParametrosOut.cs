using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryParametrosOut
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryParametrosOut()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetNombreDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<(List<string> empleados, int suma
            , int media, int personas)>GetEmpleadosDepartamento(string nombre)
        {
            string sql = "SP_EMPLEADOS_DEPT_OUT";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            // Parámetro de entrada
            this.com.Parameters.Clear();
            this.com.Parameters.AddWithValue("@nombre", nombre);

            // Parámetros de salida
            SqlParameter pamSuma = new SqlParameter("@suma", SqlDbType.Int) { Direction = ParameterDirection.Output };
            SqlParameter pamMedia = new SqlParameter("@media", SqlDbType.Int) { Direction = ParameterDirection.Output };
            SqlParameter pamPersonas = new SqlParameter("@personas", SqlDbType.Int) { Direction = ParameterDirection.Output };

            this.com.Parameters.Add(pamSuma);
            this.com.Parameters.Add(pamMedia);
            this.com.Parameters.Add(pamPersonas);
                        
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> empleados = new List<string>();
            while (await reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return (empleados, Convert.ToInt32(pamSuma.Value), Convert.ToInt32(pamMedia.Value), Convert.ToInt32(pamPersonas.Value));
        }
    }    
}
