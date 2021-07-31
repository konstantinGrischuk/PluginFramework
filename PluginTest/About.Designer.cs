
namespace PluginTest
{
    partial class About
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exListBox1 = new testexListBox.exListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exListBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загруженные плагины";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // exListBox1
            // 
            this.exListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.exListBox1.FormattingEnabled = true;
            this.exListBox1.ItemHeight = 50;
            this.exListBox1.Location = new System.Drawing.Point(3, 16);
            this.exListBox1.Name = "exListBox1";
            this.exListBox1.Size = new System.Drawing.Size(497, 289);
            this.exListBox1.TabIndex = 1;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "About";
            this.Size = new System.Drawing.Size(503, 308);
            this.Load += new System.EventHandler(this.About_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private testexListBox.exListBox exListBox1;
    }
}
