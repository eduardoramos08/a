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
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // totalTxt
            // 
            totalTxt.AutoSize = true;
            totalTxt.Font = new Font("Segoe UI", 12F);
            totalTxt.Location = new Point(1119, 500);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(0, 21);
            totalTxt.TabIndex = 0;
            // 
            // cardapioTxt
            // 
            cardapioTxt.AutoSize = true;
            cardapioTxt.Font = new Font("Bauhaus 93", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardapioTxt.Location = new Point(212, 124);
            cardapioTxt.Name = "cardapioTxt";
            cardapioTxt.Size = new Size(96, 23);
            cardapioTxt.TabIndex = 1;
            cardapioTxt.Text = "Cardápio";
            cardapioTxt.Click += cardapioTxt_Click;
            // 
            // adicionarBtn
            // 
            adicionarBtn.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adicionarBtn.ForeColor = SystemColors.ControlText;
            adicionarBtn.Location = new Point(580, 155);
            adicionarBtn.Name = "adicionarBtn";
            adicionarBtn.Size = new Size(129, 56);
            adicionarBtn.TabIndex = 2;
            adicionarBtn.Text = "Adicionar";
            adicionarBtn.UseVisualStyleBackColor = true;
            adicionarBtn.Click += adicionarBtn_Click;
            // 
            // removerBtn
            // 
            removerBtn.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removerBtn.Location = new Point(715, 155);
            removerBtn.Name = "removerBtn";
            removerBtn.Size = new Size(129, 56);
            removerBtn.TabIndex = 3;
            removerBtn.Text = "Remover";
            removerBtn.UseVisualStyleBackColor = true;
            removerBtn.Click += removerBtn_Click;
            // 
            // finalizarBtn
            // 
            finalizarBtn.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finalizarBtn.Location = new Point(850, 155);
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
            pedidoTxt.Font = new Font("Bauhaus 93", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pedidoTxt.Location = new Point(1214, 124);
            pedidoTxt.Name = "pedidoTxt";
            pedidoTxt.Size = new Size(73, 23);
            pedidoTxt.TabIndex = 7;
            pedidoTxt.Text = "Pedido";
            // 
            // quantidadeTxt
            // 
            quantidadeTxt.Location = new Point(729, 268);
            quantidadeTxt.Name = "quantidadeTxt";
            quantidadeTxt.Size = new Size(130, 23);
            quantidadeTxt.TabIndex = 9;
            quantidadeTxt.TextChanged += quantidadeTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(629, 268);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
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
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dinheiroRecebidoTxt
            // 
            dinheiroRecebidoTxt.Location = new Point(730, 395);
            dinheiroRecebidoTxt.Name = "dinheiroRecebidoTxt";
            dinheiroRecebidoTxt.Size = new Size(124, 23);
            dinheiroRecebidoTxt.TabIndex = 15;
            dinheiroRecebidoTxt.TextChanged += dinheiroRecebido_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(607, 394);
            label1.Name = "label1";
            label1.Size = new Size(117, 24);
            label1.TabIndex = 16;
            label1.Text = "Total recebido:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(668, 428);
            label3.Name = "label3";
            label3.Size = new Size(56, 24);
            label3.TabIndex = 17;
            label3.Text = "Troco:";
            label3.Click += label3_Click;
            // 
            // Troco
            // 
            Troco.AutoSize = true;
            Troco.Font = new Font("Segoe UI", 13F);
            Troco.Location = new Point(729, 429);
            Troco.Name = "Troco";
            Troco.Size = new Size(124, 25);
            Troco.TabIndex = 19;
            Troco.Text = "________________";
            Troco.Click += Troco_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(664, 308);
            label4.Name = "label4";
            label4.Size = new Size(60, 24);
            label4.TabIndex = 20;
            label4.Text = "Nome:";
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(730, 309);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(131, 23);
            nomeTxt.TabIndex = 21;
            nomeTxt.TextChanged += nomeTxt_TextChanged;
            // 
            // listViewCardapio
            // 
            listViewCardapio.BackColor = Color.FromArgb(243, 241, 238);
            listViewCardapio.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewCardapio.Font = new Font("Segoe UI", 15F);
            listViewCardapio.FullRowSelect = true;
            listViewCardapio.GridLines = true;
            listViewCardapio.Location = new Point(12, 155);
            listViewCardapio.MultiSelect = false;
            listViewCardapio.Name = "listViewCardapio";
            listViewCardapio.Size = new Size(494, 505);
            listViewCardapio.TabIndex = 22;
            listViewCardapio.UseCompatibleStateImageBehavior = false;
            listViewCardapio.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 80;
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
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Preço (R$)";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 110;
            // 
            // listViewCarrinho
            // 
            listViewCarrinho.BackColor = Color.FromArgb(243, 241, 238);
            listViewCarrinho.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewCarrinho.Font = new Font("Segoe UI", 15F);
            listViewCarrinho.FullRowSelect = true;
            listViewCarrinho.GridLines = true;
            listViewCarrinho.Location = new Point(1036, 155);
            listViewCarrinho.MultiSelect = false;
            listViewCarrinho.Name = "listViewCarrinho";
            listViewCarrinho.Size = new Size(505, 505);
            listViewCarrinho.TabIndex = 23;
            listViewCarrinho.UseCompatibleStateImageBehavior = false;
            listViewCarrinho.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Produto";
            columnHeader5.Width = 150;
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
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Subtotal (R$)";
            columnHeader8.TextAlign = HorizontalAlignment.Right;
            columnHeader8.Width = 150;
            // 
            // comboBoxFormaPagamento
            // 
            comboBoxFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormaPagamento.FormattingEnabled = true;
            comboBoxFormaPagamento.Location = new Point(729, 349);
            comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            comboBoxFormaPagamento.Size = new Size(128, 23);
            comboBoxFormaPagamento.TabIndex = 24;
            comboBoxFormaPagamento.SelectedIndexChanged += comboBoxFormaPagamento_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(547, 348);
            label5.Name = "label5";
            label5.Size = new Size(187, 24);
            label5.TabIndex = 25;
            label5.Text = "Método de pagamento: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Captura_de_tela_2025_05_20_223613_removebg_preview;
            pictureBox1.Location = new Point(39, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(547, 539);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(385, 94);
            listBox1.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(755, 510);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 28;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 0);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1574, 736);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
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
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button1;
    }
}
