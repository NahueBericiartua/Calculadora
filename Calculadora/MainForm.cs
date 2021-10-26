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
	}
}
