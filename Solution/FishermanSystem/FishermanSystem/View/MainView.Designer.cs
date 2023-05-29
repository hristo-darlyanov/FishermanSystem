namespace FishermanSystem.View
{
    partial class MainView
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
            this.btnAlterUserInfo = new System.Windows.Forms.Button();
            this.btnShowExpiringLicenses = new System.Windows.Forms.Button();
            this.btnShowCarbonPrint = new System.Windows.Forms.Button();
            this.btnShowBiggestCatchFromHobbyFishers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowFishingInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvQueryData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterUserInfo
            // 
            this.btnAlterUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterUserInfo.Location = new System.Drawing.Point(1199, 15);
            this.btnAlterUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterUserInfo.Name = "btnAlterUserInfo";
            this.btnAlterUserInfo.Size = new System.Drawing.Size(261, 41);
            this.btnAlterUserInfo.TabIndex = 0;
            this.btnAlterUserInfo.Text = "ALTER USER INFO";
            this.btnAlterUserInfo.UseVisualStyleBackColor = true;
            this.btnAlterUserInfo.Click += new System.EventHandler(this.btnAlterUserInfo_Click);
            // 
            // btnShowExpiringLicenses
            // 
            this.btnShowExpiringLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowExpiringLicenses.Location = new System.Drawing.Point(16, 57);
            this.btnShowExpiringLicenses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowExpiringLicenses.Name = "btnShowExpiringLicenses";
            this.btnShowExpiringLicenses.Size = new System.Drawing.Size(229, 65);
            this.btnShowExpiringLicenses.TabIndex = 1;
            this.btnShowExpiringLicenses.Text = "Show Info";
            this.btnShowExpiringLicenses.UseVisualStyleBackColor = true;
            this.btnShowExpiringLicenses.Click += new System.EventHandler(this.btnShowExpiringLicenses_Click);
            // 
            // btnShowCarbonPrint
            // 
            this.btnShowCarbonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCarbonPrint.Location = new System.Drawing.Point(16, 500);
            this.btnShowCarbonPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowCarbonPrint.Name = "btnShowCarbonPrint";
            this.btnShowCarbonPrint.Size = new System.Drawing.Size(229, 65);
            this.btnShowCarbonPrint.TabIndex = 2;
            this.btnShowCarbonPrint.Text = "Show Info";
            this.btnShowCarbonPrint.UseVisualStyleBackColor = true;
            this.btnShowCarbonPrint.Click += new System.EventHandler(this.btnShowCarbonPrint_Click);
            // 
            // btnShowBiggestCatchFromHobbyFishers
            // 
            this.btnShowBiggestCatchFromHobbyFishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBiggestCatchFromHobbyFishers.Location = new System.Drawing.Point(16, 201);
            this.btnShowBiggestCatchFromHobbyFishers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowBiggestCatchFromHobbyFishers.Name = "btnShowBiggestCatchFromHobbyFishers";
            this.btnShowBiggestCatchFromHobbyFishers.Size = new System.Drawing.Size(229, 65);
            this.btnShowBiggestCatchFromHobbyFishers.TabIndex = 4;
            this.btnShowBiggestCatchFromHobbyFishers.Text = "Show Info";
            this.btnShowBiggestCatchFromHobbyFishers.UseVisualStyleBackColor = true;
            this.btnShowBiggestCatchFromHobbyFishers.Click += new System.EventHandler(this.btnShowBiggestCatchFromHobbyFishers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Show biggest catch from hobby fishers";
            // 
            // btnShowFishingInfo
            // 
            this.btnShowFishingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFishingInfo.Location = new System.Drawing.Point(16, 353);
            this.btnShowFishingInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowFishingInfo.Name = "btnShowFishingInfo";
            this.btnShowFishingInfo.Size = new System.Drawing.Size(229, 65);
            this.btnShowFishingInfo.TabIndex = 3;
            this.btnShowFishingInfo.Text = "Show Info";
            this.btnShowFishingInfo.UseVisualStyleBackColor = true;
            this.btnShowFishingInfo.Click += new System.EventHandler(this.btnShowFishingInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show expiring licenses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 319);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Show fishing info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Show carbon print";
            // 
            // dgvQueryData
            // 
            this.dgvQueryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryData.Location = new System.Drawing.Point(431, 143);
            this.dgvQueryData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQueryData.Name = "dgvQueryData";
            this.dgvQueryData.RowHeadersWidth = 51;
            this.dgvQueryData.Size = new System.Drawing.Size(1029, 566);
            this.dgvQueryData.TabIndex = 9;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 724);
            this.Controls.Add(this.dgvQueryData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowBiggestCatchFromHobbyFishers);
            this.Controls.Add(this.btnShowFishingInfo);
            this.Controls.Add(this.btnShowCarbonPrint);
            this.Controls.Add(this.btnShowExpiringLicenses);
            this.Controls.Add(this.btnAlterUserInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterUserInfo;
        private System.Windows.Forms.Button btnShowExpiringLicenses;
        private System.Windows.Forms.Button btnShowCarbonPrint;
        private System.Windows.Forms.Button btnShowBiggestCatchFromHobbyFishers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowFishingInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvQueryData;
    }
}