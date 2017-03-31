using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateMapTool
{
	[Serializable]
	public enum CellBehavior
	{
		Wall,
		Path,
		Empty,
		EndGoal,
	}
}
