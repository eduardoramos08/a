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
            SuspendLayout();
            // 
            // totalTxt
            // 
            totalTxt.AutoSize = true;
            totalTxt.Location = new Point(582, 380);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(37, 15);
            totalTxt.TabIndex = 0;
            totalTxt.Text = "total :";
            // 
            // cardapioTxt
            // 
            cardapioTxt.AutoSize = true;
            cardapioTxt.Location = new Point(148, 41);
            cardapioTxt.Name = "cardapioTxt";
            cardapioTxt.Size = new Size(55, 15);
            cardapioTxt.TabIndex = 1;
            cardapioTxt.Text = "Cardápio";
            // 
            // adicionarBtn
            // 
            adicionarBtn.Location = new Point(357, 80);
            adicionarBtn.Name = "adicionarBtn";
            adicionarBtn.Size = new Size(122, 51);
            adicionarBtn.TabIndex = 2;
            adicionarBtn.Text = "Adicionar";
            adicionarBtn.UseVisualStyleBackColor = true;
            adicionarBtn.Click += adicionarBtn_Click;
            // 
            // removerBtn
            // 
            removerBtn.Location = new Point(357, 137);
            removerBtn.Name = "removerBtn";
            removerBtn.Size = new Size(122, 66);
            removerBtn.TabIndex = 3;
            removerBtn.Text = "Remover";
            removerBtn.UseVisualStyleBackColor = true;
            removerBtn.Click += removerBtn_Click;
            // 
            // finalizarBtn
            // 
            finalizarBtn.Location = new Point(357, 209);
            finalizarBtn.Name = "finalizarBtn";
            finalizarBtn.Size = new Size(122, 89);
            finalizarBtn.TabIndex = 4;
            finalizarBtn.Text = "Finalizar";
            finalizarBtn.UseVisualStyleBackColor = true;
            finalizarBtn.Click += finalizarBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(102, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(135, 184);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(582, 90);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(190, 274);
            listBox2.TabIndex = 6;
            // 
            // pedidoTxt
            // 
            pedidoTxt.AutoSize = true;
            pedidoTxt.Location = new Point(681, 48);
            pedidoTxt.Name = "pedidoTxt";
            pedidoTxt.Size = new Size(44, 15);
            pedidoTxt.TabIndex = 7;
            pedidoTxt.Text = "Pedido";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
