using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4_lab.Properties;

namespace _4_lab
{
    public partial class Form1 : Form
    {
        List<Plants> plantsList = new List<Plants>();
        
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.plantsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; i++)
            {
                switch(rnd.Next() % 3)
                {
                    case 0:
                        this.plantsList.Add(Shrub.Generate());
                        break;
                    case 1:
                        this.plantsList.Add(Tree.Generate());
                        break;
                    case 2:
                        this.plantsList.Add(Flowers.Generate());
                        break;
                }
               
            }
           /* for (int i = 1; i < 10; i++)
            {
                ochered.Text = i + " " + plantsList[i] + "\n";
            }*/
            ShowInfo();

        }
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int shrubCount = 0;
            int treeCount = 0;
            int flowerCount = 0;
            
            

            // пройдемся по всему списку
            foreach (var plants in this.plantsList)
            {
    
                if (plants is Shrub)
                {
                    shrubCount += 1;
                }
                else if (plants is Tree)
                {
                    treeCount += 1;
                }
                else if (plants is Flowers)
                {
                    flowerCount += 1;
                }
            }
            
            
            // а ну и вывести все это надо на форму
            txtInfo.Text = "Дерево\tЦветок\tКустарник";
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}",  treeCount, flowerCount, shrubCount);
            
            
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.plantsList.Count == 0)
            {
                txtOut.Text = "Список пуст!\nПерезаполните список";
                return;
            }

            // взяли первое растение
            var plants = this.plantsList[0];
            // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
            // где хранится экземпляр класса, так что если хочешь удалить, делай это сам
            this.plantsList.RemoveAt(0);

            // ну а теперь предложим покупателю его растение
            txtOut.Text = plants.GetInfo();
            

            // обновим информацию о количестве товара на форме
            ShowInfo();
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

