﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
	public class FlatWhite : Kaffe, Imælk
	{
		public FlatWhite()
		{

		}

		public int MlMælk()
		{
			return 160;
		}

		public override int Pris()
		{
			return 45;
		}

		public override string Styrke()
		{
			return "Mild";
		}
	}
}
