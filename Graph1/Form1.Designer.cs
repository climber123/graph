namespace Graph1
{
    partial class Form1
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
            this.Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MoveNode = new System.Windows.Forms.RadioButton();
            this.DelEdge = new System.Windows.Forms.RadioButton();
            this.AddEdge = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DelEl = new System.Windows.Forms.RadioButton();
            this.AddEl = new System.Windows.Forms.RadioButton();
            this.IsGraph = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MadeTree = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFile = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 553);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(705, 111);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(201, 36);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Очистить ";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MoveNode);
            this.groupBox1.Controls.Add(this.DelEdge);
            this.groupBox1.Controls.Add(this.AddEdge);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DelEl);
            this.groupBox1.Controls.Add(this.AddEl);
            this.groupBox1.Location = new System.Drawing.Point(705, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // MoveNode
            // 
            this.MoveNode.AutoSize = true;
            this.MoveNode.Location = new System.Drawing.Point(9, 175);
            this.MoveNode.Name = "MoveNode";
            this.MoveNode.Size = new System.Drawing.Size(177, 21);
            this.MoveNode.TabIndex = 5;
            this.MoveNode.TabStop = true;
            this.MoveNode.Text = "Переместить вершину";
            this.MoveNode.UseVisualStyleBackColor = true;
            // 
            // DelEdge
            // 
            this.DelEdge.AutoSize = true;
            this.DelEdge.Location = new System.Drawing.Point(9, 148);
            this.DelEdge.Name = "DelEdge";
            this.DelEdge.Size = new System.Drawing.Size(128, 21);
            this.DelEdge.TabIndex = 4;
            this.DelEdge.TabStop = true;
            this.DelEdge.Text = "Удалить ребро";
            this.DelEdge.UseVisualStyleBackColor = true;
            // 
            // AddEdge
            // 
            this.AddEdge.AutoSize = true;
            this.AddEdge.Location = new System.Drawing.Point(9, 121);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(137, 21);
            this.AddEdge.TabIndex = 3;
            this.AddEdge.TabStop = true;
            this.AddEdge.Text = "Добавить ребро";
            this.AddEdge.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Введите значение";
            // 
            // DelEl
            // 
            this.DelEl.AutoSize = true;
            this.DelEl.Location = new System.Drawing.Point(9, 94);
            this.DelEl.Name = "DelEl";
            this.DelEl.Size = new System.Drawing.Size(145, 21);
            this.DelEl.TabIndex = 1;
            this.DelEl.Text = "Удалить вершину";
            this.DelEl.UseVisualStyleBackColor = true;
            // 
            // AddEl
            // 
            this.AddEl.AutoSize = true;
            this.AddEl.Checked = true;
            this.AddEl.Location = new System.Drawing.Point(9, 35);
            this.AddEl.Name = "AddEl";
            this.AddEl.Size = new System.Drawing.Size(154, 21);
            this.AddEl.TabIndex = 0;
            this.AddEl.TabStop = true;
            this.AddEl.Text = "Добавить вершину";
            this.AddEl.UseVisualStyleBackColor = true;
            // 
            // IsGraph
            // 
            this.IsGraph.Location = new System.Drawing.Point(705, 32);
            this.IsGraph.Name = "IsGraph";
            this.IsGraph.Size = new System.Drawing.Size(201, 36);
            this.IsGraph.TabIndex = 3;
            this.IsGraph.Text = "Проверка на дерево";
            this.IsGraph.UseVisualStyleBackColor = true;
            this.IsGraph.Click += new System.EventHandler(this.IsGraph_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // MadeTree
            // 
            this.MadeTree.Location = new System.Drawing.Point(705, 364);
            this.MadeTree.Name = "MadeTree";
            this.MadeTree.Size = new System.Drawing.Size(201, 44);
            this.MadeTree.TabIndex = 5;
            this.MadeTree.Text = "Сделать дерево, убрав одну вершину";
            this.MadeTree.UseVisualStyleBackColor = true;
            this.MadeTree.Click += new System.EventHandler(this.MadeTree_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(702, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(705, 506);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(201, 26);
            this.OpenFile.TabIndex = 9;
            this.OpenFile.Text = "Чтение из файла";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(705, 538);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(201, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Запись в файл";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(994, 577);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MadeTree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsGraph);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DelEl;
        private System.Windows.Forms.RadioButton AddEl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton AddEdge;
        private System.Windows.Forms.RadioButton DelEdge;
        private System.Windows.Forms.RadioButton MoveNode;
        private System.Windows.Forms.Button IsGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MadeTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

