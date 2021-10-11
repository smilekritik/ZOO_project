namespace ZOO_main
{
    partial class BuyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyForm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SonameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketPanel = new System.Windows.Forms.Panel();
            this.BuyTicketButton = new System.Windows.Forms.Button();
            this.WolfCheckBox = new System.Windows.Forms.CheckBox();
            this.RiceCheckBox = new System.Windows.Forms.CheckBox();
            this.LionCheckBox = new System.Windows.Forms.CheckBox();
            this.FoxCheckBox = new System.Windows.Forms.CheckBox();
            this.BeerCheckBox = new System.Windows.Forms.CheckBox();
            this.TicketPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            resources.ApplyResources(this.NameBox, "NameBox");
            this.NameBox.Name = "NameBox";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SonameBox
            // 
            resources.ApplyResources(this.SonameBox, "SonameBox");
            this.SonameBox.Name = "SonameBox";
            this.SonameBox.TextChanged += new System.EventHandler(this.SonameBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TicketPanel
            // 
            this.TicketPanel.Controls.Add(this.BuyTicketButton);
            this.TicketPanel.Controls.Add(this.WolfCheckBox);
            this.TicketPanel.Controls.Add(this.RiceCheckBox);
            this.TicketPanel.Controls.Add(this.LionCheckBox);
            this.TicketPanel.Controls.Add(this.FoxCheckBox);
            this.TicketPanel.Controls.Add(this.BeerCheckBox);
            this.TicketPanel.Controls.Add(this.NameBox);
            this.TicketPanel.Controls.Add(this.label1);
            this.TicketPanel.Controls.Add(this.SonameBox);
            resources.ApplyResources(this.TicketPanel, "TicketPanel");
            this.TicketPanel.Name = "TicketPanel";
            // 
            // BuyTicketButton
            // 
            resources.ApplyResources(this.BuyTicketButton, "BuyTicketButton");
            this.BuyTicketButton.Name = "BuyTicketButton";
            this.BuyTicketButton.UseVisualStyleBackColor = true;
            this.BuyTicketButton.UseWaitCursor = true;
            this.BuyTicketButton.Click += new System.EventHandler(this.BuyTicketButton_Click);
            // 
            // WolfCheckBox
            // 
            resources.ApplyResources(this.WolfCheckBox, "WolfCheckBox");
            this.WolfCheckBox.Name = "WolfCheckBox";
            this.WolfCheckBox.UseVisualStyleBackColor = true;
            this.WolfCheckBox.UseWaitCursor = true;
            this.WolfCheckBox.CheckedChanged += new System.EventHandler(this.WolfCheckBox_CheckedChanged);
            // 
            // RiceCheckBox
            // 
            resources.ApplyResources(this.RiceCheckBox, "RiceCheckBox");
            this.RiceCheckBox.Name = "RiceCheckBox";
            this.RiceCheckBox.UseVisualStyleBackColor = true;
            this.RiceCheckBox.UseWaitCursor = true;
            this.RiceCheckBox.CheckedChanged += new System.EventHandler(this.RiceCheckBox_CheckedChanged);
            // 
            // LionCheckBox
            // 
            resources.ApplyResources(this.LionCheckBox, "LionCheckBox");
            this.LionCheckBox.Name = "LionCheckBox";
            this.LionCheckBox.UseVisualStyleBackColor = true;
            this.LionCheckBox.UseWaitCursor = true;
            this.LionCheckBox.CheckedChanged += new System.EventHandler(this.LionCheckBox_CheckedChanged);
            // 
            // FoxCheckBox
            // 
            resources.ApplyResources(this.FoxCheckBox, "FoxCheckBox");
            this.FoxCheckBox.Name = "FoxCheckBox";
            this.FoxCheckBox.UseVisualStyleBackColor = true;
            this.FoxCheckBox.UseWaitCursor = true;
            this.FoxCheckBox.CheckedChanged += new System.EventHandler(this.FoxCheckBox_CheckedChanged);
            // 
            // BeerCheckBox
            // 
            resources.ApplyResources(this.BeerCheckBox, "BeerCheckBox");
            this.BeerCheckBox.Name = "BeerCheckBox";
            this.BeerCheckBox.UseVisualStyleBackColor = true;
            this.BeerCheckBox.UseWaitCursor = true;
            this.BeerCheckBox.CheckedChanged += new System.EventHandler(this.BeerCheckBox_CheckedChanged);
            // 
            // BuyForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TicketPanel);
            this.Name = "BuyForm";
            this.Load += new System.EventHandler(this.BuyForm_Load);
            this.TicketPanel.ResumeLayout(false);
            this.TicketPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SonameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TicketPanel;
        private System.Windows.Forms.Button BuyTicketButton;
        private System.Windows.Forms.CheckBox WolfCheckBox;
        private System.Windows.Forms.CheckBox RiceCheckBox;
        private System.Windows.Forms.CheckBox LionCheckBox;
        private System.Windows.Forms.CheckBox FoxCheckBox;
        private System.Windows.Forms.CheckBox BeerCheckBox;
    }
}

