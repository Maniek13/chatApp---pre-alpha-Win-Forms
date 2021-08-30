﻿using Klient.App.Objects;
using System;
using System.Windows.Forms;

namespace Klient
{
    public partial class MessageBox : Form
    {
        private readonly string name;
        private string message;

        public MessageBox(string name)
        {
            this.name = name;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.message = TextToSend.Text;

            if (this.message != "")
            {
                MessagesController messagesController = new MessagesController();
                string res = messagesController.Wiadomość(this.name, this.message, true);
                ChatWindow.AppendText(res + Environment.NewLine);
                TextToSend.Text = "";
            }
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            ContactName.Text = this.name;
        }

        private void TextToSend_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChatWindow_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactName_Click(object sender, EventArgs e)
        {

        }
    }
}