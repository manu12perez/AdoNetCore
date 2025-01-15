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
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        //DEVOLVER TODOS LOS HOSPITALES
        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            string sql = "select * from HOSPITAL";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<Hospital> hospitales = new List<Hospital>();
            while (await this.reader.ReadAsync())
            {
                int codHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                string nombre = this.reader["NOMBRE"].ToString();
                string direccion = this.reader["DIRECCION"].ToString();
                string telefono = this.reader["TELEFONO"].ToString();
                int camas = int.Parse(this.reader["NUM_CAMA"].ToString());

                Hospital hospital = new Hospital();
                hospital.CodHospital = codHospital;
                hospital.Nombre = nombre;
                hospital.Direccion = direccion;
                hospital.Telefono = telefono;
                hospital.Camas = camas;
                hospitales.Add(hospital);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return hospitales;
        }

        public async Task InsertHospitalAsync
            (int codHospital, string nombre, string direccion, string telefono, int camas)
        {
            string sql = "insert into HOSPITAL values " +
                "(@codHospital, @nombre, @direccion, @telefono, @camas)";

            SqlParameter pamCodHospital = new SqlParameter("@codHospital", codHospital);
            this.com.Parameters.Add(pamCodHospital);
            SqlParameter pamNombre = new SqlParameter("@nombre", nombre);
            this.com.Parameters.Add(pamNombre);
            SqlParameter pamDireccion = new SqlParameter("@direccion", direccion);
            this.com.Parameters.Add(pamDireccion);
            SqlParameter pamTelefono = new SqlParameter("@telefono", telefono);
            this.com.Parameters.Add(pamTelefono);
            SqlParameter pamCamas = new SqlParameter("@camas", camas);
            this.com.Parameters.Add(pamCamas);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task UpdateHospitalAsync
            (int codHospital, string nombre, string direccion, string telefono, int camas)
        {
            string sql = "update HOSPITAL set NOMBRE = @nombre, " +
                "DIRECCION = @direccion, TELEFONO = @telefono, " +
                "NUM_CAMA = @camas " + 
                " where HOSPITAL_COD = @codHospital";

            this.com.Parameters.AddWithValue("@codHospital", codHospital);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@direccion", direccion);
            this.com.Parameters.AddWithValue("@telefono", telefono);
            this.com.Parameters.AddWithValue("@camas", camas);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task DeleteHospitalAsync(int codHospital)
        {
            string sql = " delete from HOSPITAL where HOSPITAL_COD = @codHospital";

            this.com.Parameters.AddWithValue("@codHospital", codHospital);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
