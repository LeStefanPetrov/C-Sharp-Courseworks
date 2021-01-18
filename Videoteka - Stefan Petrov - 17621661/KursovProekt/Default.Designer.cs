namespace KursovProekt
{
    partial class Default
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kursovProektDataSet = new KursovProekt.KursovProektDataSet();
            this.firstTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstTableTableAdapter = new KursovProekt.KursovProektDataSetTableAdapters.FirstTableTableAdapter();
            this.kursovProektDataSet1 = new KursovProekt.KursovProektDataSet1();
            this.firstTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firstTableTableAdapter1 = new KursovProekt.KursovProektDataSet1TableAdapters.FirstTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovProektDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovProektDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kursovProektDataSet
            // 
            this.kursovProektDataSet.DataSetName = "KursovProektDataSet";
            this.kursovProektDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstTableBindingSource
            // 
            this.firstTableBindingSource.DataMember = "FirstTable";
            this.firstTableBindingSource.DataSource = this.kursovProektDataSet;
            // 
            // firstTableTableAdapter
            // 
            this.firstTableTableAdapter.ClearBeforeFill = true;
            // 
            // kursovProektDataSet1
            // 
            this.kursovProektDataSet1.DataSetName = "KursovProektDataSet1";
            this.kursovProektDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firstTableBindingSource1
            // 
            this.firstTableBindingSource1.DataMember = "FirstTable";
            this.firstTableBindingSource1.DataSource = this.kursovProektDataSet1;
            // 
            // firstTableTableAdapter1
            // 
            this.firstTableTableAdapter1.ClearBeforeFill = true;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "Default";
            this.Size = new System.Drawing.Size(942, 579);
            this.Load += new System.EventHandler(this.Default_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovProektDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursovProektDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource firstTableBindingSource;
        private KursovProektDataSet kursovProektDataSet;
        private KursovProektDataSetTableAdapters.FirstTableTableAdapter firstTableTableAdapter;
        private KursovProektDataSet1 kursovProektDataSet1;
        private System.Windows.Forms.BindingSource firstTableBindingSource1;
        private KursovProektDataSet1TableAdapters.FirstTableTableAdapter firstTableTableAdapter1;
    }
}
