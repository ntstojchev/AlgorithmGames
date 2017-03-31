using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CreateMapTool
{
	[Serializable]
	public class Cell
	{
		private Point _coordinates;

		public int Size { get; set; }

		public Point Coordinates
		{
			get
			{
				return _coordinates;
			}
			set
			{
				if (value != null)
					_coordinates = value;
			}
		}

		public int Column { get; set; }

		public int Row { get; set; }

		public bool IsStartPosition { get; set; }

		public bool IsCurrentPosition { get; set; }

		public CellBehavior Behavior { get; set; }

		public Cell(int x, int y)
		{
			_coordinates = new Point(x, y);
		}

		public Cell()
		{
			_coordinates = new Point(0, 0);
		}
	}
}
