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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            btnMarcarConcluido = new Button();
            btnVerDetalhes = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 89);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(494, 379);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(641, 89);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(485, 379);
            listBox2.TabIndex = 1;
            // 
            // btnMarcarConcluido
            // 
            btnMarcarConcluido.Font = new Font("Segoe UI", 15F);
            btnMarcarConcluido.Location = new Point(12, 502);
            btnMarcarConcluido.Name = "btnMarcarConcluido";
            btnMarcarConcluido.Size = new Size(230, 72);
            btnMarcarConcluido.TabIndex = 2;
            btnMarcarConcluido.Text = "Marcar como concluido";
            btnMarcarConcluido.UseVisualStyleBackColor = true;
            btnMarcarConcluido.Click += btnMarcarConcluido_Click;
            // 
            // btnVerDetalhes
            // 
            btnVerDetalhes.Font = new Font("Segoe UI", 15F);
            btnVerDetalhes.Location = new Point(285, 502);
            btnVerDetalhes.Name = "btnVerDetalhes";
            btnVerDetalhes.Size = new Size(168, 72);
            btnVerDetalhes.TabIndex = 3;
            btnVerDetalhes.Text = "Exibir detalhes";
            btnVerDetalhes.UseVisualStyleBackColor = true;
            btnVerDetalhes.Click += btnVerDetalhes_Click;
            // 
            // FormBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 682);
            Controls.Add(btnVerDetalhes);
            Controls.Add(btnMarcarConcluido);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "FormBalcao";
            Text = "FormBalcao";
            Load += FormBalcao_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button btnMarcarConcluido;
        private Button btnVerDetalhes;
    }
}