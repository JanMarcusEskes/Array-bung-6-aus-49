using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace _6_aus_49
{
	public partial class Form1 : Form
	{
		int[] ziehung = new int[6];
		int zufall
		{
		get
			{
				Thread.Sleep(25);
				Random zufall = new Random(DateTime.Now.Ticks.GetHashCode());
				return zufall.Next(1, 49);
			}
		}
		int[] ausgabe
		{
			set
			{
				int[] ziehung = value;
				lblZiehung.Text = String.Empty;
				foreach (int zahl in ziehung)
				{
					lblZiehung.Text += zahl + " | ";
				}
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void btnMethodeThünnes_Click(object sender, EventArgs e)
		{
			bool istWertDoppelt = false;
			for (int i = 0; i < ziehung.Length; i++)
			{
				ziehung[i] = zufall;
				for (int y = 0; y < i; y++)
				{
					if (ziehung[i] == ziehung[y])
					{
						istWertDoppelt = true;
					}
				}
			}
			if (istWertDoppelt)
			{
				MessageBox.Show("Es ist ein Fehler aufgetreten!\nMeldung: Eine oder Mehrer Zahlen wurden doppelt gezogen!","Fehler bei Ziehung", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			ausgabe = ziehung;
		}

		private void btnMethodeScheel_Click(object sender, EventArgs e)
		{
			bool[] dopplungen = new bool[49];
			for (int i = 0; i < ziehung.Length; i++)
			{
				ziehung[i] = zufall;
				if (dopplungen[ziehung[i]])
				{
					MessageBox.Show("Es ist ein Fehler aufgetreten!\nMeldung: Eine oder Mehrer Zahlen wurden doppelt gezogen!", "Fehler bei Ziehung", MessageBoxButtons.OK, MessageBoxIcon.Error);
					ausgabe = ziehung;
					return;
				}
				else dopplungen[ziehung[i]] = true;
			}
			ausgabe = ziehung;
		}

		private void btnMethodeMe_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < ziehung.Length; i++)
			{
				ziehung[i] = zufall;
				for (int y = 0; y < i; y++)
				{
					if (ziehung[i] == ziehung[y])
					{
						i--;
					}
				}
			}
			ausgabe = ziehung;
		}
	}
}
