using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
	public abstract class Szamla : BankiSzolgaltatas
	{
		private int aktualisEgyenleg;

		public Szamla(Tulajdonos tulajdonos) : base(tulajdonos)
		{
		}

		public Szamla(int aktualisEgyenleg,Tulajdonos tulajdonos) : base(tulajdonos)
		{
			
		}

		public int AktualisEgyenleg { get => aktualisEgyenleg; }

		public void Befizet(int osszeg)
		{
			aktualisEgyenleg += osszeg;
		}

		public abstract bool Kifizet(int osszeg);
		
	}
}
