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
            this.lstAllIngredients = new System.Windows.Forms.ListBox();
            this.lblAllIngredients = new System.Windows.Forms.Label();
            this.BtnSelectIngredient = new System.Windows.Forms.Button();
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
            this.btnAddReceipe.Location = new System.Drawing.Point(476, 130);
            this.btnAddReceipe.Name = "btnAddReceipe";
            this.btnAddReceipe.Size = new System.Drawing.Size(100, 23);
            this.btnAddReceipe.TabIndex = 4;
            this.btnAddReceipe.Text = "Add Receipe";
            this.btnAddReceipe.UseVisualStyleBackColor = true;
            this.btnAddReceipe.Click += new System.EventHandler(this.btnAddReceipe_Click);
            // 
            // textReceipe1
            // 
            this.textReceipe1.Location = new System.Drawing.Point(447, 89);
            this.textReceipe1.Name = "textReceipe1";
            this.textReceipe1.Size = new System.Drawing.Size(153, 20);
            this.textReceipe1.TabIndex = 5;
            // 
            // btnUpdateReceipe
            // 
            this.btnUpdateReceipe.Location = new System.Drawing.Point(476, 173);
            this.btnUpdateReceipe.Name = "btnUpdateReceipe";
            this.btnUpdateReceipe.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateReceipe.TabIndex = 6;
            this.btnUpdateReceipe.Text = "Update Receipe Name";
            this.btnUpdateReceipe.UseVisualStyleBackColor = true;
            this.btnUpdateReceipe.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstAllIngredients
            // 
            this.lstAllIngredients.FormattingEnabled = true;
            this.lstAllIngredients.Location = new System.Drawing.Point(283, 89);
            this.lstAllIngredients.Name = "lstAllIngredients";
            this.lstAllIngredients.Size = new System.Drawing.Size(120, 160);
            this.lstAllIngredients.TabIndex = 8;
            // 
            // lblAllIngredients
            // 
            this.lblAllIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllIngredients.Location = new System.Drawing.Point(284, 49);
            this.lblAllIngredients.Name = "lblAllIngredients";
            this.lblAllIngredients.Size = new System.Drawing.Size(119, 33);
            this.lblAllIngredients.TabIndex = 7;
            this.lblAllIngredients.Text = "All Ingredients";
            this.lblAllIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSelectIngredient
            // 
            this.BtnSelectIngredient.Location = new System.Drawing.Point(476, 213);
            this.BtnSelectIngredient.Name = "BtnSelectIngredient";
            this.BtnSelectIngredient.Size = new System.Drawing.Size(100, 23);
            this.BtnSelectIngredient.TabIndex = 9;
            this.BtnSelectIngredient.Text = "Select Ingredient";
            this.BtnSelectIngredient.UseVisualStyleBackColor = true;
            this.BtnSelectIngredient.Click += new System.EventHandler(this.BtnSelectIngredient_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 432);
            this.Controls.Add(this.BtnSelectIngredient);
            this.Controls.Add(this.lstAllIngredients);
            this.Controls.Add(this.lblAllIngredients);
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
        private System.Windows.Forms.ListBox lstAllIngredients;
        private System.Windows.Forms.Label lblAllIngredients;
        private System.Windows.Forms.Button BtnSelectIngredient;
    }
}

