namespace Combo_BoxV2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxInserir = new System.Windows.Forms.ComboBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNome
            // 
            this.comboBoxNome.AutoSize = true;
            this.comboBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNome.Location = new System.Drawing.Point(114, 112);
            this.comboBoxNome.Name = "comboBoxNome";
            this.comboBoxNome.Size = new System.Drawing.Size(189, 25);
            this.comboBoxNome.TabIndex = 0;
            this.comboBoxNome.Text = "Digite seu nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(309, 109);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(229, 31);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBoxInserir
            // 
            this.comboBoxInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxInserir.FormattingEnabled = true;
            this.comboBoxInserir.Location = new System.Drawing.Point(309, 163);
            this.comboBoxInserir.Name = "comboBoxInserir";
            this.comboBoxInserir.Size = new System.Drawing.Size(229, 28);
            this.comboBoxInserir.TabIndex = 2;
            this.comboBoxInserir.Text = "==Selecionar item===";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.Location = new System.Drawing.Point(215, 260);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(143, 42);
            this.buttonInserir.TabIndex = 3;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(464, 260);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(137, 42);
            this.buttonRemover.TabIndex = 4;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.comboBoxInserir);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.comboBoxNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label comboBoxNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.ComboBox comboBoxInserir;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonRemover;
    }
}

