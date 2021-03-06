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
	public class Map
	{
		public Location[][] LocCoords = null;

		public int width = 0;

		public int height = 0;

		public Map(int width, int height)
		{
			this.width = width;
			this.height = height;
		}
		
		public void Update()
		{
			foreach (Location[] row in LocCoords)
			{
				for (int i = 0; i < row.Length; i++)
				{
					if (row[i].GetType() == typeof(DiamondGen) || row[i].GetType() == typeof(EmeraldGen) || row[i].GetType() == typeof(Genorator))
					{
						Genorator g = (Genorator)row[i];
						g.Update();
						break;
					}
					else if (row[i].GetType() == typeof(Base))
					{
						Base b = (Base)row[i];
						b.TeamForge.Update();
						break;
					}
				}
			}
		}
		
		public Location GetLocationByCoords(int x, int y)
		{
			return LocCoords[x][y];
		}
	}
}

