namespace ClientApplication
{
    partial class MainForm
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
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonFinishOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 15;
            this.listBoxOrders.Location = new System.Drawing.Point(12, 12);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(529, 259);
            this.listBoxOrders.TabIndex = 0;
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewOrder.Location = new System.Drawing.Point(313, 283);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(111, 23);
            this.buttonNewOrder.TabIndex = 1;
            this.buttonNewOrder.Text = "New Order";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // buttonFinishOrder
            // 
            this.buttonFinishOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinishOrder.Location = new System.Drawing.Point(430, 283);
            this.buttonFinishOrder.Name = "buttonFinishOrder";
            this.buttonFinishOrder.Size = new System.Drawing.Size(111, 23);
            this.buttonFinishOrder.TabIndex = 2;
            this.buttonFinishOrder.Text = "Finish Order";
            this.buttonFinishOrder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 318);
            this.Controls.Add(this.buttonFinishOrder);
            this.Controls.Add(this.buttonNewOrder);
            this.Controls.Add(this.listBoxOrders);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxOrders;
        private Button buttonNewOrder;
        private Button buttonFinishOrder;
    }
}