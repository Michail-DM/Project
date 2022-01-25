using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
namespace DMA14Glava
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TreeNode tempNode;
            // Добавляем к дереву нейтральные культуры, как корневые узлы
            foreach (CultureInfo CultureX in CultureInfo.GetCultures(CultureTypes.NeutralCultures))
            {
                tempNode = new TreeNode(CultureX.EnglishName
                + " [" + CultureX.Name + "]");
                tempNode.Tag = CultureX;
                treeView1.Nodes.Add(tempNode);
            }
            // Перебираем все конкретные культуры и добавляем
            // каждую из них к родительской нейтральной культуре в дереве
            foreach (CultureInfo CultureX in
            CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                foreach (TreeNode NodeX in treeView1.Nodes)
                {
                    if (NodeX.Tag.Equals(CultureX.Parent))
                    {
                        tempNode = new TreeNode(CultureX.EnglishName
                        + " [" + CultureX.Name + "]");
                        tempNode.Tag = CultureX;
                        tempNode.ForeColor = Color.Red;
                        foreach (CultureInfo CultureY in CultureInfo.GetCultures(
                        CultureTypes.InstalledWin32Cultures))
                        {
                            if (CultureY.Equals(CultureX))
                            {
                                tempNode.ForeColor = Color.Black;
                                break;
                            }
                        }
                        NodeX.Nodes.Add(tempNode);
                        break;
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        
                {
                    CultureInfo selectedCulture;
                    selectedCulture = (CultureInfo)treeView1.SelectedNode.Tag;
                    if (selectedCulture.IsNeutralCulture == true)
                    {
                        listView1.Items[3].SubItems[1].Text = "Нейтральная";
                        for (int x = 4; x <= 10; x++)
                            listView1.Items[x].SubItems[1].Text = "Нейтральная культура";
                    }
                    else
                    {
                        Thread.CurrentThread.CurrentCulture = selectedCulture;
                        listView1.Items[3].SubItems[1].Text = "Конкретная";
                        listView1.Items[4].SubItems[1].Text =
                        (DateTime.Now).ToShortDateString();
                        listView1.Items[5].SubItems[1].Text =
                        (DateTime.Now).ToLongDateString();
                        listView1.Items[6].SubItems[1].Text =
                        (DateTime.Now).ToShortTimeString();
                        listView1.Items[7].SubItems[1].Text =
                        (DateTime.Now).ToLongTimeString();
                        listView1.Items[8].SubItems[1].Text = (35500.75).ToString("n");
                        listView1.Items[9].SubItems[1].Text = (1750.25).ToString("c");
                        listView1.Items[10].SubItems[1].Text =
                        (selectedCulture.Calendar.ToString()).Remove(0, 21);
                    }
                    listView1.Items[0].SubItems[1].Text = selectedCulture.Name;
                    listView1.Items[1].SubItems[1].Text =
     selectedCulture.EnglishName;
                    listView1.Items[2].SubItems[1].Text = selectedCulture.NativeName;
                }
            }
        }
   