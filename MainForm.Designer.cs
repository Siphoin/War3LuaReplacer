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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxW3X
            // 
            this.textBoxW3X.Location = new System.Drawing.Point(33, 49);
            this.textBoxW3X.Name = "textBoxW3X";
            this.textBoxW3X.Size = new System.Drawing.Size(724, 20);
            this.textBoxW3X.TabIndex = 0;
            // 
            // textBoxLua
            // 
            this.textBoxLua.Location = new System.Drawing.Point(33, 107);
            this.textBoxLua.Name = "textBoxLua";
            this.textBoxLua.Size = new System.Drawing.Size(724, 20);
            this.textBoxLua.TabIndex = 1;
            // 
            // replaceButton
            // 
            this.replaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.replaceButton.Location = new System.Drawing.Point(-2, 150);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(841, 93);
            this.replaceButton.TabIndex = 2;
            this.replaceButton.Text = "Заменить файл";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // browseLuaButton
            // 
            this.browseLuaButton.Location = new System.Drawing.Point(763, 49);
            this.browseLuaButton.Name = "browseLuaButton";
            this.browseLuaButton.Size = new System.Drawing.Size(40, 20);
            this.browseLuaButton.TabIndex = 3;
            this.browseLuaButton.Text = "...";
            this.browseLuaButton.UseVisualStyleBackColor = true;
            this.browseLuaButton.Click += new System.EventHandler(this.browseLuaButton_Click);
            // 
            // browseW3XButton
            // 
            this.browseW3XButton.Location = new System.Drawing.Point(763, 107);
            this.browseW3XButton.Name = "browseW3XButton";
            this.browseW3XButton.Size = new System.Drawing.Size(40, 20);
            this.browseW3XButton.TabIndex = 4;
            this.browseW3XButton.Text = "...";
            this.browseW3XButton.UseVisualStyleBackColor = true;
            this.browseW3XButton.Click += new System.EventHandler(this.browseW3XButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Путь до war3map.lua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь до w3x | w3m карты";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseW3XButton);
            this.Controls.Add(this.browseLuaButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.textBoxLua);
            this.Controls.Add(this.textBoxW3X);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "War3 Lua Replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxW3X;
        private System.Windows.Forms.TextBox textBoxLua;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button browseLuaButton;
        private System.Windows.Forms.Button browseW3XButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

