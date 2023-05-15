
namespace libraryAutomation
{
    partial class uyeListe
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
            this.dgwMember = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearchIdNo = new System.Windows.Forms.TextBox();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMember
            // 
            this.dgwMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwMember.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMember.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwMember.Location = new System.Drawing.Point(65, 84);
            this.dgwMember.Margin = new System.Windows.Forms.Padding(4);
            this.dgwMember.Name = "dgwMember";
            this.dgwMember.ReadOnly = true;
            this.dgwMember.RowHeadersWidth = 51;
            this.dgwMember.Size = new System.Drawing.Size(1307, 716);
            this.dgwMember.TabIndex = 25;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 76);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.addToolStripMenuItem.Text = "Ekle";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.deleteToolStripMenuItem.Text = "Sil";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.editToolStripMenuItem.Text = "Düzenle";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // txtSearchIdNo
            // 
            this.txtSearchIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchIdNo.Location = new System.Drawing.Point(229, 30);
            this.txtSearchIdNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchIdNo.Name = "txtSearchIdNo";
            this.txtSearchIdNo.Size = new System.Drawing.Size(323, 29);
            this.txtSearchIdNo.TabIndex = 70;
            this.txtSearchIdNo.TextChanged += new System.EventHandler(this.txtSearchIdNo_TextChanged);
            this.txtSearchIdNo.Enter += new System.EventHandler(this.txtSearchIdNo_Enter);
            // 
            // lblIdNo
            // 
            this.lblIdNo.AutoSize = true;
            this.lblIdNo.BackColor = System.Drawing.Color.Transparent;
            this.lblIdNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdNo.Location = new System.Drawing.Point(61, 34);
            this.lblIdNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.Size = new System.Drawing.Size(153, 22);
            this.lblIdNo.TabIndex = 71;
            this.lblIdNo.Text = "Tc Kimlik No Ara :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(608, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 22);
            this.lblName.TabIndex = 73;
            this.lblName.Text = "İsim Ara :";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchName.Location = new System.Drawing.Point(705, 30);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(323, 29);
            this.txtSearchName.TabIndex = 72;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            this.txtSearchName.Enter += new System.EventHandler(this.txtSearchName_Enter);
            // 
            // frmListMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1432, 821);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblIdNo);
            this.Controls.Add(this.txtSearchIdNo);
            this.Controls.Add(this.dgwMember);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListMember";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜYELERİ LİSTELE";
            this.Load += new System.EventHandler(this.frmListMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMember)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMember;
        private System.Windows.Forms.TextBox txtSearchIdNo;
        private System.Windows.Forms.Label lblIdNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}