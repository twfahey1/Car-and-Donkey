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
            this.timesToRun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runSimulationBtn = new System.Windows.Forms.Button();
            this.yesEveryTime = new System.Windows.Forms.RadioButton();
            this.noEveryTime = new System.Windows.Forms.RadioButton();
            this.winPerc = new System.Windows.Forms.Label();
            this.lossPerc = new System.Windows.Forms.Label();
            this.switchPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 28);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(90, 153);
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
            this.resultsList.Size = new System.Drawing.Size(218, 147);
            this.resultsList.TabIndex = 6;
            // 
            // activityLog
            // 
            this.activityLog.FormattingEnabled = true;
            this.activityLog.Location = new System.Drawing.Point(227, 8);
            this.activityLog.Name = "activityLog";
            this.activityLog.Size = new System.Drawing.Size(196, 147);
            this.activityLog.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Win";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Losses";
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins.Location = new System.Drawing.Point(27, 219);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(21, 24);
            this.wins.TabIndex = 10;
            this.wins.Text = "0";
            // 
            // losses
            // 
            this.losses.AutoSize = true;
            this.losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losses.Location = new System.Drawing.Point(94, 219);
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
            this.switchPanel.Location = new System.Drawing.Point(146, 187);
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
            this.panel2.Location = new System.Drawing.Point(218, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 165);
            this.panel2.TabIndex = 13;
            // 
            // PickADoor
            // 
            this.PickADoor.AutoSize = true;
            this.PickADoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickADoor.Location = new System.Drawing.Point(247, 1);
            this.PickADoor.Name = "PickADoor";
            this.PickADoor.Size = new System.Drawing.Size(126, 24);
            this.PickADoor.TabIndex = 3;
            this.PickADoor.Text = "Pick A Door:";
            this.PickADoor.Visible = false;
            // 
            // choice3btn
            // 
            this.choice3btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.choice3btn.Location = new System.Drawing.Point(379, 28);
            this.choice3btn.Name = "choice3btn";
            this.choice3btn.Size = new System.Drawing.Size(125, 153);
            this.choice3btn.TabIndex = 5;
            this.choice3btn.UseVisualStyleBackColor = true;
            this.choice3btn.Click += new System.EventHandler(this.choice3btn_Click);
            // 
            // choice2btn
            // 
            this.choice2btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.choice2btn.Location = new System.Drawing.Point(248, 28);
            this.choice2btn.Name = "choice2btn";
            this.choice2btn.Size = new System.Drawing.Size(125, 153);
            this.choice2btn.TabIndex = 4;
            this.choice2btn.UseVisualStyleBackColor = true;
            this.choice2btn.Click += new System.EventHandler(this.choice2btn_Click);
            // 
            // choice1btn
            // 
            this.choice1btn.Location = new System.Drawing.Point(117, 28);
            this.choice1btn.Name = "choice1btn";
            this.choice1btn.Size = new System.Drawing.Size(125, 153);
            this.choice1btn.TabIndex = 3;
            this.choice1btn.UseVisualStyleBackColor = true;
            this.choice1btn.Click += new System.EventHandler(this.choice1btn_Click);
            // 
            // timesToRun
            // 
            this.timesToRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesToRun.Location = new System.Drawing.Point(510, 74);
            this.timesToRun.Name = "timesToRun";
            this.timesToRun.Size = new System.Drawing.Size(199, 31);
            this.timesToRun.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Times To Run";
            // 
            // runSimulationBtn
            // 
            this.runSimulationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runSimulationBtn.Location = new System.Drawing.Point(510, 111);
            this.runSimulationBtn.Name = "runSimulationBtn";
            this.runSimulationBtn.Size = new System.Drawing.Size(199, 70);
            this.runSimulationBtn.TabIndex = 16;
            this.runSimulationBtn.Text = "Run Simulation";
            this.runSimulationBtn.UseVisualStyleBackColor = true;
            this.runSimulationBtn.Click += new System.EventHandler(this.runSimulationBtn_Click);
            // 
            // yesEveryTime
            // 
            this.yesEveryTime.AutoSize = true;
            this.yesEveryTime.Checked = true;
            this.yesEveryTime.Location = new System.Drawing.Point(509, 51);
            this.yesEveryTime.Name = "yesEveryTime";
            this.yesEveryTime.Size = new System.Drawing.Size(99, 17);
            this.yesEveryTime.TabIndex = 17;
            this.yesEveryTime.TabStop = true;
            this.yesEveryTime.Text = "Yes Every Time";
            this.yesEveryTime.UseVisualStyleBackColor = true;
            this.yesEveryTime.CheckedChanged += new System.EventHandler(this.yesEveryTime_CheckedChanged);
            // 
            // noEveryTime
            // 
            this.noEveryTime.AutoSize = true;
            this.noEveryTime.Location = new System.Drawing.Point(614, 51);
            this.noEveryTime.Name = "noEveryTime";
            this.noEveryTime.Size = new System.Drawing.Size(95, 17);
            this.noEveryTime.TabIndex = 18;
            this.noEveryTime.Text = "No Every Time";
            this.noEveryTime.UseVisualStyleBackColor = true;
            this.noEveryTime.CheckedChanged += new System.EventHandler(this.noEveryTime_CheckedChanged);
            // 
            // winPerc
            // 
            this.winPerc.AutoSize = true;
            this.winPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winPerc.Location = new System.Drawing.Point(27, 255);
            this.winPerc.Name = "winPerc";
            this.winPerc.Size = new System.Drawing.Size(21, 24);
            this.winPerc.TabIndex = 19;
            this.winPerc.Text = "0";
            // 
            // lossPerc
            // 
            this.lossPerc.AutoSize = true;
            this.lossPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossPerc.Location = new System.Drawing.Point(94, 255);
            this.lossPerc.Name = "lossPerc";
            this.lossPerc.Size = new System.Drawing.Size(21, 24);
            this.lossPerc.TabIndex = 20;
            this.lossPerc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 295);
            this.Controls.Add(this.lossPerc);
            this.Controls.Add(this.winPerc);
            this.Controls.Add(this.noEveryTime);
            this.Controls.Add(this.yesEveryTime);
            this.Controls.Add(this.runSimulationBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timesToRun);
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
        private System.Windows.Forms.TextBox timesToRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runSimulationBtn;
        private System.Windows.Forms.RadioButton yesEveryTime;
        private System.Windows.Forms.RadioButton noEveryTime;
        private System.Windows.Forms.Label winPerc;
        private System.Windows.Forms.Label lossPerc;
    }
}

