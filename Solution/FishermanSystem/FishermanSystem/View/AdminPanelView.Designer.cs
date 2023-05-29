namespace FishermanSystem.View
{
    partial class AdminPanelView
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.registeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hobbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fishermanSystemDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fishermanSystemDBDataSet = new FishermanSystem.FishermanSystemDBDataSet();
            this.userTableAdapter = new FishermanSystem.FishermanSystemDBDataSetTableAdapters.UserTableAdapter();
            this.dgvBoats = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boat_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engine_fuel_consumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFishingInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_fishing_session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_fished_kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration_of_fishing_session_min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fishingSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boatTableAdapter = new FishermanSystem.FishermanSystemDBDataSetTableAdapters.BoatTableAdapter();
            this.fishing_SessionTableAdapter = new FishermanSystem.FishermanSystemDBDataSetTableAdapters.Fishing_SessionTableAdapter();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishermanSystemDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishermanSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingSessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registeridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.hobbyDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.userBindingSource;
            this.dgvUsers.Location = new System.Drawing.Point(12, 37);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(429, 310);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // registeridDataGridViewTextBoxColumn
            // 
            this.registeridDataGridViewTextBoxColumn.DataPropertyName = "register_id";
            this.registeridDataGridViewTextBoxColumn.HeaderText = "register_id";
            this.registeridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registeridDataGridViewTextBoxColumn.Name = "registeridDataGridViewTextBoxColumn";
            this.registeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.registeridDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // hobbyDataGridViewTextBoxColumn
            // 
            this.hobbyDataGridViewTextBoxColumn.DataPropertyName = "hobby";
            this.hobbyDataGridViewTextBoxColumn.HeaderText = "hobby";
            this.hobbyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hobbyDataGridViewTextBoxColumn.Name = "hobbyDataGridViewTextBoxColumn";
            this.hobbyDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.fishermanSystemDBDataSetBindingSource;
            // 
            // fishermanSystemDBDataSetBindingSource
            // 
            this.fishermanSystemDBDataSetBindingSource.DataSource = this.fishermanSystemDBDataSet;
            this.fishermanSystemDBDataSetBindingSource.Position = 0;
            // 
            // fishermanSystemDBDataSet
            // 
            this.fishermanSystemDBDataSet.DataSetName = "FishermanSystemDBDataSet";
            this.fishermanSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // dgvBoats
            // 
            this.dgvBoats.AutoGenerateColumns = false;
            this.dgvBoats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.boat_name,
            this.expire_date,
            this.engine_fuel_consumption});
            this.dgvBoats.DataSource = this.boatBindingSource1;
            this.dgvBoats.Location = new System.Drawing.Point(502, 37);
            this.dgvBoats.Name = "dgvBoats";
            this.dgvBoats.RowHeadersWidth = 51;
            this.dgvBoats.RowTemplate.Height = 24;
            this.dgvBoats.Size = new System.Drawing.Size(418, 310);
            this.dgvBoats.TabIndex = 1;
            this.dgvBoats.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoats_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "register_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "register_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // boat_name
            // 
            this.boat_name.DataPropertyName = "boat_name";
            this.boat_name.HeaderText = "boat_name";
            this.boat_name.MinimumWidth = 6;
            this.boat_name.Name = "boat_name";
            this.boat_name.Width = 125;
            // 
            // expire_date
            // 
            this.expire_date.DataPropertyName = "expire_date";
            this.expire_date.HeaderText = "expire_date";
            this.expire_date.MinimumWidth = 6;
            this.expire_date.Name = "expire_date";
            this.expire_date.Width = 125;
            // 
            // engine_fuel_consumption
            // 
            this.engine_fuel_consumption.DataPropertyName = "engine_fuel_consumption";
            this.engine_fuel_consumption.HeaderText = "engine_fuel_consumption";
            this.engine_fuel_consumption.MinimumWidth = 6;
            this.engine_fuel_consumption.Name = "engine_fuel_consumption";
            this.engine_fuel_consumption.Width = 125;
            // 
            // boatBindingSource1
            // 
            this.boatBindingSource1.DataMember = "Boat";
            this.boatBindingSource1.DataSource = this.fishermanSystemDBDataSetBindingSource;
            // 
            // dgvFishingInfo
            // 
            this.dgvFishingInfo.AutoGenerateColumns = false;
            this.dgvFishingInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFishingInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.date_of_fishing_session,
            this.amount_fished_kg,
            this.duration_of_fishing_session_min});
            this.dgvFishingInfo.DataSource = this.fishingSessionBindingSource;
            this.dgvFishingInfo.Location = new System.Drawing.Point(976, 37);
            this.dgvFishingInfo.Name = "dgvFishingInfo";
            this.dgvFishingInfo.RowHeadersWidth = 51;
            this.dgvFishingInfo.RowTemplate.Height = 24;
            this.dgvFishingInfo.Size = new System.Drawing.Size(448, 310);
            this.dgvFishingInfo.TabIndex = 2;
            this.dgvFishingInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFishingInfo_CellClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "register_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "register_id";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // date_of_fishing_session
            // 
            this.date_of_fishing_session.DataPropertyName = "date_of_fishing_session";
            this.date_of_fishing_session.HeaderText = "date_of_fishing_session";
            this.date_of_fishing_session.MinimumWidth = 6;
            this.date_of_fishing_session.Name = "date_of_fishing_session";
            this.date_of_fishing_session.Width = 125;
            // 
            // amount_fished_kg
            // 
            this.amount_fished_kg.DataPropertyName = "amount_fished_kg";
            this.amount_fished_kg.HeaderText = "amount_fished_kg";
            this.amount_fished_kg.MinimumWidth = 6;
            this.amount_fished_kg.Name = "amount_fished_kg";
            this.amount_fished_kg.Width = 125;
            // 
            // duration_of_fishing_session_min
            // 
            this.duration_of_fishing_session_min.DataPropertyName = "duration_of_fishing_session_min";
            this.duration_of_fishing_session_min.HeaderText = "duration_of_fishing_session_min";
            this.duration_of_fishing_session_min.MinimumWidth = 6;
            this.duration_of_fishing_session_min.Name = "duration_of_fishing_session_min";
            this.duration_of_fishing_session_min.Width = 125;
            // 
            // fishingSessionBindingSource
            // 
            this.fishingSessionBindingSource.DataMember = "Fishing_Session";
            this.fishingSessionBindingSource.DataSource = this.fishermanSystemDBDataSetBindingSource;
            // 
            // boatBindingSource
            // 
            this.boatBindingSource.DataMember = "Boat";
            this.boatBindingSource.DataSource = this.fishermanSystemDBDataSetBindingSource;
            // 
            // boatTableAdapter
            // 
            this.boatTableAdapter.ClearBeforeFill = true;
            // 
            // fishing_SessionTableAdapter
            // 
            this.fishing_SessionTableAdapter.ClearBeforeFill = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 413);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(278, 39);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Selected user ID:";
            // 
            // AdminPanelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 638);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvFishingInfo);
            this.Controls.Add(this.dgvBoats);
            this.Controls.Add(this.dgvUsers);
            this.Name = "AdminPanelView";
            this.Text = "AdminPanelView";
            this.Load += new System.EventHandler(this.AdminPanelView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishermanSystemDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishermanSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishingInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishingSessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.BindingSource fishermanSystemDBDataSetBindingSource;
        private FishermanSystemDBDataSet fishermanSystemDBDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private FishermanSystemDBDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hobbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvBoats;
        private System.Windows.Forms.DataGridView dgvFishingInfo;
        private System.Windows.Forms.BindingSource boatBindingSource;
        private FishermanSystemDBDataSetTableAdapters.BoatTableAdapter boatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boat_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn expire_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn engine_fuel_consumption;
        private System.Windows.Forms.BindingSource boatBindingSource1;
        private System.Windows.Forms.BindingSource fishingSessionBindingSource;
        private FishermanSystemDBDataSetTableAdapters.Fishing_SessionTableAdapter fishing_SessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_fishing_session;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_fished_kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration_of_fishing_session_min;
        private System.Windows.Forms.Label lblId;
    }
}