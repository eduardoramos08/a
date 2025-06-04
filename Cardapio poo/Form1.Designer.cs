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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            button1 = new Button();
            btnViagem = new CheckBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // totalTxt
            // 
            totalTxt.AutoSize = true;
            totalTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalTxt.Location = new Point(1119, 500);
            totalTxt.Name = "totalTxt";
            totalTxt.Size = new Size(0, 21);
            totalTxt.TabIndex = 0;
            // 
            // cardapioTxt
            // 
            cardapioTxt.AutoSize = true;
            cardapioTxt.Font = new Font("Agrandir Narrow Bold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            cardapioTxt.Location = new Point(204, 115);
            cardapioTxt.Name = "cardapioTxt";
            cardapioTxt.Size = new Size(129, 36);
            cardapioTxt.TabIndex = 1;
            cardapioTxt.Text = "Cardápio";
            cardapioTxt.Click += cardapioTxt_Click;
            // 
            // adicionarBtn
            // 
            adicionarBtn.BackColor = Color.FromArgb(243, 241, 238);
            adicionarBtn.BackgroundImage = (Image)resources.GetObject("adicionarBtn.BackgroundImage");
            adicionarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            adicionarBtn.FlatAppearance.BorderSize = 0;
            adicionarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            adicionarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            adicionarBtn.FlatStyle = FlatStyle.Flat;
            adicionarBtn.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            adicionarBtn.ForeColor = Color.White;
            adicionarBtn.Location = new Point(555, 181);
            adicionarBtn.Name = "adicionarBtn";
            adicionarBtn.Size = new Size(156, 150);
            adicionarBtn.TabIndex = 2;
            adicionarBtn.Text = "Adicionar";
            adicionarBtn.UseVisualStyleBackColor = false;
            adicionarBtn.Click += adicionarBtn_Click;
            // 
            // removerBtn
            // 
            removerBtn.BackColor = Color.FromArgb(243, 241, 238);
            removerBtn.BackgroundImage = (Image)resources.GetObject("removerBtn.BackgroundImage");
            removerBtn.BackgroundImageLayout = ImageLayout.Stretch;
            removerBtn.FlatAppearance.BorderSize = 0;
            removerBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            removerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            removerBtn.FlatStyle = FlatStyle.Flat;
            removerBtn.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            removerBtn.ForeColor = Color.White;
            removerBtn.Location = new Point(706, 182);
            removerBtn.Name = "removerBtn";
            removerBtn.Size = new Size(156, 150);
            removerBtn.TabIndex = 3;
            removerBtn.Text = "Remover";
            removerBtn.UseVisualStyleBackColor = false;
            removerBtn.Click += removerBtn_Click;
            // 
            // finalizarBtn
            // 
            finalizarBtn.BackColor = Color.FromArgb(243, 241, 238);
            finalizarBtn.BackgroundImage = (Image)resources.GetObject("finalizarBtn.BackgroundImage");
            finalizarBtn.BackgroundImageLayout = ImageLayout.Stretch;
            finalizarBtn.FlatAppearance.BorderSize = 0;
            finalizarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 241, 238);
            finalizarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 241, 238);
            finalizarBtn.FlatStyle = FlatStyle.Flat;
            finalizarBtn.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            finalizarBtn.ForeColor = Color.White;
            finalizarBtn.Location = new Point(862, 181);
            finalizarBtn.Name = "finalizarBtn";
            finalizarBtn.Size = new Size(156, 150);
            finalizarBtn.TabIndex = 4;
            finalizarBtn.Text = "Finalizar";
            finalizarBtn.UseVisualStyleBackColor = false;
            finalizarBtn.Click += finalizarBtn_Click;
            // 
            // pedidoTxt
            // 
            pedidoTxt.AutoSize = true;
            pedidoTxt.Font = new Font("Agrandir Narrow Bold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            pedidoTxt.Location = new Point(1339, 115);
            pedidoTxt.Name = "pedidoTxt";
            pedidoTxt.Size = new Size(97, 36);
            pedidoTxt.TabIndex = 7;
            pedidoTxt.Text = "Pedido";
            // 
            // quantidadeTxt
            // 
            quantidadeTxt.Location = new Point(702, 172);
            quantidadeTxt.Name = "quantidadeTxt";
            quantidadeTxt.Size = new Size(130, 23);
            quantidadeTxt.TabIndex = 9;
            quantidadeTxt.TextChanged += quantidadeTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(243, 241, 238);
            label2.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(554, 172);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 11;
            label2.Text = "quantidade:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1305, 38);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 32);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.Value = new DateTime(2025, 5, 16, 8, 31, 20, 0);
            dateTimePicker1.Visible = false;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dinheiroRecebidoTxt
            // 
            dinheiroRecebidoTxt.ForeColor = Color.White;
            dinheiroRecebidoTxt.Location = new Point(806, 501);
            dinheiroRecebidoTxt.Name = "dinheiroRecebidoTxt";
            dinheiroRecebidoTxt.Size = new Size(134, 23);
            dinheiroRecebidoTxt.TabIndex = 15;
            dinheiroRecebidoTxt.TextChanged += dinheiroRecebido_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(651, 501);
            label1.Name = "label1";
            label1.Size = new Size(152, 24);
            label1.TabIndex = 16;
            label1.Text = "Total recebido:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(731, 565);
            label3.Name = "label3";
            label3.Size = new Size(72, 24);
            label3.TabIndex = 17;
            label3.Text = "Troco:";
            label3.Click += label3_Click;
            // 
            // Troco
            // 
            Troco.AutoSize = true;
            Troco.BackColor = Color.White;
            Troco.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Troco.ForeColor = Color.White;
            Troco.Location = new Point(806, 566);
            Troco.Name = "Troco";
            Troco.Size = new Size(131, 25);
            Troco.TabIndex = 19;
            Troco.Text = "_________________";
            Troco.Click += Troco_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(730, 377);
            label4.Name = "label4";
            label4.Size = new Size(73, 24);
            label4.TabIndex = 20;
            label4.Text = "Nome:";
            // 
            // nomeTxt
            // 
            nomeTxt.Location = new Point(809, 381);
            nomeTxt.Name = "nomeTxt";
            nomeTxt.Size = new Size(131, 23);
            nomeTxt.TabIndex = 21;
            nomeTxt.TextChanged += nomeTxt_TextChanged;
            // 
            // listViewCardapio
            // 
            listViewCardapio.BackColor = Color.FromArgb(243, 241, 238);
            listViewCardapio.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewCardapio.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            listViewCardapio.FullRowSelect = true;
            listViewCardapio.GridLines = true;
            listViewCardapio.Location = new Point(12, 154);
            listViewCardapio.MultiSelect = false;
            listViewCardapio.Name = "listViewCardapio";
            listViewCardapio.Size = new Size(503, 505);
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
            columnHeader4.Width = 120;
            // 
            // listViewCarrinho
            // 
            listViewCarrinho.BackColor = Color.FromArgb(243, 241, 238);
            listViewCarrinho.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewCarrinho.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            listViewCarrinho.ForeColor = Color.White;
            listViewCarrinho.FullRowSelect = true;
            listViewCarrinho.GridLines = true;
            listViewCarrinho.Location = new Point(1084, 154);
            listViewCarrinho.MultiSelect = false;
            listViewCarrinho.Name = "listViewCarrinho";
            listViewCarrinho.Size = new Size(524, 505);
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
            columnHeader7.Text = "Preço Unit. (R$)";
            columnHeader7.TextAlign = HorizontalAlignment.Right;
            columnHeader7.Width = 170;
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
            comboBoxFormaPagamento.Location = new Point(809, 433);
            comboBoxFormaPagamento.Name = "comboBoxFormaPagamento";
            comboBoxFormaPagamento.Size = new Size(131, 23);
            comboBoxFormaPagamento.TabIndex = 24;
            comboBoxFormaPagamento.SelectedIndexChanged += comboBoxFormaPagamento_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(572, 433);
            label5.Name = "label5";
            label5.Size = new Size(231, 24);
            label5.TabIndex = 25;
            label5.Text = "Método de pagamento:";
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
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(225, 255, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(225, 255, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(715, 659);
            button1.Name = "button1";
            button1.Size = new Size(156, 154);
            button1.TabIndex = 28;
            button1.Text = "Tela de Pedidos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnViagem
            // 
            btnViagem.AutoSize = true;
            btnViagem.BackColor = Color.Black;
            btnViagem.Font = new Font("Inter SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnViagem.ForeColor = Color.White;
            btnViagem.Location = new Point(726, 625);
            btnViagem.Name = "btnViagem";
            btnViagem.Size = new Size(151, 28);
            btnViagem.TabIndex = 29;
            btnViagem.Text = "Para Viagem";
            btnViagem.UseVisualStyleBackColor = false;
            btnViagem.CheckedChanged += btnViagem_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(554, 296);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(479, 380);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Agrandir Narrow Bold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(683, 307);
            label6.Name = "label6";
            label6.Size = new Size(220, 36);
            label6.TabIndex = 31;
            label6.Text = "Dados do Cliente";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(243, 241, 238);
            pictureBox3.Location = new Point(555, 145);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(479, 159);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 255, 0);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1636, 774);
            Controls.Add(label6);
            Controls.Add(btnViagem);
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
            Controls.Add(cardapioTxt);
            Controls.Add(totalTxt);
            Controls.Add(pictureBox2);
            Controls.Add(removerBtn);
            Controls.Add(finalizarBtn);
            Controls.Add(adicionarBtn);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Button button1;
        private CheckBox btnViagem;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox3;
    }
}
