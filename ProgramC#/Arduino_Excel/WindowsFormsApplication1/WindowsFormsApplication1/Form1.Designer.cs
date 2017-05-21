namespace WindowsFormsApplication1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPomiarPierwszy = new System.Windows.Forms.TextBox();
            this.textBoxPomiarDrugi = new System.Windows.Forms.TextBox();
            this.buttonStartPomiar = new System.Windows.Forms.Button();
            this.buttonStartZapisPomiarPierwszy = new System.Windows.Forms.Button();
            this.buttonStopZapisPomiarPierwszy = new System.Windows.Forms.Button();
            this.buttonStopPomiar = new System.Windows.Forms.Button();
            this.buttonStartZapisPomiarDrugi = new System.Windows.Forms.Button();
            this.buttonStopZapisPomiarDrugi = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pomiar 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pomiar 2";
            // 
            // textBoxPomiarPierwszy
            // 
            this.textBoxPomiarPierwszy.Location = new System.Drawing.Point(100, 73);
            this.textBoxPomiarPierwszy.Name = "textBoxPomiarPierwszy";
            this.textBoxPomiarPierwszy.Size = new System.Drawing.Size(100, 20);
            this.textBoxPomiarPierwszy.TabIndex = 11;
            // 
            // textBoxPomiarDrugi
            // 
            this.textBoxPomiarDrugi.Location = new System.Drawing.Point(361, 73);
            this.textBoxPomiarDrugi.Name = "textBoxPomiarDrugi";
            this.textBoxPomiarDrugi.Size = new System.Drawing.Size(100, 20);
            this.textBoxPomiarDrugi.TabIndex = 10;
            // 
            // buttonStartPomiar
            // 
            this.buttonStartPomiar.Location = new System.Drawing.Point(111, 113);
            this.buttonStartPomiar.Name = "buttonStartPomiar";
            this.buttonStartPomiar.Size = new System.Drawing.Size(75, 23);
            this.buttonStartPomiar.TabIndex = 4;
            this.buttonStartPomiar.Text = "Start Pomiar";
            this.buttonStartPomiar.UseVisualStyleBackColor = true;
            this.buttonStartPomiar.Click += new System.EventHandler(this.buttonStartPomiar_Click);
            // 
            // buttonStartZapisPomiarPierwszy
            // 
            this.buttonStartZapisPomiarPierwszy.Location = new System.Drawing.Point(111, 156);
            this.buttonStartZapisPomiarPierwszy.Name = "buttonStartZapisPomiarPierwszy";
            this.buttonStartZapisPomiarPierwszy.Size = new System.Drawing.Size(75, 23);
            this.buttonStartZapisPomiarPierwszy.TabIndex = 5;
            this.buttonStartZapisPomiarPierwszy.Text = "Start Zapis";
            this.buttonStartZapisPomiarPierwszy.UseVisualStyleBackColor = true;
            this.buttonStartZapisPomiarPierwszy.Click += new System.EventHandler(this.buttonStartZapisPomiarPierwszy_Click);
            // 
            // buttonStopZapisPomiarPierwszy
            // 
            this.buttonStopZapisPomiarPierwszy.Location = new System.Drawing.Point(111, 196);
            this.buttonStopZapisPomiarPierwszy.Name = "buttonStopZapisPomiarPierwszy";
            this.buttonStopZapisPomiarPierwszy.Size = new System.Drawing.Size(75, 23);
            this.buttonStopZapisPomiarPierwszy.TabIndex = 6;
            this.buttonStopZapisPomiarPierwszy.Text = "Stop Zapis";
            this.buttonStopZapisPomiarPierwszy.UseVisualStyleBackColor = true;
            this.buttonStopZapisPomiarPierwszy.Click += new System.EventHandler(this.buttonStopZapisPomiarPierwszy_Click);
            // 
            // buttonStopPomiar
            // 
            this.buttonStopPomiar.Location = new System.Drawing.Point(373, 113);
            this.buttonStopPomiar.Name = "buttonStopPomiar";
            this.buttonStopPomiar.Size = new System.Drawing.Size(75, 23);
            this.buttonStopPomiar.TabIndex = 7;
            this.buttonStopPomiar.Text = "Stop Pomiar";
            this.buttonStopPomiar.UseVisualStyleBackColor = true;
            this.buttonStopPomiar.Click += new System.EventHandler(this.buttonStopPomiar_Click);
            // 
            // buttonStartZapisPomiarDrugi
            // 
            this.buttonStartZapisPomiarDrugi.Location = new System.Drawing.Point(373, 156);
            this.buttonStartZapisPomiarDrugi.Name = "buttonStartZapisPomiarDrugi";
            this.buttonStartZapisPomiarDrugi.Size = new System.Drawing.Size(75, 23);
            this.buttonStartZapisPomiarDrugi.TabIndex = 8;
            this.buttonStartZapisPomiarDrugi.Text = "Start Zapis";
            this.buttonStartZapisPomiarDrugi.UseVisualStyleBackColor = true;
            this.buttonStartZapisPomiarDrugi.Click += new System.EventHandler(this.buttonStartZapisPomiarDrugi_Click);
            // 
            // buttonStopZapisPomiarDrugi
            // 
            this.buttonStopZapisPomiarDrugi.Location = new System.Drawing.Point(373, 195);
            this.buttonStopZapisPomiarDrugi.Name = "buttonStopZapisPomiarDrugi";
            this.buttonStopZapisPomiarDrugi.Size = new System.Drawing.Size(75, 23);
            this.buttonStopZapisPomiarDrugi.TabIndex = 9;
            this.buttonStopZapisPomiarDrugi.Text = "Stop Zapis";
            this.buttonStopZapisPomiarDrugi.UseVisualStyleBackColor = true;
            this.buttonStopZapisPomiarDrugi.Click += new System.EventHandler(this.buttonStopZapisPomiarDrugi_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM8";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 244);
            this.Controls.Add(this.buttonStopZapisPomiarDrugi);
            this.Controls.Add(this.buttonStartZapisPomiarDrugi);
            this.Controls.Add(this.buttonStopPomiar);
            this.Controls.Add(this.buttonStopZapisPomiarPierwszy);
            this.Controls.Add(this.buttonStartZapisPomiarPierwszy);
            this.Controls.Add(this.buttonStartPomiar);
            this.Controls.Add(this.textBoxPomiarDrugi);
            this.Controls.Add(this.textBoxPomiarPierwszy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPomiarPierwszy;
        private System.Windows.Forms.TextBox textBoxPomiarDrugi;
        private System.Windows.Forms.Button buttonStartPomiar;
        private System.Windows.Forms.Button buttonStartZapisPomiarPierwszy;
        private System.Windows.Forms.Button buttonStopZapisPomiarPierwszy;
        private System.Windows.Forms.Button buttonStopPomiar;
        private System.Windows.Forms.Button buttonStartZapisPomiarDrugi;
        private System.Windows.Forms.Button buttonStopZapisPomiarDrugi;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

