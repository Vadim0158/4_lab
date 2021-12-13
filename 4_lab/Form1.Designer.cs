
namespace _4_lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefill = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.ochered = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(12, 12);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(247, 23);
            this.btnRefill.TabIndex = 0;
            this.btnRefill.Text = "Перезаполнить";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(202, 106);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(57, 96);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(12, 41);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(247, 49);
            this.txtInfo.TabIndex = 2;
            this.txtInfo.Text = "";
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(12, 106);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(184, 96);
            this.txtOut.TabIndex = 3;
            this.txtOut.Text = "";
            // 
            // ochered
            // 
            this.ochered.Location = new System.Drawing.Point(265, 12);
            this.ochered.Name = "ochered";
            this.ochered.Size = new System.Drawing.Size(126, 190);
            this.ochered.TabIndex = 4;
            this.ochered.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 221);
            this.Controls.Add(this.ochered);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnRefill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.RichTextBox ochered;
    }
}

