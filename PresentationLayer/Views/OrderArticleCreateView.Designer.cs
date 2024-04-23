
namespace PresentationLayer.Views
{
    partial class OrderArticleCreateView
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.txtNumberOfArticle = new System.Windows.Forms.TextBox();
            this.lblNumberOfArticle = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbArticles = new System.Windows.Forms.ComboBox();
            this.lblArticle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(4, 4);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(242, 41);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ORDER ARTICLE DATA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlBody.Controls.Add(this.txtNumberOfArticle);
            this.pnlBody.Controls.Add(this.lblNumberOfArticle);
            this.pnlBody.Controls.Add(this.lblResult);
            this.pnlBody.Controls.Add(this.cmbArticles);
            this.pnlBody.Controls.Add(this.lblArticle);
            this.pnlBody.Location = new System.Drawing.Point(4, 50);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(243, 283);
            this.pnlBody.TabIndex = 1;
            // 
            // txtNumberOfArticle
            // 
            this.txtNumberOfArticle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNumberOfArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfArticle.Location = new System.Drawing.Point(0, 63);
            this.txtNumberOfArticle.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfArticle.Name = "txtNumberOfArticle";
            this.txtNumberOfArticle.Size = new System.Drawing.Size(243, 23);
            this.txtNumberOfArticle.TabIndex = 46;
            this.txtNumberOfArticle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberOfArticle_KeyPress);
            // 
            // lblNumberOfArticle
            // 
            this.lblNumberOfArticle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumberOfArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfArticle.Location = new System.Drawing.Point(0, 44);
            this.lblNumberOfArticle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfArticle.Name = "lblNumberOfArticle";
            this.lblNumberOfArticle.Size = new System.Drawing.Size(243, 19);
            this.lblNumberOfArticle.TabIndex = 45;
            this.lblNumberOfArticle.Text = "Number of Article";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblResult.Location = new System.Drawing.Point(0, 217);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(243, 66);
            this.lblResult.TabIndex = 44;
            this.lblResult.Text = "result";
            this.lblResult.Visible = false;
            // 
            // cmbArticles
            // 
            this.cmbArticles.DisplayMember = "Name";
            this.cmbArticles.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticles.FormattingEnabled = true;
            this.cmbArticles.Location = new System.Drawing.Point(0, 19);
            this.cmbArticles.Margin = new System.Windows.Forms.Padding(2);
            this.cmbArticles.Name = "cmbArticles";
            this.cmbArticles.Size = new System.Drawing.Size(243, 25);
            this.cmbArticles.TabIndex = 42;
            // 
            // lblArticle
            // 
            this.lblArticle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticle.Location = new System.Drawing.Point(0, 0);
            this.lblArticle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(243, 19);
            this.lblArticle.TabIndex = 0;
            this.lblArticle.Text = "Article";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnAccept);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(4, 338);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(242, 73);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(0, 41);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(242, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(0, 0);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(242, 32);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // OrderArticleCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 415);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderArticleCreateView";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticleCreateView";
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.ComboBox cmbArticles;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNumberOfArticle;
        private System.Windows.Forms.Label lblNumberOfArticle;
    }
}