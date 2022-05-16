using Circustrein.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(1, enumSize.Groot, true));
            animals.Add(new Animal(2, enumSize.Middelgrote, true));
            animals.Add(new Animal(3, enumSize.Groot, true));
            animals.Add(new Animal(4, enumSize.Groot, true));
            animals.Add(new Animal(5, enumSize.klein, true));
            animals.Add(new Animal(6, enumSize.klein, true));
            animals.Add(new Animal(7, enumSize.Groot, true));
            animals.Add(new Animal(8, enumSize.Middelgrote, true));
            animals.Add(new Animal(9, enumSize.Middelgrote, true));
            animals.Add(new Animal(10, enumSize.Groot, true));
            animals.Add(new Animal(11, enumSize.klein, true));
            animals.Add(new Animal(12, enumSize.klein, true));
            animals.Add(new Animal(13, enumSize.klein, true));
            Train train = new Train(animals);
            train.AddWagons();

            int x = 0;
            int y = 0;
            foreach (var wagon in train.Wagons)
            {
                ListBox listBox = new ListBox();
                listBox.Location = new System.Drawing.Point(x, y);
                listBox.Size = new System.Drawing.Size(50, 100);
                foreach (var animal in wagon.Animals)
                {
                    listBox.Items.Add(animal.Point.ToString());
                }
                TrainPanel.Controls.Add(listBox);
                x = x + 60;
                if (x > (TrainPanel.Size.Width - 125))
                {
                    x = 0;
                    y = y + 110;
                }
            }
        }
    }
}
