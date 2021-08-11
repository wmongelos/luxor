
namespace Luxor.Controls
{
    partial class DataGrid
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGrid));
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.PnFooter = new System.Windows.Forms.Panel();
            this.LbTotal = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PnLine = new System.Windows.Forms.Panel();
            this.PnLineSeparator = new System.Windows.Forms.Panel();
            this.PnAction = new System.Windows.Forms.Panel();
            this.BtnDelete = new Luxor.Controls.DataGridAction();
            this.BtnEdit = new Luxor.Controls.DataGridAction();
            this.BtnAdd = new Luxor.Controls.DataGridAction();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridAction_3 = new Luxor.Controls.DataGridAction();
            this.dataGridAction_2 = new Luxor.Controls.DataGridAction();
            this.dataGridAction_1 = new Luxor.Controls.DataGridAction();
            this.BtnPrinter = new Luxor.Controls.DataGridAction();
            this.BtnExport = new Luxor.Controls.DataGridAction();
            this.TxtSearch = new Luxor.Controls.TextBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.PnFooter.SuspendLayout();
            this.PnAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToOrderColumns = true;
            this.Dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv.BackgroundColor = System.Drawing.Color.White;
            this.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv.ColumnHeadersHeight = 35;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv.EnableHeadersVisualStyles = false;
            this.Dgv.GridColor = System.Drawing.SystemColors.Control;
            this.Dgv.Location = new System.Drawing.Point(3, 54);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.RowTemplate.Height = 35;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(888, 376);
            this.Dgv.TabIndex = 1;
            this.Dgv.VirtualMode = true;
            this.Dgv.DataSourceChanged += new System.EventHandler(this.Dgv_DataSourceChanged);
            // 
            // PnFooter
            // 
            this.PnFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnFooter.Controls.Add(this.LbTotal);
            this.PnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnFooter.Location = new System.Drawing.Point(0, 436);
            this.PnFooter.Name = "PnFooter";
            this.PnFooter.Size = new System.Drawing.Size(894, 38);
            this.PnFooter.TabIndex = 2;
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LbTotal.Location = new System.Drawing.Point(16, 8);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(148, 21);
            this.LbTotal.TabIndex = 0;
            this.LbTotal.Text = "Total de Registros: 0";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PnLine
            // 
            this.PnLine.BackColor = System.Drawing.Color.Gainsboro;
            this.PnLine.Location = new System.Drawing.Point(392, 10);
            this.PnLine.Name = "PnLine";
            this.PnLine.Size = new System.Drawing.Size(1, 30);
            this.PnLine.TabIndex = 7;
            // 
            // PnLineSeparator
            // 
            this.PnLineSeparator.BackColor = System.Drawing.Color.Gainsboro;
            this.PnLineSeparator.Location = new System.Drawing.Point(558, 10);
            this.PnLineSeparator.Name = "PnLineSeparator";
            this.PnLineSeparator.Size = new System.Drawing.Size(1, 30);
            this.PnLineSeparator.TabIndex = 11;
            // 
            // PnAction
            // 
            this.PnAction.Controls.Add(this.BtnDelete);
            this.PnAction.Controls.Add(this.BtnEdit);
            this.PnAction.Controls.Add(this.BtnAdd);
            this.PnAction.Location = new System.Drawing.Point(398, -1);
            this.PnAction.Name = "PnAction";
            this.PnAction.Size = new System.Drawing.Size(152, 53);
            this.PnAction.TabIndex = 12;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Active = System.Drawing.Color.Tomato;
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Icon = global::Luxor.Properties.Resources.icons8_delete_document_32;
            this.BtnDelete.Location = new System.Drawing.Point(103, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(45, 45);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Active = System.Drawing.SystemColors.Highlight;
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Icon = global::Luxor.Properties.Resources.icons8_edit_property_32;
            this.BtnEdit.Location = new System.Drawing.Point(52, 4);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(45, 45);
            this.BtnEdit.TabIndex = 12;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Active = System.Drawing.SystemColors.Highlight;
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Icon = global::Luxor.Properties.Resources.icons8_add_property_32;
            this.BtnAdd.Location = new System.Drawing.Point(1, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(45, 45);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Luxor.Properties.Resources.icons8_search_in_list_32;
            this.pictureBox1.Location = new System.Drawing.Point(352, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridAction_3
            // 
            this.dataGridAction_3.Active = System.Drawing.SystemColors.Highlight;
            this.dataGridAction_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridAction_3.Icon = global::Luxor.Properties.Resources.icons8_delete_document_32;
            this.dataGridAction_3.Location = new System.Drawing.Point(667, 4);
            this.dataGridAction_3.Name = "dataGridAction_3";
            this.dataGridAction_3.Size = new System.Drawing.Size(45, 45);
            this.dataGridAction_3.TabIndex = 16;
            this.dataGridAction_3.Visible = false;
            this.dataGridAction_3.Click += new System.EventHandler(this.DataGridAction_3_Click);
            // 
            // dataGridAction_2
            // 
            this.dataGridAction_2.Active = System.Drawing.SystemColors.Highlight;
            this.dataGridAction_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridAction_2.Icon = global::Luxor.Properties.Resources.icons8_delete_document_32;
            this.dataGridAction_2.Location = new System.Drawing.Point(616, 4);
            this.dataGridAction_2.Name = "dataGridAction_2";
            this.dataGridAction_2.Size = new System.Drawing.Size(45, 45);
            this.dataGridAction_2.TabIndex = 15;
            this.dataGridAction_2.Visible = false;
            this.dataGridAction_2.Click += new System.EventHandler(this.DataGridAction_2_Click);
            // 
            // dataGridAction_1
            // 
            this.dataGridAction_1.Active = System.Drawing.SystemColors.Highlight;
            this.dataGridAction_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridAction_1.Icon = global::Luxor.Properties.Resources.icons8_delete_document_32;
            this.dataGridAction_1.Location = new System.Drawing.Point(565, 4);
            this.dataGridAction_1.Name = "dataGridAction_1";
            this.dataGridAction_1.Size = new System.Drawing.Size(45, 45);
            this.dataGridAction_1.TabIndex = 14;
            this.dataGridAction_1.Visible = false;
            this.dataGridAction_1.Click += new System.EventHandler(this.DataGridAction_1_Click);
            // 
            // BtnPrinter
            // 
            this.BtnPrinter.Active = System.Drawing.SystemColors.Highlight;
            this.BtnPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrinter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrinter.Icon = global::Luxor.Properties.Resources.icons8_print_32;
            this.BtnPrinter.Location = new System.Drawing.Point(795, 4);
            this.BtnPrinter.Name = "BtnPrinter";
            this.BtnPrinter.Size = new System.Drawing.Size(45, 45);
            this.BtnPrinter.TabIndex = 5;
            this.BtnPrinter.Visible = false;
            // 
            // BtnExport
            // 
            this.BtnExport.Active = System.Drawing.SystemColors.Highlight;
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExport.Icon = global::Luxor.Properties.Resources.icons8_microsoft_excel_32;
            this.BtnExport.Location = new System.Drawing.Point(846, 4);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(45, 45);
            this.BtnExport.TabIndex = 4;
            this.BtnExport.Visible = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtSearch.BorderColor = System.Drawing.Color.Gainsboro;
            this.TxtSearch.Location = new System.Drawing.Point(4, 10);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Numeric = false;
            this.TxtSearch.Padding = new System.Windows.Forms.Padding(1);
            this.TxtSearch.Password = false;
            this.TxtSearch.Size = new System.Drawing.Size(341, 30);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.TextChangeEvent += new System.EventHandler(this.TxtSearch_TextChangeEvent);
            // 
            // DataGrid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridAction_3);
            this.Controls.Add(this.dataGridAction_2);
            this.Controls.Add(this.dataGridAction_1);
            this.Controls.Add(this.PnAction);
            this.Controls.Add(this.PnLineSeparator);
            this.Controls.Add(this.PnLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnPrinter);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.PnFooter);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.Dgv);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "DataGrid";
            this.Size = new System.Drawing.Size(894, 474);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.PnFooter.ResumeLayout(false);
            this.PnFooter.PerformLayout();
            this.PnAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Dgv;
        private TextBoxAdv TxtSearch;
        private System.Windows.Forms.Panel PnFooter;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridAction BtnExport;
        private DataGridAction BtnPrinter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnLine;
        private System.Windows.Forms.Panel PnLineSeparator;
        private System.Windows.Forms.Panel PnAction;
        private DataGridAction BtnDelete;
        private DataGridAction BtnEdit;
        private DataGridAction BtnAdd;
        private DataGridAction dataGridAction_1;
        private DataGridAction dataGridAction_2;
        private DataGridAction dataGridAction_3;
    }
}
