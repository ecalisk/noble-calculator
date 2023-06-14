
namespace project1
{
    partial class calcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calcForm));
            this.val2Box = new System.Windows.Forms.TextBox();
            this.operatorDisplay = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.lcm = new System.Windows.Forms.Button();
            this.modulus = new System.Windows.Forms.Button();
            this.gcd = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.val1Box = new System.Windows.Forms.TextBox();
            this.authors = new System.Windows.Forms.Label();
            this.swapper = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // val2Box
            // 
            this.val2Box.BackColor = System.Drawing.Color.DarkCyan;
            this.val2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val2Box.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.val2Box.Location = new System.Drawing.Point(261, 58);
            this.val2Box.Name = "val2Box";
            this.val2Box.Size = new System.Drawing.Size(133, 31);
            this.val2Box.TabIndex = 1;
            this.val2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // operatorDisplay
            // 
            this.operatorDisplay.AutoSize = true;
            this.operatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorDisplay.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.operatorDisplay.Location = new System.Drawing.Point(207, 62);
            this.operatorDisplay.Name = "operatorDisplay";
            this.operatorDisplay.Size = new System.Drawing.Size(0, 25);
            this.operatorDisplay.TabIndex = 2;
            this.operatorDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.operatorDisplay.Click += new System.EventHandler(this.operDispClick);
            // 
            // plus
            // 
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.plus.Location = new System.Drawing.Point(72, 100);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(94, 43);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.operatorClick);
            // 
            // multiply
            // 
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.multiply.Location = new System.Drawing.Point(272, 100);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(94, 43);
            this.multiply.TabIndex = 4;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operatorClick);
            // 
            // minus
            // 
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.minus.Location = new System.Drawing.Point(172, 100);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(94, 43);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operatorClick);
            // 
            // factorial
            // 
            this.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.factorial.Location = new System.Drawing.Point(172, 149);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(94, 43);
            this.factorial.TabIndex = 10;
            this.factorial.Text = "!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.operatorClick);
            // 
            // power
            // 
            this.power.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.power.Location = new System.Drawing.Point(272, 149);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(94, 43);
            this.power.TabIndex = 9;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.operatorClick);
            // 
            // divide
            // 
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.divide.Location = new System.Drawing.Point(72, 149);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(94, 43);
            this.divide.TabIndex = 8;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operatorClick);
            // 
            // log
            // 
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.log.Location = new System.Drawing.Point(172, 198);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(94, 43);
            this.log.TabIndex = 13;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.operatorClick);
            // 
            // lcm
            // 
            this.lcm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcm.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lcm.Location = new System.Drawing.Point(272, 198);
            this.lcm.Name = "lcm";
            this.lcm.Size = new System.Drawing.Size(94, 43);
            this.lcm.TabIndex = 12;
            this.lcm.Text = "lcm";
            this.lcm.UseVisualStyleBackColor = true;
            this.lcm.Click += new System.EventHandler(this.operatorClick);
            // 
            // modulus
            // 
            this.modulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulus.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.modulus.Location = new System.Drawing.Point(72, 198);
            this.modulus.Name = "modulus";
            this.modulus.Size = new System.Drawing.Size(94, 43);
            this.modulus.TabIndex = 11;
            this.modulus.Text = "%";
            this.modulus.UseVisualStyleBackColor = true;
            this.modulus.Click += new System.EventHandler(this.operatorClick);
            // 
            // gcd
            // 
            this.gcd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gcd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcd.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gcd.Location = new System.Drawing.Point(72, 247);
            this.gcd.Name = "gcd";
            this.gcd.Size = new System.Drawing.Size(94, 43);
            this.gcd.TabIndex = 14;
            this.gcd.Text = "gcd";
            this.gcd.UseVisualStyleBackColor = true;
            this.gcd.Click += new System.EventHandler(this.operatorClick);
            // 
            // calc
            // 
            this.calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.calc.Location = new System.Drawing.Point(172, 247);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(194, 43);
            this.calc.TabIndex = 15;
            this.calc.Text = "calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calcClick);
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button14.Location = new System.Drawing.Point(261, 16);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(133, 30);
            this.button14.TabIndex = 17;
            this.button14.Text = "CLEAR";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.clearClick);
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button15.Location = new System.Drawing.Point(44, 16);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(133, 30);
            this.button15.TabIndex = 18;
            this.button15.Text = "EXIT";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.exitClick);
            // 
            // val1Box
            // 
            this.val1Box.BackColor = System.Drawing.Color.DarkCyan;
            this.val1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val1Box.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.val1Box.Location = new System.Drawing.Point(44, 58);
            this.val1Box.Name = "val1Box";
            this.val1Box.Size = new System.Drawing.Size(133, 31);
            this.val1Box.TabIndex = 19;
            this.val1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // authors
            // 
            this.authors.AutoSize = true;
            this.authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authors.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.authors.Location = new System.Drawing.Point(20, 459);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(379, 20);
            this.authors.TabIndex = 20;
            this.authors.Text = "DEVELOPED BY: NOBLE RUBBER DUCKIES";
            this.authors.Click += new System.EventHandler(this.authorClick);
            // 
            // swapper
            // 
            this.swapper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swapper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swapper.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.swapper.Location = new System.Drawing.Point(191, 16);
            this.swapper.Name = "swapper";
            this.swapper.Size = new System.Drawing.Size(55, 30);
            this.swapper.TabIndex = 21;
            this.swapper.Text = "swap <->";
            this.swapper.UseVisualStyleBackColor = true;
            this.swapper.Click += new System.EventHandler(this.swapClick);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.result.Location = new System.Drawing.Point(85, 349);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(72, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 134);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textOutput
            // 
            this.textOutput.AutoSize = true;
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textOutput.Location = new System.Drawing.Point(84, 318);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(84, 20);
            this.textOutput.TabIndex = 24;
            this.textOutput.Text = "OUTPUT:";
            this.textOutput.Click += new System.EventHandler(this.clickTextOutput);
            // 
            // calcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(437, 486);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.swapper);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.val1Box);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.gcd);
            this.Controls.Add(this.log);
            this.Controls.Add(this.lcm);
            this.Controls.Add(this.modulus);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.power);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.operatorDisplay);
            this.Controls.Add(this.val2Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "calcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noble Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox val2Box;
        private System.Windows.Forms.Label operatorDisplay;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button lcm;
        private System.Windows.Forms.Button modulus;
        private System.Windows.Forms.Button gcd;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox val1Box;
        private System.Windows.Forms.Label authors;
        private System.Windows.Forms.Button swapper;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textOutput;
    }
}

