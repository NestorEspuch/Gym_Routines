﻿
namespace Gym_Routines
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuLateral = new System.Windows.Forms.Panel();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.planSeleccionado = new System.Windows.Forms.Button();
            this.submenuRutinas = new System.Windows.Forms.Panel();
            this.btnNewRutina = new System.Windows.Forms.Button();
            this.rutinaHipertrofia = new System.Windows.Forms.Button();
            this.rutinaDefinicion = new System.Windows.Forms.Button();
            this.rutinas = new System.Windows.Forms.Button();
            this.submenuDietas = new System.Windows.Forms.Panel();
            this.btnNewDieta = new System.Windows.Forms.Button();
            this.dietaHipertrofia = new System.Windows.Forms.Button();
            this.dietaDefinicion = new System.Windows.Forms.Button();
            this.Dietas = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dataGridViewDietas = new System.Windows.Forms.DataGridView();
            this.dataGridViewRutinas = new System.Windows.Forms.DataGridView();
            this.menuLateral.SuspendLayout();
            this.submenuRutinas.SuspendLayout();
            this.submenuDietas.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDietas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutinas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuLateral
            // 
            this.menuLateral.AutoScroll = true;
            this.menuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.menuLateral.Controls.Add(this.textBoxInfo);
            this.menuLateral.Controls.Add(this.planSeleccionado);
            this.menuLateral.Controls.Add(this.submenuRutinas);
            this.menuLateral.Controls.Add(this.rutinas);
            this.menuLateral.Controls.Add(this.submenuDietas);
            this.menuLateral.Controls.Add(this.Dietas);
            this.menuLateral.Controls.Add(this.logo);
            this.menuLateral.Location = new System.Drawing.Point(0, 34);
            this.menuLateral.Name = "menuLateral";
            this.menuLateral.Size = new System.Drawing.Size(200, 1209);
            this.menuLateral.TabIndex = 1;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInfo.ForeColor = System.Drawing.Color.Red;
            this.textBoxInfo.Location = new System.Drawing.Point(1, 622);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(197, 17);
            this.textBoxInfo.TabIndex = 11;
            this.textBoxInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // planSeleccionado
            // 
            this.planSeleccionado.Dock = System.Windows.Forms.DockStyle.Top;
            this.planSeleccionado.FlatAppearance.BorderSize = 0;
            this.planSeleccionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.planSeleccionado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.planSeleccionado.ForeColor = System.Drawing.Color.White;
            this.planSeleccionado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.planSeleccionado.Location = new System.Drawing.Point(0, 479);
            this.planSeleccionado.Name = "planSeleccionado";
            this.planSeleccionado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.planSeleccionado.Size = new System.Drawing.Size(200, 45);
            this.planSeleccionado.TabIndex = 10;
            this.planSeleccionado.Text = "Plan seleccionado";
            this.planSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.planSeleccionado.UseVisualStyleBackColor = true;
            this.planSeleccionado.Click += new System.EventHandler(this.planSeleccionado_Click);
            // 
            // submenuRutinas
            // 
            this.submenuRutinas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.submenuRutinas.Controls.Add(this.btnNewRutina);
            this.submenuRutinas.Controls.Add(this.rutinaHipertrofia);
            this.submenuRutinas.Controls.Add(this.rutinaDefinicion);
            this.submenuRutinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuRutinas.Location = new System.Drawing.Point(0, 356);
            this.submenuRutinas.Name = "submenuRutinas";
            this.submenuRutinas.Size = new System.Drawing.Size(200, 123);
            this.submenuRutinas.TabIndex = 6;
            // 
            // btnNewRutina
            // 
            this.btnNewRutina.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewRutina.FlatAppearance.BorderSize = 0;
            this.btnNewRutina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRutina.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewRutina.ForeColor = System.Drawing.Color.White;
            this.btnNewRutina.Location = new System.Drawing.Point(0, 80);
            this.btnNewRutina.Name = "btnNewRutina";
            this.btnNewRutina.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNewRutina.Size = new System.Drawing.Size(200, 40);
            this.btnNewRutina.TabIndex = 3;
            this.btnNewRutina.Text = "Nueva";
            this.btnNewRutina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewRutina.UseVisualStyleBackColor = true;
            this.btnNewRutina.Click += new System.EventHandler(this.btnNewRutina_Click);
            // 
            // rutinaHipertrofia
            // 
            this.rutinaHipertrofia.Dock = System.Windows.Forms.DockStyle.Top;
            this.rutinaHipertrofia.FlatAppearance.BorderSize = 0;
            this.rutinaHipertrofia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rutinaHipertrofia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rutinaHipertrofia.ForeColor = System.Drawing.Color.White;
            this.rutinaHipertrofia.Location = new System.Drawing.Point(0, 40);
            this.rutinaHipertrofia.Name = "rutinaHipertrofia";
            this.rutinaHipertrofia.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.rutinaHipertrofia.Size = new System.Drawing.Size(200, 40);
            this.rutinaHipertrofia.TabIndex = 1;
            this.rutinaHipertrofia.Text = "Hipertrofia";
            this.rutinaHipertrofia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rutinaHipertrofia.UseVisualStyleBackColor = true;
            this.rutinaHipertrofia.Click += new System.EventHandler(this.rutinaHipertrofia_Click);
            // 
            // rutinaDefinicion
            // 
            this.rutinaDefinicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.rutinaDefinicion.FlatAppearance.BorderSize = 0;
            this.rutinaDefinicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rutinaDefinicion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rutinaDefinicion.ForeColor = System.Drawing.Color.White;
            this.rutinaDefinicion.Location = new System.Drawing.Point(0, 0);
            this.rutinaDefinicion.Name = "rutinaDefinicion";
            this.rutinaDefinicion.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.rutinaDefinicion.Size = new System.Drawing.Size(200, 40);
            this.rutinaDefinicion.TabIndex = 0;
            this.rutinaDefinicion.Text = "Definición";
            this.rutinaDefinicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rutinaDefinicion.UseVisualStyleBackColor = true;
            this.rutinaDefinicion.Click += new System.EventHandler(this.rutinaDefinicion_Click);
            // 
            // rutinas
            // 
            this.rutinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.rutinas.FlatAppearance.BorderSize = 0;
            this.rutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rutinas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rutinas.ForeColor = System.Drawing.Color.White;
            this.rutinas.Location = new System.Drawing.Point(0, 311);
            this.rutinas.Name = "rutinas";
            this.rutinas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rutinas.Size = new System.Drawing.Size(200, 45);
            this.rutinas.TabIndex = 5;
            this.rutinas.Text = "Rutinas";
            this.rutinas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rutinas.UseVisualStyleBackColor = true;
            this.rutinas.Click += new System.EventHandler(this.button1_Click);
            // 
            // submenuDietas
            // 
            this.submenuDietas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.submenuDietas.Controls.Add(this.btnNewDieta);
            this.submenuDietas.Controls.Add(this.dietaHipertrofia);
            this.submenuDietas.Controls.Add(this.dietaDefinicion);
            this.submenuDietas.Dock = System.Windows.Forms.DockStyle.Top;
            this.submenuDietas.Location = new System.Drawing.Point(0, 190);
            this.submenuDietas.Name = "submenuDietas";
            this.submenuDietas.Size = new System.Drawing.Size(200, 121);
            this.submenuDietas.TabIndex = 4;
            // 
            // btnNewDieta
            // 
            this.btnNewDieta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewDieta.FlatAppearance.BorderSize = 0;
            this.btnNewDieta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDieta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewDieta.ForeColor = System.Drawing.Color.White;
            this.btnNewDieta.Location = new System.Drawing.Point(0, 80);
            this.btnNewDieta.Name = "btnNewDieta";
            this.btnNewDieta.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnNewDieta.Size = new System.Drawing.Size(200, 40);
            this.btnNewDieta.TabIndex = 3;
            this.btnNewDieta.Text = "Nueva";
            this.btnNewDieta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewDieta.UseVisualStyleBackColor = true;
            this.btnNewDieta.Click += new System.EventHandler(this.btnNewDieta_Click);
            // 
            // dietaHipertrofia
            // 
            this.dietaHipertrofia.Dock = System.Windows.Forms.DockStyle.Top;
            this.dietaHipertrofia.FlatAppearance.BorderSize = 0;
            this.dietaHipertrofia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dietaHipertrofia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dietaHipertrofia.ForeColor = System.Drawing.Color.White;
            this.dietaHipertrofia.Location = new System.Drawing.Point(0, 40);
            this.dietaHipertrofia.Name = "dietaHipertrofia";
            this.dietaHipertrofia.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dietaHipertrofia.Size = new System.Drawing.Size(200, 40);
            this.dietaHipertrofia.TabIndex = 1;
            this.dietaHipertrofia.Text = "Hipertrofia";
            this.dietaHipertrofia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dietaHipertrofia.UseVisualStyleBackColor = true;
            this.dietaHipertrofia.Click += new System.EventHandler(this.dietaHipertrofia_Click);
            // 
            // dietaDefinicion
            // 
            this.dietaDefinicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.dietaDefinicion.FlatAppearance.BorderSize = 0;
            this.dietaDefinicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dietaDefinicion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dietaDefinicion.ForeColor = System.Drawing.Color.White;
            this.dietaDefinicion.Location = new System.Drawing.Point(0, 0);
            this.dietaDefinicion.Name = "dietaDefinicion";
            this.dietaDefinicion.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dietaDefinicion.Size = new System.Drawing.Size(200, 40);
            this.dietaDefinicion.TabIndex = 0;
            this.dietaDefinicion.Text = "Definición";
            this.dietaDefinicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dietaDefinicion.UseVisualStyleBackColor = true;
            this.dietaDefinicion.Click += new System.EventHandler(this.dietaDefinicion_Click);
            // 
            // Dietas
            // 
            this.Dietas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dietas.FlatAppearance.BorderSize = 0;
            this.Dietas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dietas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dietas.ForeColor = System.Drawing.Color.White;
            this.Dietas.Location = new System.Drawing.Point(0, 145);
            this.Dietas.Name = "Dietas";
            this.Dietas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Dietas.Size = new System.Drawing.Size(200, 45);
            this.Dietas.TabIndex = 3;
            this.Dietas.Text = "Dietas";
            this.Dietas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dietas.UseVisualStyleBackColor = true;
            this.Dietas.Click += new System.EventHandler(this.Dietas_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Black;
            this.logo.Controls.Add(this.imgLogo);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 145);
            this.logo.TabIndex = 2;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 6);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 138);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panelTitulo.Controls.Add(this.labelTitle);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1943, 42);
            this.panelTitulo.TabIndex = 2;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            this.panelTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseMove);
            this.panelTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Silver;
            this.labelTitle.Location = new System.Drawing.Point(9, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(147, 22);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "GYM ROUTINES";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1866, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(14, 42);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1886, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(14, 42);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataGridViewDietas
            // 
            this.dataGridViewDietas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDietas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(142)))));
            this.dataGridViewDietas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDietas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewDietas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDietas.Location = new System.Drawing.Point(251, 93);
            this.dataGridViewDietas.Name = "dataGridViewDietas";
            this.dataGridViewDietas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(123)))), ((int)(((byte)(218)))));
            this.dataGridViewDietas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDietas.RowTemplate.Height = 25;
            this.dataGridViewDietas.Size = new System.Drawing.Size(1619, 927);
            this.dataGridViewDietas.TabIndex = 4;
            this.dataGridViewDietas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDietas_CellDoubleClick);
            // 
            // dataGridViewRutinas
            // 
            this.dataGridViewRutinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRutinas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(142)))));
            this.dataGridViewRutinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRutinas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRutinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRutinas.Location = new System.Drawing.Point(251, 93);
            this.dataGridViewRutinas.Name = "dataGridViewRutinas";
            this.dataGridViewRutinas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(80)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(123)))), ((int)(((byte)(218)))));
            this.dataGridViewRutinas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRutinas.RowTemplate.Height = 25;
            this.dataGridViewRutinas.Size = new System.Drawing.Size(1619, 931);
            this.dataGridViewRutinas.TabIndex = 5;
            this.dataGridViewRutinas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRutinas_CellDoubleClick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1924, 894);
            this.Controls.Add(this.dataGridViewDietas);
            this.Controls.Add(this.dataGridViewRutinas);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.menuLateral);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.Text = "GYM ROUTINES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.menuLateral.ResumeLayout(false);
            this.menuLateral.PerformLayout();
            this.submenuRutinas.ResumeLayout(false);
            this.submenuDietas.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDietas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRutinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuLateral;
        private System.Windows.Forms.Panel submenuRutinas;
        private System.Windows.Forms.Button rutinaHipertrofia;
        private System.Windows.Forms.Button rutinaDefinicion;
        private System.Windows.Forms.Button rutinas;
        private System.Windows.Forms.Button Dietas;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnNewRutina;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button planSeleccionado;
        private System.Windows.Forms.Panel submenuDietas;
        private System.Windows.Forms.Button btnNewDieta;
        private System.Windows.Forms.Button dietaHipertrofia;
        private System.Windows.Forms.Button dietaDefinicion;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.DataGridView dataGridViewDietas;
        private System.Windows.Forms.DataGridView dataGridViewRutinas;
    }
}

