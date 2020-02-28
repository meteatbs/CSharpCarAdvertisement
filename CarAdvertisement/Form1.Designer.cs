namespace CarAdvertisement
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.vv = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchByColor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 215);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 43);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // vv
            // 
            this.vv.AutoSize = true;
            this.vv.Location = new System.Drawing.Point(11, 15);
            this.vv.Name = "vv";
            this.vv.Size = new System.Drawing.Size(36, 13);
            this.vv.TabIndex = 1;
            this.vv.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(151, 15);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 2;
            // 
            // dgvCarList
            // 
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Location = new System.Drawing.Point(343, 120);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.ReadOnly = true;
            this.dgvCarList.Size = new System.Drawing.Size(511, 233);
            this.dgvCarList.TabIndex = 3;
            this.dgvCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarList_CellContentClick);
            this.dgvCarList.DoubleClick += new System.EventHandler(this.dgvCarList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(151, 41);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Brand";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(151, 67);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(125, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 43);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(242, 215);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 43);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fuel Type";
            // 
            // txtFuelType
            // 
            this.txtFuelType.Location = new System.Drawing.Point(151, 133);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(100, 20);
            this.txtFuelType.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gear";
            // 
            // txtGear
            // 
            this.txtGear.Location = new System.Drawing.Point(151, 159);
            this.txtGear.Name = "txtGear";
            this.txtGear.Size = new System.Drawing.Size(100, 20);
            this.txtGear.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(151, 104);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(749, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 46);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(359, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(339, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search By Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchByColor
            // 
            this.txtSearchByColor.Location = new System.Drawing.Point(359, 15);
            this.txtSearchByColor.Name = "txtSearchByColor";
            this.txtSearchByColor.Size = new System.Drawing.Size(339, 20);
            this.txtSearchByColor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.txtSearchByColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCarList);
            this.Controls.Add(this.txtGear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.vv);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Car Advertisements";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label vv;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchByColor;
    }
}

