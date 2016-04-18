namespace AplicacionPuntoDeVenta
{
    partial class FormOrders
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
            this.panelMeals = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDrinks = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.lblParcial = new System.Windows.Forms.Label();
            this.lblDivision2 = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMeals.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelDrinks.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeals
            // 
            this.panelMeals.BackColor = System.Drawing.Color.White;
            this.panelMeals.Controls.Add(this.panel3);
            this.panelMeals.Location = new System.Drawing.Point(12, 37);
            this.panelMeals.Name = "panelMeals";
            this.panelMeals.Size = new System.Drawing.Size(313, 322);
            this.panelMeals.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 34);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platillos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.menu1ToolStripMenuItem.Text = "Menu 1";
            this.menu1ToolStripMenuItem.Click += new System.EventHandler(this.menu1ToolStripMenuItem_Click);
            // 
            // panelDrinks
            // 
            this.panelDrinks.BackColor = System.Drawing.Color.White;
            this.panelDrinks.Controls.Add(this.panel2);
            this.panelDrinks.Location = new System.Drawing.Point(12, 375);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(313, 109);
            this.panelDrinks.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 34);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bebidas";
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.White;
            this.panelOrder.Controls.Add(this.lblParcial);
            this.panelOrder.Controls.Add(this.lblDivision2);
            this.panelOrder.Controls.Add(this.lblDivision);
            this.panelOrder.Controls.Add(this.panel4);
            this.panelOrder.Location = new System.Drawing.Point(342, 37);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(313, 232);
            this.panelOrder.TabIndex = 2;
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.lblParcial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParcial.Location = new System.Drawing.Point(13, 111);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(125, 22);
            this.lblParcial.TabIndex = 4;
            this.lblParcial.Text = "Orden Parcial";
            this.lblParcial.Visible = false;
            // 
            // lblDivision2
            // 
            this.lblDivision2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.lblDivision2.Location = new System.Drawing.Point(-5, 111);
            this.lblDivision2.Name = "lblDivision2";
            this.lblDivision2.Size = new System.Drawing.Size(322, 10);
            this.lblDivision2.TabIndex = 2;
            this.lblDivision2.Visible = false;
            // 
            // lblDivision
            // 
            this.lblDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.lblDivision.Location = new System.Drawing.Point(-3, 110);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(322, 10);
            this.lblDivision.TabIndex = 1;
            this.lblDivision.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(108)))), ((int)(((byte)(176)))));
            this.panel4.Controls.Add(this.lblOrderNum);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 34);
            this.panel4.TabIndex = 0;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrderNum.Location = new System.Drawing.Point(3, 7);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(67, 24);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "Orden";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ordenes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Inventario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(424, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Usuarios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Menu edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(683, 498);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.panelDrinks);
            this.Controls.Add(this.panelMeals);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrders_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMeals.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDrinks.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMeals;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelDrinks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDivision2;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

