
namespace programa1
{
    partial class HelloWorld
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
            this.Lb_Titulo = new System.Windows.Forms.Label();
            this.Bt_fechar = new System.Windows.Forms.Button();
            this.Bt_Modif_Label = new System.Windows.Forms.Button();
            this.Txt_conteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lb_Titulo
            // 
            this.Lb_Titulo.AutoSize = true;
            this.Lb_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Titulo.Location = new System.Drawing.Point(29, 31);
            this.Lb_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_Titulo.Name = "Lb_Titulo";
            this.Lb_Titulo.Size = new System.Drawing.Size(213, 19);
            this.Lb_Titulo.TabIndex = 0;
            this.Lb_Titulo.Text = "Visual Studio. NET Version";
            // 
            // Bt_fechar
            // 
            this.Bt_fechar.Location = new System.Drawing.Point(443, 370);
            this.Bt_fechar.Name = "Bt_fechar";
            this.Bt_fechar.Size = new System.Drawing.Size(155, 30);
            this.Bt_fechar.TabIndex = 1;
            this.Bt_fechar.Text = "Fechar a Aplicação";
            this.Bt_fechar.UseVisualStyleBackColor = true;
            this.Bt_fechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bt_Modif_Label
            // 
            this.Bt_Modif_Label.Location = new System.Drawing.Point(33, 64);
            this.Bt_Modif_Label.Name = "Bt_Modif_Label";
            this.Bt_Modif_Label.Size = new System.Drawing.Size(209, 30);
            this.Bt_Modif_Label.TabIndex = 2;
            this.Bt_Modif_Label.Text = "Mod. Texto Label";
            this.Bt_Modif_Label.UseVisualStyleBackColor = true;
            this.Bt_Modif_Label.Click += new System.EventHandler(this.Bt_Modif_Label_Click);
            // 
            // Txt_conteudoLabel
            // 
            this.Txt_conteudoLabel.Location = new System.Drawing.Point(33, 101);
            this.Txt_conteudoLabel.Name = "Txt_conteudoLabel";
            this.Txt_conteudoLabel.Size = new System.Drawing.Size(476, 26);
            this.Txt_conteudoLabel.TabIndex = 3;
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 412);
            this.Controls.Add(this.Txt_conteudoLabel);
            this.Controls.Add(this.Bt_Modif_Label);
            this.Controls.Add(this.Bt_fechar);
            this.Controls.Add(this.Lb_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HelloWorld";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Titulo;
        private System.Windows.Forms.Button Bt_fechar;
        private System.Windows.Forms.Button Bt_Modif_Label;
        private System.Windows.Forms.TextBox Txt_conteudoLabel;
    }
}

