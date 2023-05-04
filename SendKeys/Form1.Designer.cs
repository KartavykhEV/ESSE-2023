
namespace SendKeys
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrentlyActiveWindow = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLock = new System.Windows.Forms.Button();
            this.lblActiveWindow = new System.Windows.Forms.Label();
            this.txtActiveWindow = new System.Windows.Forms.TextBox();
            this.txtWindowHandle = new System.Windows.Forms.TextBox();
            this.lblActiveWindowHandle = new System.Windows.Forms.Label();
            this.grpKeys = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rbtALT = new System.Windows.Forms.RadioButton();
            this.rbtCTRL = new System.Windows.Forms.RadioButton();
            this.cboLetter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.grpKeys.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentlyActiveWindow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1424, 42);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrentlyActiveWindow
            // 
            this.lblCurrentlyActiveWindow.Name = "lblCurrentlyActiveWindow";
            this.lblCurrentlyActiveWindow.Size = new System.Drawing.Size(178, 32);
            this.lblCurrentlyActiveWindow.Text = "Active Window:";
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(992, 10);
            this.btnLock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(220, 44);
            this.btnLock.TabIndex = 1;
            this.btnLock.Text = "Lock Window";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Visible = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // lblActiveWindow
            // 
            this.lblActiveWindow.AutoSize = true;
            this.lblActiveWindow.Location = new System.Drawing.Point(32, 17);
            this.lblActiveWindow.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblActiveWindow.Name = "lblActiveWindow";
            this.lblActiveWindow.Size = new System.Drawing.Size(159, 25);
            this.lblActiveWindow.TabIndex = 2;
            this.lblActiveWindow.Text = "Active Window:";
            // 
            // txtActiveWindow
            // 
            this.txtActiveWindow.Enabled = false;
            this.txtActiveWindow.Location = new System.Drawing.Point(203, 14);
            this.txtActiveWindow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtActiveWindow.Name = "txtActiveWindow";
            this.txtActiveWindow.Size = new System.Drawing.Size(392, 31);
            this.txtActiveWindow.TabIndex = 3;
            this.txtActiveWindow.Text = "Редактирование обучающегося";
            // 
            // txtWindowHandle
            // 
            this.txtWindowHandle.Enabled = false;
            this.txtWindowHandle.Location = new System.Drawing.Point(789, 17);
            this.txtWindowHandle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtWindowHandle.Name = "txtWindowHandle";
            this.txtWindowHandle.Size = new System.Drawing.Size(140, 31);
            this.txtWindowHandle.TabIndex = 4;
            // 
            // lblActiveWindowHandle
            // 
            this.lblActiveWindowHandle.AutoSize = true;
            this.lblActiveWindowHandle.Location = new System.Drawing.Point(607, 17);
            this.lblActiveWindowHandle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblActiveWindowHandle.Name = "lblActiveWindowHandle";
            this.lblActiveWindowHandle.Size = new System.Drawing.Size(168, 25);
            this.lblActiveWindowHandle.TabIndex = 5;
            this.lblActiveWindowHandle.Text = "Window Handle:";
            // 
            // grpKeys
            // 
            this.grpKeys.Controls.Add(this.richTextBox1);
            this.grpKeys.Controls.Add(this.panel2);
            this.grpKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKeys.Location = new System.Drawing.Point(0, 60);
            this.grpKeys.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpKeys.Name = "grpKeys";
            this.grpKeys.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpKeys.Size = new System.Drawing.Size(1424, 565);
            this.grpKeys.TabIndex = 6;
            this.grpKeys.TabStop = false;
            this.grpKeys.Text = "Send Keys";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(391, 40);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 41);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rbtALT
            // 
            this.rbtALT.AutoSize = true;
            this.rbtALT.Location = new System.Drawing.Point(138, 48);
            this.rbtALT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtALT.Name = "rbtALT";
            this.rbtALT.Size = new System.Drawing.Size(82, 29);
            this.rbtALT.TabIndex = 4;
            this.rbtALT.TabStop = true;
            this.rbtALT.Text = "ALT";
            this.rbtALT.UseVisualStyleBackColor = true;
            // 
            // rbtCTRL
            // 
            this.rbtCTRL.AutoSize = true;
            this.rbtCTRL.Location = new System.Drawing.Point(20, 48);
            this.rbtCTRL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtCTRL.Name = "rbtCTRL";
            this.rbtCTRL.Size = new System.Drawing.Size(98, 29);
            this.rbtCTRL.TabIndex = 3;
            this.rbtCTRL.TabStop = true;
            this.rbtCTRL.Text = "CTRL";
            this.rbtCTRL.UseVisualStyleBackColor = true;
            // 
            // cboLetter
            // 
            this.cboLetter.FormattingEnabled = true;
            this.cboLetter.Items.AddRange(new object[] {
            "A",
            "O",
            "P",
            "F4"});
            this.cboLetter.Location = new System.Drawing.Point(235, 40);
            this.cboLetter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboLetter.Name = "cboLetter";
            this.cboLetter.Size = new System.Drawing.Size(140, 33);
            this.cboLetter.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(760, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(644, 93);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отправить строку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(6, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1412, 415);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblActiveWindow);
            this.panel1.Controls.Add(this.btnLock);
            this.panel1.Controls.Add(this.lblActiveWindowHandle);
            this.panel1.Controls.Add(this.txtActiveWindow);
            this.panel1.Controls.Add(this.txtWindowHandle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1424, 60);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.rbtCTRL);
            this.panel2.Controls.Add(this.cboLetter);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.rbtALT);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(6, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1412, 114);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 667);
            this.Controls.Add(this.grpKeys);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpKeys.ResumeLayout(false);
            this.grpKeys.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentlyActiveWindow;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Label lblActiveWindow;
        private System.Windows.Forms.TextBox txtActiveWindow;
        private System.Windows.Forms.TextBox txtWindowHandle;
        private System.Windows.Forms.Label lblActiveWindowHandle;
        private System.Windows.Forms.GroupBox grpKeys;
        private System.Windows.Forms.ComboBox cboLetter;
        private System.Windows.Forms.RadioButton rbtCTRL;
        private System.Windows.Forms.RadioButton rbtALT;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

