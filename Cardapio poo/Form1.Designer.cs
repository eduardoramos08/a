namespace CARDAPIO_POO
{
    partial class Form1
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
            totalTxt = new Label();
            cardapioTxt = new Label();
            adicionarBtn = new Button();
            removerBtn = new Button();
            finalizarBtn = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            pedidoTxt = new Label();
            quantidadeTxt = new TextBox();
            label2 = new Label();
            verificarBtn = new Button();
            pagamentoBtn = new Button();
            SuspendLayout();
            // 
            // totalTxt
            // 
            totalTxt.AutoSize = true;
            totalTxt.Font = new Font("Segoe UI", 12F);
            totalTxt.Location = new Point(1030, 544);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(0, 21);
            totalTxt.TabIndex = 0;
            // 
            // cardapioTxt
            // 
            cardapioTxt.AutoSize = true;
            cardapioTxt.Font = new Font("Segoe UI", 12F);
            cardapioTxt.Location = new Point(193, 46);
            cardapioTxt.Name = "cardapioTxt";
            cardapioTxt.Size = new Size(73, 21);
            cardapioTxt.TabIndex = 1;
            cardapioTxt.Text = "Cardápio";
            // 
            // adicionarBtn
            // 
            adicionarBtn.Location = new Point(814, 70);
            adicionarBtn.Name = "adicionarBtn";
            adicionarBtn.Size = new Size(156, 85);
            adicionarBtn.TabIndex = 2;
            adicionarBtn.Text = "Adicionar";
            adicionarBtn.UseVisualStyleBackColor = true;
            adicionarBtn.Click += adicionarBtn_Click;
            // 
            // removerBtn
            // 
            removerBtn.Location = new Point(814, 182);
            removerBtn.Name = "removerBtn";
            removerBtn.Size = new Size(156, 85);
            removerBtn.TabIndex = 3;
            removerBtn.Text = "Remover";
            removerBtn.UseVisualStyleBackColor = true;
            removerBtn.Click += removerBtn_Click;
            // 
            // finalizarBtn
            // 
            finalizarBtn.Location = new Point(814, 439);
            finalizarBtn.Name = "finalizarBtn";
            finalizarBtn.Size = new Size(156, 85);
            finalizarBtn.TabIndex = 4;
            finalizarBtn.Text = "Finalizar";
            finalizarBtn.UseVisualStyleBackColor = true;
            finalizarBtn.Click += finalizarBtn_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(12, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(467, 466);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 10F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 17;
            listBox2.Location = new Point(1015, 80);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(421, 429);
            listBox2.TabIndex = 6;
            // 
            // pedidoTxt
            // 
            pedidoTxt.AutoSize = true;
            pedidoTxt.Font = new Font("Segoe UI", 12F);
            pedidoTxt.Location = new Point(1129, 46);
            pedidoTxt.Name = "pedidoTxt";
            pedidoTxt.Size = new Size(57, 21);
            pedidoTxt.TabIndex = 7;
            pedidoTxt.Text = "Pedido";
            // 
            // quantidadeTxt
            // 
            quantidadeTxt.Location = new Point(596, 136);
            quantidadeTxt.Name = "quantidadeTxt";
            quantidadeTxt.Size = new Size(195, 23);
            quantidadeTxt.TabIndex = 9;
            quantidadeTxt.TextChanged += quantidadeTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(499, 134);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 11;
            label2.Text = "quantidade:";
            // 
            // verificarBtn
            // 
            verificarBtn.Location = new Point(12, 546);
            verificarBtn.Name = "verificarBtn";
            verificarBtn.Size = new Size(156, 85);
            verificarBtn.TabIndex = 12;
            verificarBtn.Text = "Verificar estoque";
            verificarBtn.UseVisualStyleBackColor = true;
            // 
            // pagamentoBtn
            // 
            pagamentoBtn.Location = new Point(814, 318);
            pagamentoBtn.Name = "pagamentoBtn";
            pagamentoBtn.Size = new Size(156, 85);
            pagamentoBtn.TabIndex = 13;
            pagamentoBtn.Text = "Escolher pagamento";
            pagamentoBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 750);
            Controls.Add(pagamentoBtn);
            Controls.Add(verificarBtn);
            Controls.Add(label2);
            Controls.Add(quantidadeTxt);
            Controls.Add(pedidoTxt);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(finalizarBtn);
            Controls.Add(removerBtn);
            Controls.Add(adicionarBtn);
            Controls.Add(cardapioTxt);
            Controls.Add(totalTxt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalTxt;
        private Label cardapioTxt;
        private Button adicionarBtn;
        private Button removerBtn;
        private Button finalizarBtn;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label pedidoTxt;
        private TextBox quantidadeTxt;
        private Label label2;
        private Button verificarBtn;
        private Button pagamentoBtn;
    }
}
