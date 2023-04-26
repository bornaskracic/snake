namespace Snake
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            snake = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // snake
            // 
            snake.Location = new Point(401, 241);
            snake.Margin = new Padding(3, 4, 3, 4);
            snake.Name = "snake";
            snake.Size = new Size(57, 67);
            snake.TabIndex = 0;
            snake.UseVisualStyleBackColor = true;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 500;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(snake);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 567);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button snake;
        private System.Windows.Forms.Timer gameTimer;
        private Panel panel1;
    }
}