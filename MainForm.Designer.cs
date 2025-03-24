namespace War3LuaReplacer
{
    partial class MainForm
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
            this.textBoxW3X = new System.Windows.Forms.TextBox();
            this.textBoxLua = new System.Windows.Forms.TextBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.browseLuaButton = new System.Windows.Forms.Button();
            this.browseW3XButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxW3X
            // 
            this.textBoxW3X.Location = new System.Drawing.Point(102, 215);
            this.textBoxW3X.Name = "textBoxW3X";
            this.textBoxW3X.Size = new System.Drawing.Size(100, 20);
            this.textBoxW3X.TabIndex = 0;
            // 
            // textBoxLua
            // 
            this.textBoxLua.Location = new System.Drawing.Point(555, 215);
            this.textBoxLua.Name = "textBoxLua";
            this.textBoxLua.Size = new System.Drawing.Size(100, 20);
            this.textBoxLua.TabIndex = 1;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(297, 355);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(211, 58);
            this.replaceButton.TabIndex = 2;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // browseLuaButton
            // 
            this.browseLuaButton.Location = new System.Drawing.Point(537, 355);
            this.browseLuaButton.Name = "browseLuaButton";
            this.browseLuaButton.Size = new System.Drawing.Size(211, 58);
            this.browseLuaButton.TabIndex = 3;
            this.browseLuaButton.Text = "Browse LUA";
            this.browseLuaButton.UseVisualStyleBackColor = true;
            this.browseLuaButton.Click += new System.EventHandler(this.browseLuaButton_Click);
            // 
            // browseW3XButton
            // 
            this.browseW3XButton.Location = new System.Drawing.Point(47, 355);
            this.browseW3XButton.Name = "browseW3XButton";
            this.browseW3XButton.Size = new System.Drawing.Size(211, 58);
            this.browseW3XButton.TabIndex = 4;
            this.browseW3XButton.Text = "Browse W3X";
            this.browseW3XButton.UseVisualStyleBackColor = true;
            this.browseW3XButton.Click += new System.EventHandler(this.browseW3XButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browseW3XButton);
            this.Controls.Add(this.browseLuaButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.textBoxLua);
            this.Controls.Add(this.textBoxW3X);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxW3X;
        private System.Windows.Forms.TextBox textBoxLua;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button browseLuaButton;
        private System.Windows.Forms.Button browseW3XButton;
    }
}

