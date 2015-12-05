namespace Car_and_Donkey
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
            this.startButton = new System.Windows.Forms.Button();
            this.resultsList = new System.Windows.Forms.ListBox();
            this.activityLog = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.losses = new System.Windows.Forms.Label();
            this.switchPanel = new System.Windows.Forms.Panel();
            this.labelswitch = new System.Windows.Forms.Label();
            this.choiceNo = new System.Windows.Forms.Button();
            this.choiceYes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PickADoor = new System.Windows.Forms.Label();
            this.choice3btn = new System.Windows.Forms.Button();
            this.choice2btn = new System.Windows.Forms.Button();
            this.choice1btn = new System.Windows.Forms.Button();
            this.switchPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 58);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(117, 108);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resultsList
            // 
            this.resultsList.FormattingEnabled = true;
            this.resultsList.Location = new System.Drawing.Point(3, 8);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(218, 43);
            this.resultsList.TabIndex = 6;
            // 
            // activityLog
            // 
            this.activityLog.FormattingEnabled = true;
            this.activityLog.Location = new System.Drawing.Point(227, 8);
            this.activityLog.Name = "activityLog";
            this.activityLog.Size = new System.Drawing.Size(181, 43);
            this.activityLog.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Win";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Losses";
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins.Location = new System.Drawing.Point(96, 238);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(21, 24);
            this.wins.TabIndex = 10;
            this.wins.Text = "0";
            // 
            // losses
            // 
            this.losses.AutoSize = true;
            this.losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losses.Location = new System.Drawing.Point(173, 238);
            this.losses.Name = "losses";
            this.losses.Size = new System.Drawing.Size(21, 24);
            this.losses.TabIndex = 11;
            this.losses.Text = "0";
            // 
            // switchPanel
            // 
            this.switchPanel.Controls.Add(this.labelswitch);
            this.switchPanel.Controls.Add(this.choiceNo);
            this.switchPanel.Controls.Add(this.choiceYes);
            this.switchPanel.Location = new System.Drawing.Point(265, 195);
            this.switchPanel.Name = "switchPanel";
            this.switchPanel.Size = new System.Drawing.Size(247, 100);
            this.switchPanel.TabIndex = 12;
            this.switchPanel.Visible = false;
            // 
            // labelswitch
            // 
            this.labelswitch.AutoSize = true;
            this.labelswitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelswitch.Location = new System.Drawing.Point(13, 10);
            this.labelswitch.Name = "labelswitch";
            this.labelswitch.Size = new System.Drawing.Size(223, 24);
            this.labelswitch.TabIndex = 2;
            this.labelswitch.Text = "Do you want to switch?";
            // 
            // choiceNo
            // 
            this.choiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceNo.Location = new System.Drawing.Point(140, 46);
            this.choiceNo.Name = "choiceNo";
            this.choiceNo.Size = new System.Drawing.Size(89, 46);
            this.choiceNo.TabIndex = 1;
            this.choiceNo.Text = "No";
            this.choiceNo.UseVisualStyleBackColor = true;
            this.choiceNo.Click += new System.EventHandler(this.choiceNo_Click);
            // 
            // choiceYes
            // 
            this.choiceYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceYes.Location = new System.Drawing.Point(17, 46);
            this.choiceYes.Name = "choiceYes";
            this.choiceYes.Size = new System.Drawing.Size(90, 46);
            this.choiceYes.TabIndex = 0;
            this.choiceYes.Text = "Yes";
            this.choiceYes.UseVisualStyleBackColor = true;
            this.choiceYes.Click += new System.EventHandler(this.choiceYes_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultsList);
            this.panel2.Controls.Add(this.activityLog);
            this.panel2.Location = new System.Drawing.Point(201, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 61);
            this.panel2.TabIndex = 13;
            // 
            // PickADoor
            // 
            this.PickADoor.AutoSize = true;
            this.PickADoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickADoor.Location = new System.Drawing.Point(304, 5);
            this.PickADoor.Name = "PickADoor";
            this.PickADoor.Size = new System.Drawing.Size(126, 24);
            this.PickADoor.TabIndex = 3;
            this.PickADoor.Text = "Pick A Door:";
            this.PickADoor.Visible = false;
            // 
            // choice3btn
            // 
            this.choice3btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.choice3btn.Location = new System.Drawing.Point(458, 36);
            this.choice3btn.Name = "choice3btn";
            this.choice3btn.Size = new System.Drawing.Size(125, 153);
            this.choice3btn.TabIndex = 5;
            this.choice3btn.UseVisualStyleBackColor = true;
            this.choice3btn.Click += new System.EventHandler(this.choice3btn_Click);
            // 
            // choice2btn
            // 
            this.choice2btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.choice2btn.Location = new System.Drawing.Point(305, 39);
            this.choice2btn.Name = "choice2btn";
            this.choice2btn.Size = new System.Drawing.Size(125, 153);
            this.choice2btn.TabIndex = 4;
            this.choice2btn.UseVisualStyleBackColor = true;
            this.choice2btn.Click += new System.EventHandler(this.choice2btn_Click);
            // 
            // choice1btn
            // 
            this.choice1btn.Location = new System.Drawing.Point(151, 36);
            this.choice1btn.Name = "choice1btn";
            this.choice1btn.Size = new System.Drawing.Size(125, 153);
            this.choice1btn.TabIndex = 3;
            this.choice1btn.UseVisualStyleBackColor = true;
            this.choice1btn.Click += new System.EventHandler(this.choice1btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 299);
            this.Controls.Add(this.PickADoor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.switchPanel);
            this.Controls.Add(this.losses);
            this.Controls.Add(this.wins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choice3btn);
            this.Controls.Add(this.choice2btn);
            this.Controls.Add(this.choice1btn);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Car And Donkey Game";
            this.switchPanel.ResumeLayout(false);
            this.switchPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button choice1btn;
        private System.Windows.Forms.Button choice2btn;
        private System.Windows.Forms.Button choice3btn;
        private System.Windows.Forms.ListBox resultsList;
        private System.Windows.Forms.ListBox activityLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wins;
        private System.Windows.Forms.Label losses;
        private System.Windows.Forms.Panel switchPanel;
        private System.Windows.Forms.Label labelswitch;
        private System.Windows.Forms.Button choiceNo;
        private System.Windows.Forms.Button choiceYes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PickADoor;
    }
}

