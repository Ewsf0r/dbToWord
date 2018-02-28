using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace KAS_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kAS_DB_1_3DataSet.Merch". При необходимости она может быть перемещена или удалена.
            this.merchTableAdapter.Fill(this.kAS_DB_1_3DataSet.Merch);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kAS_DB_1_3DataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.kAS_DB_1_3DataSet.Categories);

            SetDefaultDate();
            PopulateTree();
            treeView1.SelectedNode = GetNode("00.", treeView1.Nodes[0]);
            label5.Text = System.Windows.Forms.Application.ExecutablePath;
        }

        // Выводит в текстбокс дату в заданном формате
        void SetDefaultDate()
        {
            //Номер текущего дня
            string CurDate = DateTime.Today.Day.ToString() + " ";
            //Выбор и вывод названия текущего месяца исходя из его номера
            switch (Convert.ToInt32(DateTime.Today.Month))
            {
                case 1:
                    CurDate += "января ";
                    break;
                case 2:
                    CurDate += "февраля ";
                    break;
                case 3:
                    CurDate += "марта ";
                    break;
                case 4:
                    CurDate += "апреля ";
                    break;
                case 5:
                    CurDate += "мая ";
                    break;
                case 6:
                    CurDate += "июня ";
                    break;
                case 7:
                    CurDate += "июля ";
                    break;
                case 8:
                    CurDate += "августа ";
                    break;
                case 9:
                    CurDate += "сентября ";
                    break;
                case 10:
                    CurDate += "октября ";
                    break;
                case 11:
                    CurDate += "ноября ";
                    break;
                case 12:
                    CurDate += "декабря ";
                    break;
            }
            //Вывод текущего года
            CurDate += DateTime.Today.Year.ToString() + " г.";
            textBoxDate.Text = CurDate;
        }

        //Инициализация заполнения дерева
        private void PopulateTree()
        {
            //Добавляем корневую категорию и данные для нее
            TreeNode root_node = new TreeNode("root");
            string self_id = "00.";
            root_node.Tag = self_id;
            //запускаем поиск дочерних категорий
            GetCategories(root_node, self_id);
            //выводим получившееся дерево
            treeView1.Nodes.Add(root_node);
        }

        //Получение родительского ИД по известному собственному ИД
        private string GetParentID(string self_id)
        {
            string result;
            //каждый новый уровень вложенности добавляет 3 к длинне ИД
            //если длинна ИД равна трем символам, то это первый уровень вложенности
            //и родительским является ИД корневой категории 
            if (self_id.Length == 3) result = "00.";
            //для получения родительского ИД
            //достаточно удалить последние три символа 
            //из собственного идентификатора
            else result = self_id.Remove(self_id.Length - 3, 3);
            return result;
        }
        
        //поиск дочерних категорий для заполнения дерева
        //в качестве аргументов - родительская ветвь, к которой будет прикреплена ветвь найденная в резульате работы функции
        //и ИД родительской категории, по которому будет проводиться поиск дочерних категорий
        //в результате дочернии категории станут дочерними ветвями
        private void GetCategories(TreeNode node_to_add_to, string parent_id)
        {
            //создаем новую ветвь
            TreeNode branch_node;
            //в переменных будут храниться ИД и имя категории проверяемой на данной итерации цикла
            string self_id, self_name;
            for (int i = 0; i < categoriesDT.RowCount - 1; i++)
            {
                self_id = categoriesDT.Rows[i].Cells["CategoryID"].Value.ToString();
                self_name = categoriesDT.Rows[i].Cells["CategoryName"].Value.ToString();
                //проверяем, является ли родительский ИД проверяемой на данной итерации категории
                //ИД родителской ветви
                if (GetParentID(self_id) == parent_id)
                {
                    //если является, создаем новую дочернюю ветвь, заполняем ее данные
                    branch_node = new TreeNode(self_name, 0, 0);
                    branch_node.Tag = self_id;
                    branch_node.ImageKey = "folder";
                    //проводим поиск дочерних ветвей для нее
                    GetCategories(branch_node, self_id);
                    //прикрепляем ее к родительской ветви
                    node_to_add_to.Nodes.Add(branch_node);
                }
            }
        }

        //при щелчке по одной из ветвей
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView1.SelectedNode = e.Node;
        }

        //Фунция заполнения ListView категориями и товарми, дочерними к выбранной категории
        //в качестве аргумента принимает ИД родительской категории
        private void PopulateListView(string parent_id)
        {
            //очищаем лист от содержимого, инициализируем новые объекты и свойства
            listView1.Items.Clear();
            tableLayoutPanelPropertiesNames.Visible = false;
            tableLayoutPanelPropertiesValues.Visible = false;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            //аналогично поиску дочерних категорий для дерева
            string self_id, self_name, merch_parent_id;
            for (int i = 0; i < categoriesDT.RowCount - 1; i++)
            {
                self_id = categoriesDT.Rows[i].Cells["CategoryID"].Value.ToString();
                self_name = categoriesDT.Rows[i].Cells["CategoryName"].Value.ToString();
                if (GetParentID(self_id) == parent_id)
                {
                    //если родительски ИД проверяемой на данной итерации категории соответствует
                    //принятому в качестве аргумента функции, то добавляем новый элемент в лист
                    //указываем в свойствах, что это категория
                    item = new ListViewItem(self_name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, "Категория"), 
                        new ListViewItem.ListViewSubItem(item, self_id)
                    };
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }
            }
            //аналогично предыдущему циклу, но поиск идет по товарам
            for (int i = 0; i < merchDT.RowCount - 1; i++)
            {
                self_id = merchDT.Rows[i].Cells["MerchID"].Value.ToString();
                self_name = merchDT.Rows[i].Cells["MerchName"].Value.ToString();
                merch_parent_id = merchDT.Rows[i].Cells["ParentID"].Value.ToString();
                if (merch_parent_id == parent_id)
                {
                    item = new ListViewItem(self_name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, "Товар"), 
                        new ListViewItem.ListViewSubItem(item, self_id)
                    };
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }
            }
        }

        //функция вывода подробных свойств категорий и товаров при их выборе из листа
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //проверяем, выбран ли только один объект, без этого выражение
            //listView1.SelectedItems[0] может работать неверно (кастыль)
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string selected_type = item.SubItems[1].Text.ToString();
                string selected_id = item.SubItems[2].Text.ToString();
                ShowProperties(selected_type, selected_id);
            }
        }

        private void ShowProperties(string selected_type, string selected_id)
        {
            //если подробные свойства не отображаются (если ранее не был выбран ни один объект)
            //отобрзить подробные войства
            bool is_new = true;
            if (tableLayoutPanelPropertiesNames.Visible == false)
            {
                tableLayoutPanelPropertiesNames.Visible = true;
                tableLayoutPanelPropertiesValues.Visible = true;
            }
                if (selected_type == "Категория")
                {
                    if (labelTextCode.Visible == true)
                    {
                        labelTextCode.Visible = false;
                        labelTextDescription.Visible = false;
                        labelTextUnits.Visible = false;
                        labelTextMerchPrice.Visible = false;
                        labelTextWorkPrice.Visible = false;
                        labelTextQuantity.Visible = false;
                        textBoxCode.Visible = false;
                        textBoxDescription.Visible = false;
                        textBoxUnits.Visible = false;
                        numericUpDownMerchPrice.Visible = false;
                        numericUpDownWorkPrice.Visible = false;
                        numericUpDownQuantity.Visible = false;
                    }
                    labelID.Text = selected_id;
                    for (int i = 0; i < categoriesDT.RowCount - 1; i++)
                    {
                        string self_id = categoriesDT.Rows[i].Cells["CategoryID"].Value.ToString();
                        if (self_id == selected_id)
                        {
                            is_new = false;
                            textBoxName.Text = categoriesDT.Rows[i].Cells["CategoryName"].Value.ToString();
                        }
                    }
                }
                else if (selected_type == "Товар")
                {
                    if (labelTextCode.Visible == false)
                    {
                        labelTextCode.Visible = true;
                        labelTextDescription.Visible = true;
                        labelTextUnits.Visible = true;
                        labelTextMerchPrice.Visible = true;
                        labelTextWorkPrice.Visible = true;
                        labelTextQuantity.Visible = true;
                        textBoxCode.Visible = true;
                        textBoxDescription.Visible = true;
                        textBoxUnits.Visible = true;
                        numericUpDownMerchPrice.Visible = true;
                        numericUpDownWorkPrice.Visible = true;
                        numericUpDownQuantity.Visible = true;
                    }
                    labelID.Text = selected_id;
                    for (int i = 0; i < merchDT.RowCount - 1; i++)
                    {
                        string self_id = merchDT.Rows[i].Cells["MerchID"].Value.ToString();
                        if (self_id == selected_id)
                        {
                            is_new = false;
                            textBoxCode.Text = merchDT.Rows[i].Cells["Code"].Value.ToString();
                            textBoxDescription.Text = merchDT.Rows[i].Cells["Description"].Value.ToString();
                            textBoxUnits.Text = merchDT.Rows[i].Cells["Units"].Value.ToString();
                            textBoxName.Text = merchDT.Rows[i].Cells["MerchName"].Value.ToString();
                            numericUpDownMerchPrice.Value = Convert.ToDecimal(merchDT.Rows[i].Cells["MerchPrice"].Value);
                            numericUpDownWorkPrice.Value = Convert.ToDecimal(merchDT.Rows[i].Cells["WorkPrice"].Value);
                            numericUpDownQuantity.Value = Convert.ToDecimal(merchDT.Rows[i].Cells["Quantity"].Value);
                        }
                    }
                }
            
            if (is_new) DBUpdate();
        }

        private void AddMerchToDoc()
        {
            AddDT.Rows.Add();
            AddDT.Rows[AddDT.Rows.Count - 2].Cells["AID"].Value = labelID.Text;
            AddDT.Rows[AddDT.Rows.Count - 2].Cells["AName"].Value = textBoxName.Text;
            AddDT.Rows[AddDT.Rows.Count - 2].Cells["ADescription"].Value = textBoxDescription.Text;
            AddDT.Rows[AddDT.Rows.Count - 2].Cells["AUnits"].Value = textBoxUnits.Text;
            AddDT.Rows[AddDT.Rows.Count - 2].Cells["AQuantity"].Value = numericUpDownAQuantity.Value;
            AddDT.Rows[AddDT.Rows.Count - 2].Cells["AMerchPrice"].Value = numericUpDownMerchPrice.Value;
            AddDT.Rows[AddDT.Rows.Count - 2].Cells["AWorkPrice"].Value = numericUpDownWorkPrice.Value;
            if (numericUpDownQuantity.Value > 0) numericUpDownQuantity.Value -= numericUpDownAQuantity.Value;
        }

        private void LoadFromExcel()
        {

        }

        private void DeleteMerchFromDoc()
        {
            if (AddDT.RowCount > 1 && AddDT.CurrentRow.Index != AddDT.RowCount - 1)
            {
                numericUpDownQuantity.Value += Convert.ToDecimal(AddDT.CurrentRow.Cells["AQuantity"].Value);
                AddDT.Rows.Remove(AddDT.CurrentRow);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string selected_type = item.SubItems[1].Text.ToString();
                if (selected_type == "Товар")
                {
                    AddMerchToDoc();
                }
            }
        }

        private TreeNode GetNode(string id, TreeNode nodes)
        {
            foreach (TreeNode node in nodes.Nodes)
            {
                if (node.Tag.Equals(id)) return node;
                TreeNode next = GetNode(id, node);
                if (next != null) return next;
            }
            return null;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string selected_type = item.SubItems[1].Text.ToString();
                string selected_id = item.SubItems[2].Text.ToString();
                if (selected_type == "Товар")
                {
                    AddMerchToDoc();
                }
                else if (selected_type == "Категория")
                {
                    treeView1.SelectedNode = GetNode(selected_id, treeView1.Nodes[0]);
                }
            }
        }

        private void ShowDoc()
        {
            if (AddDT.RowCount > 1)
            {
                Microsoft.Office.Interop.Word.Document doc;
                Object pathToTemplate = System.Windows.Forms.Application.StartupPath + "\\standart.docx";
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                Object missing = System.Reflection.Missing.Value;
                doc = app.Documents.Add(ref pathToTemplate, ref missing, ref missing, ref missing);
                Microsoft.Office.Interop.Word.Table table = doc.Tables[1];
                int i;
                double MerchSumm = 0, MontageSumm = 0;
                table.Rows[3].Cells[4].Range.Text = textBoxDate.Text;
                table.Rows[6].Cells[1].Range.Text = "на " + textBoxOffer.Text;
                for (i = 0; i < AddDT.RowCount - 1; i++)
                {
                    table.Rows.Add(table.Rows[8]);
                }
                for (i = 0; i < AddDT.RowCount - 1; i++)
                {
                    table.Rows[i + 8].Cells[1].Range.Text = Convert.ToString(i + 1);
                    table.Rows[i + 8].Cells[2].Range.Text = Convert.ToString(AddDT.Rows[i].Cells["AName"].Value);
                    table.Rows[i + 8].Cells[3].Range.Text = Convert.ToString(AddDT.Rows[i].Cells["ADescription"].Value);
                    table.Rows[i + 8].Cells[4].Range.Text = Convert.ToString(AddDT.Rows[i].Cells["AUnits"].Value);
                    table.Rows[i + 8].Cells[5].Range.Text = Convert.ToString(AddDT.Rows[i].Cells["AQuantity"].Value);
                    table.Rows[i + 8].Cells[6].Range.Text = Convert.ToString(AddDT.Rows[i].Cells["AMerchPrice"].Value) + "р.";
                    double InterSumm = Convert.ToInt32(AddDT.Rows[i].Cells["AQuantity"].Value) * Convert.ToDouble(AddDT.Rows[i].Cells["AMerchPrice"].Value);
                    table.Rows[i + 8].Cells[7].Range.Text = Convert.ToString(InterSumm) + "р.";
                    MerchSumm += InterSumm;
                    MontageSumm += Convert.ToInt32(AddDT.Rows[i].Cells["AQuantity"].Value) * Convert.ToDouble(AddDT.Rows[i].Cells["AWorkPrice"].Value);
                }
                table.Rows[i + 8].Delete();
                table.Rows[i + 8].Cells[2].Range.Text = Convert.ToString(numericUpDownConsumables.Value) + "р.";
                table.Rows[i + 9].Cells[2].Range.Text = Convert.ToString(MerchSumm) + "р.";
                table.Rows[i + 10].Cells[2].Range.Text = Convert.ToString(MontageSumm) + "р.";
                table.Rows[i + 11].Cells[2].Range.Text = Convert.ToString(MerchSumm + MontageSumm + Convert.ToInt32(numericUpDownConsumables.Value)) + "р.";
                app.Visible = true;
            }
        }

        private void показатьПредложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDoc();
        }

        private void AddDT_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteMerchFromDoc();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteMerchFromDoc();
        }

        private void AddDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AddDT.RowCount > 1)
            {
                labelID.Text = AddDT.CurrentRow.Cells["AID"].Value.ToString();
                textBoxName.Text = AddDT.CurrentRow.Cells["AName"].Value.ToString();
                textBoxDescription.Text = AddDT.CurrentRow.Cells["ADescription"].Value.ToString();
                textBoxUnits.Text = AddDT.CurrentRow.Cells["AUnits"].Value.ToString();
                for (int i = 0; i < merchDT.RowCount - 1; i++)
                {
                    if (merchDT.Rows[i].Cells["MerchID"].Value.ToString() == labelID.Text)
                        numericUpDownQuantity.Value = Convert.ToDecimal(merchDT.Rows[i].Cells["Quantity"].Value);
                }
                numericUpDownMerchPrice.Value = Convert.ToDecimal(AddDT.CurrentRow.Cells["AMerchPrice"].Value);
                numericUpDownWorkPrice.Value = Convert.ToDecimal(AddDT.CurrentRow.Cells["AWorkPrice"].Value);
            }
        }

        //Основная ункция для работы с базой данных
        private void DBUpdate()
        {
            //Флаги проверок: были ли внесены измения в сравнении с тем, что храниться в базе,
            //был ли создан новый товар или категория, изменения в категории или в товаре
            bool is_changed = false, is_new = true, is_category = false;
            //строка содержащая идентификатор родителя
            string parent_id = GetParentID(labelID.Text);
            //если собственный идентификатор изменяемого объекта заканчивается точкой, то объект являетс категорией
            if (labelID.Text.EndsWith(".")) is_category = true;
            
            //если проверяемый объект - категория
            if (is_category)
            {
                //поиск соответствущей категории в базе
                for (int i = 0; i < categoriesDT.RowCount - 1; i++)
                {
                    string current_id = categoriesDT.Rows[i].Cells["CategoryID"].Value.ToString();
                    //если категория найдена, проверка на наличие изменений
                    if (current_id == labelID.Text)
                    {
                        is_new = false;
                        string new_name = textBoxName.Text;
                        string current_name = categoriesDT.Rows[i].Cells["CategoryName"].Value.ToString();
                        if (new_name != current_name)
                        {
                            //если изменения были внесены, внесем их в базу
                            is_changed = true;
                            int level_id = Convert.ToInt32(categoriesDT.Rows[i].Cells["CategoryLevelID"].Value);
                            int level = Convert.ToInt32(categoriesDT.Rows[i].Cells["CategoryLevel"].Value);
                            categoriesDT.Rows[i].Cells["CategoryName"].Value = textBoxName.Text;
                            categoriesTableAdapter.Update(new_name, level, level_id,
                                current_id, current_name, level, level_id);
                        }
                        break;
                    }
                }
                //если категория не найдена - создадим новую в текущей директории
                if (is_new)
                {
                    is_changed = true;
                    int new_level_id = 1, new_level = 1;
                    string new_id, new_name = "Новая категория";
                    for (int i = 0; i < categoriesDT.RowCount - 1; i++)
                    {
                        string current_id  = categoriesDT.Rows[i].Cells["CategoryID"].Value.ToString();
                        int level_id = Convert.ToInt32(categoriesDT.Rows[i].Cells["CategoryLevelID"].Value);
                        if ((GetParentID(current_id) == parent_id) && (level_id >= new_level_id)) new_level_id = level_id + 1;
                        if (current_id == parent_id) new_level = Convert.ToInt32(categoriesDT.Rows[i].Cells["CategoryLevel"].Value) + 1;
                    }
                    if (parent_id == "00.") parent_id = "";
                    if (new_level_id > 9) new_id = parent_id + new_level_id + ".";
                    else new_id = parent_id + "0" + new_level_id + ".";
                    categoriesTableAdapter.Insert(new_id, new_name, new_level, new_level_id);
                }
            }

            //Проверка изменений товара
            else
            {
                string new_id = labelID.Text;
                for (int i = 0; i < merchDT.RowCount - 1; i++)
                {
                    string current_id = merchDT.Rows[i].Cells["MerchID"].Value.ToString();
                    if (current_id == new_id)
                    {
                        string new_name = textBoxName.Text;
                        string new_code = textBoxCode.Text;
                        string new_description = textBoxDescription.Text;
                        string new_units = textBoxUnits.Text;
                        double new_merch_price = Convert.ToDouble(numericUpDownMerchPrice.Value);
                        double new_work_price = Convert.ToDouble(numericUpDownWorkPrice.Value);
                        int new_quantity = Convert.ToInt32(numericUpDownQuantity.Value);
                
                        string current_parent_id = merchDT.Rows[i].Cells["ParentID"].Value.ToString();
                        string current_name = merchDT.Rows[i].Cells["MerchName"].Value.ToString();
                        string current_code = merchDT.Rows[i].Cells["Code"].Value.ToString();
                        string current_description = merchDT.Rows[i].Cells["Description"].Value.ToString();
                        string current_units = merchDT.Rows[i].Cells["Units"].Value.ToString();
                        double current_merch_price = Convert.ToDouble(merchDT.Rows[i].Cells["MerchPrice"].Value);
                        double current_work_price = Convert.ToDouble(merchDT.Rows[i].Cells["WorkPrice"].Value);
                        int current_quantity = Convert.ToInt32(merchDT.Rows[i].Cells["Quantity"].Value);
                        is_new = false;
                        if ((new_name != current_name)||
                            (new_description != current_description)||
                            (new_code != current_code)||
                            (new_units != current_units)||
                            (new_merch_price != current_merch_price)||
                            (new_work_price != current_work_price)||
                            (new_quantity != current_quantity))
                        {
                            is_changed = true;
                            int level_id = Convert.ToInt32(merchDT.Rows[i].Cells["MerchLevelID"].Value);
                            int level = Convert.ToInt32(merchDT.Rows[i].Cells["MerchLevel"].Value);
                            merchTableAdapter.Update(new_id, new_name, level, level_id, new_code, new_description, new_units, new_merch_price, new_work_price, new_quantity, current_parent_id, 
                                current_id, current_name, level, level_id, current_code, current_units, current_merch_price, current_work_price, current_quantity, current_parent_id);
                        }
                        break;
                    }
                }
                if (is_new)
                {
                    is_changed = true;
                    int new_level_id = 1, new_level = 1;
                    for (int i = 0; i < merchDT.RowCount - 1; i++)
                    {
                        string current_id = merchDT.Rows[i].Cells["MerchID"].Value.ToString();
                        string current_parent_id = merchDT.Rows[i].Cells["ParentID"].Value.ToString();
                        int current_level_id = Convert.ToInt32(merchDT.Rows[i].Cells["MerchLevelID"].Value);
                        if ((current_parent_id == parent_id) && (current_level_id >= new_level_id)) new_level_id = current_level_id + 1;
                        if (current_id == parent_id) new_level = Convert.ToInt32(merchDT.Rows[i].Cells["MerchLevel"].Value) + 1;
                    }
                    if (parent_id == "00.") parent_id = "";
                    if (new_level_id > 99) new_id = parent_id + new_level_id;
                    else if (new_level_id > 9) new_id = parent_id + "0" + new_level_id;
                    else new_id = parent_id + "00" + new_level_id;
                    merchTableAdapter.Insert(new_id, "Новый товар", new_level, new_level_id, "", "", "", 100, 50, 100, parent_id);
                }
            }

            //Обновление отображения, если были внесены изменения
            if (is_changed) 
            {
                if(is_category)
                {
                    categoriesTableAdapter.Fill(kAS_DB_1_3DataSet.Categories); 
                    treeView1.Nodes.Clear();
                    PopulateTree();
                    treeView1.SelectedNode = GetNode(labelID.Text, treeView1.Nodes[0]);
                }
                else merchTableAdapter.Fill(kAS_DB_1_3DataSet.Merch); 
                PopulateListView(parent_id);
            }
        }

        private void ChildrenDelete(string parent_id)
        {
            string parent_name = "";
            int parent_level = 0;
            int parent_level_id = 0;
                
            for (int i = 0; i < categoriesDT.RowCount - 1; i++)
            {
                string self_id = categoriesDT.Rows[i].Cells["CategoryID"].Value.ToString();
                if (self_id == parent_id)
                {
                    parent_name = categoriesDT.Rows[i].Cells["CategoryName"].Value.ToString();
                    parent_level = Convert.ToInt32(categoriesDT.Rows[i].Cells["CategoryLevel"].Value);
                    parent_level_id = Convert.ToInt32(categoriesDT.Rows[i].Cells["CategoryLevelID"].Value);
            
                }
                if (GetParentID(self_id) == parent_id)
                {
                    ChildrenDelete(self_id);
                }
            }
            for (int i = 0; i < merchDT.RowCount - 1; i++)
            {
                string current_parent_id = merchDT.Rows[i].Cells["ParentID"].Value.ToString();
                if (current_parent_id == parent_id)
                {
                    string current_id = merchDT.Rows[i].Cells["MerchID"].Value.ToString();
                    string current_name = merchDT.Rows[i].Cells["MerchName"].Value.ToString();
                    string current_code = merchDT.Rows[i].Cells["Code"].Value.ToString();
                    string current_description = merchDT.Rows[i].Cells["Description"].Value.ToString();
                    string current_units = merchDT.Rows[i].Cells["Units"].Value.ToString();
                    double current_merch_price = Convert.ToDouble(merchDT.Rows[i].Cells["MerchPrice"].Value);
                    double current_work_price = Convert.ToDouble(merchDT.Rows[i].Cells["WorkPrice"].Value);
                    int current_quantity = Convert.ToInt32(merchDT.Rows[i].Cells["Quantity"].Value);
                    int current_level = Convert.ToInt32(merchDT.Rows[i].Cells["MerchLevel"].Value);
                    int current_level_id = Convert.ToInt32(merchDT.Rows[i].Cells["MerchLevelID"].Value);
                    merchTableAdapter.Delete(current_id, current_name, current_level, current_level_id, 
                        current_code, current_units, current_merch_price, current_work_price, current_quantity, current_parent_id);
                }
            }
            categoriesTableAdapter.Delete(parent_id, parent_name, parent_level, parent_level_id);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //определяем ИД категории выбранной ветви
            string parent_id = e.Node.Tag.ToString();
            //заполняем ListView категориями и товарми, дочерними к выбранной категории
            labelID.Text = parent_id;
            textBoxName.Text = "";
            PopulateListView(parent_id);
        }

        
        private void добавитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string parent_id = "";
            if (textBoxName.Text.Length > 0) parent_id = GetParentID(labelID.Text);
            else parent_id = labelID.Text;
            ShowProperties("Категория", parent_id + "00.");
        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string parent_id = "";
            if (textBoxName.Text.Length > 0) parent_id = GetParentID(labelID.Text);
            else parent_id = labelID.Text;
            ShowProperties("Товар", parent_id + "000");
        }

        private void удалитьВыбранноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labelID.Text.Length > 0 && textBoxName.Text.Length > 0)
            {
                bool is_category = true;
                string parent_id = GetParentID(labelID.Text);
                //если собственный идентификатор изменяемого объекта заканчивается точкой, то объект являетс категорией
                if (labelID.Text.EndsWith(".")) ChildrenDelete(labelID.Text);
                else
                {
                    is_category = false;
                    for (int i = 0; i < merchDT.RowCount - 1; i++)
                    {
                        string current_id = merchDT.Rows[i].Cells["MerchID"].Value.ToString();
                        if (current_id == labelID.Text)
                        {
                            string current_parent_id = merchDT.Rows[i].Cells["ParentID"].Value.ToString();
                            string current_name = merchDT.Rows[i].Cells["MerchName"].Value.ToString();
                            string current_code = merchDT.Rows[i].Cells["Code"].Value.ToString();
                            string current_description = merchDT.Rows[i].Cells["Description"].Value.ToString();
                            string current_units = merchDT.Rows[i].Cells["Units"].Value.ToString();
                            double current_merch_price = Convert.ToDouble(merchDT.Rows[i].Cells["MerchPrice"].Value);
                            double current_work_price = Convert.ToDouble(merchDT.Rows[i].Cells["WorkPrice"].Value);
                            int current_quantity = Convert.ToInt32(merchDT.Rows[i].Cells["Quantity"].Value);
                            int current_level = Convert.ToInt32(merchDT.Rows[i].Cells["MerchLevel"].Value);
                            int current_level_id = Convert.ToInt32(merchDT.Rows[i].Cells["MerchLevelID"].Value);
                            merchTableAdapter.Delete(current_id, current_name, current_level, current_level_id,
                                current_code, current_units, current_merch_price, current_work_price, current_quantity, current_parent_id);
                        }
                    }
                }
                if (is_category)
                {
                    categoriesTableAdapter.Fill(kAS_DB_1_3DataSet.Categories);
                    treeView1.Nodes.Clear();
                    PopulateTree();
                    treeView1.SelectedNode = GetNode(labelID.Text, treeView1.Nodes[0]);
                }
                else merchTableAdapter.Fill(kAS_DB_1_3DataSet.Merch);
                PopulateListView(parent_id);
            }
        }

        private void сохранитьТеущееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddDT.RowCount > 1)
            {
                SaveFileDialog save_dialog = new SaveFileDialog();
                save_dialog.Filter = "AT files | *.at";
                save_dialog.DefaultExt = "at";
                save_dialog.RestoreDirectory = true;
                Stream sub_stream;
                if (save_dialog.ShowDialog() == DialogResult.OK)
                {
                    if ((sub_stream = save_dialog.OpenFile()) != null)
                    {
                        string sub_string = "";
                        for (int i = 0; i < AddDT.RowCount - 1; i++)
                        {
                            sub_string += AddDT.Rows[i].Cells["AID"].Value.ToString() + " "
                                + AddDT.Rows[i].Cells["AQuantity"].Value.ToString() + "\n";
                        }
                        foreach (byte b in sub_string)
                        {
                            sub_stream.WriteByte(b);
                        }
                        sub_stream.Close();
                    }
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "AT files | *.at";
            open_dialog.DefaultExt = "at";
            open_dialog.RestoreDirectory = true;
            Stream sub_stream;
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                if ((sub_stream = open_dialog.OpenFile()) != null)
                {
                    StreamReader reader = new StreamReader(sub_stream);
                    string loaded_string = reader.ReadToEnd(), sub_string = "";
                    sub_stream.Close();
                    AddDT.Rows.Clear();
                    AddDT.Rows.Add();
                    foreach (char c in loaded_string)
                    {
                        if (c == ' ')
                        {
                            AddDT.Rows[AddDT.Rows.Count - 2].Cells["AID"].Value = sub_string;
                            for (int i = 0; i < merchDT.RowCount - 1; i++)
                            {
                                if (merchDT.Rows[i].Cells["MerchID"].Value.ToString() == sub_string)
                                {
                                    AddDT.Rows[AddDT.Rows.Count - 2].Cells["AName"].Value = merchDT.Rows[i].Cells["MerchName"].Value;
                                    AddDT.Rows[AddDT.Rows.Count - 2].Cells["ADescription"].Value = merchDT.Rows[i].Cells["Description"].Value;
                                    AddDT.Rows[AddDT.Rows.Count - 2].Cells["AUnits"].Value = merchDT.Rows[i].Cells["Units"].Value;
                                    AddDT.Rows[AddDT.Rows.Count - 2].Cells["AMerchPrice"].Value = merchDT.Rows[i].Cells["MerchPrice"].Value;
                                    AddDT.Rows[AddDT.Rows.Count - 2].Cells["AWorkPrice"].Value = merchDT.Rows[i].Cells["WorkPrice"].Value;
                                }
                            }
                            sub_string = "";
                        }
                        else if (c == '\n')
                        {
                            AddDT.Rows[AddDT.Rows.Count - 2].Cells["AQuantity"].Value = Convert.ToInt32(sub_string);
                            sub_string = "";
                            AddDT.Rows.Add();
                        }
                        else sub_string += c;
                    }
                    AddDT.Rows.RemoveAt(AddDT.Rows.Count - 2);
                }
            }
        }

        private void textBoxCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) DBUpdate();
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) DBUpdate();
        }
        private void textBoxDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) DBUpdate();
        }

        private void textBoxUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) DBUpdate();
        }

        private void numericUpDownMerchPrice_ValueChanged(object sender, EventArgs e)
        {
            DBUpdate();
        }

        private void numericUpDownWorkPrice_ValueChanged(object sender, EventArgs e)
        {
            DBUpdate();
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            DBUpdate();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
