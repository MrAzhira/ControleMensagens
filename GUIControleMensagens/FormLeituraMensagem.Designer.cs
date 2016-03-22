namespace GUIControleMensagens
{
    partial class FormLeituraMensagem
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
            this.UsuarioDataGrid = new System.Windows.Forms.DataGridView();
            this.BuscaButton = new System.Windows.Forms.Button();
            this.UsuarioBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioDataGrid
            // 
            this.UsuarioDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuarioDataGrid.Location = new System.Drawing.Point(58, 63);
            this.UsuarioDataGrid.Name = "UsuarioDataGrid";
            this.UsuarioDataGrid.Size = new System.Drawing.Size(406, 206);
            this.UsuarioDataGrid.TabIndex = 0;
            // 
            // BuscaButton
            // 
            this.BuscaButton.Location = new System.Drawing.Point(341, 22);
            this.BuscaButton.Name = "BuscaButton";
            this.BuscaButton.Size = new System.Drawing.Size(123, 23);
            this.BuscaButton.TabIndex = 1;
            this.BuscaButton.Text = "Buscar Mensagens";
            this.BuscaButton.UseVisualStyleBackColor = true;
            this.BuscaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsuarioBox
            // 
            this.UsuarioBox.Location = new System.Drawing.Point(138, 24);
            this.UsuarioBox.Name = "UsuarioBox";
            this.UsuarioBox.Size = new System.Drawing.Size(182, 20);
            this.UsuarioBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Usuario:";
            // 
            // FormLeituraMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuarioBox);
            this.Controls.Add(this.BuscaButton);
            this.Controls.Add(this.UsuarioDataGrid);
            this.Name = "FormLeituraMensagem";
            this.Text = "Leitor/Busca de Mensagens";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsuarioDataGrid;
        private System.Windows.Forms.Button BuscaButton;
        private System.Windows.Forms.TextBox UsuarioBox;
        private System.Windows.Forms.Label label1;
    }
}