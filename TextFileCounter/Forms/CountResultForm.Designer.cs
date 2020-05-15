using System.Collections.Generic;
using System.Linq;

namespace TextFileCounter
{
    partial class CountResultForm
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
            this.mainText = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.Label();
            this.text5 = new System.Windows.Forms.Label();
            this.text6 = new System.Windows.Forms.Label();
            this.result6 = new System.Windows.Forms.Label();
            this.result5 = new System.Windows.Forms.Label();
            this.result4 = new System.Windows.Forms.Label();
            this.result3 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.buttonOkResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.Location = new System.Drawing.Point(46, 41);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(586, 29);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "Please find a result for counting words and or phrases";
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(51, 117);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(73, 29);
            this.text1.TabIndex = 1;
            this.text1.Text = "Text1";
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(51, 168);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(73, 29);
            this.text2.TabIndex = 2;
            this.text2.Text = "Text2";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(51, 220);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(73, 29);
            this.text3.TabIndex = 3;
            this.text3.Text = "Text3";
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text4.Location = new System.Drawing.Point(51, 272);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(73, 29);
            this.text4.TabIndex = 4;
            this.text4.Text = "Text4";
            // 
            // text5
            // 
            this.text5.AutoSize = true;
            this.text5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text5.Location = new System.Drawing.Point(51, 326);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(73, 29);
            this.text5.TabIndex = 5;
            this.text5.Text = "Text5";
            // 
            // text6
            // 
            this.text6.AutoSize = true;
            this.text6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text6.Location = new System.Drawing.Point(51, 380);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(73, 29);
            this.text6.TabIndex = 6;
            this.text6.Text = "Text6";
            // 
            // result6
            // 
            this.result6.AutoSize = true;
            this.result6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result6.Location = new System.Drawing.Point(414, 380);
            this.result6.Name = "result6";
            this.result6.Size = new System.Drawing.Size(94, 29);
            this.result6.TabIndex = 12;
            this.result6.Text = "Result6";
            // 
            // result5
            // 
            this.result5.AutoSize = true;
            this.result5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result5.Location = new System.Drawing.Point(414, 326);
            this.result5.Name = "result5";
            this.result5.Size = new System.Drawing.Size(94, 29);
            this.result5.TabIndex = 11;
            this.result5.Text = "Result5";
            // 
            // result4
            // 
            this.result4.AutoSize = true;
            this.result4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result4.Location = new System.Drawing.Point(414, 272);
            this.result4.Name = "result4";
            this.result4.Size = new System.Drawing.Size(94, 29);
            this.result4.TabIndex = 10;
            this.result4.Text = "Result4";
            // 
            // result3
            // 
            this.result3.AutoSize = true;
            this.result3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result3.Location = new System.Drawing.Point(414, 220);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(94, 29);
            this.result3.TabIndex = 9;
            this.result3.Text = "Result3";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result2.Location = new System.Drawing.Point(414, 168);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(94, 29);
            this.result2.TabIndex = 8;
            this.result2.Text = "Result2";
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result1.Location = new System.Drawing.Point(414, 117);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(94, 29);
            this.result1.TabIndex = 7;
            this.result1.Text = "Result1";
            // 
            // buttonOkResult
            // 
            this.buttonOkResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOkResult.Location = new System.Drawing.Point(568, 425);
            this.buttonOkResult.Name = "buttonOkResult";
            this.buttonOkResult.Size = new System.Drawing.Size(77, 53);
            this.buttonOkResult.TabIndex = 13;
            this.buttonOkResult.Text = "OK";
            this.buttonOkResult.UseVisualStyleBackColor = true;
            this.buttonOkResult.Click += new System.EventHandler(this.buttonOkResult_Click);
            // 
            // CountResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 502);
            this.Controls.Add(this.buttonOkResult);
            this.Controls.Add(this.result6);
            this.Controls.Add(this.result5);
            this.Controls.Add(this.result4);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.text6);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.mainText);
            this.Name = "CountResultForm";
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Label text5;
        private System.Windows.Forms.Label text6;
        private System.Windows.Forms.Label result6;
        private System.Windows.Forms.Label result5;
        private System.Windows.Forms.Label result4;
        private System.Windows.Forms.Label result3;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Button buttonOkResult;
    }
}