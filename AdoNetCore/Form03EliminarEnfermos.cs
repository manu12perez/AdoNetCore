using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AdoNetCore
{
    public partial class Form03EliminarEnfermos : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form03EliminarEnfermos()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            CargarEnfermos();
            
        }

        private void CargarEnfermos()
        {
            string sql = "select * from ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();
            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        //SIN PARAMETROS
        //private void btnEliminarEnfermo_Click(object sender, EventArgs e)
        //{
        //    string sql = "delete from ENFERMO where INSCRIPCION = " + this.txtInscripcion.Text;
        //    this.com.Connection = this.cn;
        //    this.com.CommandType = CommandType.Text;
        //    this.com.CommandText = sql;
        //    this.cn.Open();

        //    int eliminados = this.com.ExecuteNonQuery();
        //    this.cn.Close();
        //    CargarEnfermos();
        //    MessageBox.Show("Enfermos eliminados " + eliminados);
        //}

        //CON PARAMETROS
        private void btnEliminarEnfermo_Click(object sender, EventArgs e)
        {
            //INSCRIPCION E S UN NUMERO, POR LO QUE DEBEMOS HACER UN CASTING PARA int
            int inscripcion = int.Parse(this.txtInscripcion.Text);
            string sql = "delete from ENFERMO where INSCRIPCION = @inscripcion";
            //CREAMOS EL PARAMETRO PARA LA INSCRIPCION
            SqlParameter paramInscripcion = new SqlParameter("@inscripcion", inscripcion);
            //paramInscripcion.ParameterName = "@inscripcion";
            //Value DEBE SER DEL MISMO TIPO QUE EL PARAMETRO (int)
            //paramInscripcion.Value = inscripcion;
            //OPCIONAL
            //paramInscripcion.DbType = DbType.Int32;
            //Direction INDICA SI EL PARAMETRO ES ENTRADA O SALIDA
            //POR DEFECTO, ES Input
            //paramInscripcion.Direction = ParameterDirection.Input;
            //AÑADIMOS EL PARAMETRO AL COMMAND
            this.com.Parameters.Add(paramInscripcion);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            CargarEnfermos();
            MessageBox.Show("Enfermos eliminados " + eliminados);
        }
    }
}
