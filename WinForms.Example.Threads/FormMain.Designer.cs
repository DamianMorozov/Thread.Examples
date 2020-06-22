namespace WinForms.Example.Threads
{
    partial class FormMain
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
            this.buttonTaskRun = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.comboBoxProgressBarStyle = new System.Windows.Forms.ComboBox();
            this.labelStyle = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.buttonStartProgress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTaskRun
            // 
            this.buttonTaskRun.Location = new System.Drawing.Point(20, 40);
            this.buttonTaskRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTaskRun.Name = "buttonTaskRun";
            this.buttonTaskRun.Size = new System.Drawing.Size(100, 24);
            this.buttonTaskRun.TabIndex = 0;
            this.buttonTaskRun.Text = "Task.Run()";
            this.buttonTaskRun.UseVisualStyleBackColor = true;
            this.buttonTaskRun.Click += new System.EventHandler(this.buttonTaskRun_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(135, 40);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 24);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 2;
            this.progressBar.Value = 10;
            // 
            // comboBoxProgressBarStyle
            // 
            this.comboBoxProgressBarStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgressBarStyle.FormattingEnabled = true;
            this.comboBoxProgressBarStyle.Items.AddRange(new object[] {
            "normal",
            "error",
            "warning"});
            this.comboBoxProgressBarStyle.Location = new System.Drawing.Point(350, 40);
            this.comboBoxProgressBarStyle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxProgressBarStyle.Name = "comboBoxProgressBarStyle";
            this.comboBoxProgressBarStyle.Size = new System.Drawing.Size(91, 21);
            this.comboBoxProgressBarStyle.TabIndex = 3;
            this.comboBoxProgressBarStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxProgressBarStyle_SelectedIndexChanged);
            // 
            // labelStyle
            // 
            this.labelStyle.Location = new System.Drawing.Point(350, 20);
            this.labelStyle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(90, 19);
            this.labelStyle.TabIndex = 4;
            this.labelStyle.Text = "Style";
            this.labelStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValue
            // 
            this.labelValue.Location = new System.Drawing.Point(135, 20);
            this.labelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(200, 19);
            this.labelValue.TabIndex = 5;
            this.labelValue.Text = "Value";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStartProgress
            // 
            this.buttonStartProgress.Location = new System.Drawing.Point(20, 80);
            this.buttonStartProgress.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartProgress.Name = "buttonStartProgress";
            this.buttonStartProgress.Size = new System.Drawing.Size(100, 24);
            this.buttonStartProgress.TabIndex = 6;
            this.buttonStartProgress.Text = "Start progress";
            this.buttonStartProgress.UseVisualStyleBackColor = true;
            this.buttonStartProgress.Click += new System.EventHandler(this.buttonStartProgress_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 353);
            this.Controls.Add(this.buttonStartProgress);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelStyle);
            this.Controls.Add(this.comboBoxProgressBarStyle);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonTaskRun);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Examples of System.Threads";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTaskRun;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox comboBoxProgressBarStyle;
        private System.Windows.Forms.Label labelStyle;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button buttonStartProgress;
    }
}

