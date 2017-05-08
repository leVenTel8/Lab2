using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pERSONALBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pERSONALBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DEPARTMENT' table. You can move, or remove it, as needed.
            this.dEPARTMENTTableAdapter.Fill(this.dataSet1.DEPARTMENT);
            // TODO: This line of code loads data into the 'dataSet1.PERSONAL' table. You can move, or remove it, as needed.
            this.pERSONALTableAdapter.Fill(this.dataSet1.PERSONAL);

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FromClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes;
        }

        private void отделыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.ShowDialog();

            //Читаем данные из таблицы Department БД в набор dataset1 главной формы
            this.dEPARTMENTTableAdapter.Fill(this.dataSet1.DEPARTMENT);

            //Обновляем все элементы интерфейса, отображающие данные ( для отображения на основном 
            //экране всех изменений, которые мысделали в окне справочника)
            dEPARTMENTBindingSource.ResetBindings(false);
            pERSONALBindingSource.ResetBindings(false);
        }
    }
}
