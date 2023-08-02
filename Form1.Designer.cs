namespace MapData
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
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            Coordinates = new Button();
            Output = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            OutputBox = new RichTextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Load = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Coordinates);
            panel1.Controls.Add(Output);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(OutputBox);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(30, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 270);
            panel1.TabIndex = 0;
            // 
            // Coordinates
            // 
            Coordinates.Location = new Point(15, 109);
            Coordinates.Name = "Coordinates";
            Coordinates.Size = new Size(117, 60);
            Coordinates.TabIndex = 4;
            Coordinates.Text = "Add Coordinates";
            Coordinates.UseVisualStyleBackColor = true;
            Coordinates.Click += Coordinates_Click;
            // 
            // Output
            // 
            Output.Location = new Point(15, 186);
            Output.Name = "Output";
            Output.Size = new Size(117, 53);
            Output.TabIndex = 5;
            Output.Text = "Output CSV";
            Output.UseVisualStyleBackColor = true;
            Output.Click += Output_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 42);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 6;
            label3.Text = "Longitude";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 43);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Latitude";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 43);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 4;
            label1.Text = "Site";
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(138, 109);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(156, 130);
            OutputBox.TabIndex = 6;
            OutputBox.Text = "";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(32, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(71, 23);
            textBox1.TabIndex = 2;
            // 
            // Load
            // 
            Load.Location = new Point(62, 340);
            Load.Name = "Load";
            Load.Size = new Size(262, 41);
            Load.TabIndex = 0;
            Load.Text = "Load data";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 414);
            Controls.Add(Load);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "MapData";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private RichTextBox OutputBox;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Button Output;
        private Button Load;
        private Button Coordinates;
    }
}