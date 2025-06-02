namespace CARDAPIO_POO
{
    partial class FormBalcao
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
            btnMarcarConcluido = new Button();
            btnVerDetalhes = new Button();
            listViewPedidos = new ListView();
            listViewFinalizados = new ListView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMarcarConcluido
            // 
            btnMarcarConcluido.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarcarConcluido.Location = new Point(108, 583);
            btnMarcarConcluido.Name = "btnMarcarConcluido";
            btnMarcarConcluido.Size = new Size(230, 72);
            btnMarcarConcluido.TabIndex = 2;
            btnMarcarConcluido.Text = "Marcar como concluido";
            btnMarcarConcluido.UseVisualStyleBackColor = true;
            btnMarcarConcluido.Click += btnMarcarConcluido_Click;
            // 
            // btnVerDetalhes
            // 
            btnVerDetalhes.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerDetalhes.Location = new Point(350, 583);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(168, 72);
            btnVerDetalhes.TabIndex = 3;
            btnVerDetalhes.Text = "Exibir detalhes";
            btnVerDetalhes.UseVisualStyleBackColor = true;
            btnVerDetalhes.Click += btnVerDetalhes_Click;
            // 
            // listViewPedidos
            // 
            listViewPedidos.FullRowSelect = true;
            listViewPedidos.GridLines = true;
            listViewPedidos.Location = new Point(108, 162);
            listViewPedidos.Name = "listViewPedidos";
            listViewPedidos.Size = new Size(410, 391);
            listViewPedidos.TabIndex = 4;
            listViewPedidos.UseCompatibleStateImageBehavior = false;
            listViewPedidos.View = View.Details;
            listViewPedidos.SelectedIndexChanged += listViewPedidos_SelectedIndexChanged;
            // 
            // listViewFinalizados
            // 
            listViewFinalizados.FullRowSelect = true;
            listViewFinalizados.GridLines = true;
            listViewFinalizados.Location = new Point(631, 162);
            listViewFinalizados.Name = "listViewFinalizados";
            listViewFinalizados.Size = new Size(411, 391);
            listViewFinalizados.TabIndex = 5;
            listViewFinalizados.UseCompatibleStateImageBehavior = false;
            listViewFinalizados.View = View.Details;
            listViewFinalizados.SelectedIndexChanged += listViewFinalizados_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_20_223613_removebg_preview;
            pictureBox1.Location = new Point(32, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // FormBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 0);
            ClientSize = new Size(1208, 682);
            Controls.Add(pictureBox1);
            Controls.Add(listViewFinalizados);
            Controls.Add(listViewPedidos);
            Controls.Add(btnVerDetalhes);
            Controls.Add(btnMarcarConcluido);
            Name = "FormBalcao";
            Text = "FormBalcao";
            Load += FormBalcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMarcarConcluido;
        private Button btnVerDetalhes;
        private ListView listViewPedidos;
        private ListView listViewFinalizados;
        private PictureBox pictureBox1;
    }
}