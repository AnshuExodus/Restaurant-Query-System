namespace Cinnamon
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Go = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.michelin_stars = new System.Windows.Forms.TextBox();
            this.price_for_two = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(97, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "RESTAURANTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(134, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "(By Area)";
            // 
            // P
            // 
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.P.Location = new System.Drawing.Point(88, 415);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(33, 36);
            this.P.TabIndex = 9;
            this.P.Text = "<";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // N
            // 
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.N.Location = new System.Drawing.Point(237, 415);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(33, 36);
            this.N.TabIndex = 10;
            this.N.Text = ">";
            this.N.UseVisualStyleBackColor = true;
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Maiandra GD", 12F);
            this.back.Location = new System.Drawing.Point(136, 461);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 32);
            this.back.TabIndex = 11;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(120, 108);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(119, 20);
            this.searchbar.TabIndex = 19;
            this.searchbar.TextChanged += new System.EventHandler(this.searchbar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter State";
            // 
            // Go
            // 
            this.Go.Font = new System.Drawing.Font("Maiandra GD", 9F);
            this.Go.Location = new System.Drawing.Point(250, 108);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(54, 20);
            this.Go.TabIndex = 21;
            this.Go.Text = "GO!";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click_1);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.name.Location = new System.Drawing.Point(102, 172);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(162, 37);
            this.name.TabIndex = 22;
            this.name.Text = "Name";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.id.Location = new System.Drawing.Point(102, 224);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(162, 42);
            this.id.TabIndex = 23;
            this.id.Text = "ID";
            // 
            // michelin_stars
            // 
            this.michelin_stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.michelin_stars.Location = new System.Drawing.Point(102, 287);
            this.michelin_stars.Multiline = true;
            this.michelin_stars.Name = "michelin_stars";
            this.michelin_stars.Size = new System.Drawing.Size(162, 41);
            this.michelin_stars.TabIndex = 24;
            this.michelin_stars.Text = "Michelin Stars";
            // 
            // price_for_two
            // 
            this.price_for_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.price_for_two.Location = new System.Drawing.Point(102, 344);
            this.price_for_two.Multiline = true;
            this.price_for_two.Name = "price_for_two";
            this.price_for_two.Size = new System.Drawing.Size(162, 36);
            this.price_for_two.TabIndex = 25;
            this.price_for_two.Text = "Price For Two";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(98, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 10);
            this.label4.TabIndex = 27;
            this.label4.Text = "TM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cinnamon";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(348, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price_for_two);
            this.Controls.Add(this.michelin_stars);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.back);
            this.Controls.Add(this.N);
            this.Controls.Add(this.P);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button N;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox searchbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox michelin_stars;
        private System.Windows.Forms.TextBox price_for_two;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}