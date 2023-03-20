namespace Calculadora
{
    partial class Form1
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
            this.caixa = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.sair = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caixa
            // 
            this.caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.caixa.Location = new System.Drawing.Point(2, 78);
            this.caixa.Multiline = true;
            this.caixa.Name = "caixa";
            this.caixa.ReadOnly = true;
            this.caixa.Size = new System.Drawing.Size(247, 40);
            this.caixa.TabIndex = 0;
            this.caixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.caixa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.resultado.Location = new System.Drawing.Point(-1, 110);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(250, 33);
            this.resultado.TabIndex = 1;
            // 
            // sair
            // 
            this.sair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sair.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.sair.Location = new System.Drawing.Point(207, 1);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(42, 21);
            this.sair.TabIndex = 2;
            this.sair.Text = "Sair>";
            this.sair.UseVisualStyleBackColor = false;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // limpar
            // 
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.limpar.ForeColor = System.Drawing.Color.Orange;
            this.limpar.Location = new System.Drawing.Point(2, 146);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(66, 56);
            this.limpar.TabIndex = 3;
            this.limpar.Text = "LIMP.";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // dividir
            // 
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dividir.ForeColor = System.Drawing.Color.Orange;
            this.dividir.Location = new System.Drawing.Point(64, 146);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(66, 56);
            this.dividir.TabIndex = 4;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.multiplicar.ForeColor = System.Drawing.Color.Orange;
            this.multiplicar.Location = new System.Drawing.Point(127, 146);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(66, 56);
            this.multiplicar.TabIndex = 5;
            this.multiplicar.Text = "x";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // apagar
            // 
            this.apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.apagar.ForeColor = System.Drawing.Color.Orange;
            this.apagar.Location = new System.Drawing.Point(186, 146);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(66, 56);
            this.apagar.TabIndex = 6;
            this.apagar.Text = "DEL";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.button4_Click);
            // 
            // menos
            // 
            this.menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.menos.ForeColor = System.Drawing.Color.Orange;
            this.menos.Location = new System.Drawing.Point(186, 198);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(66, 56);
            this.menos.TabIndex = 10;
            this.menos.Text = "-";
            this.menos.UseVisualStyleBackColor = true;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n9.Location = new System.Drawing.Point(127, 198);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(66, 56);
            this.n9.TabIndex = 9;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n8.Location = new System.Drawing.Point(64, 198);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(66, 56);
            this.n8.TabIndex = 8;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n7.Location = new System.Drawing.Point(2, 198);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(66, 56);
            this.n7.TabIndex = 7;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.add.ForeColor = System.Drawing.Color.Orange;
            this.add.Location = new System.Drawing.Point(186, 250);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(66, 56);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n6.Location = new System.Drawing.Point(127, 250);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(66, 56);
            this.n6.TabIndex = 13;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n5.Location = new System.Drawing.Point(64, 250);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(66, 56);
            this.n5.TabIndex = 12;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n4.Location = new System.Drawing.Point(2, 250);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(66, 56);
            this.n4.TabIndex = 11;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n3.Location = new System.Drawing.Point(127, 302);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(66, 56);
            this.n3.TabIndex = 17;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n2.Location = new System.Drawing.Point(64, 302);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(66, 56);
            this.n2.TabIndex = 16;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n1.Location = new System.Drawing.Point(2, 302);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(66, 56);
            this.n1.TabIndex = 15;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // virgula
            // 
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.virgula.Location = new System.Drawing.Point(127, 349);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(66, 56);
            this.virgula.TabIndex = 21;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = true;
            // 
            // n0
            // 
            this.n0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.n0.Location = new System.Drawing.Point(2, 349);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(128, 56);
            this.n0.TabIndex = 19;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = true;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.Orange;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.igual.ForeColor = System.Drawing.SystemColors.Info;
            this.igual.Location = new System.Drawing.Point(186, 302);
            this.igual.Name = "igual";
            this.igual.Padding = new System.Windows.Forms.Padding(1);
            this.igual.Size = new System.Drawing.Size(66, 103);
            this.igual.TabIndex = 22;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 405);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.caixa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcule Joel Setembro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixa;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.Button igual;
    }
}

