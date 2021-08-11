using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Luxor.Controls
{
    public partial class DataGrid : UserControl
    {
        public DataGrid()
        {
            InitializeComponent();

            Dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);  
        }

        public Boolean ShowPrinter 
        {
            get { return BtnPrinter.Visible; }
            set { BtnPrinter.Visible = value; }
        }
        public Boolean ShowExport
        {
            get { return BtnExport.Visible; }
            set { BtnExport.Visible = value; }
        }
        public Boolean ShowAction
        {
            get { return PnAction.Visible; }
            set { PnAction.Visible = value; PnLineSeparator.Visible = PnAction.Visible; }
        }

        public Boolean CustomAction_1
        {
            get { return dataGridAction_1.Visible; }
            set { dataGridAction_1.Visible = value; }
        }

        public Image IconCustonAction_1 
        {
            get { return dataGridAction_1.Icon; }
            set { dataGridAction_1.Icon = value; }
        }

        public Boolean CustomAction_2
        {
            get { return dataGridAction_2.Visible; }
            set { dataGridAction_2.Visible = value; }
        }

        public Image IconCustonAction_2
        {
            get { return dataGridAction_2.Icon; }
            set { dataGridAction_2.Icon = value; }
        }

        public Boolean CustomAction_3
        {
            get { return dataGridAction_3.Visible; }
            set { dataGridAction_3.Visible = value; }
        }

        public Image IconCustonAction_3
        {
            get { return dataGridAction_3.Icon; }
            set { dataGridAction_3.Icon = value; }
        }

        protected override void OnLoad(EventArgs e)
        {
            TxtSearch.Focus();
            base.OnLoad(e);
        }

        private void TxtSearch_TextChangeEvent(object sender, EventArgs e)
        {
            String StringRowFilter = "";
            BindingSource bs = new BindingSource();
            bs.DataSource = Dgv.DataSource;
            DataTable dat = (DataTable)(bs.DataSource);

            foreach (DataGridViewColumn item in Dgv.Columns)
            { 
                if(item.Name != "img")
                { 
                    if (item.Visible == true)
                    {
                        switch (item.ValueType.Name)
                        {
                            case "Int32":
                            case "Decimal":
                            case "DateTime":
                                StringRowFilter += String.Format("Convert({0}, System.String) Like '%{1}%' OR ", item.DataPropertyName, TxtSearch.Text);
                                break;
                            case "String":
                                StringRowFilter += String.Format("{0} Like '%{1}%' OR ", item.DataPropertyName, TxtSearch.Text);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            dat.DefaultView.RowFilter = StringRowFilter.Substring(0, StringRowFilter.Length - 4);
        }

        private void Dgv_DataSourceChanged(object sender, EventArgs e)
        {
            LbTotal.Text = String.Format("Total de Registros: {0}", Dgv.Rows.Count.ToString());
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            Tools tools = new Tools();
            tools.ExportToExcel(Dgv);
        }

        [Description("Click Button Add")]
        public event EventHandler ButtonAdd_Click;
        protected void ButtonAdd_Clicked(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (ButtonAdd_Click != null)
                ButtonAdd_Click(this, e);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ButtonAdd_Clicked(this, e);
        }

        [Description("Click Button Edit")]
        public event EventHandler ButtonEdit_Click;
        protected void ButtonEdit_Clicked(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (ButtonEdit_Click != null)
                ButtonEdit_Click(this, e);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ButtonEdit_Clicked(this, e);
        }

        [Description("Click Button Delete")]
        public event EventHandler ButtonDelete_Click;
        protected void ButtonDelete_Clicked(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (ButtonDelete_Click != null)
                ButtonDelete_Click(this, e);
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ButtonDelete_Clicked(this, e);
        }


        [Description("Click Button Action 1")]
        public event EventHandler ButtonAction1_Click;
        protected void ButtonAction1_Clicked(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (ButtonAction1_Click != null)
                ButtonAction1_Click(this, e);
        }

        [Description("Click Button Action 2")]
        public event EventHandler ButtonAction2_Click;
        protected void ButtonAction2_Clicked(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (ButtonAction2_Click != null)
                ButtonAction2_Click(this, e);
        }

        [Description("Click Button Action 3")]
        public event EventHandler ButtonAction3_Click;
        protected void ButtonAction3_Clicked(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (ButtonAction3_Click != null)
                ButtonAction3_Click(this, e);
        }

        private void DataGridAction_1_Click(object sender, EventArgs e)
        {
            ButtonAction1_Clicked(this, e);
        }

        private void DataGridAction_2_Click(object sender, EventArgs e)
        {
            ButtonAction2_Clicked(this, e);
        }

        private void DataGridAction_3_Click(object sender, EventArgs e)
        {
            ButtonAction3_Clicked(this, e);
        }

    }
}
