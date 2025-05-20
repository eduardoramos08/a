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
            listViewCardapio = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listViewCarrinho = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            comboBoxFormaPagamento = new ComboBox();
            label5 = new Label();
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
            finalizarBtn.Location = new Point(614, 544);
            finalizarBtn.Name = "finalizarBtn";
            finalizarBtn.Size = new Size(129, 56);
            finalizarBtn.TabIndex = 4;
            finalizarBtn.Text = "Finalizar";
            finalizarBtn.UseVisualStyleBackColor = true;
            finalizarBtn.Click += finalizarBtn_Click;
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
            dinheiroRecebidoTxt.Location = new Point(637, 458);
            dinheiroRecebidoTxt.Name = "dinheiroRecebidoTxt";
            dinheiroRecebidoTxt.Size = new Size(132, 23);
            dinheiroRecebidoTxt.TabIndex = 15;
            dinheiroRecebidoTxt.TextChanged += dinheiroRecebido_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(491, 453);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 16;
            label1.Text = "Total recebido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(569, 493);
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
            Troco.Location = new Point(639, 498);
            Troco.Name = "Troco";
            Troco.Size = new Size(124, 25);
            Troco.TabIndex = 19;
            Troco.Text = "________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(561, 415);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 20;
            label4.Text = "Nome:";
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(637, 420);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(134, 23);
            nomeTxt.TabIndex = 21;
            nomeTxt.TextChanged += nomeTxt_TextChanged;
            // 
            // listViewCardapio
            // 
            listViewCardapio.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewCardapio.FullRowSelect = true;
            listViewCardapio.GridLines = true;
            listViewCardapio.Location = new Point(29, 121);
            listViewCardapio.MultiSelect = false;
            listViewCardapio.Name = "listViewCardapio";
            listViewCardapio.Size = new Size(430, 505);
            listViewCardapio.TabIndex = 22;
            listViewCardapio.UseCompatibleStateImageBehavior = false;
            listViewCardapio.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Descrição";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Estoque";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Preço (R$)";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 80;
            // 
            // listViewCarrinho
            // 
            listViewCarrinho.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewCarrinho.FullRowSelect = true;
            listViewCarrinho.GridLines = true;
            listViewCarrinho.Location = new Point(966, 121);
            listViewCarrinho.MultiSelect = false;
            listViewCarrinho.Name = "listViewCarrinho";
            listViewCarrinho.Size = new Size(339, 505);
            listViewCarrinho.TabIndex = 23;
            listViewCarrinho.UseCompatibleStateImageBehavior = false;
            listViewCarrinho.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Produto";
            columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Qtd";
            columnHeader6.TextAlign = HorizontalAlignment.Right;
            columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Preço Unit. (R$";
            columnHeader7.TextAlign = HorizontalAlignment.Right;
            columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Subtotal (R$)";
            columnHeader8.TextAlign = HorizontalAlignment.Right;
            columnHeader8.Width = 90;
            // 
            // comboBoxFormaPagamento
            // 
            comboBoxFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormaPagamento.FormattingEnabled = true;
            comboBoxFormaPagamento.Location = new Point(702, 309);
            comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            comboBoxFormaPagamento.Size = new Size(177, 23);
            comboBoxFormaPagamento.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(475, 309);
            label5.Name = "label5";
            label5.Size = new Size(221, 28);
            label5.TabIndex = 25;
            label5.Text = "Método de pagamento ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1465, 750);
            Controls.Add(label5);
            Controls.Add(comboBoxFormaPagamento);
            Controls.Add(listViewCarrinho);
            Controls.Add(listViewCardapio);
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
        private ListView listViewCardapio;
        private ListView listViewCarrinho;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ComboBox comboBoxFormaPagamento;
        private Label label5;
    }
}
