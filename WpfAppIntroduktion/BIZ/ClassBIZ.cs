using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppIntroduktion.BIZ
{
    class ClassBIZ
    {
        public ClassBIZ()
        {

        }

        public void Delopgave12(ListBox listBox)
        {
            listBox.Items.Clear();
            string infoText = "Opgave 1.2: \nEn funktion der udskriver \ntallene fra 4711 til 4736.\n---------------------------";
            listBox.Items.Add(infoText.ToString());
            for (int i = 4711; i < 4737; i++)
            {
                listBox.Items.Add(i.ToString());
            }
        }

        public void Delopgave13(ListBox listBox)
        {
            listBox.Items.Clear();
            string infoText = "Opgave 1.3: \nEn metode der opretter \n25 tilfældige tal \nmellem 100.000 og 1.000.000.\n---------------------------";
            listBox.Items.Add(infoText.ToString());
            Random random = new Random(); 

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listBox.Items.Add(randomTal.ToString());
            }
        }

        public void Delopgave14(ListBox listBox)
        {
            listBox.Items.Clear();
            string infoText = "Opgave 1.4: \nEn metode der opretter \n25 tilfældige tal \nog sortere dem i stigende orden.\n---------------------------";
            listBox.Items.Add(infoText.ToString());
            Random random = new Random();
            List<int> listInt = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(1,26);
                listInt.Add(randomTal);
            }

            listInt.Sort();

            foreach(int tal in listInt)
            {
                listBox.Items.Add(tal.ToString());
            }
        }

        public void Delopgave15(ListBox listBox)
        {
            listBox.Items.Clear();
            string infoText = "Opgave 1.5: \nEn metode der opretter \n25 tilfældige tal \nUdskriver tal både som de er, samt sorteret.\n---------------------------";
            listBox.Items.Add(infoText.ToString());
            Random random = new Random();
            List<int> listInt1 = new List<int>();
            List<int> listInt2 = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(1, 26);
                listInt1.Add(randomTal);
                listInt2.Add(randomTal);
            }

            listInt2.Sort(); // Sort List  

            for(int i = 0; i < listInt1.Count; i++)
            {
                listBox.Items.Add($" {listInt1[i]}  --- {listInt2[i]} ");
            }
        }
    }
}
