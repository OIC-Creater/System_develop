﻿namespace SystemDevelop
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.reciveControl = new SystemDevelop.UserControls.Recive();
            this.warehouseMenuBar = new SystemDevelop.UserControls.WarehouseMenuBar();
            this.salesMenuBar = new SystemDevelop.UserControls.SalesMenuBar();
            this.loginControl = new SystemDevelop.UserControls.Login();
            this.SuspendLayout();
            // 
            // reciveControl
            // 
            this.reciveControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reciveControl.Location = new System.Drawing.Point(231, 81);
            this.reciveControl.Name = "reciveControl";
            this.reciveControl.Size = new System.Drawing.Size(1033, 706);
            this.reciveControl.TabIndex = 15;
            this.reciveControl.Visible = false;
            // 
            // warehouseMenuBar
            // 
            this.warehouseMenuBar.Location = new System.Drawing.Point(0, 81);
            this.warehouseMenuBar.Name = "warehouseMenuBar";
            this.warehouseMenuBar.Size = new System.Drawing.Size(231, 789);
            this.warehouseMenuBar.TabIndex = 14;
            this.warehouseMenuBar.Visible = false;
            // 
            // salesMenuBar
            // 
            this.salesMenuBar.Location = new System.Drawing.Point(0, 81);
            this.salesMenuBar.Name = "salesMenuBar";
            this.salesMenuBar.Size = new System.Drawing.Size(231, 789);
            this.salesMenuBar.TabIndex = 13;
            this.salesMenuBar.Visible = false;
            // 
            // loginControl
            // 
            this.loginControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginControl.Location = new System.Drawing.Point(0, 1);
            this.loginControl.Name = "loginControl";
            this.loginControl.Size = new System.Drawing.Size(1264, 786);
            this.loginControl.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 788);
            this.Controls.Add(this.reciveControl);
            this.Controls.Add(this.warehouseMenuBar);
            this.Controls.Add(this.salesMenuBar);
            this.Controls.Add(this.loginControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(910, 638);
            this.Name = "MainForm";
            this.Text = "ログイン画面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Login loginControl;
        private UserControls.SalesMenuBar salesMenuBar;
        private UserControls.WarehouseMenuBar warehouseMenuBar;
        private UserControls.Recive reciveControl;
    }
}

