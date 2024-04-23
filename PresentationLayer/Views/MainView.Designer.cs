
namespace PresentationLayer.Views
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnArticles = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.llbAbout = new System.Windows.Forms.LinkLabel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnArticles
            // 
            this.btnArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticles.Location = new System.Drawing.Point(0, 43);
            this.btnArticles.Margin = new System.Windows.Forms.Padding(2);
            this.btnArticles.Name = "btnArticles";
            this.btnArticles.Size = new System.Drawing.Size(189, 41);
            this.btnArticles.TabIndex = 1;
            this.btnArticles.Text = "Articles";
            this.btnArticles.UseVisualStyleBackColor = true;
            // 
            // btnCategories
            // 
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Location = new System.Drawing.Point(0, 89);
            this.btnCategories.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(189, 41);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(0, 179);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(189, 41);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            // 
            // llbAbout
            // 
            this.llbAbout.AutoSize = true;
            this.llbAbout.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llbAbout.Location = new System.Drawing.Point(0, 222);
            this.llbAbout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbAbout.Name = "llbAbout";
            this.llbAbout.Size = new System.Drawing.Size(35, 13);
            this.llbAbout.TabIndex = 4;
            this.llbAbout.TabStop = true;
            this.llbAbout.Text = "About";
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(0, 134);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(189, 41);
            this.btnOrders.TabIndex = 5;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 245);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.llbAbout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnArticles);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArticles;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.LinkLabel llbAbout;
        private System.Windows.Forms.Button btnOrders;
    }
}