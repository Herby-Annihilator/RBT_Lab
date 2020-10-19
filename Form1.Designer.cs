using System;

namespace RBTCore
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonCreateOrAddNodesToTree = new System.Windows.Forms.Button();
			this.textBoxCountOfNodes = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelCountOfTreesInMemory = new System.Windows.Forms.Label();
			this.buttonRestoreTrees = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonFirstTree = new System.Windows.Forms.RadioButton();
			this.radioButtonSecondTree = new System.Windows.Forms.RadioButton();
			this.radioButtonThirdTree = new System.Windows.Forms.RadioButton();
			this.buttonClearWorkingTree = new System.Windows.Forms.Button();
			this.buttonShowTree = new System.Windows.Forms.Button();
			this.buttonPerformTask = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnLeftChild = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRightChild = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 430);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 20);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonPerformTask);
			this.panel1.Controls.Add(this.buttonShowTree);
			this.panel1.Controls.Add(this.buttonClearWorkingTree);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.buttonRestoreTrees);
			this.panel1.Controls.Add(this.labelCountOfTreesInMemory);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBoxCountOfNodes);
			this.panel1.Controls.Add(this.buttonCreateOrAddNodesToTree);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(794, 123);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 132);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(794, 295);
			this.panel2.TabIndex = 2;
			// 
			// buttonCreateOrAddNodesToTree
			// 
			this.buttonCreateOrAddNodesToTree.Location = new System.Drawing.Point(10, 35);
			this.buttonCreateOrAddNodesToTree.Name = "buttonCreateOrAddNodesToTree";
			this.buttonCreateOrAddNodesToTree.Size = new System.Drawing.Size(100, 36);
			this.buttonCreateOrAddNodesToTree.TabIndex = 0;
			this.buttonCreateOrAddNodesToTree.Text = "Добавить узлы в дерево";
			this.buttonCreateOrAddNodesToTree.UseVisualStyleBackColor = true;
			this.buttonCreateOrAddNodesToTree.Click += new System.EventHandler(this.buttonCreateOrAddNodesToTree_Click);
			// 
			// textBoxCountOfNodes
			// 
			this.textBoxCountOfNodes.Location = new System.Drawing.Point(10, 9);
			this.textBoxCountOfNodes.Name = "textBoxCountOfNodes";
			this.textBoxCountOfNodes.Size = new System.Drawing.Size(100, 20);
			this.textBoxCountOfNodes.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(116, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Число узлов в дереве";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(199, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Деревьев в памяти в данный момент";
			// 
			// labelCountOfTreesInMemory
			// 
			this.labelCountOfTreesInMemory.AutoSize = true;
			this.labelCountOfTreesInMemory.Location = new System.Drawing.Point(216, 94);
			this.labelCountOfTreesInMemory.Name = "labelCountOfTreesInMemory";
			this.labelCountOfTreesInMemory.Size = new System.Drawing.Size(0, 13);
			this.labelCountOfTreesInMemory.TabIndex = 4;
			// 
			// buttonRestoreTrees
			// 
			this.buttonRestoreTrees.Location = new System.Drawing.Point(473, 10);
			this.buttonRestoreTrees.Name = "buttonRestoreTrees";
			this.buttonRestoreTrees.Size = new System.Drawing.Size(93, 23);
			this.buttonRestoreTrees.TabIndex = 5;
			this.buttonRestoreTrees.Text = "Восстановить";
			this.buttonRestoreTrees.UseVisualStyleBackColor = true;
			this.buttonRestoreTrees.Click += new System.EventHandler(this.buttonRestoreTrees_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(573, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(211, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Восстановить рабочее дерево из файла";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonThirdTree);
			this.groupBox1.Controls.Add(this.radioButtonSecondTree);
			this.groupBox1.Controls.Add(this.radioButtonFirstTree);
			this.groupBox1.Location = new System.Drawing.Point(265, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(216, 85);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Выбрать рабочее дерево";
			// 
			// radioButtonFirstTree
			// 
			this.radioButtonFirstTree.AutoSize = true;
			this.radioButtonFirstTree.Checked = true;
			this.radioButtonFirstTree.Location = new System.Drawing.Point(7, 20);
			this.radioButtonFirstTree.Name = "radioButtonFirstTree";
			this.radioButtonFirstTree.Size = new System.Drawing.Size(191, 17);
			this.radioButtonFirstTree.TabIndex = 0;
			this.radioButtonFirstTree.TabStop = true;
			this.radioButtonFirstTree.Text = "Сделать рабочим первое дерево";
			this.radioButtonFirstTree.UseVisualStyleBackColor = true;
			this.radioButtonFirstTree.CheckedChanged += new System.EventHandler(this.radioButtonFirstTree_CheckedChanged);
			// 
			// radioButtonSecondTree
			// 
			this.radioButtonSecondTree.AutoSize = true;
			this.radioButtonSecondTree.Location = new System.Drawing.Point(7, 44);
			this.radioButtonSecondTree.Name = "radioButtonSecondTree";
			this.radioButtonSecondTree.Size = new System.Drawing.Size(196, 17);
			this.radioButtonSecondTree.TabIndex = 1;
			this.radioButtonSecondTree.Text = "Сделать рабочим воторое дерево";
			this.radioButtonSecondTree.UseVisualStyleBackColor = true;
			this.radioButtonSecondTree.CheckedChanged += new System.EventHandler(this.radioButtonSecondTree_CheckedChanged);

			// 
			// radioButtonThirdTree
			// 
			this.radioButtonThirdTree.AutoSize = true;
			this.radioButtonThirdTree.Location = new System.Drawing.Point(6, 67);
			this.radioButtonThirdTree.Name = "radioButtonThirdTree";
			this.radioButtonThirdTree.Size = new System.Drawing.Size(189, 17);
			this.radioButtonThirdTree.TabIndex = 2;
			this.radioButtonThirdTree.Text = "Сделать рабочим третье дерево";
			this.radioButtonThirdTree.UseVisualStyleBackColor = true;
			this.radioButtonThirdTree.CheckedChanged += new System.EventHandler(this.radioButtonThirdTree_CheckedChanged);

			// 
			// buttonClearWorkingTree
			// 
			this.buttonClearWorkingTree.Location = new System.Drawing.Point(487, 97);
			this.buttonClearWorkingTree.Name = "buttonClearWorkingTree";
			this.buttonClearWorkingTree.Size = new System.Drawing.Size(146, 23);
			this.buttonClearWorkingTree.TabIndex = 8;
			this.buttonClearWorkingTree.Text = "Очистить рабочее дерево";
			this.buttonClearWorkingTree.UseVisualStyleBackColor = true;
			this.buttonClearWorkingTree.Click += new System.EventHandler(this.buttonClearWorkingTree_Click);
			// 
			// buttonShowTree
			// 
			this.buttonShowTree.Location = new System.Drawing.Point(650, 97);
			this.buttonShowTree.Name = "buttonShowTree";
			this.buttonShowTree.Size = new System.Drawing.Size(141, 23);
			this.buttonShowTree.TabIndex = 9;
			this.buttonShowTree.Text = "Показать дерево";
			this.buttonShowTree.UseVisualStyleBackColor = true;
			this.buttonShowTree.Click += new System.EventHandler(this.buttonShowTree_Click);
			// 
			// buttonPerformTask
			// 
			this.buttonPerformTask.Location = new System.Drawing.Point(576, 55);
			this.buttonPerformTask.Name = "buttonPerformTask";
			this.buttonPerformTask.Size = new System.Drawing.Size(168, 23);
			this.buttonPerformTask.TabIndex = 10;
			this.buttonPerformTask.Text = "Выполнить задание";
			this.buttonPerformTask.UseVisualStyleBackColor = true;
			this.buttonPerformTask.Click += new System.EventHandler(this.buttonPerformTask_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ColumnData,
			this.ColumnColor,
			this.ColumnLeftChild,
			this.ColumnRightChild,
			this.ColumnParent});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(794, 295);
			this.dataGridView1.TabIndex = 0;
			// 
			// ColumnData
			// 
			this.ColumnData.HeaderText = "Значение";
			this.ColumnData.Name = "ColumnData";
			this.ColumnData.ReadOnly = true;
			// 
			// ColumnColor
			// 
			this.ColumnColor.HeaderText = "Цвет";
			this.ColumnColor.Name = "ColumnColor";
			this.ColumnColor.ReadOnly = true;
			// 
			// ColumnLeftChild
			// 
			this.ColumnLeftChild.HeaderText = "Потомок слева";
			this.ColumnLeftChild.Name = "ColumnLeftChild";
			this.ColumnLeftChild.ReadOnly = true;
			// 
			// ColumnRightChild
			// 
			this.ColumnRightChild.HeaderText = "Потомок справа";
			this.ColumnRightChild.Name = "ColumnRightChild";
			this.ColumnRightChild.ReadOnly = true;
			// 
			// ColumnParent
			// 
			this.ColumnParent.HeaderText = "Родитель";
			this.ColumnParent.Name = "ColumnParent";
			this.ColumnParent.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "rbt";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxCountOfNodes;
		private System.Windows.Forms.Button buttonCreateOrAddNodesToTree;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCountOfTreesInMemory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonThirdTree;
		private System.Windows.Forms.RadioButton radioButtonSecondTree;
		private System.Windows.Forms.RadioButton radioButtonFirstTree;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonRestoreTrees;
		private System.Windows.Forms.Button buttonShowTree;
		private System.Windows.Forms.Button buttonClearWorkingTree;
		private System.Windows.Forms.Button buttonPerformTask;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLeftChild;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRightChild;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParent;
	}
}

