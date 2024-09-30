namespace Buoi8_Tung
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
            btn_SV = new Button();
            btn_biz = new Button();
            txt_Css = new TextBox();
            txt_Java = new TextBox();
            txt_KT = new TextBox();
            txt_Bhang = new TextBox();
            txt_MKTing = new TextBox();
            SuspendLayout();
            // 
            // btn_SV
            // 
            btn_SV.Location = new Point(186, 172);
            btn_SV.Name = "btn_SV";
            btn_SV.Size = new Size(75, 23);
            btn_SV.TabIndex = 0;
            btn_SV.Text = "Sinhvien IT";
            btn_SV.UseVisualStyleBackColor = true;
            btn_SV.Click += btn_SV_Click;
            // 
            // btn_biz
            // 
            btn_biz.Location = new Point(492, 172);
            btn_biz.Name = "btn_biz";
            btn_biz.Size = new Size(75, 23);
            btn_biz.TabIndex = 0;
            btn_biz.Text = "Sinhvienbiz";
            btn_biz.UseVisualStyleBackColor = true;
            btn_biz.Click += btn_biz_Click;
            // 
            // txt_Css
            // 
            txt_Css.Location = new Point(186, 271);
            txt_Css.Name = "txt_Css";
            txt_Css.Size = new Size(98, 23);
            txt_Css.TabIndex = 1;
            // 
            // txt_Java
            // 
            txt_Java.Location = new Point(186, 225);
            txt_Java.Name = "txt_Java";
            txt_Java.Size = new Size(98, 23);
            txt_Java.TabIndex = 1;
            // 
            // txt_KT
            // 
            txt_KT.Location = new Point(481, 225);
            txt_KT.Name = "txt_KT";
            txt_KT.Size = new Size(98, 23);
            txt_KT.TabIndex = 1;
            // 
            // txt_Bhang
            // 
            txt_Bhang.Location = new Point(481, 324);
            txt_Bhang.Name = "txt_Bhang";
            txt_Bhang.Size = new Size(98, 23);
            txt_Bhang.TabIndex = 1;
            // 
            // txt_MKTing
            // 
            txt_MKTing.Location = new Point(481, 271);
            txt_MKTing.Name = "txt_MKTing";
            txt_MKTing.Size = new Size(98, 23);
            txt_MKTing.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_MKTing);
            Controls.Add(txt_Bhang);
            Controls.Add(txt_KT);
            Controls.Add(txt_Java);
            Controls.Add(txt_Css);
            Controls.Add(btn_biz);
            Controls.Add(btn_SV);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_SV;
        private Button btn_biz;
        private TextBox txt_Css;
        private TextBox txt_Java;
        private TextBox txt_KT;
        private TextBox txt_Bhang;
        private TextBox txt_MKTing;
    }
}
