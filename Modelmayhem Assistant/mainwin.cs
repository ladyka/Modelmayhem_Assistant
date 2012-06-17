using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Modelmayhem_Assistant
{
    public partial class mainwin : Form
    {
        private int delayMin;
        Thread t;
        Announcement webwork;
        string messageMM;

        public mainwin()
        {
            InitializeComponent();
            setDefaultValue();
            webwork = new Announcement();
        }

        /// <summary>
        /// Авторизация на сайте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginOnSite(object sender, EventArgs e)
        {
            if (webwork.loginonsite(textBox1.Text, textBox2.Text))
            {
                richTextBox2.AppendText("Залогинился\n");
                button1.Enabled = true;
                buttonlogin.Enabled = false;
                buttonlogin.Hide();
                button2.Show();
                начатьПосылатьСообщенияToolStripMenuItem.Enabled = true;
                залогинитьсяToolStripMenuItem.Enabled = false;
            }
            else
            {
                richTextBox2.AppendText("Ошибка. Прога не залогинилась\n");
            }

        }

        /// <summary>
        /// Запуск функции посыла сообщения на сайт, визуальные работы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendtext(object sender, EventArgs e)
        {
            delayMin = Convert.ToInt32(numericUpDown1.Value);
            t = new Thread(sendMsgThread);
            progressBar1.Maximum = delayMin * 60 + 1;
            richTextBox2.AppendText("Создаля отдельный поток, который будет писать каждые n минут на сайт сообщение.\n");
            messageMM = richTextBox1.Text;
            t.Start();
        }

        /// <summary>
        /// Поток t, управляющий методом посыла сообщения на сайт
        /// </summary>
        private void sendMsgThread()
        {
            while (true)
            {
                //прогбар в начало
                setValue();
                //послать сообщение
                webwork.sendannouncement(messageMM);
                //подождать
                int n;
                Random rnd = new Random();
                n = rnd.Next(2,20);
                n = 1000 * (60 * delayMin + n);
                AppendText(msg());
                int i1 = 0 ;
                while (i1 < n + 12)
                {
                    i1 += 1000;
                    //пока жду тягать прогбар
                    PerformStep();
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// Убийство потока t,  визуальные работы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void killThread(object sender, EventArgs e)
        {
            if (t != null)
                if (t.IsAlive)
                {
                    t.Abort();
                    richTextBox2.AppendText("Поток который посылает сообщения скорее всего мертв.\n");
                }
                else
                    MessageBox.Show("Ошибка. Марина, что делала, последние действия, напиши мне, или пусть это сделает Илья");
        }

        private void exitProgram(object sender, EventArgs e)
        {
            killThread(sender, e);
            this.Close();
        }

        private void changelogWindowShow(object sender, EventArgs e)
        {
            CHANGELOG chante5 = new CHANGELOG();
            chante5.Show();
        }
        
        // Меню "О программе."
        private void aboutProgram(object sender, EventArgs e)
        {
            MessageBox.Show("Программа для работы с сайтом Modelmayhem.com");
        }

        // здесь хранится состояние окна до сворачивания (максимизированное или нормальное)
        private FormWindowState _OldFormState;

        //обрабатываем событие клика мышью по значку в трее
        void _notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            //проверяем, какой кнопкой было произведено нажатие
            if (e.Button == MouseButtons.Left)//если левой кнопкой мыши
            {
                //проверяем текущее состояние окна
                if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)//если оно развернуто
                {
                    //сохраняем текущее состояние
                    _OldFormState = WindowState;
                    //сворачиваем окно
                    WindowState = FormWindowState.Minimized;
                    //скрываться в трей оно будет по событию Resize (изменение размера), которое сгенерировалось после минимизации строчкой выше
                }
                else//в противном случае
                {
                    //и показываем на нанели задач
                    Show();
                    //разворачиваем (возвращаем старое состояние "до сворачивания")
                    WindowState = _OldFormState;
                }
            }
        }

        // обрабатываем событие изменения размера
        void FormForTray_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)//если окно "свернуто"
            {
                //то скрываем его
                Hide();
            }
        }

        //Формируем строку и обрабатываем её для текущего момента для записи в лог файл.
        private string msg()
        {
            DateTime d1 = DateTime.Now;
            string msg;
            msg = Convert.ToString(d1.Year) + ".";
            msg += fIntString(d1.Month) + ".";
            msg += fIntString(d1.Day) + " - ";
            msg += fIntString(d1.Hour) + ":";
            msg += fIntString(d1.Minute) + ":";
            msg += fIntString(d1.Second) + "\n";
            return msg;
        }

        // Обработка значения времени для 2 знаков
        private string fIntString(int i)
        {
            string istring;
            if (i < 10)
                istring = "0" + Convert.ToString(i);
            else
                istring = Convert.ToString(i);

            return istring;

        }

        private delegate void DAppendText(string message);

        private void AppendText(string message)
        {
            if (richTextBox2.InvokeRequired)
            {
                DAppendText deleg = AppendText;
                richTextBox2.Invoke(deleg, message);
            }
            else
            {
                richTextBox2.AppendText(msg());
            }
        }

        /// <summary>
        /// Работы с треем и визуальные работы
        /// </summary>
        private void setDefaultValue()
        {
            //задаем всплывающий текст-подсказку (появляется при наведении указателя на иконку в трее)
            _notifyIcon.Text = "Modelmayhem_Assistant";
            //устанавливаем значок, отображаемый в трее:
            _notifyIcon.Icon = global::Modelmayhem_Assistant.Properties.Resources.favicon;
            //подписываемся на событие клика мышкой по значку в трее
            _notifyIcon.MouseClick += new MouseEventHandler(_notifyIcon_MouseClick);
            //подписываемся на событие изменения размера формы
            this.Resize += new EventHandler(FormForTray_Resize);

            numericUpDown1.Value = 5;
            numericUpDown1.Maximum = 1000;
            numericUpDown1.Minimum = 5;

            string path = @"password.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                richTextBox2.AppendText("Файл паролей не найден, беру дефолтные настройки и пишу их в файл.\n");
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("randomemail@email.com");
                    sw.WriteLine("randompassword");
                    sw.WriteLine("Modelmayhem Assistant.");
                }
            }

            // Open the file to read from.

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                int i = 0;
                while ((s = sr.ReadLine()) != null)
                {

                    if (i == 0) textBox1.Text = s;//"iluviar.m@gmail.com";
                    if (i == 1) textBox2.Text = s;// "catfelix666";
                    if (i == 2) richTextBox1.Text = s;//"Photomanipulation and Retouching Services";
                    i++;
                }
            }

            button1.Enabled = false;
            начатьПосылатьСообщенияToolStripMenuItem.Enabled = false;
            button2.Hide();
            progressBar1.Step = 1;
            progressBar1.Value = 1;
            progressBar1.Minimum = 0;
        }

        private delegate void DPerformStep();

        private void PerformStep()
        {
            if (progressBar1.InvokeRequired)
            {
                DPerformStep deleg = PerformStep;
                progressBar1.Invoke(deleg);
            }
            else
            {
                progressBar1.PerformStep();
            }
        }

        /// <summary>
        /// Прогрес бар в исходно е положение возвращается.
        /// </summary>
        #region Прогрес бар в исходно е положение возвращается.
        private delegate void DprogBartoStart();
        private void setValue()
        {
            if (progressBar1.InvokeRequired)
            {
                DprogBartoStart deleg = progBartoStart;
                progressBar1.Invoke(deleg);
            }
            else
            {
                progressBar1.Value = 1;
            }
        }
        private void progBartoStart()
        {
            progressBar1.Value = 1;
        }
        #endregion 


    }
}