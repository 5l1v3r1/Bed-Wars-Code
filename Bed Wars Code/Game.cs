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
	public class Game
	{
		public Map BWMap;

		public bool Running = false;

		public List<Player> Players = new List<Player>();

		public Game(List<Player> Players, Map map)
		{
			this.Players = Players;
			this.BWMap = map;
		}
	}
}
