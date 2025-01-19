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

#region STORED PROCEDURES
//create procedure SP_ALL_HOSPITALES
//as
//	select * from HOSPITAL
//go

//create procedure SP_UPDATEPLANTILLA_HOSPITAL
//(@nombre nvarchar(50), @incremento int)
//as
//	declare @hospitalcod int
//	select @hospitalcod = HOSPITAL_COD from HOSPITAL
//	where NOMBRE = @nombre
//	update PLANTILLA set SALARIO = SALARIO + @incremento
//	where HOSPITAL_COD = @hospitalcod
//	select * from PLANTILLA
//	where HOSPITAL_COD = @hospitalcod
//go

//create procedure SP_GETPLANTILLA_HOSPITAL
//(@nombre nvarchar(50))
//as
//	begin
//		declare @hospitalcod
//		select @hospitalcod = HOSPITAL_COD from HOSPITAL where NOMBRE = @nombre
//		select APELLIDO, SALARIO from PLANTILLA
//		where HOSPITAL_COD = @hospitalcod
//	end
//go
#endregion

namespace AdoNetCore
{
    public partial class Form11UpdatePlantillaProcedures : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form11UpdatePlantillaProcedures()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            LoadHospitales();
        }

        public async void LoadHospitales()
        {
            string sql = "SP_ALL_HOSPITALES";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            this.lstPlantilla.Items.Clear();
            while(await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospital.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnModificarSalarios_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospital.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);
            string sql = "SP_UPDATEPLANTILLA_HOSPITAL";

            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@incremento", incremento);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            this.lstPlantilla.Items.Clear();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " - " + salario);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}