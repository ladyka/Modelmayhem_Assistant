﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Modelmayhem_Assistant
{
    public partial class CHANGELOG : Form
    {
        /// <summary>
        /// CHANGELOG window
        /// </summary>
        public CHANGELOG()
        {
            //Я это просто тут оставил.
            InitializeComponent();
            labellog.Text = "Если нужно что-то будет. То это будет!!! \n" +
                "Cписок изменений:\n" +
                "\n" +
                "v 0.1.6 Запилен прогресс бар, отсчитывает, сколько осталось времени до посыла очередного сообщения.\n" +
                "v 0.1.5 Оптимизирована работа программы. Добавлены отловы исключений.\n" +
                "v 0.1.4 Почищен вывод лога.\n" +
                "v 0.1.3 Сворачивается в трей по счелчку на трее.\n" +
                "v 0.1.2 Добавлена панель меню. Изменён дизайн приложения.\n" +
                "v 0.1.1 Нули перед целыми числами во времени, для однозначных значений. Пароль отображается в строке звездочками\n" +
                "v 0.0.4 Добавлено ведение лога в правое окно, когда было послано сообщение\n" +
                "v 0.0.3 Добавлена функция, убивающая поток, посылающий сообщения.\n" +
                "v 0.0.2 Логин пароль и сообщение сохраняются в файле.\n" +
                "v 0.0.1 Запилена прога. Логиниться на сайте. Посылает сообщения.\n" + //Присутствует проблема с амперсандом
                //С амперсантом действительно есть проблемы - отправился только текст до него.
                "";
            labelautor.Text = "Autor Fylh-if";
            linkLabel1.Text = "fylh-if@yandex.by";
        }
    }
}
