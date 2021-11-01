/*
 * Created by SharpDevelop.
 * User: LAB-04
 * Date: 25/10/2021
 * Time: 6:57 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
	public class calculadora{
		
		
		
		public double sumar(double a, double b){
			a = a+b;
			return a;
		}
		
		public double restar(double a, double b){
			a = a-b;
			return a;
		}
		
		public double dividr(double a, double b){
			a = a/b;
			return a;
		}
		
		public double multiplicar(double a, double b){
			a = a*b;
			return a;
		}
		
	}
	
	public partial class MainForm : Form
	{
		double a,b;
		bool aux = false,aux2 = false;
		string operador="";
		
		calculadora calc = new calculadora();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_0Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			
			if (!aux2){
				txt_resultado.Text = "";
			}
			txt_resultado.Text += btn.Text;
			aux2 = true;
		}
		
		
		void Btn_dividirClick(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if(operador == ""){
				
				operador = Convert.ToString(btn.Tag);
			}
			if(!aux){
				a = Convert.ToDouble(txt_resultado.Text);
			}
				if (aux){
					b = Convert.ToDouble(txt_resultado.Text);
					switch(operador){
					
					case "+":
						a = calc.sumar(a,b);
						break;
					case "-":
						a = calc.restar(a,b);
						break;
					case "/":
						a = calc.dividr(a,b);
						break;
					case "*":
						a = calc.multiplicar(a,b);
						break;
					}
				}
				operador = Convert.ToString(btn.Tag);
				txt_resultadoa.Text = Convert.ToString(a)+" "+Convert.ToString(operador);
				
				
					
				
				txt_resultado.Text = Convert.ToString(a);
				aux = true;
				aux2 = false;
		}
		
		void Btn_reiniciarClick(object sender, EventArgs e)
		{
			a = 0;
			b = 0;
			txt_resultado.Text = "0";
			txt_resultadoa.Text = "";
			aux = false;
			aux2 = false;
		}
		
		void Btn_igualClick(object sender, EventArgs e)
		{
			b = Convert.ToDouble(txt_resultado.Text);
			
			switch(operador){
				
				case "+":
					txt_resultado.Text = Convert.ToString(calc.sumar(a,b));
					break;
				case "-":
					txt_resultado.Text = Convert.ToString(calc.restar(a,b));
					break;
				case "/":
					txt_resultado.Text = Convert.ToString(calc.dividr(a,b));
					break;
				case "*":
					txt_resultado.Text = Convert.ToString(calc.multiplicar(a,b));
					break;
			}
			a = 0;
			b = 0;
			aux2 = false;
			txt_resultadoa.Text = "";
			aux = false;
		}
		
		void Btn_cambiarsClick(object sender, EventArgs e)
		{
			double aux;
			aux = Convert.ToDouble(txt_resultado.Text);
			aux = aux*-1;
			txt_resultado.Text = Convert.ToString(aux);
		}
		
		void Btn_borrarClick(object sender, EventArgs e)
		{
			if(txt_resultado.Text.Length > 1){
				txt_resultado.Text = txt_resultado.Text.Substring(0,txt_resultado.Text.Length-1);
			}else{
				txt_resultado.Text = "0";
				aux2 = false;
			}
		}
		
		void Btn_raizClick(object sender, EventArgs e)
		{
			a = Convert.ToDouble(txt_resultado.Text);
			txt_resultadoa.Text = Convert.ToString(btn_raiz.Tag)+Convert.ToString(a);
			a = Math.Sqrt(a);
			txt_resultado.Text = Convert.ToString(a);
			aux2 = false;
		}
		
		void Btn_potenciaClick(object sender, EventArgs e)
		{
			a = Convert.ToDouble(txt_resultado.Text);
			txt_resultadoa.Text = Convert.ToString(a)+Convert.ToString(btn_potencia.Tag)+Convert.ToString(2);
			a = Math.Pow(a,2);
			txt_resultado.Text = Convert.ToString(a);
			aux2 = false;	
		}
		
		void Btn_fraccionClick(object sender, EventArgs e)
		{
			a = Convert.ToDouble(txt_resultado.Text);
			txt_resultadoa.Text = Convert.ToString(1)+Convert.ToString(btn_fraccion.Tag)+Convert.ToString(a);
			a = 1/a;
			txt_resultado.Text = Convert.ToString(a);
			aux2 = false;	
		}
		
		void Btn_reiniciaraClick(object sender, EventArgs e)
		{
			txt_resultado.Text = "0";
			aux2 = false;			
		}
		
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == Convert.ToChar(Keys.A)){
			
			}
		}
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1){
				Btn_0Click(btn_1,e);
			}
			if(e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2){
				//btn_1.PerformClick();
				Btn_0Click(btn_2,e);
			}
			if(e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3){
				//btn_1.PerformClick();
				Btn_0Click(btn_3,e);
			}
			if(e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4){
				//btn_1.PerformClick();
				Btn_0Click(btn_4,e);
			}
			if(e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5){
				//btn_1.PerformClick();
				Btn_0Click(btn_5,e);
			}
			if(e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6){
				//btn_1.PerformClick();
				Btn_0Click(btn_6,e);
			}
			if(e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7){
				//btn_1.PerformClick();
				Btn_0Click(btn_7,e);
			}
			if(e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8){
				//btn_1.PerformClick();
				Btn_0Click(btn_8,e);
			}
			if(e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9){
				//btn_1.PerformClick();
				Btn_0Click(btn_9,e);
			}
			if(e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0){
				//btn_1.PerformClick();
				Btn_0Click(btn_0,e);
			}
			if(e.KeyCode == Keys.Back){
				//btn_1.PerformClick();
				Btn_borrarClick(btn_borrar,e);
			}
			//if(e.KeyCode == Keys.Enter){
			//	btn_igual.PerformClick();
			//}
			if(e.KeyCode == Keys.Add){
				btn_sumar.PerformClick();
			}
			if(	e.KeyCode == Keys.Multiply){
				btn_multiplicar.PerformClick();
			}
			if(e.KeyCode == Keys.Divide){
				btn_dividir.PerformClick();
			}
			if(e.KeyCode == Keys.Subtract){
				btn_restar.PerformClick();
			}
		}
	}
}
