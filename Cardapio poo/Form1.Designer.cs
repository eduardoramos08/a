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
            dateTimePicker1 = new DateTimePicker();
            dinheiroRecebidoTxt = new TextBox();
            label1 = new Label();
            label3 = new Label();
            Troco = new Label();
            label4 = new Label();
            nomeTxt = new TextBox();
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
            cardapioTxt.Font = new Font("Segoe UI", 15F);
            cardapioTxt.Location = new Point(197, 64);
            cardapioTxt.Name = "cardapioTxt";
            cardapioTxt.Size = new Size(92, 28);
            cardapioTxt.TabIndex = 1;
            cardapioTxt.Text = "Cardápio";
            // 
            // adicionarBtn
            // 
            adicionarBtn.Font = new Font("Segoe UI", 15F);
            adicionarBtn.Location = new Point(614, 149);
            adicionarBtn.Name = "adicionarBtn";
            adicionarBtn.Size = new Size(129, 56);
            adicionarBtn.TabIndex = 2;
            adicionarBtn.Text = "Adicionar";
            adicionarBtn.UseVisualStyleBackColor = true;
            adicionarBtn.Click += adicionarBtn_Click;
            // 
            // removerBtn
            // 
            removerBtn.Font = new Font("Segoe UI", 15F);
            removerBtn.Location = new Point(614, 225);
            removerBtn.Name = "removerBtn";
            removerBtn.Size = new Size(129, 56);
            removerBtn.TabIndex = 3;
            removerBtn.Text = "Remover";
            removerBtn.UseVisualStyleBackColor = true;
            removerBtn.Click += removerBtn_Click;
            // 
            // finalizarBtn
            // 
            finalizarBtn.Font = new Font("Segoe UI", 15F);
            finalizarBtn.Location = new Point(614, 306);
            finalizarBtn.Name = "finalizarBtn";
            finalizarBtn.Size = new Size(129, 56);
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
            listBox1.Location = new Point(12, 111);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(447, 466);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 12F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 21;
            listBox2.Location = new Point(923, 95);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(421, 424);
            listBox2.TabIndex = 6;
            // 
            // pedidoTxt
            // 
            pedidoTxt.AutoSize = true;
            pedidoTxt.Font = new Font("Segoe UI", 15F);
            pedidoTxt.Location = new Point(1051, 64);
            pedidoTxt.Name = "pedidoTxt";
            pedidoTxt.Size = new Size(73, 28);
            pedidoTxt.TabIndex = 7;
            pedidoTxt.Text = "Pedido";
            // 
            // quantidadeTxt
            // 
            quantidadeTxt.Location = new Point(585, 111);
            quantidadeTxt.Name = "quantidadeTxt";
            quantidadeTxt.Size = new Size(195, 23);
            quantidadeTxt.TabIndex = 9;
            quantidadeTxt.TextChanged += quantidadeTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(465, 106);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 11;
            label2.Text = "quantidade:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1189, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(78, 23);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Value = new DateTime(2025, 5, 16, 8, 31, 20, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dinheiroRecebidoTxt
            // 
            dinheiroRecebidoTxt.Location = new Point(636, 425);
            dinheiroRecebidoTxt.Name = "dinheiroRecebidoTxt";
            dinheiroRecebidoTxt.Size = new Size(132, 23);
            dinheiroRecebidoTxt.TabIndex = 15;
            dinheiroRecebidoTxt.TextChanged += dinheiroRecebido_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(490, 420);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 16;
            label1.Text = "Total recebido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(568, 460);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 17;
            label3.Text = "Troco:";
            label3.Click += label3_Click;
            // 
            // Troco
            // 
            Troco.AutoSize = true;
            Troco.Font = new Font("Segoe UI", 13F);
            Troco.Location = new Point(638, 465);
            Troco.Name = "Troco";
            Troco.Size = new Size(124, 25);
            Troco.TabIndex = 19;
            Troco.Text = "________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(560, 382);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 20;
            label4.Text = "Nome:";
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(636, 387);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(134, 23);
            nomeTxt.TabIndex = 21;
            nomeTxt.TextChanged += nomeTxt_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1465, 750);
            Controls.Add(nomeTxt);
            Controls.Add(label4);
            Controls.Add(Troco);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dinheiroRecebidoTxt);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private TextBox dinheiroRecebidoTxt;
        private Label label1;
        private Label label3;
        private Label Troco;
        private Label label4;
        private TextBox nomeTxt;
    }
}
