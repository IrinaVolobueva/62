namespace PR_6._2
{
    partial class Greenhouse
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
            this.Lamp = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Temperature = new System.Windows.Forms.Button();
            this.Leica = new System.Windows.Forms.Button();
            this.Flowers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lamp
            // 
            this.Lamp.BackgroundImage = global::PR_6._2.Properties.Resources.лампа;
            this.Lamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Lamp.Location = new System.Drawing.Point(265, 1);
            this.Lamp.Name = "Lamp";
            this.Lamp.Size = new System.Drawing.Size(118, 123);
            this.Lamp.TabIndex = 0;
            this.Lamp.UseVisualStyleBackColor = true;
            this.Lamp.Click += new System.EventHandler(this.Lamp_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::PR_6._2.Properties.Resources.выход;
            this.Exit.Location = new System.Drawing.Point(220, 381);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(82, 43);
            this.Exit.TabIndex = 1;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Temperature
            // 
            this.Temperature.BackgroundImage = global::PR_6._2.Properties.Resources.тепм;
            this.Temperature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Temperature.Location = new System.Drawing.Point(782, 249);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(31, 77);
            this.Temperature.TabIndex = 2;
            this.Temperature.UseVisualStyleBackColor = true;
            this.Temperature.Click += new System.EventHandler(this.Temperature_Click);
            // 
            // Leica
            // 
            this.Leica.BackgroundImage = global::PR_6._2.Properties.Resources.лейка;
            this.Leica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Leica.Location = new System.Drawing.Point(540, 460);
            this.Leica.Name = "Leica";
            this.Leica.Size = new System.Drawing.Size(145, 117);
            this.Leica.TabIndex = 3;
            this.Leica.UseVisualStyleBackColor = true;
            this.Leica.Click += new System.EventHandler(this.Leica_Click);
            // 
            // Flowers
            // 
            this.Flowers.BackColor = System.Drawing.Color.SteelBlue;
            this.Flowers.Location = new System.Drawing.Point(33, 288);
            this.Flowers.Name = "Flowers";
            this.Flowers.Size = new System.Drawing.Size(50, 16);
            this.Flowers.TabIndex = 4;
            this.Flowers.UseVisualStyleBackColor = false;
            this.Flowers.Click += new System.EventHandler(this.Flowers_Click);
            // 
            // Greenhouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PR_6._2.Properties.Resources.сад3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 589);
            this.Controls.Add(this.Flowers);
            this.Controls.Add(this.Leica);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Lamp);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Greenhouse";
            this.Text = "Теплица";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lamp;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Temperature;
        private System.Windows.Forms.Button Leica;
        private System.Windows.Forms.Button Flowers;
    }
}

