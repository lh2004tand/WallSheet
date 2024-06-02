using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Wolf_of_Wallstreet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        private TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        public Form1(int port)
        {
            listener = new TcpListener(IPAddress.Any, port);
        }
        public void Start()
        {
            listener.Start();
            Console.WriteLine("Server started...");

            Task.Run(async () =>
            {
                while (true)
                {
                    var client = await listener.AcceptTcpClientAsync();
                    lock (clients)
                    {
                        clients.Add(client);
                    }
                    HandleClient(client);
                }
            });
        }
        private async void HandleClient(TcpClient client)
        {
            var stream = client.GetStream();
            var buffer = new byte[1024];

            while (true)
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0) break; // Connection closed

                lock (clients)
                {
                    foreach (var c in clients)
                    {
                        if (c != client)
                        {
                            c.GetStream().Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }
            lock (clients)
            {
                clients.Remove(client);
            }
            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            {
                this.SuspendLayout();
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(800, 450);
                this.Name = "Form1";
                this.Text = "Server";
                this.ResumeLayout(false);

            }

            #endregion
        }
    }
}

