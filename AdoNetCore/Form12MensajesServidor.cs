using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

#region STORED PROCEDURES
//create procedure SP_ALL_DEPARTAMENTOS
//as
//	select * from DEPARTAMENTOS
//go

//create procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
//as
//	begin
//		insert into DEPARTAMENTOS (DEPT_NO, DNOMBRE, LOC)
//		values (@numero, @nombre, @localidad);
//end;
//go

//alter procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
//as
//--NO QUEREMOS LA LOCALIDAD DE TERUEL
//	if(@localidad = 'TERUEL')
//	begin
//		print 'TERUEL NO EXISTE'
//	end
//	else
//	begin
//		insert into DEPARTAMENTOS (DEPT_NO, DNOMBRE, LOC)
//		values (@numero, @nombre, @localidad);
//end;
//go
#endregion

namespace AdoNetCore
{
    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;            

            //RECUPERAMOS EL EVENTO DE MENSAJES DE LA CONEXION
            this.cn.InfoMessage += Cn_InfoMessage;

            this.LoadDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensaje.Text = e.Message;
        }

        public async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            this.lst_Departamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                int numero = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();

                this.lst_Departamentos.Items.Add
                    (numero + " - " + nombre + " - " + localidad);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";

            int numero = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            string sql = "SP_INSERT_DEPARTAMENTO";

            this.com.Parameters.AddWithValue("@numero", numero);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.cn.Open();
            int afectados = this.com.ExecuteNonQuery();
            this.cn.Close();

            this.com.Parameters.Clear();
            //await this.LoadDepartamentos();
            MessageBox.Show("Insertados " + afectados);
        }
    }
}
