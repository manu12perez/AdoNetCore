using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Repositories;
using Microsoft.Data.SqlClient;


#region PROCEDIMIENTOS ALMACENADOS
/*
create procedure SP_ALL_DEPARTAMENTOS
as
	select * from DEPT
go

create procedure SP_EMPLEADOS_DEPT_OUT
(@nombre nvarchar(50),
 @suma int OUT,
 @media int OUT,
 @personas int OUT)
 as
	declare @id int
	select @id = DEPT_NO from DEPT
	where DNOMBRE = @nombre
	select * from EMP where DEPT_NO = @id
	select @suma = SUM(SALARIO), @media = AVG(SALARIO)
    , @personas = COUNT(EMP_NO) from EMP
	where DEPT_NO = @id
 go
*/
#endregion

namespace AdoNetCore
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametrosOut repo;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosOut();
            this.LoadDepartamentos();
        }

        public async Task LoadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetNombreDepartamentos();
            this.cmbDepartamentos.Items.Clear();
            
            foreach (string departamento in departamentos)
            {
                this.cmbDepartamentos.Items.Add(departamento);
            }
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPT_OUT";
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();

            var (empleados, suma, media, personas) = await this.repo.GetEmpleadosDepartamento(nombre);

            // Limpiar y llenar la lista de empleados
            this.lstEmpleados.Items.Clear();
            foreach (string empleado in empleados)
            {
                this.lstEmpleados.Items.Add(empleado);
            }

            // Mostrar los valores de los parámetros de salida
            this.txtSumaSalarial.Text = suma.ToString();
            this.txtMediaSalarial.Text = media.ToString();
            this.txtPersonas.Text = personas.ToString();
        }
    }
}


/*
            //PARA LOS PARAMETROS DE ENTRADA PODEMOS UTILIZAR
            //AddWithValue SIN PROBLEMAS
            //PARA LOS PARAMETROS DE SALIDA ES IMPRESCINDIBLE
            //UTILIZAR OBJETOS Parameter
            this.com.Parameters.AddWithValue("@nombre", nombre);

            SqlParameter pamSuma = new SqlParameter();
            pamSuma.Value = 0;
            pamSuma.ParameterName = "@suma";
            //INDICAMOS LA DIRECCION DEL PARAMETRO
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);

            SqlParameter pamMedia = new SqlParameter();
            pamMedia.Value = 0;
            pamMedia.ParameterName = "@media";
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);

            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.Value = 0;
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            this.lstEmpleados.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            await this.reader.CloseAsync();

            //DIBUJAMOS LOS PARAMETROS
            this.txtSumaSalarial.Text = pamSuma.Value.ToString();
            this.txtMediaSalarial.Text = pamMedia.Value.ToString();
            this.txtPersonas.Text = pamPersonas.Value.ToString();
            
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
 */