using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using AdoNetCore.Repositories;

namespace AdoNetCore
{
    public partial class Form09CrudHospitales : Form
    {
        private RepositoryHospitales repo;

        public Form09CrudHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            LoadHospitales();
        }

        public async void LoadHospitales()
        {
            List<Hospital> hospitales = await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();

            foreach (Hospital hosp in hospitales)
            {
                this.lstHospitales.Items.Add("Codigo Hospital: " + hosp.CodHospital
                    + ", Nombre: " + hosp.Nombre + ", Dirección: " + hosp.Direccion + ", Teléfono: "
                    + hosp.Telefono + ", Camas: " + hosp.Camas);
            }
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int codHospital = int.Parse(this.txtCodHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);

            await this.repo.InsertHospitalAsync(codHospital, nombre, direccion, telefono, camas);
            LoadHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int codHospital = int.Parse(this.txtCodHospital.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);

            await this.repo.UpdateHospitalAsync(codHospital, nombre, direccion, telefono, camas);
            LoadHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int codHospital = int.Parse(this.txtCodHospital.Text);

            await this.repo.DeleteHospitalAsync(codHospital);
            LoadHospitales();
        }
    }
}
