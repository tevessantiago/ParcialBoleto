using BLL;
using DM;

namespace UI_WinForms
{
    public partial class Form1 : Form
    {
        //List<Ejecutivo> ejecutivos = new List<Ejecutivo>();
        //List<Turista> turistas = new List<Turista>();
        List<Boleto> boletosAgregados = new List<Boleto>();
        BoletoLogic boletoLogic = new BoletoLogic();
        public Form1()
        {
            InitializeComponent();
            cmbTipo.DataSource = Enum.GetValues(typeof(TipoBoleto));
            cmbTipo.DisplayMember = "ToString";
        }

        private void btnAgregar_Click(object sender, EventArgs e) //Falta comportamiento default/todos.
        {
            if (!int.TryParse(txtDias.Text, out int dias))
            {
                throw new Exception("Por favor, ingrese un número entero para indicar los días.");
            }

            switch (cmbTipo.SelectedItem.ToString())
            {
                case "Ejecutivo":
                    Ejecutivo boletoEjecutivo = new Ejecutivo();
                    
                    boletoEjecutivo.TiempoEnDias = dias;
                    boletoEjecutivo.FechaSalida = dateTimePicker1.Value;

                    boletoLogic.CalcularCostoBoleto(boletoEjecutivo);
                    boletoLogic.CalcularFechaRegreso(boletoEjecutivo);
                    boletoLogic.AsignarId(boletoEjecutivo);

                    boletosAgregados.Add(boletoEjecutivo);

                    dgvAgregados.DataSource = null;
                    dgvAgregados.DataSource = boletosAgregados;
                    break;
                case "Turista":
                    Turista boletoTurista = new Turista();

                    boletoTurista.TiempoEnDias = dias;
                    boletoTurista.FechaSalida = dateTimePicker1.Value;

                    boletoLogic.CalcularCostoBoleto(boletoTurista);
                    boletoLogic.CalcularFechaRegreso(boletoTurista);
                    boletoLogic.AsignarId(boletoTurista);

                    boletosAgregados.Add(boletoTurista);

                    dgvAgregados.DataSource = null;
                    dgvAgregados.DataSource = boletosAgregados;
                    break;

                default: break;

            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAgregados.DataSource != null && dgvAgregados.SelectedCells.Count > 0)
                {
                    if (!Guid.TryParse(dgvAgregados.SelectedCells[6].Value.ToString(), out Guid id))
                    {
                        throw new Exception("Error: No se pudo obtener el IdBoleto.");
                    }
                    boletosAgregados.RemoveAll(boleto => boleto.IdBoleto == id);
                    dgvAgregados.DataSource = null;
                }
                else
                {
                    throw new Exception("Por favor, seleccione un registro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvAgregados.DataSource = boletosAgregados;
                dgvAgregados.ClearSelection();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                if(boletosAgregados.Count() <= 0)
                {
                    throw new Exception("Para vender, primero debe agregar boletos.");
                }
                boletoLogic.AgregarMultiplesBoletos(boletosAgregados);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvAgregados.DataSource = null;
                LimpiarLista();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvVendidos.DataSource = null;
            dgvVendidos.DataSource = boletoLogic.ListarTodos();
        }

        private void LimpiarLista()
        {
            if (boletosAgregados.Count != 0)
            {
                boletosAgregados.Clear();
            }
        }
    }
}