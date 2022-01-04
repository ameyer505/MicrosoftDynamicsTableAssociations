
namespace DynamicsTableAssociations
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_initial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dest = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_analyze = new System.Windows.Forms.Button();
            this.lv_initial = new System.Windows.Forms.ListView();
            this.lvInitialName = new System.Windows.Forms.ColumnHeader();
            this.lv_dest = new System.Windows.Forms.ListView();
            this.lvDestName = new System.Windows.Forms.ColumnHeader();
            this.lv_output = new System.Windows.Forms.ListView();
            this.ParentTable = new System.Windows.Forms.ColumnHeader();
            this.ParentColumn = new System.Windows.Forms.ColumnHeader();
            this.ChildTable = new System.Windows.Forms.ColumnHeader();
            this.ChildColumn = new System.Windows.Forms.ColumnHeader();
            this.cb_SearchLayers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // tb_initial
            // 
            this.tb_initial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_initial.Location = new System.Drawing.Point(82, 73);
            this.tb_initial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_initial.Name = "tb_initial";
            this.tb_initial.Size = new System.Drawing.Size(361, 29);
            this.tb_initial.TabIndex = 1;
            this.tb_initial.TextChanged += new System.EventHandler(this.tbInitial_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(507, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search :";
            // 
            // tb_dest
            // 
            this.tb_dest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_dest.Location = new System.Drawing.Point(576, 73);
            this.tb_dest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_dest.Name = "tb_dest";
            this.tb_dest.Size = new System.Drawing.Size(371, 29);
            this.tb_dest.TabIndex = 3;
            this.tb_dest.TextChanged += new System.EventHandler(this.tbDest_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Initial Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(507, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destination Table";
            // 
            // btn_analyze
            // 
            this.btn_analyze.Enabled = false;
            this.btn_analyze.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_analyze.Location = new System.Drawing.Point(719, 479);
            this.btn_analyze.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_analyze.Name = "btn_analyze";
            this.btn_analyze.Size = new System.Drawing.Size(229, 40);
            this.btn_analyze.TabIndex = 9;
            this.btn_analyze.Text = "Find Associations";
            this.btn_analyze.UseVisualStyleBackColor = true;
            this.btn_analyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lv_initial
            // 
            this.lv_initial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvInitialName});
            this.lv_initial.FullRowSelect = true;
            this.lv_initial.GridLines = true;
            this.lv_initial.HideSelection = false;
            this.lv_initial.Location = new System.Drawing.Point(15, 115);
            this.lv_initial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_initial.MultiSelect = false;
            this.lv_initial.Name = "lv_initial";
            this.lv_initial.Size = new System.Drawing.Size(428, 355);
            this.lv_initial.TabIndex = 10;
            this.lv_initial.UseCompatibleStateImageBehavior = false;
            this.lv_initial.View = System.Windows.Forms.View.Details;
            this.lv_initial.SelectedIndexChanged += new System.EventHandler(this.lvInitial_SelectedIndexChanged);
            // 
            // lvInitialName
            // 
            this.lvInitialName.Text = "Name";
            // 
            // lv_dest
            // 
            this.lv_dest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvDestName});
            this.lv_dest.FullRowSelect = true;
            this.lv_dest.GridLines = true;
            this.lv_dest.HideSelection = false;
            this.lv_dest.Location = new System.Drawing.Point(519, 115);
            this.lv_dest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_dest.MultiSelect = false;
            this.lv_dest.Name = "lv_dest";
            this.lv_dest.Size = new System.Drawing.Size(428, 355);
            this.lv_dest.TabIndex = 11;
            this.lv_dest.UseCompatibleStateImageBehavior = false;
            this.lv_dest.View = System.Windows.Forms.View.Details;
            this.lv_dest.SelectedIndexChanged += new System.EventHandler(this.lvDest_SelectedIndexChanged);
            // 
            // lvDestName
            // 
            this.lvDestName.Text = "Name";
            // 
            // lv_output
            // 
            this.lv_output.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ParentTable,
            this.ParentColumn,
            this.ChildTable,
            this.ChildColumn});
            this.lv_output.FullRowSelect = true;
            this.lv_output.GridLines = true;
            this.lv_output.HideSelection = false;
            this.lv_output.Location = new System.Drawing.Point(15, 548);
            this.lv_output.Name = "lv_output";
            this.lv_output.Size = new System.Drawing.Size(932, 384);
            this.lv_output.TabIndex = 12;
            this.lv_output.UseCompatibleStateImageBehavior = false;
            this.lv_output.View = System.Windows.Forms.View.Details;
            // 
            // ParentTable
            // 
            this.ParentTable.Text = "Parent Table";
            this.ParentTable.Width = 200;
            // 
            // ParentColumn
            // 
            this.ParentColumn.Text = "Parent Column";
            this.ParentColumn.Width = 200;
            // 
            // ChildTable
            // 
            this.ChildTable.Text = "Child Table";
            this.ChildTable.Width = 200;
            // 
            // ChildColumn
            // 
            this.ChildColumn.Text = "Child Column";
            this.ChildColumn.Width = 200;
            // 
            // cb_SearchLayers
            // 
            this.cb_SearchLayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SearchLayers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_SearchLayers.FormattingEnabled = true;
            this.cb_SearchLayers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_SearchLayers.Location = new System.Drawing.Point(252, 489);
            this.cb_SearchLayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_SearchLayers.Name = "cb_SearchLayers";
            this.cb_SearchLayers.Size = new System.Drawing.Size(191, 29);
            this.cb_SearchLayers.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Number of Layers to Search :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 945);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_SearchLayers);
            this.Controls.Add(this.lv_output);
            this.Controls.Add(this.lv_dest);
            this.Controls.Add(this.lv_initial);
            this.Controls.Add(this.btn_analyze);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_dest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_initial);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Dynamics AX / 365FO Table Associations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_initial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_analyze;
        private System.Windows.Forms.ListView lv_initial;
        private System.Windows.Forms.ColumnHeader lvInitialName;
        private System.Windows.Forms.ListView lv_dest;
        private System.Windows.Forms.ColumnHeader lvDestName;
        private System.Windows.Forms.ListView lv_output;
        private System.Windows.Forms.ColumnHeader ParentTable;
        private System.Windows.Forms.ColumnHeader ParentColumn;
        private System.Windows.Forms.ColumnHeader ChildTable;
        private System.Windows.Forms.ColumnHeader ChildColumn;
        private System.Windows.Forms.ComboBox cb_SearchLayers;
        private System.Windows.Forms.Label label5;
    }
}

