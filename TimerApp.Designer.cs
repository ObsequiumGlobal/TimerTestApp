
namespace TimerTestApp
{
    partial class TimerApp
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Timer = new System.Windows.Forms.Button();
            this.txt_Timer = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_Timer
            // 
            this.btn_Timer.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Timer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Timer.Location = new System.Drawing.Point(314, 643);
            this.btn_Timer.Name = "btn_Timer";
            this.btn_Timer.Size = new System.Drawing.Size(117, 52);
            this.btn_Timer.TabIndex = 0;
            this.btn_Timer.Text = "Timer";
            this.btn_Timer.UseVisualStyleBackColor = false;
            this.btn_Timer.Click += new System.EventHandler(this.btn_Timer_Click);
            // 
            // txt_Timer
            // 
            this.txt_Timer.Location = new System.Drawing.Point(12, 12);
            this.txt_Timer.Name = "txt_Timer";
            this.txt_Timer.Size = new System.Drawing.Size(420, 625);
            this.txt_Timer.TabIndex = 1;
            this.txt_Timer.Text = "";
            // 
            // TimerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 707);
            this.Controls.Add(this.txt_Timer);
            this.Controls.Add(this.btn_Timer);
            this.Name = "TimerApp";
            this.Text = "Timer - Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Timer;
        private System.Windows.Forms.RichTextBox txt_Timer;
        private System.Windows.Forms.Timer timer1;
    }
}

