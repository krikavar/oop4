using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
	class Zbozi
	{
		private string nazev;
		private double cena;
		private DateTime datumVyroby;
		private int minimalniTrvanlivost;

		public Zbozi(string nazev, double cena, DateTime datumVyroby, int minimalniTrvanlivost)
		{
			this.nazev = nazev;
			this.cena = cena;
			this.datumVyroby = datumVyroby;
			this.minimalniTrvanlivost = minimalniTrvanlivost;
		}

		public bool SplnujeMinimlaniTrvanlivost()
		{
			if ((DateTime.Now - datumVyroby).Days <= minimalniTrvanlivost) { return true; }
			else { return false; }
		}

		public virtual double Cena_s_DPH()
		{
			return (cena + ((cena * 21) / 100));
		}

		public override string ToString()
		{
			if (SplnujeMinimlaniTrvanlivost()) { return $"{nazev} stoji {cena}, datum vyroby: {datumVyroby}, cena s dph: {Cena_s_DPH()}, zbozi splnuje minimalni trvanlivost"; }
			else { return $"{nazev} stoji {cena}, datum vyroby: {datumVyroby}, cena s dph: {Cena_s_DPH()}, zbozi nesplnuje minimalni trvanlivost"; }
		}
	}
}
