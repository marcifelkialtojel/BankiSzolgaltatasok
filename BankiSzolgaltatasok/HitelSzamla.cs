﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok 
{
	public class HitelSzamla : Szamla
	{
		private int hitelKeret;

		public HitelSzamla(int hitelKeret, Tulajdonos tulajdonos) : base(tulajdonos)
		{
			this.hitelKeret = hitelKeret;
		}

		public int HitelKeret { get => hitelKeret; set => hitelKeret = value; }

		public override bool Kifizet(int osszeg)
		{
			throw new NotImplementedException();
		}
	}
}
