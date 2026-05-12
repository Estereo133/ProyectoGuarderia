using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoGuarderia
{
    public partial class Form_Pagos : Form
    {
        private const decimal CUOTA = 500m;

        public Form_Pagos()
        {
            InitializeComponent();

            this.dataGridView1.DataError += DataGridView1_DataError;

            this.dataGridView1.CellFormatting +=
            dataGridView1_CellFormatting;
        }

        private void Form_Pagos_Load(object sender, EventArgs e)
        {
            InicializarFiltros();

            CargarPagos();

            dataGridView1.RowTemplate.Height = 30;

            dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.ReadOnly = true;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.BackgroundColor = Color.White;
        }

        private void InicializarFiltros()
        {
            cbxTipoPago.Items.Clear();

            cbxTipoPago.Items.AddRange(
            new object[]
            {
                "Todos",
                "Efectivo",
                "Tarjeta"
            });

            cbxTipoPago.SelectedIndex = 0;

            cboEstado.Items.Clear();

            cboEstado.Items.AddRange(
            new object[]
            {
                "Todos",
                "Pagado",
                "Abonado",
                "Pendiente"
            });

            cboEstado.SelectedIndex = 0;
        }

        // BUSCAR
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarPagos();
        }

        // FILTRO TIPO PAGO
        private void cbxTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPagos();
        }

        // GRID
        private void dataGridView1_CellContentClick(object sender,
        DataGridViewCellEventArgs e)
        {

        }

        // CARGAR DATOS
        private void CargarPagos()
        {
            try
            {
                string nombreFiltro =
                "%" + (txtBuscar.Text ?? "") + "%";

                string estadoFiltro =
                cboEstado.Text ?? "Todos";

                string tipoFiltro =
                cbxTipoPago.Text ?? "Todos";

                using (MySqlConnection conn =
                Conexion.conectar())
                {
                    conn.Open();

                    string query = @"

SELECT 
    t.IdNino,
    t.Nombre AS Nino,
    t.TotalPagado,
    t.Saldo,
    t.Estado

FROM
(
    SELECT 
        n.IdNino,
        n.Nombre,

        COALESCE(
        SUM(
        CASE
            WHEN p.Concepto IN ('Pago','Abono')
            THEN p.Monto
            ELSE 0
        END),0) AS TotalPagado,

        @cuota -
        COALESCE(
        SUM(
        CASE
            WHEN p.Concepto IN ('Pago','Abono')
            THEN p.Monto
            ELSE 0
        END),0) AS Saldo,

        CASE

            WHEN COALESCE(
            SUM(
            CASE
                WHEN p.Concepto IN ('Pago','Abono')
                THEN p.Monto
                ELSE 0
            END),0) >= @cuota

            THEN 'Pagado'

            WHEN COALESCE(
            SUM(
            CASE
                WHEN p.Concepto IN ('Pago','Abono')
                THEN p.Monto
                ELSE 0
            END),0) > 0

            THEN 'Abonado'

            ELSE 'Pendiente'

        END AS Estado,

        SUM(
        CASE
            WHEN p.TipoPago = @tipo
            THEN 1
            ELSE 0
        END) AS TipoCount

    FROM nino n

    LEFT JOIN pagos p
    ON p.IdNino = n.IdNino

    WHERE n.Nombre LIKE @nombre

    GROUP BY n.IdNino, n.Nombre

) t

WHERE (@estado = 'Todos'
OR t.Estado = @estado)

AND (@tipo = 'Todos'
OR t.TipoCount > 0)

ORDER BY t.Nombre;
";

                    using (MySqlCommand cmd =
                    new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                        "@cuota", CUOTA);

                        cmd.Parameters.AddWithValue(
                        "@nombre", nombreFiltro);

                        cmd.Parameters.AddWithValue(
                        "@estado", estadoFiltro);

                        cmd.Parameters.AddWithValue(
                        "@tipo", tipoFiltro);

                        MySqlDataAdapter da =
                        new MySqlDataAdapter(cmd);

                        DataTable dt = new DataTable();

                        da.Fill(dt);

                        dataGridView1.AutoGenerateColumns = true;

                        dataGridView1.DataSource = dt;

                        ConfigureGridColumns();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // CONFIGURACIÓN GRID
        private void ConfigureGridColumns()
        {
            dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.ClearSelection();

            if (dataGridView1.Columns.Contains("Saldo"))
            {
                dataGridView1.Columns["Saldo"]
                .DefaultCellStyle.Format = "N2";

                dataGridView1.Columns["Saldo"]
                .DefaultCellStyle.NullValue = "0.00";
            }

            if (dataGridView1.Columns.Contains("TotalPagado"))
            {
                dataGridView1.Columns["TotalPagado"]
                .DefaultCellStyle.Format = "N2";
            }

            // OCULTAR ID
            if (dataGridView1.Columns.Contains("IdNino"))
            {
                dataGridView1.Columns["IdNino"].Visible = false;
            }

            // ESTILO
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =
            Color.SteelBlue;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.Font =
            new Font("Segoe UI", 10);

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
            Color.FromArgb(245, 245, 245);

            dataGridView1.DefaultCellStyle.SelectionBackColor =
            Color.LightSkyBlue;

            dataGridView1.DefaultCellStyle.SelectionForeColor =
            Color.Black;

            dataGridView1.BorderStyle = BorderStyle.None;

            dataGridView1.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal;

            dataGridView1.RowHeadersVisible = false;
        }

        // COLORES AUTOMÁTICOS
        private void dataGridView1_CellFormatting(object sender,
        DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    string estado = e.Value.ToString();

                    if (estado == "Pendiente")
                    {
                        e.CellStyle.ForeColor = Color.Red;

                        e.CellStyle.Font =
                        new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                    else if (estado == "Pagado")
                    {
                        e.CellStyle.ForeColor = Color.Green;

                        e.CellStyle.Font =
                        new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                    else if (estado == "Abonado")
                    {
                        e.CellStyle.ForeColor = Color.DarkOrange;

                        e.CellStyle.Font =
                        new Font("Segoe UI", 9, FontStyle.Bold);
                    }
                }
            }
        }

        // EVITAR ERRORES
        private void DataGridView1_DataError(object sender,
        DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
        }

        // OBTENER ID
        private int GetSelectedIdNino()
        {
            if (dataGridView1.SelectedRows != null &&
                dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                return ReadIdNinoFromRow(row);
            }

            if (dataGridView1.CurrentRow != null)
            {
                return ReadIdNinoFromRow(
                dataGridView1.CurrentRow);
            }

            return 0;
        }

        private int ReadIdNinoFromRow(DataGridViewRow row)
        {
            if (row == null)
                return 0;

            if (dataGridView1.Columns.Contains("IdNino"))
            {
                var val = row.Cells["IdNino"].Value;

                if (val != null &&
                    !Convert.IsDBNull(val) &&
                    int.TryParse(val.ToString(), out int id))

                    return id;
            }

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (string.Equals(
                    col.DataPropertyName,
                    "IdNino",
                    StringComparison.OrdinalIgnoreCase)

                    ||

                    string.Equals(
                    col.Name,
                    "IdNino",
                    StringComparison.OrdinalIgnoreCase))
                {
                    var val = row.Cells[col.Index].Value;

                    if (val != null &&
                        !Convert.IsDBNull(val) &&
                        int.TryParse(val.ToString(), out int id))

                        return id;
                }
            }

            return 0;
        }

        // REGISTRAR PAGO
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedId = GetSelectedIdNino();

            if (selectedId == 0)
            {
                MessageBox.Show(
                "Selecciona un niño primero",
                "Atención",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            string metodo = PedirMetodoPago();

            if (metodo == null)
                return;

            try
            {
                using (MySqlConnection conn =
                Conexion.conectar())
                {
                    conn.Open();

                    string query = @"

INSERT INTO pagos
(IdNino, FechaPago, Monto, Concepto, TipoPago)

VALUES
(@IdNino, @Fecha, @Monto, 'Pago', @TipoPago)
";

                    using (MySqlCommand cmd =
                    new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                        "@IdNino", selectedId);

                        cmd.Parameters.AddWithValue(
                        "@Fecha", DateTime.Now);

                        cmd.Parameters.AddWithValue(
                        "@Monto", 500m);

                        cmd.Parameters.AddWithValue(
                        "@TipoPago", metodo);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                "Pago registrado",
                "OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                dataGridView1.ClearSelection();

                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        // REGISTRAR ABONO
        private void button2_Click(object sender, EventArgs e)
        {
            int selectedId = GetSelectedIdNino();

            if (selectedId == 0)
            {
                MessageBox.Show(
                "Selecciona un niño primero",
                "Atención",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                return;
            }

            string metodo = PedirMetodoPago();

            if (metodo == null)
                return;

            try
            {
                using (MySqlConnection conn =
                Conexion.conectar())
                {
                    conn.Open();

                    string query = @"

INSERT INTO pagos
(IdNino, FechaPago, Monto, Concepto, TipoPago)

VALUES
(@IdNino, @Fecha, @Monto, 'Abono', @TipoPago)
";

                    using (MySqlCommand cmd =
                    new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                        "@IdNino", selectedId);

                        cmd.Parameters.AddWithValue(
                        "@Fecha", DateTime.Now);

                        cmd.Parameters.AddWithValue(
                        "@Monto", 200m);

                        cmd.Parameters.AddWithValue(
                        "@TipoPago", metodo);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                "Abono registrado",
                "OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                dataGridView1.ClearSelection();

                CargarPagos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        // MÉTODO DE PAGO
        private string PedirMetodoPago()
        {
            var result = MessageBox.Show(

            "Seleccione método de pago:\n" +
            "SÍ = Efectivo\n" +
            "NO = Tarjeta\n" +
            "Cancelar = Anular",

            "Método de pago",

            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
                return null;

            return result == DialogResult.Yes
                ? "Efectivo"
                : "Tarjeta";
        }

        // SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPagos();

            txtBuscar.Focus();
        }

        // FILTRO ESTADO
        private void cboEstado_SelectedIndexChanged(object sender,
        EventArgs e)
        {
            CargarPagos();
        }
    }
}