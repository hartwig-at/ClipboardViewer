namespace ClipboardViewer {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing ) {
      if( disposing && ( components != null ) ) {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.ClipboardItems = new System.Windows.Forms.ListBox();
      this.ReloadTimer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // ClipboardItems
      // 
      this.ClipboardItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ClipboardItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ClipboardItems.FormattingEnabled = true;
      this.ClipboardItems.ItemHeight = 24;
      this.ClipboardItems.Location = new System.Drawing.Point(0, 0);
      this.ClipboardItems.Name = "ClipboardItems";
      this.ClipboardItems.Size = new System.Drawing.Size(284, 245);
      this.ClipboardItems.TabIndex = 0;
      // 
      // ReloadTimer
      // 
      this.ReloadTimer.Enabled = true;
      this.ReloadTimer.Tick += new System.EventHandler(this.ReloadTimerTick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 245);
      this.Controls.Add(this.ClipboardItems);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Zwischenablage";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox ClipboardItems;
    private System.Windows.Forms.Timer ReloadTimer;
  }
}

