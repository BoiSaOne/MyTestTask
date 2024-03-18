namespace MyTestTask.Docsvision
{
    partial class ConnectingToDocsvision
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
            this.Address = new System.Windows.Forms.Label();
            this.DatabaseName = new System.Windows.Forms.Label();
            this.connectAddress = new System.Windows.Forms.TextBox();
            this.baseName = new System.Windows.Forms.TextBox();
            this.CreateCard = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address.Location = new System.Drawing.Point(12, 13);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(72, 24);
            this.Address.TabIndex = 0;
            this.Address.Text = "Адрес:";
            // 
            // DatabaseName
            // 
            this.DatabaseName.AutoSize = true;
            this.DatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatabaseName.Location = new System.Drawing.Point(12, 47);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(100, 24);
            this.DatabaseName.TabIndex = 1;
            this.DatabaseName.Text = "Имя базы:";
            // 
            // connectAddress
            // 
            this.connectAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectAddress.Location = new System.Drawing.Point(114, 13);
            this.connectAddress.Name = "connectAddress";
            this.connectAddress.Size = new System.Drawing.Size(663, 26);
            this.connectAddress.TabIndex = 2;
            this.connectAddress.TextChanged += new System.EventHandler(this.connectAddress_TextChanged);
            // 
            // baseName
            // 
            this.baseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseName.Location = new System.Drawing.Point(114, 47);
            this.baseName.Name = "baseName";
            this.baseName.Size = new System.Drawing.Size(663, 26);
            this.baseName.TabIndex = 3;
            this.baseName.TextChanged += new System.EventHandler(this.baseName_TextChanged);
            // 
            // CreateCard
            // 
            this.CreateCard.Enabled = false;
            this.CreateCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateCard.Location = new System.Drawing.Point(622, 79);
            this.CreateCard.Name = "CreateCard";
            this.CreateCard.Size = new System.Drawing.Size(155, 28);
            this.CreateCard.TabIndex = 4;
            this.CreateCard.Text = "Создать карточку";
            this.CreateCard.UseVisualStyleBackColor = true;
            this.CreateCard.Click += new System.EventHandler(this.CreateCard_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectButton.Location = new System.Drawing.Point(481, 79);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(136, 28);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectingToDocsvision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 117);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.CreateCard);
            this.Controls.Add(this.baseName);
            this.Controls.Add(this.connectAddress);
            this.Controls.Add(this.DatabaseName);
            this.Controls.Add(this.Address);
            this.Name = "ConnectingToDocsvision";
            this.Text = "Подключение к DocsVision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label DatabaseName;
        private System.Windows.Forms.TextBox connectAddress;
        private System.Windows.Forms.TextBox baseName;
        private System.Windows.Forms.Button CreateCard;
        private System.Windows.Forms.Button ConnectButton;
    }
}

