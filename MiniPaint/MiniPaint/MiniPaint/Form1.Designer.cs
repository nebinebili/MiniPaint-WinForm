namespace MiniPaint
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBox_width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_height = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.radiobtn_fill = new System.Windows.Forms.RadioButton();
            this.radiobtn_outline = new System.Windows.Forms.RadioButton();
            this.btn_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBox_width
            // 
            this.txtBox_width.Location = new System.Drawing.Point(254, 39);
            this.txtBox_width.Name = "txtBox_width";
            this.txtBox_width.Size = new System.Drawing.Size(100, 27);
            this.txtBox_width.TabIndex = 1;
            this.txtBox_width.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // txtBox_height
            // 
            this.txtBox_height.Location = new System.Drawing.Point(461, 38);
            this.txtBox_height.Name = "txtBox_height";
            this.txtBox_height.Size = new System.Drawing.Size(100, 27);
            this.txtBox_height.TabIndex = 4;
            this.txtBox_height.Text = "100";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(602, 46);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(49, 20);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Color";
            // 
            // radiobtn_fill
            // 
            this.radiobtn_fill.AutoSize = true;
            this.radiobtn_fill.Location = new System.Drawing.Point(836, 12);
            this.radiobtn_fill.Name = "radiobtn_fill";
            this.radiobtn_fill.Size = new System.Drawing.Size(49, 24);
            this.radiobtn_fill.TabIndex = 7;
            this.radiobtn_fill.TabStop = true;
            this.radiobtn_fill.Text = "Fill";
            this.radiobtn_fill.UseVisualStyleBackColor = true;
            // 
            // radiobtn_outline
            // 
            this.radiobtn_outline.AutoSize = true;
            this.radiobtn_outline.Location = new System.Drawing.Point(836, 46);
            this.radiobtn_outline.Name = "radiobtn_outline";
            this.radiobtn_outline.Size = new System.Drawing.Size(80, 24);
            this.radiobtn_outline.TabIndex = 8;
            this.radiobtn_outline.TabStop = true;
            this.radiobtn_outline.Text = "Outline";
            this.radiobtn_outline.UseVisualStyleBackColor = true;
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(668, 37);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(75, 30);
            this.btn_color.TabIndex = 9;
            this.btn_color.Text = "Select";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 692);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.radiobtn_outline);
            this.Controls.Add(this.radiobtn_fill);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.txtBox_height);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_width);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtBox_width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_height;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.RadioButton radiobtn_fill;
        private System.Windows.Forms.RadioButton radiobtn_outline;
        private System.Windows.Forms.Button btn_color;
        public System.Windows.Forms.ColorDialog colorDialog1;
    }
}

