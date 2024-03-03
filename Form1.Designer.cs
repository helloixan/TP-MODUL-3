namespace Project1
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
            input_user = new TextBox();
            submit_button = new Button();
            output = new Label();
            SuspendLayout();
            // 
            // input_user
            // 
            input_user.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input_user.Location = new Point(239, 181);
            input_user.Name = "input_user";
            input_user.Size = new Size(241, 27);
            input_user.TabIndex = 0;
            input_user.Text = "Masukkan Nama Praktikan";
            input_user.TextChanged += input_user_TextChanged;
            // 
            // submit_button
            // 
            submit_button.BackColor = SystemColors.Highlight;
            submit_button.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submit_button.ForeColor = SystemColors.ControlLight;
            submit_button.Location = new Point(506, 177);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(93, 32);
            submit_button.TabIndex = 1;
            submit_button.Text = "Submit";
            submit_button.UseVisualStyleBackColor = false;
            submit_button.Click += submit_button_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.BackColor = SystemColors.Control;
            output.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            output.Location = new Point(358, 246);
            output.Name = "output";
            output.Size = new Size(59, 19);
            output.TabIndex = 2;
            output.Text = "Output";
            output.TextAlign = ContentAlignment.MiddleCenter;
            output.Click += output_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(output);
            Controls.Add(submit_button);
            Controls.Add(input_user);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input_user;
        private Button submit_button;
        private Label output;
    }
}
