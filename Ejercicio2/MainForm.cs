/*
 * Creado por SharpDevelop.
 * Usuario: lenovo
 * Fecha: 27/10/2026
 * Hora: 05:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public double n, m;
		public double suma, resta, multi, divi, mod;
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
		
		void Button1Click(object sender, EventArgs e)
		{
			n=Convert.ToDouble(textBox1.Text);
			m=Convert.ToDouble(textBox2.Text);
			suma=n+m;
			MessageBox.Show("El resultado es: "+suma);
		}
		
		void Button2Click(object sender, EventArgs e)
		{   
			n=Convert.ToDouble(textBox1.Text);
			m=Convert.ToDouble(textBox2.Text);
			resta=n-m;
			MessageBox.Show("El resultado es: "+resta);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			n=Convert.ToDouble(textBox1.Text);
			m=Convert.ToDouble(textBox2.Text);
			multi=n*m;
			MessageBox.Show("El resultado es: "+multi);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			n=Convert.ToDouble(textBox1.Text);
			m=Convert.ToDouble(textBox2.Text);
			divi=n/m;
			MessageBox.Show("El resultado es: "+divi);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			n=Convert.ToDouble(textBox1.Text);
			m=Convert.ToDouble(textBox2.Text);
			mod=n%m;
			MessageBox.Show("El resultado es: "+mod);
		}
	}
}
