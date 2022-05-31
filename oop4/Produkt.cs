using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
	class Produkt : Zbozi
	{
		private bool lze_zlevnit;

		public Produkt(string nazev, double cena, DateTime datumVyroby, int minimalniTrvanlivost, bool lze_zlevnit) : base(nazev, cena, datumVyroby, minimalniTrvanlivost)
		{
			this.lze_zlevnit = lze_zlevnit;
		}

		public override double Cena_s_DPH()
		{
			if (SplnujeMinimlaniTrvanlivost() == false)
			{
				return (base.Cena_s_DPH() - ((base.Cena_s_DPH() * 40) / 100));
			}
			else { return base.Cena_s_DPH(); }
		}
	}
}
