namespace Example_Lego_Mindstorms_Bluetooth
{
    partial class LegoMindstormsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LegoMindstormsForm));
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portListBox = new System.Windows.Forms.ListBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputlistBox = new System.Windows.Forms.ListBox();
            this.btForward = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btnLift = new System.Windows.Forms.Button();
            this.btndrop = new System.Windows.Forms.Button();
            this.btShowMessage = new System.Windows.Forms.Button();
            this.gbxcontrols = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelmode = new System.Windows.Forms.Label();
            this.cbmode = new System.Windows.Forms.ComboBox();
            this.connectionGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.gbxcontrols.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Controls.Add(this.refreshButton);
            this.connectionGroupBox.Controls.Add(this.label1);
            this.connectionGroupBox.Controls.Add(this.portListBox);
            this.connectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Size = new System.Drawing.Size(406, 131);
            this.connectionGroupBox.TabIndex = 4;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(275, 93);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(120, 23);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(275, 64);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(120, 23);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(275, 35);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 23);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Referesh ports";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port for blutooth connection";
            // 
            // portListBox
            // 
            this.portListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.FormattingEnabled = true;
            this.portListBox.Location = new System.Drawing.Point(9, 35);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(260, 82);
            this.portListBox.TabIndex = 5;
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.labelInstructions);
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Controls.Add(this.inputButton);
            this.inputGroupBox.Enabled = false;
            this.inputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGroupBox.Location = new System.Drawing.Point(12, 151);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(200, 143);
            this.inputGroupBox.TabIndex = 5;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(9, 19);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(184, 63);
            this.labelInstructions.TabIndex = 4;
            this.labelInstructions.Text = "Via this form you can send a message to the Brick. The message will be saved and " +
    "can be retrieved via the Output form.";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(9, 81);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(184, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButton.Location = new System.Drawing.Point(9, 111);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(184, 23);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "Send message";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputButton);
            this.outputGroupBox.Controls.Add(this.outputlistBox);
            this.outputGroupBox.Enabled = false;
            this.outputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputGroupBox.Location = new System.Drawing.Point(218, 151);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(200, 143);
            this.outputGroupBox.TabIndex = 6;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputButton
            // 
            this.outputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.Location = new System.Drawing.Point(6, 111);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(187, 23);
            this.outputButton.TabIndex = 0;
            this.outputButton.Text = "Read message";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputlistBox
            // 
            this.outputlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlistBox.FormattingEnabled = true;
            this.outputlistBox.Location = new System.Drawing.Point(7, 19);
            this.outputlistBox.Name = "outputlistBox";
            this.outputlistBox.Size = new System.Drawing.Size(187, 82);
            this.outputlistBox.TabIndex = 4;
            // 
            // btForward
            // 
            this.btForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForward.Location = new System.Drawing.Point(104, 41);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(75, 23);
            this.btForward.TabIndex = 7;
            this.btForward.Text = "Forward\"W\'\"";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            this.btForward.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btForward_KeyDown);
            // 
            // btLeft
            // 
            this.btLeft.BackColor = System.Drawing.SystemColors.Control;
            this.btLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLeft.Location = new System.Drawing.Point(21, 76);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(75, 23);
            this.btLeft.TabIndex = 8;
            this.btLeft.Text = "Left\"A\"";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            this.btLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btLeft_KeyDown);
            // 
            // btRight
            // 
            this.btRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRight.Location = new System.Drawing.Point(197, 73);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(75, 23);
            this.btRight.TabIndex = 9;
            this.btRight.Text = "Right\"D\"";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            this.btRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btRight_KeyDown);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Location = new System.Drawing.Point(104, 99);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 10;
            this.btBack.Text = "Back\"S\"";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            this.btBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btBack_KeyDown);
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.Location = new System.Drawing.Point(197, 197);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 11;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            this.btStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btStop_KeyDown);
            // 
            // btnLift
            // 
            this.btnLift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLift.Location = new System.Drawing.Point(6, 128);
            this.btnLift.Name = "btnLift";
            this.btnLift.Size = new System.Drawing.Size(75, 23);
            this.btnLift.TabIndex = 12;
            this.btnLift.Text = "Lift\"Z\"";
            this.btnLift.UseVisualStyleBackColor = true;
            this.btnLift.Click += new System.EventHandler(this.btGrap_Click);
            // 
            // btndrop
            // 
            this.btndrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndrop.Location = new System.Drawing.Point(212, 122);
            this.btndrop.Name = "btndrop";
            this.btndrop.Size = new System.Drawing.Size(75, 23);
            this.btndrop.TabIndex = 13;
            this.btndrop.Text = "Drop \"C\"";
            this.btndrop.UseVisualStyleBackColor = true;
            this.btndrop.Click += new System.EventHandler(this.btlift_Click);
            // 
            // btShowMessage
            // 
            this.btShowMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowMessage.Location = new System.Drawing.Point(59, 250);
            this.btShowMessage.Name = "btShowMessage";
            this.btShowMessage.Size = new System.Drawing.Size(182, 23);
            this.btShowMessage.TabIndex = 14;
            this.btShowMessage.Text = "Show Message";
            this.btShowMessage.UseVisualStyleBackColor = true;
            this.btShowMessage.Click += new System.EventHandler(this.btShowMessage_Click);
            // 
            // gbxcontrols
            // 
            this.gbxcontrols.Controls.Add(this.btnStart);
            this.gbxcontrols.Controls.Add(this.labelmode);
            this.gbxcontrols.Controls.Add(this.cbmode);
            this.gbxcontrols.Controls.Add(this.btndrop);
            this.gbxcontrols.Controls.Add(this.btShowMessage);
            this.gbxcontrols.Controls.Add(this.btnLift);
            this.gbxcontrols.Controls.Add(this.btForward);
            this.gbxcontrols.Controls.Add(this.btBack);
            this.gbxcontrols.Controls.Add(this.btStop);
            this.gbxcontrols.Controls.Add(this.btRight);
            this.gbxcontrols.Controls.Add(this.btLeft);
            this.gbxcontrols.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxcontrols.Location = new System.Drawing.Point(424, 12);
            this.gbxcontrols.Name = "gbxcontrols";
            this.gbxcontrols.Size = new System.Drawing.Size(297, 282);
            this.gbxcontrols.TabIndex = 16;
            this.gbxcontrols.TabStop = false;
            this.gbxcontrols.Text = "Controls";
            this.gbxcontrols.Enter += new System.EventHandler(this.gbxcontrols_Enter);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(21, 197);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelmode
            // 
            this.labelmode.AutoSize = true;
            this.labelmode.Location = new System.Drawing.Point(118, 16);
            this.labelmode.Name = "labelmode";
            this.labelmode.Size = new System.Drawing.Size(46, 13);
            this.labelmode.TabIndex = 16;
            this.labelmode.Text = "Mode :";
            this.labelmode.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbmode
            // 
            this.cbmode.FormattingEnabled = true;
            this.cbmode.Items.AddRange(new object[] {
            "Automatic",
            "Manual"});
            this.cbmode.Location = new System.Drawing.Point(170, 10);
            this.cbmode.Name = "cbmode";
            this.cbmode.Size = new System.Drawing.Size(121, 21);
            this.cbmode.TabIndex = 15;
            this.cbmode.SelectedIndexChanged += new System.EventHandler(this.cbmode_SelectedIndexChanged);
            // 
            // LegoMindstormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 318);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.gbxcontrols);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LegoMindstormsForm";
            this.Text = "Robot";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.LegoMindstormsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LegoMindstormsForm_KeyDown);
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.gbxcontrols.ResumeLayout(false);
            this.gbxcontrols.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox portListBox;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.ListBox outputlistBox;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btnLift;
        private System.Windows.Forms.Button btndrop;
        private System.Windows.Forms.Button btShowMessage;
        private System.Windows.Forms.GroupBox gbxcontrols;
        private System.Windows.Forms.ComboBox cbmode;
        private System.Windows.Forms.Label labelmode;
        private System.Windows.Forms.Button btnStart;
    }
}

