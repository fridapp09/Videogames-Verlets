namespace PLAYGROUND
{
    partial class MyForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PNL_MAIN = new System.Windows.Forms.Panel();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.PNL_BOTTOM = new System.Windows.Forms.Panel();
            this.ADD_POINT_BTN = new System.Windows.Forms.Button();
            this.PNL_HEADER = new System.Windows.Forms.Panel();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PNL_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.PNL_HEADER.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_MAIN
            // 
            this.PNL_MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PNL_MAIN.Controls.Add(this.PCT_CANVAS);
            this.PNL_MAIN.Controls.Add(this.panel2);
            this.PNL_MAIN.Controls.Add(this.panel1);
            this.PNL_MAIN.Controls.Add(this.PNL_BOTTOM);
            this.PNL_MAIN.Controls.Add(this.PNL_HEADER);
            this.PNL_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_MAIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNL_MAIN.ForeColor = System.Drawing.Color.Silver;
            this.PNL_MAIN.Location = new System.Drawing.Point(0, 0);
            this.PNL_MAIN.Name = "PNL_MAIN";
            this.PNL_MAIN.Size = new System.Drawing.Size(962, 548);
            this.PNL_MAIN.TabIndex = 0;
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PCT_CANVAS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PCT_CANVAS.Location = new System.Drawing.Point(200, 100);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(562, 348);
            this.PCT_CANVAS.TabIndex = 6;
            this.PCT_CANVAS.TabStop = false;
            // 
            // PNL_BOTTOM
            // 
            this.PNL_BOTTOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PNL_BOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNL_BOTTOM.Location = new System.Drawing.Point(0, 448);
            this.PNL_BOTTOM.Name = "PNL_BOTTOM";
            this.PNL_BOTTOM.Size = new System.Drawing.Size(962, 100);
            this.PNL_BOTTOM.TabIndex = 3;
            // 
            // ADD_POINT_BTN
            // 
            this.ADD_POINT_BTN.AutoSize = true;
            this.ADD_POINT_BTN.ForeColor = System.Drawing.Color.Black;
            this.ADD_POINT_BTN.Location = new System.Drawing.Point(32, 22);
            this.ADD_POINT_BTN.Margin = new System.Windows.Forms.Padding(2);
            this.ADD_POINT_BTN.Name = "ADD_POINT_BTN";
            this.ADD_POINT_BTN.Size = new System.Drawing.Size(80, 34);
            this.ADD_POINT_BTN.TabIndex = 7;
            this.ADD_POINT_BTN.Text = "Balls";
            this.ADD_POINT_BTN.UseVisualStyleBackColor = true;
            this.ADD_POINT_BTN.Click += new System.EventHandler(this.ADD_POINT_BTN_Click);
            // 
            // PNL_HEADER
            // 
            this.PNL_HEADER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PNL_HEADER.Controls.Add(this.ADD_POINT_BTN);
            this.PNL_HEADER.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_HEADER.Location = new System.Drawing.Point(0, 0);
            this.PNL_HEADER.Name = "PNL_HEADER";
            this.PNL_HEADER.Size = new System.Drawing.Size(962, 100);
            this.PNL_HEADER.TabIndex = 0;
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 10;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(762, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 348);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 348);
            this.panel1.TabIndex = 4;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 548);
            this.Controls.Add(this.PNL_MAIN);
            this.Name = "MyForm";
            this.Text = "PLAYGROUND || VERLETS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.MyForm_SizeChanged);
            this.PNL_MAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.PNL_HEADER.ResumeLayout(false);
            this.PNL_HEADER.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_MAIN;
        private System.Windows.Forms.Button ADD_POINT_BTN;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Panel PNL_BOTTOM;
        private System.Windows.Forms.Panel PNL_HEADER;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

