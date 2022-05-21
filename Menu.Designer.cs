
namespace Matricula
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelMostrar = new System.Windows.Forms.Panel();
            this.panelSup = new System.Windows.Forms.Panel();
            this.iconoMinimizar = new System.Windows.Forms.PictureBox();
            this.iconoMin = new System.Windows.Forms.PictureBox();
            this.iconoMax = new System.Windows.Forms.PictureBox();
            this.iconoCerrar = new System.Windows.Forms.PictureBox();
            this.panelMeDes = new System.Windows.Forms.Panel();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnProfesor = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal.SuspendLayout();
            this.panelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).BeginInit();
            this.panelMeDes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panelMostrar);
            this.panelPrincipal.Controls.Add(this.panelSup);
            this.panelPrincipal.Controls.Add(this.panelMeDes);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 450);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panelMostrar
            // 
            this.panelMostrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMostrar.Location = new System.Drawing.Point(230, 30);
            this.panelMostrar.Name = "panelMostrar";
            this.panelMostrar.Size = new System.Drawing.Size(570, 420);
            this.panelMostrar.TabIndex = 2;
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.Brown;
            this.panelSup.Controls.Add(this.iconoMinimizar);
            this.panelSup.Controls.Add(this.iconoMin);
            this.panelSup.Controls.Add(this.iconoMax);
            this.panelSup.Controls.Add(this.iconoCerrar);
            this.panelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSup.Location = new System.Drawing.Point(230, 0);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(570, 30);
            this.panelSup.TabIndex = 0;
            this.panelSup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSup_MouseDown);
            // 
            // iconoMinimizar
            // 
            this.iconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconoMinimizar.Image")));
            this.iconoMinimizar.Location = new System.Drawing.Point(503, 7);
            this.iconoMinimizar.Name = "iconoMinimizar";
            this.iconoMinimizar.Size = new System.Drawing.Size(15, 15);
            this.iconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMinimizar.TabIndex = 3;
            this.iconoMinimizar.TabStop = false;
            this.iconoMinimizar.Click += new System.EventHandler(this.iconoMinimizar_Click);
            // 
            // iconoMin
            // 
            this.iconoMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMin.Image = ((System.Drawing.Image)(resources.GetObject("iconoMin.Image")));
            this.iconoMin.Location = new System.Drawing.Point(524, 7);
            this.iconoMin.Name = "iconoMin";
            this.iconoMin.Size = new System.Drawing.Size(15, 15);
            this.iconoMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMin.TabIndex = 2;
            this.iconoMin.TabStop = false;
            this.iconoMin.Visible = false;
            this.iconoMin.Click += new System.EventHandler(this.iconoMin_Click);
            // 
            // iconoMax
            // 
            this.iconoMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoMax.Image = ((System.Drawing.Image)(resources.GetObject("iconoMax.Image")));
            this.iconoMax.Location = new System.Drawing.Point(524, 7);
            this.iconoMax.Name = "iconoMax";
            this.iconoMax.Size = new System.Drawing.Size(15, 15);
            this.iconoMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoMax.TabIndex = 1;
            this.iconoMax.TabStop = false;
            this.iconoMax.Click += new System.EventHandler(this.iconoMax_Click);
            // 
            // iconoCerrar
            // 
            this.iconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconoCerrar.Image")));
            this.iconoCerrar.Location = new System.Drawing.Point(545, 7);
            this.iconoCerrar.Name = "iconoCerrar";
            this.iconoCerrar.Size = new System.Drawing.Size(15, 15);
            this.iconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoCerrar.TabIndex = 0;
            this.iconoCerrar.TabStop = false;
            this.iconoCerrar.Click += new System.EventHandler(this.iconoCerrar_Click);
            // 
            // panelMeDes
            // 
            this.panelMeDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMeDes.Controls.Add(this.btnCurso);
            this.panelMeDes.Controls.Add(this.btnProfesor);
            this.panelMeDes.Controls.Add(this.btnAlumno);
            this.panelMeDes.Controls.Add(this.pictureBox1);
            this.panelMeDes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeDes.Location = new System.Drawing.Point(0, 0);
            this.panelMeDes.Name = "panelMeDes";
            this.panelMeDes.Size = new System.Drawing.Size(230, 450);
            this.panelMeDes.TabIndex = 0;
            // 
            // btnCurso
            // 
            this.btnCurso.FlatAppearance.BorderSize = 0;
            this.btnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnCurso.Image")));
            this.btnCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurso.Location = new System.Drawing.Point(1, 315);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(230, 40);
            this.btnCurso.TabIndex = 3;
            this.btnCurso.Text = "CURSO";
            this.btnCurso.UseVisualStyleBackColor = true;
            // 
            // btnProfesor
            // 
            this.btnProfesor.FlatAppearance.BorderSize = 0;
            this.btnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProfesor.Image = ((System.Drawing.Image)(resources.GetObject("btnProfesor.Image")));
            this.btnProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesor.Location = new System.Drawing.Point(1, 252);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(230, 40);
            this.btnProfesor.TabIndex = 2;
            this.btnProfesor.Text = "PROFESOR";
            this.btnProfesor.UseVisualStyleBackColor = true;
            // 
            // btnAlumno
            // 
            this.btnAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAlumno.FlatAppearance.BorderSize = 0;
            this.btnAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlumno.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumno.Image")));
            this.btnAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumno.Location = new System.Drawing.Point(1, 188);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(230, 40);
            this.btnAlumno.TabIndex = 1;
            this.btnAlumno.Text = "ALUMNO";
            this.btnAlumno.UseVisualStyleBackColor = false;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelPrincipal.ResumeLayout(false);
            this.panelSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoCerrar)).EndInit();
            this.panelMeDes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelMostrar;
        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.Panel panelMeDes;
        private System.Windows.Forms.PictureBox iconoCerrar;
        private System.Windows.Forms.PictureBox iconoMinimizar;
        private System.Windows.Forms.PictureBox iconoMin;
        private System.Windows.Forms.PictureBox iconoMax;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Button btnProfesor;
    }
}