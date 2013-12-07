namespace Spiral
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawSlowlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tightenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.losenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.rediculoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msToolStripMenuItem,
            this.msToolStripMenuItem1,
            this.msToolStripMenuItem2,
            this.msToolStripMenuItem3,
            this.msToolStripMenuItem4,
            this.msToolStripMenuItem5,
            this.msToolStripMenuItem6});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // msToolStripMenuItem
            // 
            this.msToolStripMenuItem.Name = "msToolStripMenuItem";
            this.msToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem.Text = "1000ms";
            this.msToolStripMenuItem.Click += new System.EventHandler(this.msToolStripMenuItem_Click);
            // 
            // msToolStripMenuItem1
            // 
            this.msToolStripMenuItem1.Name = "msToolStripMenuItem1";
            this.msToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem1.Text = "100ms";
            this.msToolStripMenuItem1.Click += new System.EventHandler(this.msToolStripMenuItem1_Click);
            // 
            // msToolStripMenuItem2
            // 
            this.msToolStripMenuItem2.Name = "msToolStripMenuItem2";
            this.msToolStripMenuItem2.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem2.Text = "50ms";
            this.msToolStripMenuItem2.Click += new System.EventHandler(this.msToolStripMenuItem2_Click);
            // 
            // msToolStripMenuItem3
            // 
            this.msToolStripMenuItem3.Name = "msToolStripMenuItem3";
            this.msToolStripMenuItem3.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem3.Text = "28ms";
            this.msToolStripMenuItem3.Click += new System.EventHandler(this.msToolStripMenuItem3_Click);
            // 
            // msToolStripMenuItem4
            // 
            this.msToolStripMenuItem4.Name = "msToolStripMenuItem4";
            this.msToolStripMenuItem4.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem4.Text = "10ms";
            this.msToolStripMenuItem4.Click += new System.EventHandler(this.msToolStripMenuItem4_Click);
            // 
            // msToolStripMenuItem5
            // 
            this.msToolStripMenuItem5.Name = "msToolStripMenuItem5";
            this.msToolStripMenuItem5.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem5.Text = "5ms";
            this.msToolStripMenuItem5.Click += new System.EventHandler(this.msToolStripMenuItem5_Click);
            // 
            // msToolStripMenuItem6
            // 
            this.msToolStripMenuItem6.Name = "msToolStripMenuItem6";
            this.msToolStripMenuItem6.Size = new System.Drawing.Size(114, 22);
            this.msToolStripMenuItem6.Text = "1ms";
            this.msToolStripMenuItem6.Click += new System.EventHandler(this.msToolStripMenuItem6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedToolStripMenuItem,
            this.drawSlowlyToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.fullscreenToolStripMenuItem,
            this.tightenToolStripMenuItem,
            this.losenToolStripMenuItem,
            this.rediculoseToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.cacheToolStripMenuItem});
            this.contextMenuStrip1.Margin = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 224);
            // 
            // drawSlowlyToolStripMenuItem
            // 
            this.drawSlowlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesToolStripMenuItem,
            this.noToolStripMenuItem});
            this.drawSlowlyToolStripMenuItem.Name = "drawSlowlyToolStripMenuItem";
            this.drawSlowlyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.drawSlowlyToolStripMenuItem.Text = "Draw Slowly";
            // 
            // yesToolStripMenuItem
            // 
            this.yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            this.yesToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.yesToolStripMenuItem.Text = "Yes";
            this.yesToolStripMenuItem.Click += new System.EventHandler(this.yesToolStripMenuItem_Click);
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.noToolStripMenuItem.Text = "No";
            this.noToolStripMenuItem.Click += new System.EventHandler(this.noToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click);
            // 
            // tightenToolStripMenuItem
            // 
            this.tightenToolStripMenuItem.Name = "tightenToolStripMenuItem";
            this.tightenToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.tightenToolStripMenuItem.Text = "tighten";
            this.tightenToolStripMenuItem.Click += new System.EventHandler(this.tightenToolStripMenuItem_Click);
            // 
            // losenToolStripMenuItem
            // 
            this.losenToolStripMenuItem.Name = "losenToolStripMenuItem";
            this.losenToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.losenToolStripMenuItem.Text = "losen";
            this.losenToolStripMenuItem.Click += new System.EventHandler(this.losenToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // rediculoseToolStripMenuItem
            // 
            this.rediculoseToolStripMenuItem.Name = "rediculoseToolStripMenuItem";
            this.rediculoseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rediculoseToolStripMenuItem.Text = "rediculose";
            this.rediculoseToolStripMenuItem.Click += new System.EventHandler(this.rediculoseToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.CheckOnClick = true;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.saveToolStripMenuItem_CheckStateChanged);
            // 
            // cacheToolStripMenuItem
            // 
            this.cacheToolStripMenuItem.Checked = true;
            this.cacheToolStripMenuItem.CheckOnClick = true;
            this.cacheToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cacheToolStripMenuItem.Name = "cacheToolStripMenuItem";
            this.cacheToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cacheToolStripMenuItem.Text = "cache";
            this.cacheToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.cacheToolStripMenuItem_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 742);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drawSlowlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tightenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem losenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rediculoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacheToolStripMenuItem;

    }
}

