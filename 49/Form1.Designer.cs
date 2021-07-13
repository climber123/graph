namespace _49
{
    partial class Number49
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MoveNode = new System.Windows.Forms.RadioButton();
            this.DelEdge = new System.Windows.Forms.RadioButton();
            this.AddEdge = new System.Windows.Forms.RadioButton();
            this.DelNode = new System.Windows.Forms.RadioButton();
            this.AddNode = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(886, 686);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.MoveNode);
            this.groupBox1.Controls.Add(this.DelEdge);
            this.groupBox1.Controls.Add(this.AddEdge);
            this.groupBox1.Controls.Add(this.DelNode);
            this.groupBox1.Controls.Add(this.AddNode);
            this.groupBox1.Location = new System.Drawing.Point(912, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 222);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 5;
            // 
            // MoveNode
            // 
            this.MoveNode.AutoSize = true;
            this.MoveNode.Location = new System.Drawing.Point(16, 104);
            this.MoveNode.Name = "MoveNode";
            this.MoveNode.Size = new System.Drawing.Size(177, 21);
            this.MoveNode.TabIndex = 4;
            this.MoveNode.TabStop = true;
            this.MoveNode.Text = "Переместить Элемент";
            this.MoveNode.UseVisualStyleBackColor = true;
            // 
            // DelEdge
            // 
            this.DelEdge.AutoSize = true;
            this.DelEdge.Location = new System.Drawing.Point(16, 182);
            this.DelEdge.Name = "DelEdge";
            this.DelEdge.Size = new System.Drawing.Size(128, 21);
            this.DelEdge.TabIndex = 3;
            this.DelEdge.TabStop = true;
            this.DelEdge.Text = "Удалить ребро";
            this.DelEdge.UseVisualStyleBackColor = true;
            // 
            // AddEdge
            // 
            this.AddEdge.AutoSize = true;
            this.AddEdge.Location = new System.Drawing.Point(16, 131);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(137, 21);
            this.AddEdge.TabIndex = 2;
            this.AddEdge.TabStop = true;
            this.AddEdge.Text = "Добавить ребро";
            this.AddEdge.UseVisualStyleBackColor = true;
            // 
            // DelNode
            // 
            this.DelNode.AutoSize = true;
            this.DelNode.Location = new System.Drawing.Point(16, 77);
            this.DelNode.Name = "DelNode";
            this.DelNode.Size = new System.Drawing.Size(145, 21);
            this.DelNode.TabIndex = 1;
            this.DelNode.TabStop = true;
            this.DelNode.Text = "Удалить Элемент";
            this.DelNode.UseVisualStyleBackColor = true;
            // 
            // AddNode
            // 
            this.AddNode.AutoSize = true;
            this.AddNode.Location = new System.Drawing.Point(16, 21);
            this.AddNode.Name = "AddNode";
            this.AddNode.Size = new System.Drawing.Size(154, 21);
            this.AddNode.TabIndex = 0;
            this.AddNode.TabStop = true;
            this.AddNode.Text = "Добавить Элемент";
            this.AddNode.UseVisualStyleBackColor = true;
            // 
            // Number49
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1156, 707);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Number49";
            this.Text = "Tratatata";
            this.Load += new System.EventHandler(this.Number49_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MoveNode;
        private System.Windows.Forms.RadioButton DelEdge;
        private System.Windows.Forms.RadioButton AddEdge;
        private System.Windows.Forms.RadioButton DelNode;
        private System.Windows.Forms.RadioButton AddNode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

