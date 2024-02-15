namespace WindowReview
{
   partial class MainForm
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbAddressee = new System.Windows.Forms.TextBox();
            this.lblAddresse = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.Linen;
            this.tbTitle.Location = new System.Drawing.Point(98, 10);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(460, 23);
            this.tbTitle.TabIndex = 0;
            // 
            // tbAddressee
            // 
            this.tbAddressee.BackColor = System.Drawing.Color.Linen;
            this.tbAddressee.Location = new System.Drawing.Point(98, 38);
            this.tbAddressee.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddressee.Name = "tbAddressee";
            this.tbAddressee.Size = new System.Drawing.Size(460, 23);
            this.tbAddressee.TabIndex = 0;
            // 
            // lblAddresse
            // 
            this.lblAddresse.AutoSize = true;
            this.lblAddresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddresse.Location = new System.Drawing.Point(0, 38);
            this.lblAddresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddresse.Name = "lblAddresse";
            this.lblAddresse.Size = new System.Drawing.Size(90, 20);
            this.lblAddresse.TabIndex = 1;
            this.lblAddresse.Text = "Addressee:";
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.Color.Linen;
            this.tbContent.Location = new System.Drawing.Point(13, 65);
            this.tbContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(545, 222);
            this.tbContent.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(15, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(261, 55);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(294, 294);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(264, 55);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(48, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(570, 365);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAddresse);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbAddressee);
            this.Controls.Add(this.tbTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Send a mail";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox tbTitle;
      private System.Windows.Forms.TextBox tbAddressee;
      private System.Windows.Forms.Label lblAddresse;
      private System.Windows.Forms.TextBox tbContent;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnSend;
      private System.Windows.Forms.Label lblTitle;
   }
}

