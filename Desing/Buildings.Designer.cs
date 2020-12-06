namespace Desing
{
    partial class Buildings
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBuilding = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBDelete = new System.Windows.Forms.Button();
            this.btnBAdd = new System.Windows.Forms.Button();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCRDelete = new System.Windows.Forms.Button();
            this.btnCRAdd = new System.Windows.Forms.Button();
            this.dgvClassroom = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.091304F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.67168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.924761F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.37401F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.70523F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 731);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aulas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgvBuilding, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBName, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.65736F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.67055F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.67208F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(633, 284);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvBuilding
            // 
            this.dgvBuilding.BackgroundColor = System.Drawing.Color.White;
            this.dgvBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuilding.Location = new System.Drawing.Point(3, 3);
            this.dgvBuilding.Name = "dgvBuilding";
            this.dgvBuilding.Size = new System.Drawing.Size(627, 200);
            this.dgvBuilding.TabIndex = 0;
            this.dgvBuilding.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuilding_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnBDelete, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBAdd, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 247);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(627, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnBDelete
            // 
            this.btnBDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBDelete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnBDelete.Location = new System.Drawing.Point(3, 3);
            this.btnBDelete.Name = "btnBDelete";
            this.btnBDelete.Size = new System.Drawing.Size(307, 28);
            this.btnBDelete.TabIndex = 1;
            this.btnBDelete.Text = "Eliminar";
            this.btnBDelete.UseVisualStyleBackColor = true;
            this.btnBDelete.Click += new System.EventHandler(this.btnBDelete_Click);
            // 
            // btnBAdd
            // 
            this.btnBAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBAdd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnBAdd.Location = new System.Drawing.Point(316, 3);
            this.btnBAdd.Name = "btnBAdd";
            this.btnBAdd.Size = new System.Drawing.Size(308, 28);
            this.btnBAdd.TabIndex = 0;
            this.btnBAdd.Text = "Agregar";
            this.btnBAdd.UseVisualStyleBackColor = true;
            this.btnBAdd.Click += new System.EventHandler(this.btnBAdd_Click);
            // 
            // txtBName
            // 
            this.txtBName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBName.Location = new System.Drawing.Point(3, 209);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(627, 27);
            this.txtBName.TabIndex = 2;
            this.txtBName.Text = "Nombre...";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.dgvClassroom, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 366);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.76426F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.30798F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.92776F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(633, 319);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.txtCapacity, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtBID, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtCount, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 238);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(627, 36);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCapacity.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCapacity.Location = new System.Drawing.Point(212, 3);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(203, 27);
            this.txtCapacity.TabIndex = 2;
            this.txtCapacity.Text = "Capacidad...";
            // 
            // txtBID
            // 
            this.txtBID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBID.Location = new System.Drawing.Point(3, 3);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(203, 27);
            this.txtBID.TabIndex = 1;
            // 
            // txtCount
            // 
            this.txtCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCount.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCount.Location = new System.Drawing.Point(421, 3);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(203, 27);
            this.txtCount.TabIndex = 0;
            this.txtCount.Text = "Cantidad (Aulas)...";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.btnCRDelete, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnCRAdd, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 280);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(627, 36);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // btnCRDelete
            // 
            this.btnCRDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCRDelete.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCRDelete.Location = new System.Drawing.Point(3, 3);
            this.btnCRDelete.Name = "btnCRDelete";
            this.btnCRDelete.Size = new System.Drawing.Size(307, 30);
            this.btnCRDelete.TabIndex = 1;
            this.btnCRDelete.Text = "Eliminar";
            this.btnCRDelete.UseVisualStyleBackColor = true;
            this.btnCRDelete.Click += new System.EventHandler(this.btnCRDelete_Click);
            // 
            // btnCRAdd
            // 
            this.btnCRAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCRAdd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCRAdd.Location = new System.Drawing.Point(316, 3);
            this.btnCRAdd.Name = "btnCRAdd";
            this.btnCRAdd.Size = new System.Drawing.Size(308, 30);
            this.btnCRAdd.TabIndex = 0;
            this.btnCRAdd.Text = "Agregar";
            this.btnCRAdd.UseVisualStyleBackColor = true;
            this.btnCRAdd.Click += new System.EventHandler(this.btnCRAdd_Click);
            // 
            // dgvClassroom
            // 
            this.dgvClassroom.BackgroundColor = System.Drawing.Color.White;
            this.dgvClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClassroom.Location = new System.Drawing.Point(3, 3);
            this.dgvClassroom.Name = "dgvClassroom";
            this.dgvClassroom.Size = new System.Drawing.Size(627, 229);
            this.dgvClassroom.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnExit.Location = new System.Drawing.Point(3, 691);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(633, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Aceptar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edificios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Buildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 731);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Buildings";
            this.Text = "Buildings";
            this.Load += new System.EventHandler(this.Buildings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuilding)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassroom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvBuilding;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnBDelete;
        private System.Windows.Forms.Button btnBAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnCRDelete;
        private System.Windows.Forms.Button btnCRAdd;
        private System.Windows.Forms.DataGridView dgvClassroom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}