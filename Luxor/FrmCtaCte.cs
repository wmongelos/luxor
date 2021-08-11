using Luxor.BLL;
using Luxor.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Luxor
{
    public partial class FrmCtaCte : FormBase
    {
        private CtaCteNegocios CtaCteNeg = new CtaCteNegocios();

        private DataTable Table = new DataTable();
        public DataRow Row;

        public FrmCtaCte()
        {
            InitializeComponent();
        }

        private void CalcularSaldo() 
        {
            if (Table.Rows.Count > 0) 
            {
                var SaldoDebe = Table.Compute("SUM(Debe)", "");
                var SaldoHaber = Table.Compute("SUM(Haber)", "");

                var Saldo = Convert.ToDecimal(SaldoDebe) - Convert.ToDecimal(SaldoHaber);

                LblSaldo.Text = String.Format("Saldo: {0}", Convert.ToDecimal(Saldo).ToString("c2"));
            }
        }

        private void FrmCtaCte_Load(object sender, EventArgs e)
        {
            BgWork.RunWorkerAsync();
        }
        private void BgWork_DoWork(object sender, DoWorkEventArgs e)
        {
            Table = CtaCteNeg.GetCtaCte(Convert.ToInt32(Row["Id"]));
        }

        private void BgWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dataGrid.Dgv.DataSource = Table;

            for (int i = 0; i < dataGrid.Dgv.Columns.Count; i++)
                dataGrid.Dgv.Columns[i].Visible = false;

            dataGrid.Dgv.Columns["Fecha"].Visible = true;
            dataGrid.Dgv.Columns["Descripcion"].Visible = true;
            dataGrid.Dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid.Dgv.Columns["Debe"].Visible = true;
            dataGrid.Dgv.Columns["Debe"].DefaultCellStyle.Format = "C2";
            dataGrid.Dgv.Columns["Debe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGrid.Dgv.Columns["Haber"].Visible = true;
            dataGrid.Dgv.Columns["Haber"].DefaultCellStyle.Format = "C2";
            dataGrid.Dgv.Columns["Haber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            LblCliente.Text = String.Format("{0}, {1}", Row["Razon_Social"], Row["Cuit"]);

            CalcularSaldo();
        }

        private void dataGrid_ButtonAction1_Click(object sender, EventArgs e)
        {
            if (dataGrid.Dgv.SelectedRows.Count > 0)
            {
                using (FrmModal Frm = new FrmModal())
                {
                    DataRow[] Dr = Table.Select(String.Format("Id = {0}", dataGrid.Dgv.SelectedRows[0].Cells["Id"].Value));
                    FrmCtaCteMov FrmAbm = new FrmCtaCteMov();
                    FrmAbm.Data = Dr[0];
                    Frm.Form = FrmAbm;

                    if (Frm.ShowDialog() == DialogResult.OK)
                        BgWork.RunWorkerAsync();
                }
                
            }
            
        }
    }
}
