namespace PulsacionesGUI
{
    partial class PrincipalFrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFrm));
            this.BarraTituloPnl = new System.Windows.Forms.Panel();
            this.RestaurarBtn = new System.Windows.Forms.PictureBox();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.MaximizarBtn = new System.Windows.Forms.PictureBox();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.MenuVerticalPnl = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EliminarBtn = new FontAwesome.Sharp.IconButton();
            this.ModificarBtn = new FontAwesome.Sharp.IconButton();
            this.ConsultarBtn = new FontAwesome.Sharp.IconButton();
            this.RegistrarBtn = new FontAwesome.Sharp.IconButton();
            this.PanelContenedorPnl = new System.Windows.Forms.Panel();
            this.BarraTituloPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            this.MenuVerticalPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTituloPnl
            // 
            this.BarraTituloPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.BarraTituloPnl.Controls.Add(this.RestaurarBtn);
            this.BarraTituloPnl.Controls.Add(this.MinimizarBtn);
            this.BarraTituloPnl.Controls.Add(this.MaximizarBtn);
            this.BarraTituloPnl.Controls.Add(this.CerrarBtn);
            this.BarraTituloPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPnl.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPnl.Name = "BarraTituloPnl";
            this.BarraTituloPnl.Size = new System.Drawing.Size(1080, 38);
            this.BarraTituloPnl.TabIndex = 0;
            this.BarraTituloPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloPnl_MouseDown);
            // 
            // RestaurarBtn
            // 
            this.RestaurarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurarBtn.Image = ((System.Drawing.Image)(resources.GetObject("RestaurarBtn.Image")));
            this.RestaurarBtn.Location = new System.Drawing.Point(1012, 3);
            this.RestaurarBtn.Name = "RestaurarBtn";
            this.RestaurarBtn.Size = new System.Drawing.Size(25, 25);
            this.RestaurarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RestaurarBtn.TabIndex = 3;
            this.RestaurarBtn.TabStop = false;
            this.RestaurarBtn.Visible = false;
            this.RestaurarBtn.Click += new System.EventHandler(this.RestaurarBtn_Click_1);
            // 
            // MinimizarBtn
            // 
            this.MinimizarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarBtn.Image")));
            this.MinimizarBtn.Location = new System.Drawing.Point(981, 3);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(25, 25);
            this.MinimizarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizarBtn.TabIndex = 2;
            this.MinimizarBtn.TabStop = false;
            this.MinimizarBtn.Click += new System.EventHandler(this.MinimizarBtn_Click_1);
            // 
            // MaximizarBtn
            // 
            this.MaximizarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("MaximizarBtn.Image")));
            this.MaximizarBtn.Location = new System.Drawing.Point(1012, 3);
            this.MaximizarBtn.Name = "MaximizarBtn";
            this.MaximizarBtn.Size = new System.Drawing.Size(25, 25);
            this.MaximizarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizarBtn.TabIndex = 1;
            this.MaximizarBtn.TabStop = false;
            this.MaximizarBtn.Click += new System.EventHandler(this.MaximizarBtn_Click_1);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(1043, 3);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(25, 25);
            this.CerrarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarBtn.TabIndex = 0;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click_1);
            // 
            // MenuVerticalPnl
            // 
            this.MenuVerticalPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(26)))), ((int)(((byte)(22)))));
            this.MenuVerticalPnl.Controls.Add(this.panel4);
            this.MenuVerticalPnl.Controls.Add(this.panel3);
            this.MenuVerticalPnl.Controls.Add(this.panel2);
            this.MenuVerticalPnl.Controls.Add(this.panel1);
            this.MenuVerticalPnl.Controls.Add(this.EliminarBtn);
            this.MenuVerticalPnl.Controls.Add(this.ModificarBtn);
            this.MenuVerticalPnl.Controls.Add(this.ConsultarBtn);
            this.MenuVerticalPnl.Controls.Add(this.RegistrarBtn);
            this.MenuVerticalPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVerticalPnl.Location = new System.Drawing.Point(0, 38);
            this.MenuVerticalPnl.Name = "MenuVerticalPnl";
            this.MenuVerticalPnl.Size = new System.Drawing.Size(220, 512);
            this.MenuVerticalPnl.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.panel4.Location = new System.Drawing.Point(0, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 60);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 60);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 60);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 60);
            this.panel1.TabIndex = 0;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.FlatAppearance.BorderSize = 0;
            this.EliminarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EliminarBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.ForeColor = System.Drawing.Color.White;
            this.EliminarBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.EliminarBtn.IconColor = System.Drawing.Color.White;
            this.EliminarBtn.IconSize = 32;
            this.EliminarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarBtn.Location = new System.Drawing.Point(0, 260);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.EliminarBtn.Rotation = 0D;
            this.EliminarBtn.Size = new System.Drawing.Size(220, 60);
            this.EliminarBtn.TabIndex = 3;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.FlatAppearance.BorderSize = 0;
            this.ModificarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.ModificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ModificarBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarBtn.ForeColor = System.Drawing.Color.White;
            this.ModificarBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ModificarBtn.IconColor = System.Drawing.Color.White;
            this.ModificarBtn.IconSize = 32;
            this.ModificarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarBtn.Location = new System.Drawing.Point(0, 180);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ModificarBtn.Rotation = 0D;
            this.ModificarBtn.Size = new System.Drawing.Size(220, 60);
            this.ModificarBtn.TabIndex = 2;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModificarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModificarBtn.UseVisualStyleBackColor = true;
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.FlatAppearance.BorderSize = 0;
            this.ConsultarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.ConsultarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultarBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ConsultarBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarBtn.ForeColor = System.Drawing.Color.White;
            this.ConsultarBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ConsultarBtn.IconColor = System.Drawing.Color.White;
            this.ConsultarBtn.IconSize = 32;
            this.ConsultarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarBtn.Location = new System.Drawing.Point(0, 100);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ConsultarBtn.Rotation = 0D;
            this.ConsultarBtn.Size = new System.Drawing.Size(220, 60);
            this.ConsultarBtn.TabIndex = 1;
            this.ConsultarBtn.Text = "Buscar";
            this.ConsultarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            // 
            // RegistrarBtn
            // 
            this.RegistrarBtn.FlatAppearance.BorderSize = 0;
            this.RegistrarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(67)))));
            this.RegistrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.RegistrarBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarBtn.ForeColor = System.Drawing.Color.White;
            this.RegistrarBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.RegistrarBtn.IconColor = System.Drawing.Color.White;
            this.RegistrarBtn.IconSize = 32;
            this.RegistrarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrarBtn.Location = new System.Drawing.Point(0, 20);
            this.RegistrarBtn.Name = "RegistrarBtn";
            this.RegistrarBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.RegistrarBtn.Rotation = 0D;
            this.RegistrarBtn.Size = new System.Drawing.Size(220, 60);
            this.RegistrarBtn.TabIndex = 0;
            this.RegistrarBtn.Text = "Registrar";
            this.RegistrarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistrarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrarBtn.UseVisualStyleBackColor = true;
            // 
            // PanelContenedorPnl
            // 
            this.PanelContenedorPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(52)))), ((int)(((byte)(44)))));
            this.PanelContenedorPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorPnl.Location = new System.Drawing.Point(220, 38);
            this.PanelContenedorPnl.Name = "PanelContenedorPnl";
            this.PanelContenedorPnl.Size = new System.Drawing.Size(860, 512);
            this.PanelContenedorPnl.TabIndex = 2;
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 550);
            this.Controls.Add(this.PanelContenedorPnl);
            this.Controls.Add(this.MenuVerticalPnl);
            this.Controls.Add(this.BarraTituloPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalFrm";
            this.Text = "Form1";
            this.BarraTituloPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RestaurarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            this.MenuVerticalPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTituloPnl;
        private System.Windows.Forms.Panel MenuVerticalPnl;
        private System.Windows.Forms.Panel PanelContenedorPnl;
        private System.Windows.Forms.PictureBox RestaurarBtn;
        private System.Windows.Forms.PictureBox MinimizarBtn;
        private System.Windows.Forms.PictureBox MaximizarBtn;
        private System.Windows.Forms.PictureBox CerrarBtn;
        private FontAwesome.Sharp.IconButton EliminarBtn;
        private FontAwesome.Sharp.IconButton ModificarBtn;
        private FontAwesome.Sharp.IconButton ConsultarBtn;
        private FontAwesome.Sharp.IconButton RegistrarBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

