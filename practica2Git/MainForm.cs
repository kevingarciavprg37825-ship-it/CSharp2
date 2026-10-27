/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC21
 * Fecha: 27/10/2026
 * Hora: 07:19 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica2Git
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public double n, m;
		public double multi, suma, resta, division;
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
			MessageBox.Show("El reusltado es: " +suma);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			n=Convert.ToDouble(textBox1.Text);
			m=Convert.ToDouble(textBox2.Text);
			resta=n-m;
			MessageBox.Show("El reusltado es: " +resta);
		}
		
		
		void Button3Click(object sender, EventArgs e)
		{
			n=Convert.ToDouble(textBox1.Text);
			m=Convert.ToDouble(textBox2.Text);
			multi=n*m;
			MessageBox.Show("El reusltado es: " +multi);
		}
		
		
		void Button4Click(object sender, EventArgs e)
		{
			n=Convert.ToDouble(textBox1.Text);
			m=Convert.ToDouble(textBox2.Text);
			division=n/m;
			MessageBox.Show("El reusltado es: " +division);
		}
		}
}


	
