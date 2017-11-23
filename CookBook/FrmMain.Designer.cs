namespace CookBook
{
    partial class FrmMain
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
            this.lblReceipes = new System.Windows.Forms.Label();
            this.lstReceipes = new System.Windows.Forms.ListBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.btnAddReceipe = new System.Windows.Forms.Button();
            this.textReceipe1 = new System.Windows.Forms.TextBox();
            this.btnUpdateReceipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReceipes
            // 
            this.lblReceipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipes.Location = new System.Drawing.Point(18, 49);
            this.lblReceipes.Name = "lblReceipes";
            this.lblReceipes.Size = new System.Drawing.Size(119, 33);
            this.lblReceipes.TabIndex = 0;
            this.lblReceipes.Text = "Receipes";
            this.lblReceipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstReceipes
            // 
            this.lstReceipes.FormattingEnabled = true;
            this.lstReceipes.Location = new System.Drawing.Point(17, 89);
            this.lstReceipes.Name = "lstReceipes";
            this.lstReceipes.Size = new System.Drawing.Size(120, 160);
            this.lstReceipes.TabIndex = 1;
            this.lstReceipes.SelectedIndexChanged += new System.EventHandler(this.lstReceipes_SelectedIndexChanged);
            // 
            // lblIngredients
            // 
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(144, 49);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(119, 33);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Ingredients";
            this.lblIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(143, 89);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(120, 160);
            this.lstIngredients.TabIndex = 3;
            // 
            // btnAddReceipe
            // 
            this.btnAddReceipe.Location = new System.Drawing.Point(331, 188);
            this.btnAddReceipe.Name = "btnAddReceipe";
            this.btnAddReceipe.Size = new System.Drawing.Size(93, 23);
            this.btnAddReceipe.TabIndex = 4;
            this.btnAddReceipe.Text = "Add Receipe";
            this.btnAddReceipe.UseVisualStyleBackColor = true;
            this.btnAddReceipe.Click += new System.EventHandler(this.btnAddReceipe_Click);
            // 
            // textReceipe1
            // 
            this.textReceipe1.Location = new System.Drawing.Point(302, 152);
            this.textReceipe1.Name = "textReceipe1";
            this.textReceipe1.Size = new System.Drawing.Size(153, 20);
            this.textReceipe1.TabIndex = 5;
            // 
            // btnUpdateReceipe
            // 
            this.btnUpdateReceipe.Location = new System.Drawing.Point(331, 226);
            this.btnUpdateReceipe.Name = "btnUpdateReceipe";
            this.btnUpdateReceipe.Size = new System.Drawing.Size(93, 23);
            this.btnUpdateReceipe.TabIndex = 6;
            this.btnUpdateReceipe.Text = "Update Receipe Name";
            this.btnUpdateReceipe.UseVisualStyleBackColor = true;
            this.btnUpdateReceipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 261);
            this.Controls.Add(this.btnUpdateReceipe);
            this.Controls.Add(this.textReceipe1);
            this.Controls.Add(this.btnAddReceipe);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lstReceipes);
            this.Controls.Add(this.lblReceipes);
            this.Name = "FrmMain";
            this.Text = "Cookbook";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceipes;
        private System.Windows.Forms.ListBox lstReceipes;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Button btnAddReceipe;
        private System.Windows.Forms.TextBox textReceipe1;
        private System.Windows.Forms.Button btnUpdateReceipe;
    }
}

