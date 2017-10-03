using System;

namespace CakeApp
{
	public enum AnfrageArt
	{
		Hochzeit,
		Kindergeburtstag,
		Cupcakes
	}

	public class Anfrage
	{
		public Anfrage()
		{
		}

		public string Kommentar { get; set; }

		public AnfrageArt Art { get; set; }

		public string sAnzahl { get; set; }

		public int Anzahl { get; set; }

		public string email { get; set; }

		//Todo: Image!
	}
}
