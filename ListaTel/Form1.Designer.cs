namespace ListaTel
{
    partial class ListaTel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaTel));
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Nomelb = new System.Windows.Forms.Label();
            this.Tellb = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lstTel = new System.Windows.Forms.Label();
            this.listAl = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgBox
            // 
            this.ImgBox.Image = ((System.Drawing.Image)(resources.GetObject("ImgBox.Image")));
            this.ImgBox.InitialImage = null;
            this.ImgBox.Location = new System.Drawing.Point(30, 25);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(107, 95);
            this.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox.TabIndex = 0;
            this.ImgBox.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Location = new System.Drawing.Point(239, 49);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(83, 23);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "AGENDA";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 162);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 23);
            this.txtNome.TabIndex = 2;
            // 
            // Nomelb
            // 
            this.Nomelb.AutoSize = true;
            this.Nomelb.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nomelb.Location = new System.Drawing.Point(30, 163);
            this.Nomelb.Name = "Nomelb";
            this.Nomelb.Size = new System.Drawing.Size(48, 17);
            this.Nomelb.TabIndex = 3;
            this.Nomelb.Text = "Nome";
            // 
            // Tellb
            // 
            this.Tellb.AutoSize = true;
            this.Tellb.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tellb.Location = new System.Drawing.Point(30, 212);
            this.Tellb.Name = "Tellb";
            this.Tellb.Size = new System.Drawing.Size(67, 17);
            this.Tellb.TabIndex = 5;
            this.Tellb.Text = "Telefone";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(103, 209);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(160, 23);
            this.txtTel.TabIndex = 4;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(290, 210);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(160, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click_1);
            // 
            // lstTel
            // 
            this.lstTel.AutoSize = true;
            this.lstTel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTel.Location = new System.Drawing.Point(30, 264);
            this.lstTel.Name = "lstTel";
            this.lstTel.Size = new System.Drawing.Size(132, 17);
            this.lstTel.TabIndex = 7;
            this.lstTel.Text = "Lista de telefones";
            // 
            // listAl
            // 
            this.listAl.FormattingEnabled = true;
            this.listAl.ItemHeight = 15;
            this.listAl.Location = new System.Drawing.Point(30, 296);
            this.listAl.Name = "listAl";
            this.listAl.Size = new System.Drawing.Size(420, 124);
            this.listAl.TabIndex = 8;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(290, 258);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(160, 23);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click_1);
            // 
            // ListaTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.listAl);
            this.Controls.Add(this.lstTel);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.Tellb);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.Nomelb);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.ImgBox);
            this.Name = "ListaTel";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ImgBox;
        private Label Titulo;
        private TextBox txtNome;
        private Label Nomelb;
        private Label Tellb;
        private TextBox txtTel;
        private Button btnIncluir;
        private Label lstTel;
        private ListBox listAl;
        private Button btnListar;
    }
}