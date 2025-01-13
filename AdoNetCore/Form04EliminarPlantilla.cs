﻿using System;
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
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            CargarPlantillas();
        }

        private void CargarPlantillas()
        {
            string sql = "select * from PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstPlantillas.Items.Clear();
            while (this.reader.Read())
            {
                string idEmpleado = this.reader["EMPLEADO_NO"].ToString();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstPlantillas.Items.Add(idEmpleado + " - " + apellido);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminarPlantilla_Click(object sender, EventArgs e)
        {
            string sql = "delete from PLANTILLA where EMPLEADO_NO = " + this.txtIdEmpleado.Text;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int eliminadas = this.com.ExecuteNonQuery();
            this.cn.Close();
            CargarPlantillas();
            MessageBox.Show("Plantillas eliminadas " + eliminadas);
        }
    }
}
