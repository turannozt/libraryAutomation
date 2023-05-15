
namespace libraryAutomation
{
    partial class kitapDuzenle
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
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtShelfNo = new System.Windows.Forms.TextBox();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtBarcodeNo = new System.Windows.Forms.TextBox();
            this.lblShelfNo = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBarcodeNo = new System.Windows.Forms.Label();
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSearchBookTitle = new System.Windows.Forms.Label();
            this.txtSearchBookTitle = new System.Windows.Forms.TextBox();
            this.labelBarcodeNo = new System.Windows.Forms.Label();
            this.txtSearchBarcodeNo = new System.Windows.Forms.TextBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "Güncelle";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(1209, 606);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(188, 52);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderRadius = 0;
            this.btnClear.ButtonText = "Temizle";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DisabledColor = System.Drawing.Color.Gray;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClear.Iconimage = null;
            this.btnClear.Iconimage_right = null;
            this.btnClear.Iconimage_right_Selected = null;
            this.btnClear.Iconimage_Selected = null;
            this.btnClear.IconMarginLeft = 0;
            this.btnClear.IconMarginRight = 0;
            this.btnClear.IconRightVisible = true;
            this.btnClear.IconRightZoom = 0D;
            this.btnClear.IconVisible = true;
            this.btnClear.IconZoom = 90D;
            this.btnClear.IsTab = false;
            this.btnClear.Location = new System.Drawing.Point(761, 606);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnClear.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClear.selected = false;
            this.btnClear.Size = new System.Drawing.Size(188, 52);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Temizle";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Textcolor = System.Drawing.Color.White;
            this.btnClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtShelfNo
            // 
            this.txtShelfNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtShelfNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtShelfNo.Location = new System.Drawing.Point(865, 506);
            this.txtShelfNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtShelfNo.Name = "txtShelfNo";
            this.txtShelfNo.Size = new System.Drawing.Size(163, 29);
            this.txtShelfNo.TabIndex = 45;
            // 
            // txtPageCount
            // 
            this.txtPageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPageCount.Location = new System.Drawing.Point(865, 463);
            this.txtPageCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(163, 29);
            this.txtPageCount.TabIndex = 44;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAuthor.Location = new System.Drawing.Point(865, 421);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(485, 29);
            this.txtAuthor.TabIndex = 43;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookTitle.Location = new System.Drawing.Point(207, 463);
            this.txtBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookTitle.Multiline = true;
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(485, 89);
            this.txtBookTitle.TabIndex = 42;
            // 
            // txtBarcodeNo
            // 
            this.txtBarcodeNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBarcodeNo.Enabled = false;
            this.txtBarcodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarcodeNo.Location = new System.Drawing.Point(207, 421);
            this.txtBarcodeNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcodeNo.Name = "txtBarcodeNo";
            this.txtBarcodeNo.Size = new System.Drawing.Size(485, 29);
            this.txtBarcodeNo.TabIndex = 41;
            // 
            // lblShelfNo
            // 
            this.lblShelfNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblShelfNo.AutoSize = true;
            this.lblShelfNo.BackColor = System.Drawing.Color.Transparent;
            this.lblShelfNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShelfNo.Location = new System.Drawing.Point(727, 511);
            this.lblShelfNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShelfNo.Name = "lblShelfNo";
            this.lblShelfNo.Size = new System.Drawing.Size(64, 22);
            this.lblShelfNo.TabIndex = 40;
            this.lblShelfNo.Text = "Raf No";
            // 
            // lblPageCount
            // 
            this.lblPageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPageCount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageCount.Location = new System.Drawing.Point(727, 468);
            this.lblPageCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(103, 22);
            this.lblPageCount.TabIndex = 39;
            this.lblPageCount.Text = "Sayfa Sayısı";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Location = new System.Drawing.Point(727, 426);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(60, 22);
            this.lblAuthor.TabIndex = 38;
            this.lblAuthor.Text = "Yazarı";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookTitle.Location = new System.Drawing.Point(68, 468);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(85, 22);
            this.lblBookTitle.TabIndex = 37;
            this.lblBookTitle.Text = "Kitap Adı";
            // 
            // lblBarcodeNo
            // 
            this.lblBarcodeNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBarcodeNo.AutoSize = true;
            this.lblBarcodeNo.BackColor = System.Drawing.Color.Transparent;
            this.lblBarcodeNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarcodeNo.Location = new System.Drawing.Point(68, 426);
            this.lblBarcodeNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarcodeNo.Name = "lblBarcodeNo";
            this.lblBarcodeNo.Size = new System.Drawing.Size(97, 22);
            this.lblBarcodeNo.TabIndex = 36;
            this.lblBarcodeNo.Text = "Barkod No";
            // 
            // dgwBook
            // 
            this.dgwBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwBook.BackgroundColor = System.Drawing.Color.Azure;
            this.dgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBook.ContextMenuStrip = this.contextMenuStrip1;
            this.dgwBook.Location = new System.Drawing.Point(16, 70);
            this.dgwBook.Margin = new System.Windows.Forms.Padding(4);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.ReadOnly = true;
            this.dgwBook.RowHeadersWidth = 51;
            this.dgwBook.Size = new System.Drawing.Size(1396, 324);
            this.dgwBook.TabIndex = 51;
            this.dgwBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBook_CellDoubleClick);
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
            // lblSearchBookTitle
            // 
            this.lblSearchBookTitle.AutoSize = true;
            this.lblSearchBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchBookTitle.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchBookTitle.Location = new System.Drawing.Point(563, 22);
            this.lblSearchBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBookTitle.Name = "lblSearchBookTitle";
            this.lblSearchBookTitle.Size = new System.Drawing.Size(95, 22);
            this.lblSearchBookTitle.TabIndex = 81;
            this.lblSearchBookTitle.Text = "Kitap Ara :";
            // 
            // txtSearchBookTitle
            // 
            this.txtSearchBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBookTitle.Location = new System.Drawing.Point(660, 17);
            this.txtSearchBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBookTitle.Name = "txtSearchBookTitle";
            this.txtSearchBookTitle.Size = new System.Drawing.Size(323, 29);
            this.txtSearchBookTitle.TabIndex = 80;
            this.txtSearchBookTitle.TextChanged += new System.EventHandler(this.txtSearchBookTitle_TextChanged);
            this.txtSearchBookTitle.Enter += new System.EventHandler(this.txtSearchBookTitle_Enter);
            // 
            // labelBarcodeNo
            // 
            this.labelBarcodeNo.AutoSize = true;
            this.labelBarcodeNo.BackColor = System.Drawing.Color.Transparent;
            this.labelBarcodeNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBarcodeNo.Location = new System.Drawing.Point(16, 22);
            this.labelBarcodeNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBarcodeNo.Name = "labelBarcodeNo";
            this.labelBarcodeNo.Size = new System.Drawing.Size(139, 22);
            this.labelBarcodeNo.TabIndex = 79;
            this.labelBarcodeNo.Text = "Barkod No Ara :";
            // 
            // txtSearchBarcodeNo
            // 
            this.txtSearchBarcodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBarcodeNo.Location = new System.Drawing.Point(184, 17);
            this.txtSearchBarcodeNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBarcodeNo.Name = "txtSearchBarcodeNo";
            this.txtSearchBarcodeNo.Size = new System.Drawing.Size(323, 29);
            this.txtSearchBarcodeNo.TabIndex = 78;
            this.txtSearchBarcodeNo.TextChanged += new System.EventHandler(this.txtSearchBarcodeNo_TextChanged);
            this.txtSearchBarcodeNo.Enter += new System.EventHandler(this.txtSearchBarcodeNo_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Sil";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(981, 606);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(188, 52);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 711);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSearchBookTitle);
            this.Controls.Add(this.txtSearchBookTitle);
            this.Controls.Add(this.labelBarcodeNo);
            this.Controls.Add(this.txtSearchBarcodeNo);
            this.Controls.Add(this.dgwBook);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtShelfNo);
            this.Controls.Add(this.txtPageCount);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBarcodeNo);
            this.Controls.Add(this.lblShelfNo);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblBarcodeNo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(754, 463);
            this.Name = "frmEditBook";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİTAP DÜZENLE / GÜNCELLE";
            this.Load += new System.EventHandler(this.frmEditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnClear;
        private System.Windows.Forms.TextBox txtShelfNo;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtBarcodeNo;
        private System.Windows.Forms.Label lblShelfNo;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBarcodeNo;
        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.Label lblSearchBookTitle;
        private System.Windows.Forms.TextBox txtSearchBookTitle;
        private System.Windows.Forms.Label labelBarcodeNo;
        private System.Windows.Forms.TextBox txtSearchBarcodeNo;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}