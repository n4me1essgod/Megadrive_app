namespace Megadrive_app
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTransport = new System.Windows.Forms.DataGridView();
            this._Subota_bdDataSet = new Megadrive_app._Subota_bdDataSet();
            this.transportviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_viewTableAdapter = new Megadrive_app._Subota_bdDataSetTableAdapters.Transport_viewTableAdapter();
            this.transportnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportcolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportenabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._Subota_bdDataSet1 = new Megadrive_app._Subota_bdDataSet1();
            this.transportviewcutedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transport_view_cutedTableAdapter = new Megadrive_app._Subota_bdDataSet1TableAdapters.Transport_view_cutedTableAdapter();
            this.buttonExtendedInformation = new System.Windows.Forms.Button();
            this.textBoxFindByNumber = new System.Windows.Forms.TextBox();
            this.labelFindByNumber = new System.Windows.Forms.Label();
            this.textBoxFindByModel = new System.Windows.Forms.TextBox();
            this.labelFindByModel = new System.Windows.Forms.Label();
            this.labelFilterAviability = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonEditGrid = new System.Windows.Forms.Button();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Subota_bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Subota_bdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportviewcutedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelFilterAviability);
            this.panel1.Controls.Add(this.textBoxFindByModel);
            this.panel1.Controls.Add(this.labelFindByModel);
            this.panel1.Controls.Add(this.textBoxFindByNumber);
            this.panel1.Controls.Add(this.labelFindByNumber);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.labelCompanyName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 130);
            this.panel1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.buttonAddUser);
            this.panel2.Controls.Add(this.buttonHistory);
            this.panel2.Controls.Add(this.buttonBooking);
            this.panel2.Controls.Add(this.buttonEditGrid);
            this.panel2.Controls.Add(this.buttonExtendedInformation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 50);
            this.panel2.TabIndex = 3;
            // 
            // dataGridViewTransport
            // 
            this.dataGridViewTransport.AutoGenerateColumns = false;
            this.dataGridViewTransport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transportnameDataGridViewTextBoxColumn,
            this.transportcolorDataGridViewTextBoxColumn,
            this.transportmodelDataGridViewTextBoxColumn,
            this.transportnumberDataGridViewTextBoxColumn,
            this.transportenabledDataGridViewCheckBoxColumn});
            this.dataGridViewTransport.DataSource = this.transportviewcutedBindingSource;
            this.dataGridViewTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransport.Location = new System.Drawing.Point(0, 130);
            this.dataGridViewTransport.Name = "dataGridViewTransport";
            this.dataGridViewTransport.Size = new System.Drawing.Size(766, 347);
            this.dataGridViewTransport.TabIndex = 4;
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
            // transportenabledDataGridViewCheckBoxColumn
            // 
            this.transportenabledDataGridViewCheckBoxColumn.DataPropertyName = "transport_enabled";
            this.transportenabledDataGridViewCheckBoxColumn.HeaderText = "Доступность к аренде";
            this.transportenabledDataGridViewCheckBoxColumn.Name = "transportenabledDataGridViewCheckBoxColumn";
            // 
            // _Subota_bdDataSet1
            // 
            this._Subota_bdDataSet1.DataSetName = "_Subota_bdDataSet1";
            this._Subota_bdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportviewcutedBindingSource
            // 
            this.transportviewcutedBindingSource.DataMember = "Transport_view_cuted";
            this.transportviewcutedBindingSource.DataSource = this._Subota_bdDataSet1;
            // 
            // transport_view_cutedTableAdapter
            // 
            this.transport_view_cutedTableAdapter.ClearBeforeFill = true;
            // 
            // buttonExtendedInformation
            // 
            this.buttonExtendedInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonExtendedInformation.Font = new System.Drawing.Font("Gabriola", 14F);
            this.buttonExtendedInformation.Location = new System.Drawing.Point(649, 6);
            this.buttonExtendedInformation.Name = "buttonExtendedInformation";
            this.buttonExtendedInformation.Size = new System.Drawing.Size(114, 41);
            this.buttonExtendedInformation.TabIndex = 0;
            this.buttonExtendedInformation.Text = "Подробно";
            this.buttonExtendedInformation.UseVisualStyleBackColor = false;
            this.buttonExtendedInformation.Click += new System.EventHandler(this.buttonExtendedInformation_Click);
            // 
            // textBoxFindByNumber
            // 
            this.textBoxFindByNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.textBoxFindByNumber.Font = new System.Drawing.Font("Gabriola", 10F);
            this.textBoxFindByNumber.Location = new System.Drawing.Point(12, 91);
            this.textBoxFindByNumber.Name = "textBoxFindByNumber";
            this.textBoxFindByNumber.Size = new System.Drawing.Size(146, 30);
            this.textBoxFindByNumber.TabIndex = 5;
            // 
            // labelFindByNumber
            // 
            this.labelFindByNumber.AutoSize = true;
            this.labelFindByNumber.Font = new System.Drawing.Font("Gabriola", 20F);
            this.labelFindByNumber.Location = new System.Drawing.Point(3, 51);
            this.labelFindByNumber.Name = "labelFindByNumber";
            this.labelFindByNumber.Size = new System.Drawing.Size(170, 50);
            this.labelFindByNumber.TabIndex = 4;
            this.labelFindByNumber.Text = "Поиск по номеру";
            // 
            // textBoxFindByModel
            // 
            this.textBoxFindByModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.textBoxFindByModel.Font = new System.Drawing.Font("Gabriola", 10F);
            this.textBoxFindByModel.Location = new System.Drawing.Point(188, 91);
            this.textBoxFindByModel.Name = "textBoxFindByModel";
            this.textBoxFindByModel.Size = new System.Drawing.Size(146, 30);
            this.textBoxFindByModel.TabIndex = 7;
            // 
            // labelFindByModel
            // 
            this.labelFindByModel.AutoSize = true;
            this.labelFindByModel.Font = new System.Drawing.Font("Gabriola", 20F);
            this.labelFindByModel.Location = new System.Drawing.Point(179, 51);
            this.labelFindByModel.Name = "labelFindByModel";
            this.labelFindByModel.Size = new System.Drawing.Size(170, 50);
            this.labelFindByModel.TabIndex = 6;
            this.labelFindByModel.Text = "Поиск по модели";
            // 
            // labelFilterAviability
            // 
            this.labelFilterAviability.AutoSize = true;
            this.labelFilterAviability.Font = new System.Drawing.Font("Gabriola", 20F);
            this.labelFilterAviability.Location = new System.Drawing.Point(355, 51);
            this.labelFilterAviability.Name = "labelFilterAviability";
            this.labelFilterAviability.Size = new System.Drawing.Size(241, 50);
            this.labelFilterAviability.TabIndex = 8;
            this.labelFilterAviability.Text = "Фильтр по доступности";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.comboBox1.Font = new System.Drawing.Font("Gabriola", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все",
            "Доступные для бронирования",
            "Недоступные"});
            this.comboBox1.Location = new System.Drawing.Point(364, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 31);
            this.comboBox1.TabIndex = 9;
            // 
            // buttonEditGrid
            // 
            this.buttonEditGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonEditGrid.Font = new System.Drawing.Font("Gabriola", 14F);
            this.buttonEditGrid.Location = new System.Drawing.Point(3, 6);
            this.buttonEditGrid.Name = "buttonEditGrid";
            this.buttonEditGrid.Size = new System.Drawing.Size(173, 41);
            this.buttonEditGrid.TabIndex = 5;
            this.buttonEditGrid.Text = "Редактировать запись";
            this.buttonEditGrid.UseVisualStyleBackColor = false;
            this.buttonEditGrid.Visible = false;
            this.buttonEditGrid.Click += new System.EventHandler(this.buttonEditGrid_Click);
            // 
            // buttonBooking
            // 
            this.buttonBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonBooking.Font = new System.Drawing.Font("Gabriola", 14F);
            this.buttonBooking.Location = new System.Drawing.Point(529, 6);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(114, 41);
            this.buttonBooking.TabIndex = 6;
            this.buttonBooking.Text = "Бронирование";
            this.buttonBooking.UseVisualStyleBackColor = false;
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonHistory.Font = new System.Drawing.Font("Gabriola", 14F);
            this.buttonHistory.Location = new System.Drawing.Point(182, 6);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(114, 41);
            this.buttonHistory.TabIndex = 7;
            this.buttonHistory.Text = "История";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Visible = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.buttonAddUser.Font = new System.Drawing.Font("Gabriola", 14F);
            this.buttonAddUser.Location = new System.Drawing.Point(302, 6);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(182, 41);
            this.buttonAddUser.TabIndex = 9;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Visible = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
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
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 527);
            this.Controls.Add(this.dataGridViewTransport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Subota_bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Subota_bdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportviewcutedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewTransport;
        private _Subota_bdDataSet _Subota_bdDataSet;
        private System.Windows.Forms.BindingSource transportviewBindingSource;
        private _Subota_bdDataSetTableAdapters.Transport_viewTableAdapter transport_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportcolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transportenabledDataGridViewCheckBoxColumn;
        private _Subota_bdDataSet1 _Subota_bdDataSet1;
        private System.Windows.Forms.BindingSource transportviewcutedBindingSource;
        private _Subota_bdDataSet1TableAdapters.Transport_view_cutedTableAdapter transport_view_cutedTableAdapter;
        private System.Windows.Forms.Button buttonExtendedInformation;
        private System.Windows.Forms.TextBox textBoxFindByNumber;
        private System.Windows.Forms.Label labelFindByNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFilterAviability;
        private System.Windows.Forms.TextBox textBoxFindByModel;
        private System.Windows.Forms.Label labelFindByModel;
        private System.Windows.Forms.Button buttonEditGrid;
        private System.Windows.Forms.Button buttonBooking;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonAddUser;
    }
}