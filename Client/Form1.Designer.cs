using System.Net.Sockets;
using System.Text;

namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private TcpClient client;
        private NetworkStream stream;
        public Form1(string ip, int port)
        {
            client = new TcpClient(ip, port);
            stream = client.GetStream();
        }
        public void SendMessage(string message)
        {
            var data = Encoding.UTF8.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
        public async Task StartReceiving(Action<string> onMessageReceived)
        {
            var buffer = new byte[1024];

            while (true)
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0) break; // Connection closed

                var message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                onMessageReceived(message);
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}
