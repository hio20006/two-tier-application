namespace M11105506_two_tier
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label listLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.function_1 = new M11105506_two_tier.Function_1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.system_info1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listsysteminfo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.function_2 = new M11105506_two_tier.Function_2();
            this.listComboBox = new System.Windows.Forms.ComboBox();
            this.systeminfo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systeminfo1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.system_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new M11105506_two_tier.Function_1TableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new M11105506_two_tier.Function_1TableAdapters.TableAdapterManager();
            this.listTableAdapter = new M11105506_two_tier.Function_2TableAdapters.ListTableAdapter();
            this.tableAdapterManager1 = new M11105506_two_tier.Function_2TableAdapters.TableAdapterManager();
            this.system_info1TableAdapter = new M11105506_two_tier.Function_2TableAdapters.system_info1TableAdapter();
            listLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.function_1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.system_info1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listsysteminfo1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.function_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systeminfo1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systeminfo1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listLabel
            // 
            listLabel.AutoSize = true;
            listLabel.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            listLabel.Location = new System.Drawing.Point(8, 76);
            listLabel.Name = "listLabel";
            listLabel.Size = new System.Drawing.Size(65, 21);
            listLabel.TabIndex = 2;
            listLabel.Text = "list:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataTable1DataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fun_1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Function_1：List ordered average of Rmax in different Segments and in different li" +
    "sts";
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource;
            this.dataTable1DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(3, 64);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.RowTemplate.Height = 24;
            this.dataTable1DataGridView.Size = new System.Drawing.Size(786, 357);
            this.dataTable1DataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "list";
            this.dataGridViewTextBoxColumn1.HeaderText = "list";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Segement";
            this.dataGridViewTextBoxColumn2.HeaderText = "Segement";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rmax_avg";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rmax_avg";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.function_1;
            // 
            // function_1
            // 
            this.function_1.DataSetName = "Function_1";
            this.function_1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.system_info1DataGridView);
            this.tabPage2.Controls.Add(listLabel);
            this.tabPage2.Controls.Add(this.listComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fun_2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(730, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Function2：Select a list, and show the number of supercomputers in descending orde" +
    "r \r\nused in each segment.";
            // 
            // system_info1DataGridView
            // 
            this.system_info1DataGridView.AutoGenerateColumns = false;
            this.system_info1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.system_info1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.system_info1DataGridView.DataSource = this.listsysteminfo1BindingSource;
            this.system_info1DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.system_info1DataGridView.Location = new System.Drawing.Point(3, 102);
            this.system_info1DataGridView.Name = "system_info1DataGridView";
            this.system_info1DataGridView.RowTemplate.Height = 24;
            this.system_info1DataGridView.Size = new System.Drawing.Size(786, 319);
            this.system_info1DataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "list";
            this.dataGridViewTextBoxColumn4.HeaderText = "list";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "segment";
            this.dataGridViewTextBoxColumn5.HeaderText = "segment";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "computer_num";
            this.dataGridViewTextBoxColumn6.HeaderText = "computer_num";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // listsysteminfo1BindingSource
            // 
            this.listsysteminfo1BindingSource.DataMember = "List_system_info1";
            this.listsysteminfo1BindingSource.DataSource = this.listBindingSource2;
            // 
            // listBindingSource2
            // 
            this.listBindingSource2.DataMember = "List";
            this.listBindingSource2.DataSource = this.function_2;
            // 
            // function_2
            // 
            this.function_2.DataSetName = "Function_2";
            this.function_2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listComboBox
            // 
            this.listComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systeminfo1BindingSource, "list", true));
            this.listComboBox.DataSource = this.listBindingSource2;
            this.listComboBox.DisplayMember = "list";
            this.listComboBox.FormattingEnabled = true;
            this.listComboBox.Location = new System.Drawing.Point(79, 76);
            this.listComboBox.Name = "listComboBox";
            this.listComboBox.Size = new System.Drawing.Size(121, 20);
            this.listComboBox.TabIndex = 3;
            this.listComboBox.ValueMember = "list";
            // 
            // systeminfo1BindingSource
            // 
            this.systeminfo1BindingSource.DataMember = "system_info1";
            this.systeminfo1BindingSource.DataSource = this.function_2;
            // 
            // systeminfo1BindingSource1
            // 
            this.systeminfo1BindingSource1.DataMember = "system_info1";
            this.systeminfo1BindingSource1.DataSource = this.function_2;
            // 
            // system_infoBindingSource
            // 
            this.system_infoBindingSource.DataMember = "system_info";
            this.system_infoBindingSource.DataSource = this.function_2;
            // 
            // listBindingSource
            // 
            this.listBindingSource.DataMember = "List";
            this.listBindingSource.DataSource = this.function_2;
            // 
            // listBindingSource1
            // 
            this.listBindingSource1.DataMember = "List";
            this.listBindingSource1.DataSource = this.function_2;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.system_infoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = M11105506_two_tier.Function_1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listTableAdapter
            // 
            this.listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = M11105506_two_tier.Function_2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // system_info1TableAdapter
            // 
            this.system_info1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.function_1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.system_info1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listsysteminfo1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.function_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systeminfo1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systeminfo1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Function_1 function_1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Function_1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private Function_1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Function_2 function_2;
        private System.Windows.Forms.BindingSource listBindingSource;
        private Function_2TableAdapters.ListTableAdapter listTableAdapter;
        private Function_2TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource listBindingSource1;
        private System.Windows.Forms.BindingSource system_infoBindingSource;
        private System.Windows.Forms.BindingSource systeminfo1BindingSource;
        private Function_2TableAdapters.system_info1TableAdapter system_info1TableAdapter;
        private System.Windows.Forms.ComboBox listComboBox;
        private System.Windows.Forms.BindingSource systeminfo1BindingSource1;
        private System.Windows.Forms.BindingSource listBindingSource2;
        private System.Windows.Forms.DataGridView system_info1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource listsysteminfo1BindingSource;
        private System.Windows.Forms.Label label2;
    }
}

