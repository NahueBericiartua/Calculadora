/*
 * Created by SharpDevelop.
 * User: LAB-04
 * Date: 25/10/2021
 * Time: 6:57 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculadora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txt_resultado = new System.Windows.Forms.TextBox();
			this.btn_cambiars = new System.Windows.Forms.Button();
			this.btn_0 = new System.Windows.Forms.Button();
			this.btn_punto = new System.Windows.Forms.Button();
			this.btn_igual = new System.Windows.Forms.Button();
			this.btn_sumar = new System.Windows.Forms.Button();
			this.btn_3 = new System.Windows.Forms.Button();
			this.btn_2 = new System.Windows.Forms.Button();
			this.btn_1 = new System.Windows.Forms.Button();
			this.btn_restar = new System.Windows.Forms.Button();
			this.btn_6 = new System.Windows.Forms.Button();
			this.btn_5 = new System.Windows.Forms.Button();
			this.btn_4 = new System.Windows.Forms.Button();
			this.btn_multiplicar = new System.Windows.Forms.Button();
			this.btn_9 = new System.Windows.Forms.Button();
			this.btn_8 = new System.Windows.Forms.Button();
			this.btn_7 = new System.Windows.Forms.Button();
			this.btn_dividir = new System.Windows.Forms.Button();
			this.btn_raiz = new System.Windows.Forms.Button();
			this.btn_potencia = new System.Windows.Forms.Button();
			this.btn_fraccion = new System.Windows.Forms.Button();
			this.btn_borrar = new System.Windows.Forms.Button();
			this.btn_reiniciar = new System.Windows.Forms.Button();
			this.btn_reiniciara = new System.Windows.Forms.Button();
			this.btn_porcentaje = new System.Windows.Forms.Button();
			this.txt_resultadoa = new System.Windows.Forms.TextBox();
			this.lbl_focus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_resultado
			// 
			this.txt_resultado.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_resultado.Location = new System.Drawing.Point(12, 60);
			this.txt_resultado.MaxLength = 21;
			this.txt_resultado.Multiline = true;
			this.txt_resultado.Name = "txt_resultado";
			this.txt_resultado.ReadOnly = true;
			this.txt_resultado.Size = new System.Drawing.Size(270, 33);
			this.txt_resultado.TabIndex = 0;
			this.txt_resultado.Text = "0";
			this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btn_cambiars
			// 
			this.btn_cambiars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_cambiars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cambiars.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cambiars.Location = new System.Drawing.Point(12, 353);
			this.btn_cambiars.Name = "btn_cambiars";
			this.btn_cambiars.Size = new System.Drawing.Size(63, 39);
			this.btn_cambiars.TabIndex = 1;
			this.btn_cambiars.TabStop = false;
			this.btn_cambiars.Text = "+ / -";
			this.btn_cambiars.UseVisualStyleBackColor = true;
			this.btn_cambiars.Click += new System.EventHandler(this.Btn_cambiarsClick);
			// 
			// btn_0
			// 
			this.btn_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_0.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_0.Location = new System.Drawing.Point(81, 353);
			this.btn_0.Name = "btn_0";
			this.btn_0.Size = new System.Drawing.Size(63, 39);
			this.btn_0.TabIndex = 2;
			this.btn_0.TabStop = false;
			this.btn_0.Text = "0";
			this.btn_0.UseVisualStyleBackColor = true;
			this.btn_0.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_punto
			// 
			this.btn_punto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_punto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_punto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_punto.Location = new System.Drawing.Point(150, 353);
			this.btn_punto.Name = "btn_punto";
			this.btn_punto.Size = new System.Drawing.Size(63, 39);
			this.btn_punto.TabIndex = 3;
			this.btn_punto.TabStop = false;
			this.btn_punto.Text = ",";
			this.btn_punto.UseVisualStyleBackColor = true;
			this.btn_punto.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_igual
			// 
			this.btn_igual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_igual.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_igual.Location = new System.Drawing.Point(219, 353);
			this.btn_igual.Name = "btn_igual";
			this.btn_igual.Size = new System.Drawing.Size(63, 39);
			this.btn_igual.TabIndex = 4;
			this.btn_igual.TabStop = false;
			this.btn_igual.Tag = "=";
			this.btn_igual.Text = "=";
			this.btn_igual.UseVisualStyleBackColor = true;
			this.btn_igual.Click += new System.EventHandler(this.Btn_igualClick);
			// 
			// btn_sumar
			// 
			this.btn_sumar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_sumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_sumar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sumar.Location = new System.Drawing.Point(219, 308);
			this.btn_sumar.Name = "btn_sumar";
			this.btn_sumar.Size = new System.Drawing.Size(63, 39);
			this.btn_sumar.TabIndex = 8;
			this.btn_sumar.TabStop = false;
			this.btn_sumar.Tag = "+";
			this.btn_sumar.Text = "+";
			this.btn_sumar.UseVisualStyleBackColor = true;
			this.btn_sumar.Click += new System.EventHandler(this.Btn_dividirClick);
			// 
			// btn_3
			// 
			this.btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_3.Location = new System.Drawing.Point(150, 308);
			this.btn_3.Name = "btn_3";
			this.btn_3.Size = new System.Drawing.Size(63, 39);
			this.btn_3.TabIndex = 7;
			this.btn_3.TabStop = false;
			this.btn_3.Text = "3";
			this.btn_3.UseVisualStyleBackColor = true;
			this.btn_3.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_2
			// 
			this.btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_2.Location = new System.Drawing.Point(81, 308);
			this.btn_2.Name = "btn_2";
			this.btn_2.Size = new System.Drawing.Size(63, 39);
			this.btn_2.TabIndex = 6;
			this.btn_2.TabStop = false;
			this.btn_2.Text = "2";
			this.btn_2.UseVisualStyleBackColor = true;
			this.btn_2.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_1
			// 
			this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_1.Location = new System.Drawing.Point(12, 308);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(63, 39);
			this.btn_1.TabIndex = 5;
			this.btn_1.TabStop = false;
			this.btn_1.Text = "1";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_restar
			// 
			this.btn_restar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_restar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_restar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_restar.Location = new System.Drawing.Point(219, 263);
			this.btn_restar.Name = "btn_restar";
			this.btn_restar.Size = new System.Drawing.Size(63, 39);
			this.btn_restar.TabIndex = 12;
			this.btn_restar.TabStop = false;
			this.btn_restar.Tag = "-";
			this.btn_restar.Text = "-";
			this.btn_restar.UseVisualStyleBackColor = true;
			this.btn_restar.Click += new System.EventHandler(this.Btn_dividirClick);
			// 
			// btn_6
			// 
			this.btn_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_6.Location = new System.Drawing.Point(150, 263);
			this.btn_6.Name = "btn_6";
			this.btn_6.Size = new System.Drawing.Size(63, 39);
			this.btn_6.TabIndex = 11;
			this.btn_6.TabStop = false;
			this.btn_6.Text = "6";
			this.btn_6.UseVisualStyleBackColor = true;
			this.btn_6.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_5
			// 
			this.btn_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_5.Location = new System.Drawing.Point(81, 263);
			this.btn_5.Name = "btn_5";
			this.btn_5.Size = new System.Drawing.Size(63, 39);
			this.btn_5.TabIndex = 10;
			this.btn_5.TabStop = false;
			this.btn_5.Text = "5";
			this.btn_5.UseVisualStyleBackColor = true;
			this.btn_5.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_4
			// 
			this.btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_4.Location = new System.Drawing.Point(12, 263);
			this.btn_4.Name = "btn_4";
			this.btn_4.Size = new System.Drawing.Size(63, 39);
			this.btn_4.TabIndex = 9;
			this.btn_4.TabStop = false;
			this.btn_4.Text = "4";
			this.btn_4.UseVisualStyleBackColor = true;
			this.btn_4.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_multiplicar
			// 
			this.btn_multiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_multiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_multiplicar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_multiplicar.Location = new System.Drawing.Point(219, 218);
			this.btn_multiplicar.Name = "btn_multiplicar";
			this.btn_multiplicar.Size = new System.Drawing.Size(63, 39);
			this.btn_multiplicar.TabIndex = 16;
			this.btn_multiplicar.TabStop = false;
			this.btn_multiplicar.Tag = "*";
			this.btn_multiplicar.Text = "x";
			this.btn_multiplicar.UseVisualStyleBackColor = true;
			this.btn_multiplicar.Click += new System.EventHandler(this.Btn_dividirClick);
			// 
			// btn_9
			// 
			this.btn_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_9.Location = new System.Drawing.Point(150, 218);
			this.btn_9.Name = "btn_9";
			this.btn_9.Size = new System.Drawing.Size(63, 39);
			this.btn_9.TabIndex = 15;
			this.btn_9.TabStop = false;
			this.btn_9.Text = "9";
			this.btn_9.UseVisualStyleBackColor = true;
			this.btn_9.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_8
			// 
			this.btn_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_8.Location = new System.Drawing.Point(81, 218);
			this.btn_8.Name = "btn_8";
			this.btn_8.Size = new System.Drawing.Size(63, 39);
			this.btn_8.TabIndex = 14;
			this.btn_8.TabStop = false;
			this.btn_8.Text = "8";
			this.btn_8.UseVisualStyleBackColor = true;
			this.btn_8.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_7
			// 
			this.btn_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_7.Location = new System.Drawing.Point(12, 218);
			this.btn_7.Name = "btn_7";
			this.btn_7.Size = new System.Drawing.Size(63, 39);
			this.btn_7.TabIndex = 13;
			this.btn_7.TabStop = false;
			this.btn_7.Text = "7";
			this.btn_7.UseVisualStyleBackColor = true;
			this.btn_7.Click += new System.EventHandler(this.Btn_0Click);
			// 
			// btn_dividir
			// 
			this.btn_dividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_dividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_dividir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dividir.Location = new System.Drawing.Point(219, 173);
			this.btn_dividir.Name = "btn_dividir";
			this.btn_dividir.Size = new System.Drawing.Size(63, 39);
			this.btn_dividir.TabIndex = 20;
			this.btn_dividir.TabStop = false;
			this.btn_dividir.Tag = "/";
			this.btn_dividir.Text = "/";
			this.btn_dividir.UseVisualStyleBackColor = true;
			this.btn_dividir.Click += new System.EventHandler(this.Btn_dividirClick);
			// 
			// btn_raiz
			// 
			this.btn_raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_raiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_raiz.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_raiz.Location = new System.Drawing.Point(150, 173);
			this.btn_raiz.Name = "btn_raiz";
			this.btn_raiz.Size = new System.Drawing.Size(63, 39);
			this.btn_raiz.TabIndex = 19;
			this.btn_raiz.TabStop = false;
			this.btn_raiz.Tag = "√";
			this.btn_raiz.Text = " √";
			this.btn_raiz.UseVisualStyleBackColor = true;
			this.btn_raiz.Click += new System.EventHandler(this.Btn_raizClick);
			// 
			// btn_potencia
			// 
			this.btn_potencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_potencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_potencia.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_potencia.Location = new System.Drawing.Point(81, 173);
			this.btn_potencia.Name = "btn_potencia";
			this.btn_potencia.Size = new System.Drawing.Size(63, 39);
			this.btn_potencia.TabIndex = 18;
			this.btn_potencia.TabStop = false;
			this.btn_potencia.Tag = "^";
			this.btn_potencia.Text = "x²";
			this.btn_potencia.UseVisualStyleBackColor = true;
			this.btn_potencia.Click += new System.EventHandler(this.Btn_potenciaClick);
			// 
			// btn_fraccion
			// 
			this.btn_fraccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_fraccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_fraccion.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_fraccion.Location = new System.Drawing.Point(12, 173);
			this.btn_fraccion.Name = "btn_fraccion";
			this.btn_fraccion.Size = new System.Drawing.Size(63, 39);
			this.btn_fraccion.TabIndex = 17;
			this.btn_fraccion.TabStop = false;
			this.btn_fraccion.Tag = "/";
			this.btn_fraccion.Text = "1/x";
			this.btn_fraccion.UseVisualStyleBackColor = true;
			this.btn_fraccion.Click += new System.EventHandler(this.Btn_fraccionClick);
			// 
			// btn_borrar
			// 
			this.btn_borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_borrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_borrar.Location = new System.Drawing.Point(219, 128);
			this.btn_borrar.Name = "btn_borrar";
			this.btn_borrar.Size = new System.Drawing.Size(63, 39);
			this.btn_borrar.TabIndex = 24;
			this.btn_borrar.TabStop = false;
			this.btn_borrar.Text = "←";
			this.btn_borrar.UseVisualStyleBackColor = true;
			this.btn_borrar.Click += new System.EventHandler(this.Btn_borrarClick);
			// 
			// btn_reiniciar
			// 
			this.btn_reiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_reiniciar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_reiniciar.Location = new System.Drawing.Point(150, 128);
			this.btn_reiniciar.Name = "btn_reiniciar";
			this.btn_reiniciar.Size = new System.Drawing.Size(63, 39);
			this.btn_reiniciar.TabIndex = 23;
			this.btn_reiniciar.TabStop = false;
			this.btn_reiniciar.Text = "C";
			this.btn_reiniciar.UseVisualStyleBackColor = true;
			this.btn_reiniciar.Click += new System.EventHandler(this.Btn_reiniciarClick);
			// 
			// btn_reiniciara
			// 
			this.btn_reiniciara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_reiniciara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_reiniciara.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_reiniciara.Location = new System.Drawing.Point(81, 128);
			this.btn_reiniciara.Name = "btn_reiniciara";
			this.btn_reiniciara.Size = new System.Drawing.Size(63, 39);
			this.btn_reiniciara.TabIndex = 22;
			this.btn_reiniciara.TabStop = false;
			this.btn_reiniciara.Text = "CE";
			this.btn_reiniciara.UseVisualStyleBackColor = true;
			this.btn_reiniciara.Click += new System.EventHandler(this.Btn_reiniciaraClick);
			// 
			// btn_porcentaje
			// 
			this.btn_porcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_porcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_porcentaje.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_porcentaje.Location = new System.Drawing.Point(12, 128);
			this.btn_porcentaje.Name = "btn_porcentaje";
			this.btn_porcentaje.Size = new System.Drawing.Size(63, 39);
			this.btn_porcentaje.TabIndex = 21;
			this.btn_porcentaje.TabStop = false;
			this.btn_porcentaje.Text = "%";
			this.btn_porcentaje.UseMnemonic = false;
			this.btn_porcentaje.UseVisualStyleBackColor = true;
			// 
			// txt_resultadoa
			// 
			this.txt_resultadoa.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_resultadoa.Location = new System.Drawing.Point(148, 34);
			this.txt_resultadoa.Name = "txt_resultadoa";
			this.txt_resultadoa.ReadOnly = true;
			this.txt_resultadoa.Size = new System.Drawing.Size(134, 22);
			this.txt_resultadoa.TabIndex = 25;
			this.txt_resultadoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_focus
			// 
			this.lbl_focus.Location = new System.Drawing.Point(10, 9);
			this.lbl_focus.Name = "lbl_focus";
			this.lbl_focus.Size = new System.Drawing.Size(20, 11);
			this.lbl_focus.TabIndex = 26;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 404);
			this.Controls.Add(this.lbl_focus);
			this.Controls.Add(this.txt_resultadoa);
			this.Controls.Add(this.btn_borrar);
			this.Controls.Add(this.btn_reiniciar);
			this.Controls.Add(this.btn_reiniciara);
			this.Controls.Add(this.btn_porcentaje);
			this.Controls.Add(this.btn_dividir);
			this.Controls.Add(this.btn_raiz);
			this.Controls.Add(this.btn_potencia);
			this.Controls.Add(this.btn_fraccion);
			this.Controls.Add(this.btn_multiplicar);
			this.Controls.Add(this.btn_9);
			this.Controls.Add(this.btn_8);
			this.Controls.Add(this.btn_7);
			this.Controls.Add(this.btn_restar);
			this.Controls.Add(this.btn_6);
			this.Controls.Add(this.btn_5);
			this.Controls.Add(this.btn_4);
			this.Controls.Add(this.btn_sumar);
			this.Controls.Add(this.btn_3);
			this.Controls.Add(this.btn_2);
			this.Controls.Add(this.btn_1);
			this.Controls.Add(this.btn_igual);
			this.Controls.Add(this.btn_punto);
			this.Controls.Add(this.btn_0);
			this.Controls.Add(this.btn_cambiars);
			this.Controls.Add(this.txt_resultado);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "Calculadora";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox txt_resultadoa;
		private System.Windows.Forms.Button btn_porcentaje;
		private System.Windows.Forms.Button btn_reiniciara;
		private System.Windows.Forms.Button btn_reiniciar;
		private System.Windows.Forms.Button btn_borrar;
		private System.Windows.Forms.Button btn_fraccion;
		private System.Windows.Forms.Button btn_potencia;
		private System.Windows.Forms.Button btn_raiz;
		private System.Windows.Forms.Button btn_dividir;
		private System.Windows.Forms.Button btn_7;
		private System.Windows.Forms.Button btn_8;
		private System.Windows.Forms.Button btn_9;
		private System.Windows.Forms.Button btn_multiplicar;
		private System.Windows.Forms.Button btn_4;
		private System.Windows.Forms.Button btn_5;
		private System.Windows.Forms.Button btn_6;
		private System.Windows.Forms.Button btn_restar;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.Button btn_2;
		private System.Windows.Forms.Button btn_3;
		private System.Windows.Forms.Button btn_sumar;
		private System.Windows.Forms.Button btn_igual;
		private System.Windows.Forms.Button btn_punto;
		private System.Windows.Forms.Button btn_0;
		private System.Windows.Forms.Button btn_cambiars;
		private System.Windows.Forms.TextBox txt_resultado;
		private System.Windows.Forms.Label lbl_focus;
	}
}
