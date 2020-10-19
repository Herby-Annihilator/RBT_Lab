using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary.DataStructures.RedBlackTree;
using MyLibrary.InputOutput;

namespace RBTCore
{
	public partial class Form1 : Form
	{
		private int countOfTreesInMemory;
		private RedBlackTree<int> firstTree;
		private RedBlackTree<int> secondTree;
		private RedBlackTree<int> thirdTree;
		private RedBlackTree<int> workingTree;
		public Form1()
		{
			InitializeComponent();
			firstTree = new RedBlackTree<int>();
			secondTree = new RedBlackTree<int>();
			thirdTree = new RedBlackTree<int>();
			countOfTreesInMemory = 0;
			workingTree = firstTree;
		}

		private void UpdateLabelCountOfTrees()
		{
			countOfTreesInMemory = 0;
			if (!firstTree.IsEmpty())
			{
				countOfTreesInMemory++;
			}
			if (!secondTree.IsEmpty())
			{
				countOfTreesInMemory++;
			}
			if (!thirdTree.IsEmpty())
			{
				countOfTreesInMemory++;
			}
			labelCountOfTreesInMemory.Text = countOfTreesInMemory.ToString();
		}

		private void buttonCreateOrAddNodesToTree_Click(object sender, EventArgs e)
		{
			int countOfNodes;
			Random random = new Random();
			try
			{
				countOfNodes = Convert.ToInt32(textBoxCountOfNodes.Text);
				for (int i = 0; i < countOfNodes; i++)
				{
					workingTree.AddData(random.Next(0, 100), Comparer<int>.Default);
				}
				WriteWorkingTreeToFile();
				UpdateLabelCountOfTrees();
				toolStripStatusLabel1.Text = "В рабочее дерево добавлено " + countOfNodes + " элементов";
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				toolStripStatusLabel1.Text = ee.Message;
				UpdateLabelCountOfTrees();
			}
		}

		private void WriteWorkingTreeToFile()
		{
			try
			{
				InputOutput.SaveToFile(GetWorkingTreeName() + ".dat", workingTree);
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				toolStripStatusLabel1.Text = ee.Message;
				UpdateLabelCountOfTrees();
			}
		}

		private string GetWorkingTreeName()
		{
			string name;
			if (workingTree == firstTree)
			{
				name = "FirstTree";
			}
			else if (workingTree == secondTree)
			{
				name = "SecondTree";
			}
			else
			{
				name = "ThirdTree";
			}
			return name;
		}

		private void buttonRestoreTrees_Click(object sender, EventArgs e)
		{
			try
			{
				workingTree.Clear();
				workingTree = (RedBlackTree<int>)InputOutput.LoadFromFile(GetWorkingTreeName() + ".dat");
				UpdateLabelCountOfTrees();
				toolStripStatusLabel1.Text = "Рабочее дерево было восстановлено";
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				toolStripStatusLabel1.Text = ee.Message;
				UpdateLabelCountOfTrees();
			}
		}

		private void buttonPerformTask_Click(object sender, EventArgs e)
		{
			try
			{
				dataGridView1.Rows.Clear();
				firstTree.TreeTraversal((node) => {
					Node<int> node1 = secondTree.Search(node.Data, Comparer<int>.Default);
					Node<int> node2 = thirdTree.Search(node.Data, Comparer<int>.Default);
					if (node1 != null && node2 != null)
					{
						WriteNodeToDataGrid(node);
					}
				});
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				toolStripStatusLabel1.Text = ee.Message;
				UpdateLabelCountOfTrees();
			}
		}

		private void buttonClearWorkingTree_Click(object sender, EventArgs e)
		{
			workingTree.Clear();
			UpdateLabelCountOfTrees();
			toolStripStatusLabel1.Text = "Рабочее дерево очищено";
		}

		private void buttonShowTree_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();

			workingTree.TreeTraversal((node) =>
			{
				WriteNodeToDataGrid(node);
				if (workingTree.IsRoot(node))
				{
					dataGridView1.Rows[dataGridView1.Rows.Count - 1].DefaultCellStyle.BackColor =
					System.Drawing.Color.Aquamarine;
				}
			});
		}

		private void WriteNodeToDataGrid(Node<int> node)
		{
			dataGridView1.Rows.Add();
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = node.Data;
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = node.Color;
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = node.LeftChild?.Data;
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = node.RightChild?.Data;
			dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = node.Parent?.Data;
		}

		private void radioButtonFirstTree_CheckedChanged(object sender, EventArgs e)
		{
			workingTree = firstTree;
		}

		private void radioButtonSecondTree_CheckedChanged(object sender, EventArgs e)
		{
			workingTree = secondTree;
		}

		private void radioButtonThirdTree_CheckedChanged(object sender, EventArgs e)
		{
			workingTree = thirdTree;
		}
	}
}
