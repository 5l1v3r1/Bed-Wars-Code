﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading;
using Bed_Wars_Code;
using Techcraft7_DLL_Pack;
using CCM = Techcraft7_DLL_Pack.ColorConsoleMethods;
namespace Bed_Wars_Code
{
	public class DiamondGen : Genorator
	{
		public DiamondGen(string name, Map map, int blocksreq) : base(name, map, blocksreq)
		{
			this.SingleResItemID = Resources.Diamond;
		}
	}
}

