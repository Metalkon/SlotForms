namespace SlotForms
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
            this.spinButton = new System.Windows.Forms.Button();
            this.playerCash = new System.Windows.Forms.Label();
            this.playerBid = new System.Windows.Forms.Label();
            this.playerFreeSpins = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spinButton
            // 
            this.spinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.spinButton.Location = new System.Drawing.Point(603, 39);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(194, 30);
            this.spinButton.TabIndex = 0;
            this.spinButton.Text = "SPIN";
            this.spinButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerCash
            // 
            this.playerCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerCash.BackColor = System.Drawing.SystemColors.Control;
            this.playerCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerCash.Location = new System.Drawing.Point(3, 0);
            this.playerCash.Name = "playerCash";
            this.playerCash.Size = new System.Drawing.Size(394, 36);
            this.playerCash.TabIndex = 1;
            this.playerCash.Text = "Cash: N/A";
            this.playerCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerBid
            // 
            this.playerBid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerBid.BackColor = System.Drawing.SystemColors.Control;
            this.playerBid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerBid.Location = new System.Drawing.Point(403, 0);
            this.playerBid.Name = "playerBid";
            this.playerBid.Size = new System.Drawing.Size(194, 36);
            this.playerBid.TabIndex = 2;
            this.playerBid.Text = "Bid: N/A";
            this.playerBid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playerBid.Click += new System.EventHandler(this.label2_Click);
            // 
            // playerFreeSpins
            // 
            this.playerFreeSpins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerFreeSpins.BackColor = System.Drawing.SystemColors.Control;
            this.playerFreeSpins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerFreeSpins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerFreeSpins.Location = new System.Drawing.Point(603, 0);
            this.playerFreeSpins.Name = "playerFreeSpins";
            this.playerFreeSpins.Size = new System.Drawing.Size(194, 36);
            this.playerFreeSpins.TabIndex = 3;
            this.playerFreeSpins.Text = "Free Spins: N/A";
            this.playerFreeSpins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.playerCash, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.spinButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerFreeSpins, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerBid, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 72);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Betty\'s Slot Machine";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button spinButton;
        private Label playerCash;
        private Label playerBid;
        private Label playerFreeSpins;
        private TableLayoutPanel tableLayoutPanel1;
    }
}