namespace Megadrive_app
{
    partial class fmExtendedTransportInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmExtendedTransportInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTransportExtended = new System.Windows.Forms.DataGridView();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this._Subota_bdDataSet = new Megadrive_app._Subota_bdDataSet();
            this.transportviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_viewTableAdapter = new Megadrive_app._Subota_bdDataSetTableAdapters.Transport_viewTableAdapter();
            this.transportidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportmanufacturedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportenabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.currentpointlocationnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentpointlocationaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransportExtended)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Subota_bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.labelCompanyName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 50);
            this.panel1.TabIndex = 4;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Gabriola", 20F);
            this.labelCompanyName.Location = new System.Drawing.Point(57, 1);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(226, 50);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "Компания \"Мегадрайв\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 50);
            this.panel2.TabIndex = 5;
            // 
            // dataGridViewTransportExtended
            // 
            this.dataGridViewTransportExtended.AutoGenerateColumns = false;
            this.dataGridViewTransportExtended.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransportExtended.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransportExtended.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportidDataGridViewTextBoxColumn,
            this.transportnameDataGridViewTextBoxColumn,
            this.transportcolorDataGridViewTextBoxColumn,
            this.transportmodelDataGridViewTextBoxColumn,
            this.transportnumberDataGridViewTextBoxColumn,
            this.transportmanufacturedateDataGridViewTextBoxColumn,
            this.transportenabledDataGridViewCheckBoxColumn,
            this.currentpointlocationnumberDataGridViewTextBoxColumn,
            this.currentpointlocationaddressDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewTransportExtended.DataSource = this.transportviewBindingSource;
            this.dataGridViewTransportExtended.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransportExtended.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewTransportExtended.Name = "dataGridViewTransportExtended";
            this.dataGridViewTransportExtended.Size = new System.Drawing.Size(1044, 350);
            this.dataGridViewTransportExtended.TabIndex = 6;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Megadrive_app.Properties.Resources.логотип;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 48);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // _Subota_bdDataSet
            // 
            this._Subota_bdDataSet.DataSetName = "_Subota_bdDataSet";
            this._Subota_bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportviewBindingSource
            // 
            this.transportviewBindingSource.DataMember = "Transport_view";
            this.transportviewBindingSource.DataSource = this._Subota_bdDataSet;
            // 
            // transport_viewTableAdapter
            // 
            this.transport_viewTableAdapter.ClearBeforeFill = true;
            // 
            // transportidDataGridViewTextBoxColumn
            // 
            this.transportidDataGridViewTextBoxColumn.DataPropertyName = "transport_id";
            this.transportidDataGridViewTextBoxColumn.HeaderText = "Id";
            this.transportidDataGridViewTextBoxColumn.Name = "transportidDataGridViewTextBoxColumn";
            // 
            // transportnameDataGridViewTextBoxColumn
            // 
            this.transportnameDataGridViewTextBoxColumn.DataPropertyName = "transport_name";
            this.transportnameDataGridViewTextBoxColumn.HeaderText = "Вид";
            this.transportnameDataGridViewTextBoxColumn.Name = "transportnameDataGridViewTextBoxColumn";
            // 
            // transportcolorDataGridViewTextBoxColumn
            // 
            this.transportcolorDataGridViewTextBoxColumn.DataPropertyName = "transport_color";
            this.transportcolorDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.transportcolorDataGridViewTextBoxColumn.Name = "transportcolorDataGridViewTextBoxColumn";
            // 
            // transportmodelDataGridViewTextBoxColumn
            // 
            this.transportmodelDataGridViewTextBoxColumn.DataPropertyName = "transport_model";
            this.transportmodelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.transportmodelDataGridViewTextBoxColumn.Name = "transportmodelDataGridViewTextBoxColumn";
            // 
            // transportnumberDataGridViewTextBoxColumn
            // 
            this.transportnumberDataGridViewTextBoxColumn.DataPropertyName = "transport_number";
            this.transportnumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.transportnumberDataGridViewTextBoxColumn.Name = "transportnumberDataGridViewTextBoxColumn";
            // 
            // transportmanufacturedateDataGridViewTextBoxColumn
            // 
            this.transportmanufacturedateDataGridViewTextBoxColumn.DataPropertyName = "transport_manufacture_date";
            this.transportmanufacturedateDataGridViewTextBoxColumn.HeaderText = "Дата производства";
            this.transportmanufacturedateDataGridViewTextBoxColumn.Name = "transportmanufacturedateDataGridViewTextBoxColumn";
            // 
            // transportenabledDataGridViewCheckBoxColumn
            // 
            this.transportenabledDataGridViewCheckBoxColumn.DataPropertyName = "transport_enabled";
            this.transportenabledDataGridViewCheckBoxColumn.HeaderText = "Доступность для аренды";
            this.transportenabledDataGridViewCheckBoxColumn.Name = "transportenabledDataGridViewCheckBoxColumn";
            // 
            // currentpointlocationnumberDataGridViewTextBoxColumn
            // 
            this.currentpointlocationnumberDataGridViewTextBoxColumn.DataPropertyName = "current_point_location_number";
            this.currentpointlocationnumberDataGridViewTextBoxColumn.HeaderText = "Номер пункта нахождения";
            this.currentpointlocationnumberDataGridViewTextBoxColumn.Name = "currentpointlocationnumberDataGridViewTextBoxColumn";
            // 
            // currentpointlocationaddressDataGridViewTextBoxColumn
            // 
            this.currentpointlocationaddressDataGridViewTextBoxColumn.DataPropertyName = "current_point_location_address";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.HeaderText = "Адрес пункта";
            this.currentpointlocationaddressDataGridViewTextBoxColumn.Name = "currentpointlocationaddressDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Стоимость аренды (руб\\сутки)";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonBack.Font = new System.Drawing.Font("Gabriola", 14F);
            this.buttonBack.Location = new System.Drawing.Point(918, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(114, 41);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // fmExtendedTransportInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.dataGridViewTransportExtended);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmExtendedTransportInformation";
            this.Text = "Extended tInformation";
            this.Load += new System.EventHandler(this.fmExtendedTransportInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransportExtended)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Subota_bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportviewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewTransportExtended;
        private _Subota_bdDataSet _Subota_bdDataSet;
        private System.Windows.Forms.BindingSource transportviewBindingSource;
        private _Subota_bdDataSetTableAdapters.Transport_viewTableAdapter transport_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportmanufacturedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transportenabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpointlocationnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpointlocationaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonBack;
    }
}