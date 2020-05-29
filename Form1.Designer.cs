namespace CircusTrein
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
            this.addAnimalbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carnivoreRbtn = new System.Windows.Forms.RadioButton();
            this.herbivoreRbtn = new System.Windows.Forms.RadioButton();
            this.bigRbtn = new System.Windows.Forms.RadioButton();
            this.smallRbtn = new System.Windows.Forms.RadioButton();
            this.mediumRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Orginisebtn = new System.Windows.Forms.Button();
            this.Animallist = new System.Windows.Forms.ListBox();
            this.Wagonlist = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAnimalbtn
            // 
            this.addAnimalbtn.Location = new System.Drawing.Point(12, 163);
            this.addAnimalbtn.Name = "addAnimalbtn";
            this.addAnimalbtn.Size = new System.Drawing.Size(120, 32);
            this.addAnimalbtn.TabIndex = 2;
            this.addAnimalbtn.Text = "Add Animal";
            this.addAnimalbtn.UseVisualStyleBackColor = true;
            this.addAnimalbtn.Click += new System.EventHandler(this.AddAnimalbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Animal Collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wagons on train";
            // 
            // carnivoreRbtn
            // 
            this.carnivoreRbtn.AutoSize = true;
            this.carnivoreRbtn.Location = new System.Drawing.Point(0, 2);
            this.carnivoreRbtn.Name = "carnivoreRbtn";
            this.carnivoreRbtn.Size = new System.Drawing.Size(90, 21);
            this.carnivoreRbtn.TabIndex = 7;
            this.carnivoreRbtn.TabStop = true;
            this.carnivoreRbtn.Text = "Carnivore";
            this.carnivoreRbtn.UseVisualStyleBackColor = true;
            // 
            // herbivoreRbtn
            // 
            this.herbivoreRbtn.AutoSize = true;
            this.herbivoreRbtn.Location = new System.Drawing.Point(0, 27);
            this.herbivoreRbtn.Name = "herbivoreRbtn";
            this.herbivoreRbtn.Size = new System.Drawing.Size(91, 21);
            this.herbivoreRbtn.TabIndex = 8;
            this.herbivoreRbtn.TabStop = true;
            this.herbivoreRbtn.Text = "Herbivore";
            this.herbivoreRbtn.UseVisualStyleBackColor = true;
            // 
            // bigRbtn
            // 
            this.bigRbtn.AutoSize = true;
            this.bigRbtn.Location = new System.Drawing.Point(0, 54);
            this.bigRbtn.Name = "bigRbtn";
            this.bigRbtn.Size = new System.Drawing.Size(49, 21);
            this.bigRbtn.TabIndex = 9;
            this.bigRbtn.TabStop = true;
            this.bigRbtn.Text = "Big";
            this.bigRbtn.UseVisualStyleBackColor = true;
            // 
            // smallRbtn
            // 
            this.smallRbtn.AutoSize = true;
            this.smallRbtn.Location = new System.Drawing.Point(0, 0);
            this.smallRbtn.Name = "smallRbtn";
            this.smallRbtn.Size = new System.Drawing.Size(63, 21);
            this.smallRbtn.TabIndex = 9;
            this.smallRbtn.TabStop = true;
            this.smallRbtn.Text = "Small";
            this.smallRbtn.UseVisualStyleBackColor = true;
            // 
            // mediumRbtn
            // 
            this.mediumRbtn.AutoSize = true;
            this.mediumRbtn.Location = new System.Drawing.Point(0, 27);
            this.mediumRbtn.Name = "mediumRbtn";
            this.mediumRbtn.Size = new System.Drawing.Size(78, 21);
            this.mediumRbtn.TabIndex = 10;
            this.mediumRbtn.TabStop = true;
            this.mediumRbtn.Text = "Medium";
            this.mediumRbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carnivoreRbtn);
            this.groupBox1.Controls.Add(this.herbivoreRbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 54);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.smallRbtn);
            this.groupBox2.Controls.Add(this.mediumRbtn);
            this.groupBox2.Controls.Add(this.bigRbtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 85);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // Orginisebtn
            // 
            this.Orginisebtn.Location = new System.Drawing.Point(13, 212);
            this.Orginisebtn.Name = "Orginisebtn";
            this.Orginisebtn.Size = new System.Drawing.Size(119, 33);
            this.Orginisebtn.TabIndex = 13;
            this.Orginisebtn.Text = "Get wagons";
            this.Orginisebtn.UseVisualStyleBackColor = true;
            this.Orginisebtn.Click += new System.EventHandler(this.Orginisebtn_Click);
            // 
            // Animallist
            // 
            this.Animallist.FormattingEnabled = true;
            this.Animallist.ItemHeight = 16;
            this.Animallist.Location = new System.Drawing.Point(268, 39);
            this.Animallist.Name = "Animallist";
            this.Animallist.Size = new System.Drawing.Size(120, 404);
            this.Animallist.TabIndex = 14;
            this.Animallist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Animallist_MouseDoubleClick);
            // 
            // Wagonlist
            // 
            this.Wagonlist.FormattingEnabled = true;
            this.Wagonlist.ItemHeight = 16;
            this.Wagonlist.Location = new System.Drawing.Point(395, 39);
            this.Wagonlist.Name = "Wagonlist";
            this.Wagonlist.Size = new System.Drawing.Size(120, 404);
            this.Wagonlist.TabIndex = 15;
            this.Wagonlist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Wagonlist_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.Wagonlist);
            this.Controls.Add(this.Animallist);
            this.Controls.Add(this.Orginisebtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAnimalbtn);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addAnimalbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton carnivoreRbtn;
        private System.Windows.Forms.RadioButton herbivoreRbtn;
        private System.Windows.Forms.RadioButton bigRbtn;
        private System.Windows.Forms.RadioButton smallRbtn;
        private System.Windows.Forms.RadioButton mediumRbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Orginisebtn;
        private System.Windows.Forms.ListBox Animallist;
        private System.Windows.Forms.ListBox Wagonlist;
    }
}

