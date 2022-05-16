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
            TrainPanel.Controls.Clear();

            List<Animal> animals = new List<Animal>();
            Random rng = new Random();
            for (int i = 0; i < 20; i++)
            {
                enumSize size = new enumSize();
                enumType type = new enumType();
                switch (rng.Next(3))
                {
                    case 0:
                        size = enumSize.Groot;
                        break;
                    case 1:
                        size = enumSize.Middelgrote;
                        break;
                    case 2:
                        size = enumSize.klein;
                        break;
                }
                switch (rng.Next(2))
                {
                    case 0:
                        type = enumType.Gras;
                        break;
                    case 1:
                        type = enumType.Vlees;
                        break;
                }
                animals.Add(new Animal(i, size, type));
            }

            Train train = new Train(animals);
            train.AddWagons();

            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new System.Drawing.Point(0, 0);
            pictureBox.Size = new System.Drawing.Size(50, 100);
            pictureBox.Image = Properties.Resources.train;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TrainPanel.Controls.Add(pictureBox);

            int x = 60;
            int y = 0;
            foreach (var wagon in train.Wagons)
            {
                Label lb = new Label();
                lb.Size = new System.Drawing.Size(8, 100);
                lb.Text = "_";
                lb.Location = new System.Drawing.Point((x - 10), (y + 40));

                ListBox listBox = new ListBox();
                listBox.Location = new System.Drawing.Point(x, y);
                listBox.Size = new System.Drawing.Size(50, 100);

                foreach (var animal in wagon.Animals)
                {
                    listBox.Items.Add(animal.Point.ToString() + " " + animal.Type.ToString());
                }

                TrainPanel.Controls.Add(listBox);
                TrainPanel.Controls.Add(lb);

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
