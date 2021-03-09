
namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.Clear = new System.Windows.Forms.Button();
            this.divison = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.Out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clear
            // 
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.Name = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // divison
            // 
            resources.ApplyResources(this.divison, "divison");
            this.divison.Name = "divison";
            this.divison.UseVisualStyleBackColor = true;
            this.divison.Click += new System.EventHandler(this.one_Click);
            // 
            // multiply
            // 
            resources.ApplyResources(this.multiply, "multiply");
            this.multiply.Name = "multiply";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.one_Click);
            // 
            // minus
            // 
            resources.ApplyResources(this.minus, "minus");
            this.minus.Name = "minus";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.one_Click);
            // 
            // nine
            // 
            resources.ApplyResources(this.nine, "nine");
            this.nine.Name = "nine";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.one_Click);
            // 
            // eight
            // 
            resources.ApplyResources(this.eight, "eight");
            this.eight.Name = "eight";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.one_Click);
            // 
            // seven
            // 
            resources.ApplyResources(this.seven, "seven");
            this.seven.Name = "seven";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.one_Click);
            // 
            // six
            // 
            resources.ApplyResources(this.six, "six");
            this.six.Name = "six";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.one_Click);
            // 
            // Five
            // 
            resources.ApplyResources(this.Five, "Five");
            this.Five.Name = "Five";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.one_Click);
            // 
            // Four
            // 
            resources.ApplyResources(this.Four, "Four");
            this.Four.Name = "Four";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.one_Click);
            // 
            // three
            // 
            resources.ApplyResources(this.three, "three");
            this.three.Name = "three";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            resources.ApplyResources(this.two, "two");
            this.two.Name = "two";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.one_Click);
            // 
            // one
            // 
            resources.ApplyResources(this.one, "one");
            this.one.Name = "one";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // plus
            // 
            resources.ApplyResources(this.plus, "plus");
            this.plus.Name = "plus";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.one_Click);
            // 
            // result
            // 
            resources.ApplyResources(this.result, "result");
            this.result.Name = "result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // zero
            // 
            resources.ApplyResources(this.zero, "zero");
            this.zero.Name = "zero";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.one_Click);
            // 
            // dot
            // 
            resources.ApplyResources(this.dot, "dot");
            this.dot.Name = "dot";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.one_Click);
            // 
            // Out
            // 
            resources.ApplyResources(this.Out, "Out");
            this.Out.Name = "Out";
            this.Out.TextChanged += new System.EventHandler(this.Out_TextChanged);
            // 
            // Calculator
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Out);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.result);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divison);
            this.Controls.Add(this.Clear);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button divison;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Label Out;
        public System.Windows.Forms.Button[] Buttons;
    }
}

