using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MyLibrary;

namespace Exp
{
    public partial class Form1 : Form
    {

        string path, pathTo;
        string[] dir, files;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                Process.Start(path);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (Win32Exception)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("ОШИБКА: НЕ УКАЗАНО ИМЯ ФАЙЛА");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                File.Delete(path);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ ИМЕЕТ НЕДОПУСТИМУЮ ФОРМУ");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                Directory.CreateDirectory(path);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                Directory.Delete(path, true);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ ИМЕЕТ НЕДОПУСТИМУЮ ФОРМУ");
            }
            catch (IOException)
            {
                MessageBox.Show("ОШИБКА: ПАПКА НЕ ПУСТА");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                pathTo = textBox2.Text;
                File.Copy(path, pathTo);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ/НАЗНАЧЕНИЕ");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (IOException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                File.Create(path);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ/НАЗНАЧЕНИЕ");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                dir = Directory.GetDirectories(path);
                listBox1.Items.Clear();
                for (int i = 0; i < dir.Length; i++)
                {
                    listBox1.Items.Add(dir[i]);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ/НАЗНАЧЕНИЕ");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
            catch (IOException)
            {
                MessageBox.Show("ОШИБКА: НЕВЕРНО ЗАДАНО ИМЯ ПАПКИ");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                dir = Directory.GetFiles(path);
                listBox1.Items.Clear();
                for (int i = 0; i < dir.Length; i++)
                {
                    listBox1.Items.Add(dir[i]);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ/НАЗНАЧЕНИЕ");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
            catch (IOException)
            {
                MessageBox.Show("ОШИБКА: НЕВЕРНО ЗАДАНО ИМЯ ФАЙЛА");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirsAndFiles();
            DirsAndFiles1();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = listBox1.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВЫБРАН ПУТЬ");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = listBox2.SelectedItem.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВЫБРАН ПУТЬ");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                File.Create(path);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ/НАЗНАЧЕНИЕ");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                Directory.Delete(path, true);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ ИМЕЕТ НЕДОПУСТИМУЮ ФОРМУ");
            }
            catch (IOException)
            {
                MessageBox.Show("ОШИБКА: ПАПКА НЕ ПУСТА");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                Directory.CreateDirectory(path);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                File.Delete(path);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ ИМЕЕТ НЕДОПУСТИМУЮ ФОРМУ");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                Process.Start(path);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (Win32Exception)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("ОШИБКА: НЕ УКАЗАНО ИМЯ ФАЙЛА");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            path = textBox1.Text = (string)listBox1.SelectedItem;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            path = textBox1.Text = (string)listBox2.SelectedItem;
        }

        private void DirsAndFiles()
        {
            try
            {
                path = textBox1.Text;
                dir = Directory.GetDirectories(path);
                files = Directory.GetFiles(path);
                for (int i = 0; i < dir.Length; i++)
                {
                    listBox1.Items.Add(dir[i]);
                }
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ/НАЗНАЧЕНИЕ");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
            catch (IOException)
            {
                MessageBox.Show("ОШИБКА: НЕВЕРНО ЗАДАНО ИМЯ ПАПКИ");
            }
        }

        private void DirsAndFiles1()
        {
            try
            {
                path = textBox1.Text;
                dir = Directory.GetDirectories(path);
                files = Directory.GetFiles(path);
                for (int i = 0; i < dir.Length; i++)
                {
                    listBox2.Items.Add(dir[i]);
                }
                for (int i = 0; i < files.Length; i++)
                {
                    listBox2.Items.Add(files[i]);
                }
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ/НАЗНАЧЕНИЕ");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
            catch (IOException)
            {
                MessageBox.Show("ОШИБКА: НЕВЕРНО ЗАДАНО ИМЯ ПАПКИ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DirsAndFiles();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            path = textBox1.Text = (string)listBox1.SelectedItem;
            listBox1.Items.Clear();
            DirsAndFiles();
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = (string)listBox2.SelectedItem;
            listBox2.Items.Clear();
            DirsAndFiles1();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            DirsAndFiles1();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                path = Methods.Return(path, '\\');
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: ОТСУТСТВУЕТ ПУТЬ");
            }
            textBox1.Text = path;
            listBox1.Items.Clear();
            DirsAndFiles();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            path = Methods.Return(path, '\\');
            textBox1.Text = path;
            listBox2.Items.Clear();
            DirsAndFiles1();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            path = textBox1.Text;
            pathTo = textBox2.Text;
            try
            {
                File.Move(path, pathTo);
                MessageBox.Show("СООБЩЕНИЕ: ЗАВЕРШЕНО!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ПУТЬ НЕ НАЙДЕН");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("ОШИБКА: НЕ ВВЕДЕН ПУТЬ/НАЗНАЧЕНИЕ");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ОШИБКА: ФАЙЛ НЕ НАЙДЕН");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("ОШИБКА: ОТКАЗАНО В ДОСТУПЕ");
            }
        }
    }
}
