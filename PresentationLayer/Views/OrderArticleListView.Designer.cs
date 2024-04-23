
namespace PresentationLayer.Views
{
    partial class OrderArticleListView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderOptions = new System.Windows.Forms.Panel();
            this.pnlSearchContainer = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.chkArticleDescription = new System.Windows.Forms.CheckBox();
            this.chkArticleName = new System.Windows.Forms.CheckBox();
            this.pnlHeaderLogo = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArticleDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderOptions.SuspendLayout();
            this.pnlSearchContainer.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlHeaderOptions);
            this.pnlHeader.Controls.Add(this.pnlHeaderLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(920, 41);
            this.pnlHeader.TabIndex = 59;
            // 
            // pnlHeaderOptions
            // 
            this.pnlHeaderOptions.Controls.Add(this.pnlSearchContainer);
            this.pnlHeaderOptions.Controls.Add(this.btnSearch);
            this.pnlHeaderOptions.Controls.Add(this.grpFilters);
            this.pnlHeaderOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderOptions.Location = new System.Drawing.Point(112, 0);
            this.pnlHeaderOptions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeaderOptions.Name = "pnlHeaderOptions";
            this.pnlHeaderOptions.Padding = new System.Windows.Forms.Padding(0, 4, 4, 0);
            this.pnlHeaderOptions.Size = new System.Drawing.Size(808, 41);
            this.pnlHeaderOptions.TabIndex = 50;
            // 
            // pnlSearchContainer
            // 
            this.pnlSearchContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSearchContainer.Controls.Add(this.txtSearch);
            this.pnlSearchContainer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pnlSearchContainer.Location = new System.Drawing.Point(117, 10);
            this.pnlSearchContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearchContainer.Name = "pnlSearchContainer";
            this.pnlSearchContainer.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnlSearchContainer.Size = new System.Drawing.Size(215, 26);
            this.pnlSearchContainer.TabIndex = 48;
            this.pnlSearchContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlSearchContainer_MouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(6, 4);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 16);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(0, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 37);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.chkArticleDescription);
            this.grpFilters.Controls.Add(this.chkArticleName);
            this.grpFilters.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilters.Location = new System.Drawing.Point(564, 4);
            this.grpFilters.Margin = new System.Windows.Forms.Padding(2);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Padding = new System.Windows.Forms.Padding(2);
            this.grpFilters.Size = new System.Drawing.Size(240, 37);
            this.grpFilters.TabIndex = 46;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Filters";
            // 
            // chkArticleDescription
            // 
            this.chkArticleDescription.AutoSize = true;
            this.chkArticleDescription.Location = new System.Drawing.Point(119, 11);
            this.chkArticleDescription.Margin = new System.Windows.Forms.Padding(2);
            this.chkArticleDescription.Name = "chkArticleDescription";
            this.chkArticleDescription.Size = new System.Drawing.Size(114, 17);
            this.chkArticleDescription.TabIndex = 8;
            this.chkArticleDescription.Text = "Artricle Description";
            this.chkArticleDescription.UseVisualStyleBackColor = true;
            // 
            // chkArticleName
            // 
            this.chkArticleName.AutoSize = true;
            this.chkArticleName.Location = new System.Drawing.Point(29, 11);
            this.chkArticleName.Margin = new System.Windows.Forms.Padding(2);
            this.chkArticleName.Name = "chkArticleName";
            this.chkArticleName.Size = new System.Drawing.Size(86, 17);
            this.chkArticleName.TabIndex = 7;
            this.chkArticleName.Text = "Article Name";
            this.chkArticleName.UseVisualStyleBackColor = true;
            // 
            // pnlHeaderLogo
            // 
            this.pnlHeaderLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeaderLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeaderLogo.Name = "pnlHeaderLogo";
            this.pnlHeaderLogo.Size = new System.Drawing.Size(112, 41);
            this.pnlHeaderLogo.TabIndex = 10;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblResult);
            this.pnlLeft.Controls.Add(this.btnShowAll);
            this.pnlLeft.Controls.Add(this.btnDelete);
            this.pnlLeft.Controls.Add(this.btnEdit);
            this.pnlLeft.Controls.Add(this.btnAdd);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 41);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Size = new System.Drawing.Size(112, 369);
            this.pnlLeft.TabIndex = 60;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblResult.Location = new System.Drawing.Point(4, 170);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(104, 195);
            this.lblResult.TabIndex = 45;
            this.lblResult.Text = "result";
            this.lblResult.Visible = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(4, 127);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(104, 41);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(4, 86);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(4, 45);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 41);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(4, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvOrders);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(112, 41);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.pnlBody.Size = new System.Drawing.Size(808, 369);
            this.pnlBody.TabIndex = 61;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colOrderId,
            this.colArticle,
            this.colArticleDescription,
            this.colNumberOfArticle});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 4);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(804, 361);
            this.dgvOrders.TabIndex = 20;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 75;
            // 
            // colOrderId
            // 
            this.colOrderId.DataPropertyName = "OrderId";
            this.colOrderId.HeaderText = "Order number";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            // 
            // colArticle
            // 
            this.colArticle.DataPropertyName = "ArticleName";
            this.colArticle.HeaderText = "ArticleName";
            this.colArticle.Name = "colArticle";
            this.colArticle.ReadOnly = true;
            // 
            // colArticleDescription
            // 
            this.colArticleDescription.DataPropertyName = "ArticleDescription";
            this.colArticleDescription.HeaderText = "Article Description";
            this.colArticleDescription.Name = "colArticleDescription";
            this.colArticleDescription.ReadOnly = true;
            // 
            // colNumberOfArticle
            // 
            this.colNumberOfArticle.DataPropertyName = "NumberOfArticle";
            this.colNumberOfArticle.HeaderText = "Number of Article";
            this.colNumberOfArticle.Name = "colNumberOfArticle";
            this.colNumberOfArticle.ReadOnly = true;
            // 
            // OrderArticleListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 410);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderArticleListView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticleListView";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeaderOptions.ResumeLayout(false);
            this.pnlSearchContainer.ResumeLayout(false);
            this.pnlSearchContainer.PerformLayout();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel pnlHeaderLogo;
        private System.Windows.Forms.Panel pnlHeaderOptions;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.CheckBox chkArticleDescription;
        private System.Windows.Forms.CheckBox chkArticleName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSearchContainer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticleDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfArticle;
    }
}