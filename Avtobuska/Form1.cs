using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Avtobuska
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            Grad g1 = new Grad("Скопје");
            Grad g2 = new Grad("Куманово");
            Grad g3 = new Grad("Тетово");
            Grad g4 = new Grad("Кичево");
            Grad g5 = new Grad("Охрид");
            Grad g6 = new Grad("Струга");
            Grad g7 = new Grad("Велес");
            Grad g8 = new Grad("Неготино");
            Grad g9 = new Grad("Кавадарци");
            Grad g10 = new Grad("Прилеп");
            Grad g11 = new Grad("Битола");
            Grad g12 = new Grad("Гевгелија");
            Grad g13 = new Grad("Струмица");
            Grad g14 = new Grad("Штип");
            Grad g15 = new Grad("Кочани");
            comboBox1.Items.Add(g1);
            comboBox1.Items.Add(g2);
            comboBox1.Items.Add(g3);
            comboBox1.Items.Add(g4);
            comboBox1.Items.Add(g5);
            comboBox1.Items.Add(g6);
            comboBox1.Items.Add(g7);
            comboBox1.Items.Add(g8);
            comboBox1.Items.Add(g9);
            comboBox1.Items.Add(g10);
            comboBox1.Items.Add(g11);
            comboBox1.Items.Add(g12);
            comboBox1.Items.Add(g13);
            comboBox1.Items.Add(g14);
            comboBox1.Items.Add(g15);
            comboBox2.Items.Add(g1);
            comboBox2.Items.Add(g2);
            comboBox2.Items.Add(g3);
            comboBox2.Items.Add(g4);
            comboBox2.Items.Add(g5);
            comboBox2.Items.Add(g6);
            comboBox2.Items.Add(g7);
            comboBox2.Items.Add(g8);
            comboBox2.Items.Add(g9);
            comboBox2.Items.Add(g10);
            comboBox2.Items.Add(g11);
            comboBox2.Items.Add(g12);
            comboBox2.Items.Add(g13);
            comboBox2.Items.Add(g14);
            comboBox2.Items.Add(g15);
            
        }
        
            private void button3_Click(object sender, EventArgs e)
        {
            Grad g1 = new Grad("Скопје");
            Grad g2 = new Grad("Куманово");
            Grad g3 = new Grad("Тетово");
            Grad g4 = new Grad("Кичево");
            Grad g5 = new Grad("Охрид");
            Grad g6 = new Grad("Струга");
            Grad g7 = new Grad("Велес");
            Grad g8 = new Grad("Неготино");
            Grad g9 = new Grad("Кавадарци");
            Grad g10 = new Grad("Прилеп");
            Grad g11 = new Grad("Битола");
            Grad g12 = new Grad("Гевгелија");
            Grad g13 = new Grad("Струмица");
            Grad g14 = new Grad("Штип");
            Grad g15 = new Grad("Кочани");


            Relacija r1 = new Relacija(g1, g2, 50, "Југтурист - Куманово", "10:00", "10:50");
            Relacija r2 = new Relacija(g1, g3, 50, "Рулетурс - Скопје локал - Тетово", "12:00", "12:45");
            Relacija r3 = new Relacija(g1, g4, 160, "Вакчаре - Струга", "08:00", "10:15");
            Relacija r4 = new Relacija(g1, g5, 260, "Галеб - Охрид", "08:00", "11:15");
            Relacija r5 = new Relacija(g1, g6, 260, "Вакчаре - Струга", "12:30", "16:20");
            Relacija r6 = new Relacija(g1, g7, 50, "Транскоп - Битола", "09:00", "09:55");
            Relacija r7 = new Relacija(g1, g8, 120, "Самвел - Кавадарци", "17:00", "18:40");
            Relacija r8 = new Relacija(g1, g9, 130, "Самвел - Кавадарци", "17:00", "19:10");
            Relacija r9 = new Relacija(g1, g10, 190, "Пелагонијатранс - Прилеп", "13:30", "14:40");
            Relacija r10 = new Relacija(g1, g11, 240, "Транскоп - Битола", "09:00", "12:40");
            Relacija r11 = new Relacija(g1, g12, 160, "Млаз-Богданци", "16:00", "19:00");
            Relacija r12 = new Relacija(g1, g13, 240, "СтрумицаЕкспрес - Струмица", "15:00", "18:00");
            Relacija r13 = new Relacija(g1, g14, 140, "СтрумицаЕкспрес - Струмица", "15:00", "17:05");
            Relacija r14 = new Relacija(g1, g15, 160, "АвтоАтом - Кочани", "09:30", "12:20");

            Relacija r15 = new Relacija(g2, g1, 50, "Југтурист - Куманово", "14:00", "14:50");
            Relacija r16 = new Relacija(g2, g3, 100, "Југтурист - Куманово", "09:30", "11:05");
            Relacija r17 = new Relacija(g2, g7, 130, "АвтоАтом - Кочани", "13:15", "15:00");
            Relacija r18 = new Relacija(g2, g14, 120, "АвтоАтом - Кочани", "17:00", "17:40");
            Relacija r19 = new Relacija(g2, g15, 100, "АвтоАтом - Кочани", "17:00", "18:20");


            Relacija r20 = new Relacija(g3, g1, 50, "Рулетурс - Скопје локал - Тетово", "07:00", "07:45");
            Relacija r21 = new Relacija(g3, g2, 100, "Југтурист - Куманово", "10:00", "11:35");
            Relacija r22 = new Relacija(g3, g4, 120, "Вакчаре - Струга", "11:00", "12:30");
            Relacija r23 = new Relacija(g3, g5, 170, "Галеб - Охрид", "14:00", "16:30");
            Relacija r24 = new Relacija(g3, g6, 180, "Вакчаре - Струга", "15:00", "18:00");



            Relacija r25 = new Relacija(g4, g1, 130, "Вакчаре - Струга", "10:00", "12:15");
            Relacija r27 = new Relacija(g4, g3, 100, "Вакчаре - Струга", "12:00", "13:30");
            Relacija r28 = new Relacija(g4, g5, 110, "Вакчаре - Струга", "18:00", "19:00");
            Relacija r29 = new Relacija(g4, g6, 120, "Вакчаре - Струга", "17:00", "18:35");



            Relacija r30 = new Relacija(g5, g1, 250, "Галеб - Охрид", "10:00", "13:15");
            Relacija r31 = new Relacija(g5, g3, 170, "Вакчаре - Струга", "11:00", "13:30");
            Relacija r32 = new Relacija(g5, g4, 110, "Вакчаре - Струга", "16:00", "17:00");
            Relacija r33 = new Relacija(g5, g6, 30, "Вакчаре - Струга", "10:00", "10:35");
            Relacija r34 = new Relacija(g5, g7, 200, "Галеб - Охрид", "13:30", "15:50");
            Relacija r35 = new Relacija(g5, g9, 150, "Галеб - Охрид", "17:00", "19:30");
            Relacija r36 = new Relacija(g5, g10, 120, "Галеб - Охрид", "17:00", "19:00");
            Relacija r37 = new Relacija(g5, g11, 100, "Галеб - Охрид", "17:00", "18:15");



            Relacija r38 = new Relacija(g6, g1, 270, "Вакчаре - Струга", "11:10", "15:00");
            Relacija r39 = new Relacija(g6, g3, 180, "Вакчаре - Струга", "12:00", "15:05");
            Relacija r40 = new Relacija(g6, g4, 120, "Вакчаре - Струга", "10:00", "11:35");
            Relacija r41 = new Relacija(g6, g5, 30, "Вакчаре - Струга", "18:00", "18:35");


            Relacija r42 = new Relacija(g7, g1, 50, "Самвел - Кавадарци", "13:00", "13:55");
            Relacija r43 = new Relacija(g7, g2, 130, "АвтоАтом - Кочани", "12:00", "13:45");
            Relacija r44 = new Relacija(g7, g5, 200, "Галеб - Охрид", "14:00", "16:20");
            Relacija r45 = new Relacija(g7, g8, 70, "Млаз-Богданци", "10:00", "10:40");
            Relacija r46 = new Relacija(g7, g9, 90, "Самвел - Кавадарци", "12:30", "13:30");
            Relacija r47 = new Relacija(g7, g10, 70, "Пелагонијатранс - Прилеп", "10:00", "11:00");
            Relacija r48 = new Relacija(g7, g11, 100, "Транскоп - Битола", "12:00", "13:40");
            Relacija r49 = new Relacija(g7, g12, 100, "Млаз-Богданци", "09:00", "11:05");
            Relacija r50 = new Relacija(g7, g13, 110, "СтрумицаЕкспрес - Струмица", "15:30", "17:35");
            Relacija r51 = new Relacija(g7, g14, 50, "СтрумицаЕкспрес - Струмица", "12:45", "13:30");
            Relacija r52 = new Relacija(g7, g15, 100, "АвтоАтом - Кочани", "14:30", "16:10");



            Relacija r53 = new Relacija(g8, g1, 120, "Самвел - Кавадарци", "13:00", "14:40");
            Relacija r54 = new Relacija(g8, g7, 70, "Самвел - Кавадарци", "10:00", "10:40");
            Relacija r55 = new Relacija(g8, g9, 20, "Самвел - Кавадарци", "14:00", "14:20");
            Relacija r56 = new Relacija(g8, g10, 90, "Пелагонијатранс - Прилеп", "13:00", "14:00");
            Relacija r57 = new Relacija(g8, g11, 110, "Транскоп - Битола", "16:00", "17:25");
            Relacija r58 = new Relacija(g8, g12, 110, "Млаз-Богданци", "12:00", "13:30");
            Relacija r59 = new Relacija(g8, g13, 120, "СтрумицаЕкспрес - Струмица", "15:00", "16:55");
            Relacija r60 = new Relacija(g8, g14, 90, "СтрумицаЕкспрес - Струмица", "09:00", "10:00");


            Relacija r61 = new Relacija(g9, g1, 130, "Самвел - Кавадарци", "13:00", "15:10");
            Relacija r62 = new Relacija(g9, g7, 90, "Самвел - Кавадарци", "16:00", "17:00");
            Relacija r63 = new Relacija(g9, g8, 20, "Самвел - Кавадарци", "13:00", "13:20");
            Relacija r64 = new Relacija(g9, g5, 150, "Галеб - Охрид", "12:00", "14:30");
            Relacija r65 = new Relacija(g9, g10, 70, "Пелагонијатранс - Прилеп", "08:00", "08:40");
            Relacija r66 = new Relacija(g9, g11, 100, "Транскоп - Битола", "11:30", "13:00");
            Relacija r67 = new Relacija(g9, g13, 140, "Транскоп - Битола", "15:00", "17:10");

            Relacija r68 = new Relacija(g10, g1, 50, "Пелагонијатранс - Прилеп", "13:00", "14:10");
            Relacija r69 = new Relacija(g10, g7, 70, "Пелагонијатранс - Прилеп", "16:00", "17:00");
            Relacija r70 = new Relacija(g10, g8, 90, "Пелагонијатранс - Прилеп", "12:00", "13:00");
            Relacija r71 = new Relacija(g10, g9, 70, "Пелагонијатранс - Прилеп", "15:00", "15:40");
            Relacija r72 = new Relacija(g10, g5, 30, "Транскоп - Битола", "09:30", "11:30");
            Relacija r73 = new Relacija(g10, g11, 50, "Галеб - Охрид", "10:00", "10:40");
            Relacija r74 = new Relacija(g10, g13, 200, "Транскоп - Битола", "15:00", "17:50");


            Relacija r75 = new Relacija(g11, g1, 240, "Транскоп - Битола", "13:00", "16:40");
            Relacija r76 = new Relacija(g11, g7, 100, "Транскоп - Битола", "16:00", "17:40");
            Relacija r77 = new Relacija(g11, g8, 110, "Транскоп - Битола", "11:00", "12:25");
            Relacija r78 = new Relacija(g11, g9, 100, "Галеб - Охрид", "08:00", "09:30");
            Relacija r79 = new Relacija(g11, g5, 100, "Галеб - Охрид", "14:00", "15:15");
            Relacija r80 = new Relacija(g11, g10, 50, "Галеб - Охрид", "18:00", "18:40");
            Relacija r81 = new Relacija(g11, g13, 220, "Транскоп - Битола", "12:00", "15:40");



            Relacija r82 = new Relacija(g12, g1, 160, "Млаз-Богданци", "13:00", "16:00");
            Relacija r83 = new Relacija(g12, g7, 100, "Млаз-Богданци", "16:00", "18:05");
            Relacija r84 = new Relacija(g12, g8, 110, "Млаз-Богданци", "10:00", "11:30");



            Relacija r85 = new Relacija(g13, g1, 240, "СтрумицаЕкспрес - Струмица", "10:00 ", "13:00 ");
            Relacija r86 = new Relacija(g13, g7, 110, "СтрумицаЕкспрес - Струмица", "17:00", "19:05");
            Relacija r87 = new Relacija(g13, g8, 120, "СтрумицаЕкспрес - Струмица", "11:00", "12:55");
            Relacija r88 = new Relacija(g13, g9, 140, "Транскоп - Битола", "13:00", "15:10");
            Relacija r90 = new Relacija(g13, g11, 220, "Транскоп - Битола", "08:00", "11:40");
            Relacija r91 = new Relacija(g13, g10, 200, "Транскоп - Битола", "18:00", "20:50");
            Relacija r92 = new Relacija(g13, g14, 60, "СтрумицаЕкспрес - Струмица", "10:00", "10:40");
            Relacija r93 = new Relacija(g13, g15, 80, "СтрумицаЕкспрес - Струмица", "09:40", "11:40");


            Relacija r94 = new Relacija(g14, g1, 140, "СтрумицаЕкспрес - Струмица", "13:00", "15:05");
            Relacija r95 = new Relacija(g14, g2, 120, "АвтоАтом - Кочани", "11:00", "11:40");
            Relacija r96 = new Relacija(g14, g7, 50, "АвтоАтом - Кочани", "19:00", "19:45");
            Relacija r97 = new Relacija(g14, g13, 60, "СтрумицаЕкспрес - Струмица", "18:00", "18:40");
            Relacija r98 = new Relacija(g14, g15, 50, "АвтоАтом - Кочани", "19:00", "20:00");
            Relacija r89 = new Relacija(g14, g8, 90, "СтрумицаЕкспрес - Струмица", "14:30 ", "15:30 ");

            Relacija r99 = new Relacija(g15, g1, 160, "АвтоАтом - Кочани", "13:00", "15:50");
            Relacija r100 = new Relacija(g15, g2, 100, "АвтоАтом - Кочани", "18:00", "20:20");
            Relacija r101 = new Relacija(g15, g7, 100, "СтрумицаЕкспрес - Струмица", "15:00", "16:40");
            Relacija r102 = new Relacija(g15, g13, 80, "СтрумицаЕкспрес - Струмица", "16:00", "18:00");
            Relacija r103 = new Relacija(g15, g14, 50, "АвтоАтом - Кочани", "10:00", "11:00");
          

            if (comboBox1.SelectedIndex != -1)
            {
                if (comboBox2.SelectedIndex != -1)
                {
                    if (comboBox1.SelectedItem.ToString()=="Скопје")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Куманово")
                        {
                            listBox1.Items.Add(r1);
                            txtCena.Text = string.Format("{0}", r1.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Тетово")
                        {
                            listBox1.Items.Add(r2);
                            txtCena.Text = string.Format("{0}", r2.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кичево")
                        {
                            listBox1.Items.Add(r3);
                            txtCena.Text = string.Format("{0}", r3.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r6);
                            txtCena.Text = string.Format("{0}", r6.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Неготино")
                        {
                            listBox1.Items.Add(r7);
                            txtCena.Text = string.Format("{0}", r7.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кавадарци")
                        {
                            listBox1.Items.Add(r8);
                            txtCena.Text = string.Format("{0}", r8.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Прилеп")
                        {
                            listBox1.Items.Add(r9);
                            txtCena.Text = string.Format("{0}", r9.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Битола")
                        {
                            listBox1.Items.Add(r10);
                            txtCena.Text = string.Format("{0}", r10.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Охрид")
                        {
                            listBox1.Items.Add(r4);
                            txtCena.Text = string.Format("{0}", r4.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Струга")
                        {
                            listBox1.Items.Add(r5);
                            txtCena.Text = string.Format("{0}", r5.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Гевгелија")
                        {
                            listBox1.Items.Add(r11);
                            txtCena.Text = string.Format("{0}", r11.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Струмица")
                        {
                            listBox1.Items.Add(r12);
                            txtCena.Text = string.Format("{0}", r12.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Штип")
                        {
                            listBox1.Items.Add(r13);
                            txtCena.Text = string.Format("{0}", r13.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кочани")
                        {
                            listBox1.Items.Add(r14);
                            txtCena.Text = string.Format("{0}", r14.Cena());
                        }

                    }
                    else if (comboBox1.SelectedItem.ToString() == "Куманово")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r15);
                            txtCena.Text = string.Format("{0}", r15.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Тетово")
                        {
                            listBox1.Items.Add(r16);
                            txtCena.Text = string.Format("{0}", r16.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r17);
                            txtCena.Text = string.Format("{0}", r17.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Штип")
                        {
                            listBox1.Items.Add(r18);
                            txtCena.Text = string.Format("{0}", r18.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кочани")
                        {
                            listBox1.Items.Add(r19);
                            txtCena.Text = string.Format("{0}", r19.Cena());
                        }

                    }
                    else if (comboBox1.SelectedItem.ToString() == "Тетово")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Куманово")
                        {
                            listBox1.Items.Add(r21);
                            txtCena.Text = string.Format("{0}", r21.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r20);
                            txtCena.Text = string.Format("{0}", r20.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кичево")
                        {
                            listBox1.Items.Add(r22);
                            txtCena.Text = string.Format("{0}", r22.Cena());
                        }
                       
                        else if (comboBox2.SelectedItem.ToString() == "Охрид")
                        {
                            listBox1.Items.Add(r23);
                            txtCena.Text = string.Format("{0}", r23.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Струга")
                        {
                            listBox1.Items.Add(r24);
                            txtCena.Text = string.Format("{0}", r24.Cena());
                        }

                    }
                    else if (comboBox1.SelectedItem.ToString() == "Кичево")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r25);
                            txtCena.Text = string.Format("{0}", r25.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Тетово")
                        {
                            listBox1.Items.Add(r27);
                            txtCena.Text = string.Format("{0}", r27.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Охрид")
                        {
                            listBox1.Items.Add(r28);
                            txtCena.Text = string.Format("{0}", r28.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Струга")
                        {
                            listBox1.Items.Add(r29);
                            txtCena.Text = string.Format("{0}", r29.Cena());
                        }

                    }
                    else if (comboBox1.SelectedItem.ToString() == "Охрид")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r30);
                            txtCena.Text = string.Format("{0}", r30.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Тетово")
                        {
                            listBox1.Items.Add(r31);
                            txtCena.Text = string.Format("{0}", r31.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кичево")
                        {
                            listBox1.Items.Add(r32);
                            txtCena.Text = string.Format("{0}", r32.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r34);
                            txtCena.Text = string.Format("{0}", r34.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кавадарци")
                        {
                            listBox1.Items.Add(r35);
                            txtCena.Text = string.Format("{0}", r35.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Прилеп")
                        {
                            listBox1.Items.Add(r36);
                            txtCena.Text = string.Format("{0}", r36.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Битола")
                        {
                            listBox1.Items.Add(r37);
                            txtCena.Text = string.Format("{0}", r37.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Струга")
                        {
                            listBox1.Items.Add(r33);
                            txtCena.Text = string.Format("{0}", r33.Cena());
                        }
                        

                    }
                    else if (comboBox1.SelectedItem.ToString() == "Струга")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r38);
                            txtCena.Text = string.Format("{0}", r38.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Тетово")
                        {
                            listBox1.Items.Add(r39);
                            txtCena.Text = string.Format("{0}", r39.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кичево")
                        {
                            listBox1.Items.Add(r40);
                            txtCena.Text = string.Format("{0}", r40.Cena());
                        }
                       
                        else if (comboBox2.SelectedItem.ToString() == "Охрид")
                        {
                            listBox1.Items.Add(r41);
                            txtCena.Text = string.Format("{0}", r41.Cena());
                        }
                        
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Велес")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Куманово")
                        {
                            listBox1.Items.Add(r43);
                            txtCena.Text = string.Format("{0}", r43.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r42);
                            txtCena.Text = string.Format("{0}", r42.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Неготино")
                        {
                            listBox1.Items.Add(r45);
                            txtCena.Text = string.Format("{0}", r45.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кавадарци")
                        {
                            listBox1.Items.Add(r46);
                            txtCena.Text = string.Format("{0}", r46.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Прилеп")
                        {
                            listBox1.Items.Add(r47);
                            txtCena.Text = string.Format("{0}", r47.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Битола")
                        {
                            listBox1.Items.Add(r48);
                            txtCena.Text = string.Format("{0}", r48.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Охрид")
                        {
                            listBox1.Items.Add(r44);
                            txtCena.Text = string.Format("{0}", r44.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Гевгелија")
                        {
                            listBox1.Items.Add(r49);
                            txtCena.Text = string.Format("{0}", r49.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Струмица")
                        {
                            listBox1.Items.Add(r50);
                            txtCena.Text = string.Format("{0}", r50.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Штип")
                        {
                            listBox1.Items.Add(r51);
                            txtCena.Text = string.Format("{0}", r51.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кочани")
                        {
                            listBox1.Items.Add(r52);
                            txtCena.Text = string.Format("{0}", r52.Cena());
                        }

                    }
                    else if (comboBox1.SelectedItem.ToString() == "Неготино")
                    {
                        
                        if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r54);
                            txtCena.Text = string.Format("{0}", r54.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r53);
                            txtCena.Text = string.Format("{0}", r53.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кавадарци")
                        {
                            listBox1.Items.Add(r55);
                            txtCena.Text = string.Format("{0}", r55.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Прилеп")
                        {
                            listBox1.Items.Add(r56);
                            txtCena.Text = string.Format("{0}", r56.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Битола")
                        {
                            listBox1.Items.Add(r57);
                            txtCena.Text = string.Format("{0}", r57.Cena());
                        }
                       
                        else if (comboBox2.SelectedItem.ToString() == "Гевгелија")
                        {
                            listBox1.Items.Add(r58);
                            txtCena.Text = string.Format("{0}", r58.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Струмица")
                        {
                            listBox1.Items.Add(r59);
                            txtCena.Text = string.Format("{0}", r59.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Штип")
                        {
                            listBox1.Items.Add(r60);
                            txtCena.Text = string.Format("{0}", r60.Cena());
                        }
                       
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Кавадарци")
                    {
                        
                        if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r62);
                            txtCena.Text = string.Format("{0}", r62.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Неготино")
                        {
                            listBox1.Items.Add(r63);
                            txtCena.Text = string.Format("{0}", r63.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r61);
                            txtCena.Text = string.Format("{0}", r61.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Прилеп")
                        {
                            listBox1.Items.Add(r65);
                            txtCena.Text = string.Format("{0}", r65.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Битола")
                        {
                            listBox1.Items.Add(r66);
                            txtCena.Text = string.Format("{0}", r66.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Охрид")
                        {
                            listBox1.Items.Add(r64);
                            txtCena.Text = string.Format("{0}", r64.Cena());
                        }
                       
                        else if (comboBox2.SelectedItem.ToString() == "Струмица")
                        {
                            listBox1.Items.Add(r67);
                            txtCena.Text = string.Format("{0}", r67.Cena());
                        }
                       
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Прилеп")
                    {
                        
                        if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r69);
                            txtCena.Text = string.Format("{0}", r69.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Неготино")
                        {
                            listBox1.Items.Add(r70);
                            txtCena.Text = string.Format("{0}", r70.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кавадарци")
                        {
                            listBox1.Items.Add(r71);
                            txtCena.Text = string.Format("{0}", r71.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r68);
                            txtCena.Text = string.Format("{0}", r68.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Битола")
                        {
                            listBox1.Items.Add(r73);
                            txtCena.Text = string.Format("{0}", r73.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Охрид")
                        {
                            listBox1.Items.Add(r72);
                            txtCena.Text = string.Format("{0}", r72.Cena());
                        }
                        
                        else if (comboBox2.SelectedItem.ToString() == "Струмица")
                        {
                            listBox1.Items.Add(r74);
                            txtCena.Text = string.Format("{0}", r74.Cena());
                        }
                        
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Битола")
                    {
                        
                        if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r76);
                            txtCena.Text = string.Format("{0}", r76.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Неготино")
                        {
                            listBox1.Items.Add(r77);
                            txtCena.Text = string.Format("{0}", r7.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кавадарци")
                        {
                            listBox1.Items.Add(r78);
                            txtCena.Text = string.Format("{0}", r78.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Прилеп")
                        {
                            listBox1.Items.Add(r80);
                            txtCena.Text = string.Format("{0}", r80.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r75);
                            txtCena.Text = string.Format("{0}", r75.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Охрид")
                        {
                            listBox1.Items.Add(r79);
                            txtCena.Text = string.Format("{0}", r79.Cena());
                        }
                        
                        else if (comboBox2.SelectedItem.ToString() == "Струмица")
                        {
                            listBox1.Items.Add(r81);
                            txtCena.Text = string.Format("{0}", r81.Cena());
                        }                       
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Гевгелија")
                    {
                        
                        if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r83);
                            txtCena.Text = string.Format("{0}", r83.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Неготино")
                        {
                            listBox1.Items.Add(r84);
                            txtCena.Text = string.Format("{0}", r84.Cena());
                        }
                        
                        else if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r82);
                            txtCena.Text = string.Format("{0}", r82.Cena());
                        }
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Струмица")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r85);
                            txtCena.Text = string.Format("{0}", r85.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r86);
                            txtCena.Text = string.Format("{0}", r86.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Неготино")
                        {
                            listBox1.Items.Add(r87);
                            txtCena.Text = string.Format("{0}", r87.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кавадарци")
                        {
                            listBox1.Items.Add(r88);
                            txtCena.Text = string.Format("{0}", r88.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Прилеп")
                        {
                            listBox1.Items.Add(r91);
                            txtCena.Text = string.Format("{0}", r91.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Битола")
                        {
                            listBox1.Items.Add(r90);
                            txtCena.Text = string.Format("{0}", r90.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Штип")
                        {
                            listBox1.Items.Add(r92);
                            txtCena.Text = string.Format("{0}", r92.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кочани")
                        {
                            listBox1.Items.Add(r93);
                            txtCena.Text = string.Format("{0}", r93.Cena());
                        }

                    }
                    else if (comboBox1.SelectedItem.ToString() == "Штип")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Куманово")
                        {
                            listBox1.Items.Add(r95);
                            txtCena.Text = string.Format("{0}", r95.Cena());
                        }
                        
                        else if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r96);
                            txtCena.Text = string.Format("{0}", r96.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Неготино")
                        {
                            listBox1.Items.Add(r89);
                            txtCena.Text = string.Format("{0}", r89.Cena());
                        }
                        
                        else if (comboBox2.SelectedItem.ToString() == "Струмица")
                        {
                            listBox1.Items.Add(r97);
                            txtCena.Text = string.Format("{0}", r97.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r94);
                            txtCena.Text = string.Format("{0}", r94.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Кочани")
                        {
                            listBox1.Items.Add(r98);
                            txtCena.Text = string.Format("{0}", r98.Cena());
                        }

                    }
                    else if (comboBox1.SelectedItem.ToString() == "Кочани")
                    {
                        if (comboBox2.SelectedItem.ToString() == "Куманово")
                        {
                            listBox1.Items.Add(r100);
                            txtCena.Text = string.Format("{0}", r100.Cena());
                        }
                        
                        else if (comboBox2.SelectedItem.ToString() == "Велес")
                        {
                            listBox1.Items.Add(r101);
                            txtCena.Text = string.Format("{0}", r101.Cena());
                        }
                        
                        else if (comboBox2.SelectedItem.ToString() == "Струмица")
                        {
                            listBox1.Items.Add(r102);
                            txtCena.Text = string.Format("{0}", r102.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Штип")
                        {
                            listBox1.Items.Add(r103);
                            txtCena.Text = string.Format("{0}", r103.Cena());
                        }
                        else if (comboBox2.SelectedItem.ToString() == "Скопје")
                        {
                            listBox1.Items.Add(r99);
                            txtCena.Text = string.Format("{0}", r99.Cena());
                        }

                    }


                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            float c = 0;
            float n = 0;
            float.TryParse(txtCena.Text,out c);
            float.TryParse(txtNaplateno.Text,out n);
            if (c<=n)
            {
                float k = n-c;
                txtKusur.Text = k.ToString();
                MessageBox.Show(string.Format("Цената на билетот изнесува {0} денари, вие плативте {1} денари и треба да ви се вратат {2} денари", txtCena.Text, txtNaplateno.Text, txtKusur.Text));
            }
            else { MessageBox.Show(string.Format("Немате доволно пари да ја платите картата")); }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сакате да го откажете купувањето на билетот?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        int br = 1;
        int br2 = 0;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex != -1)
            {
                float nova = 0;
                float.TryParse(txtCena.Text, out nova);
                if (radioButton2.Checked == true)
                {
                    
                    if (br%2!=0)
                    {
                        nova = (nova / 2) * 3;
                        br++;
                        br2++;
                    }
                    txtCena.Text = nova.ToString();
                    nova = 0;
                }
                else
                {   
                    if(br2%2!=0)
                    {
                        nova = (nova / 3) * 2;
                         br2++;
                         br++;
                    }
                    txtCena.Text = nova.ToString();
                    nova = 0;
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                float nova = 0;
                float.TryParse(txtCena.Text, out nova);
                txtCena.Text = nova.ToString();
            }
        }
        public void calculateTotal(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                int i = listBox1.SelectedIndex;
                Relacija r = listBox1.Items[i] as Relacija;
                txtCena.Text =string.Format("{0}", r.Cena());
            }
        }
        
       

       


        

        

       
        
    }
}
