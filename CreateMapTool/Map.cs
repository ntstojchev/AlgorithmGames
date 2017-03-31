using CreateMapTool.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CreateMapTool
{
	[Serializable]
	public class Map
	{
		private Cell[,] _cells;
		private List<string> _mapSolution;

		[XmlIgnore]
		public Cell[,] Cells
		{
			set
			{
				_cells = value;
			}
			get
			{
				return _cells;
			}
		}

		public List<string> MapSolution
		{
			get
			{
				return _mapSolution;
			}
		}

		public int CellSize { get; set; }

		public int MapSize { get; set; }

		public int CellNumber { get; set; }

		public Cell RobotStartingCell { get; set; }

		public Cell RobotCurrentCell { get; set; }

		public Cell EndGoal { get; set; }

		public Map(int cellSize, int mapSize)
		{
			CellSize = cellSize;
			MapSize = mapSize;
			CellNumber = mapSize / cellSize;

			_cells = new Cell[CellNumber, CellNumber];
			_mapSolution = new List<string>();

			FillCellArray();
		}

		public Map()
		{
			CellSize = 10;
			MapSize = 500;
			CellNumber = MapSize / CellSize;

			_cells = new Cell[CellNumber, CellNumber];
			_mapSolution = new List<string>();

			FillCellArray();
		}

		public void DrawMap(Graphics g, bool isNewTry = false)
		{
			g.Clear(Color.Empty);
			Pen pen = new Pen(Color.Black);

			for (int i = 0; i < CellNumber; i++)
			{
				Cell cell = _cells[i, 0];

				if (isNewTry)
					cell.IsCurrentPosition = false;

				DrawCell(g, cell);

				for (int j = 1; j < CellNumber; j++)
				{
					Cell subCell = _cells[i, j];

					if (isNewTry)
						subCell.IsCurrentPosition = false;

					DrawCell(g, subCell);
				}
			}
		}

		public void DrawCell(Graphics g, Cell cell)
		{
			var pen = new Pen(Color.Black);
			var brush = new SolidBrush(Color.Red);
			
			var size = new Size(cell.Size, cell.Size);

			switch (cell.Behavior)
			{
				case CellBehavior.Path:
					brush.Color = Color.White;
					g.DrawImage(Resources.path2Texture, new Rectangle(cell.Coordinates, size));
					//g.FillRectangle(brush, new Rectangle(cell.Coordinates, size));
					g.DrawRectangle(pen, new Rectangle(cell.Coordinates, size));
					break;
				case CellBehavior.Wall:
					brush.Color = Color.Red;
					g.DrawImage(Resources.wallTexture, new Rectangle(cell.Coordinates, size));
					//g.FillRectangle(brush, new Rectangle(cell.Coordinates, size));
					g.DrawRectangle(pen, new Rectangle(cell.Coordinates, size));
					break;
				case CellBehavior.EndGoal:
					brush.Color = Color.LightGreen;
					g.FillRectangle(brush, new Rectangle(cell.Coordinates, size));
					g.DrawRectangle(pen, new Rectangle(cell.Coordinates, size));

					brush.Color = Color.Blue;
					g.DrawString("ФИНАЛ", new Font("Times New Roman", 8.0f), brush, new PointF(cell.Coordinates.X + (cell.Size / 2 - 21), cell.Coordinates.Y + (cell.Size / 2 - 21)));
					break;
				case CellBehavior.Empty:
					brush.Color = Color.Gray;
					g.DrawImage(Resources.trapPitTexture, new Rectangle(cell.Coordinates, size));
					//g.FillRectangle(brush, new Rectangle(cell.Coordinates, size));
					g.DrawRectangle(pen, new Rectangle(cell.Coordinates, size));
					break;
			}

			if (cell.IsCurrentPosition)
			{
				brush.Color = Color.Blue;
				//g.FillEllipse(brush, cell.Coordinates.X + (cell.Size / 2 - 5), cell.Coordinates.Y + (cell.Size / 2 - 5));//, 10, 10);
				g.DrawImage(Resources.robot, cell.Coordinates.X + (cell.Size / 2 - 17), cell.Coordinates.Y + (cell.Size / 2 - 17));//, 10, 10);
			}
			if (cell.IsStartPosition)
			{
				brush.Color = Color.Red;
				g.DrawString("СТАРТ", new Font("Times New Roman", 8.0f), brush, new PointF(cell.Coordinates.X + (cell.Size / 2 - 21), cell.Coordinates.Y + (cell.Size / 2 - 21)));
				//g.FillEllipse(brush, cell.Coordinates.X + (cell.Size / 2 - 5), cell.Coordinates.Y + (cell.Size / 2 - 5));//, 10, 10);
				g.DrawImage(Resources.robot, cell.Coordinates.X + (cell.Size / 2 - 17), (cell.Coordinates.Y + (cell.Size / 2 - 17)) + 5 );//, 10, 10);
			}

		}

		public Cell GetCell(Point selectedCell)
		{
			for (int i = 0; i < CellNumber; i++)
			{
				for (int j = 0; j < CellNumber; j++)
				{
					Cell cell = _cells[i, j];

					if (Between(selectedCell, cell))
					{
						return cell;
					}
				}
			}

			return null;
		}

		public Cell GetCell(int column, int row)
		{
			try
			{
				return _cells[column, row];
			}
			catch (IndexOutOfRangeException ex)
			{
				return null;
			}
		}

		public void SaveCell(Cell cell)
		{
			_cells[cell.Column, cell.Row] = cell;
		}

		public bool MoveRobot(Graphics g, Cell currentCell, Cell nextCell)
		{
			if (nextCell != null)
			{
				if (nextCell.Behavior == CellBehavior.Wall)
					throw new Exception("Роботът не може да премине през стената.");

				if (nextCell.Behavior == CellBehavior.Empty)
				{
					DrawMap(g, true);
					throw new Exception("Пропаднахте в дупка и роботът се счупва.");
				}

				currentCell.IsCurrentPosition = false;
				SaveCell(currentCell);

				nextCell.IsCurrentPosition = true;

				RobotCurrentCell = nextCell;
				DrawCell(g, currentCell);
				DrawCell(g, nextCell);

				if (nextCell.Behavior == CellBehavior.EndGoal)
					return true;
			}

			return false;
		}

		private bool Between(Point selectedCell, Cell cell)
		{
			return ((selectedCell.X > cell.Coordinates.X)
				&& (selectedCell.Y > cell.Coordinates.Y) &&
				(selectedCell.X < (cell.Coordinates.X + cell.Size))
				&& (selectedCell.Y < (cell.Coordinates.Y + cell.Size)));
		}

		private void FillCellArray()
		{
			int x = 0;
			int y = 0;

			for (int i = 0; i < CellNumber; i++)
			{
				var cell = new Cell(x, y);
				cell.Size = CellSize;
				cell.Column = i;
				cell.Row = 0;
				cell.Behavior = CellBehavior.Empty;

				_cells[i, 0] = cell;

				for (int j = 1; j < CellNumber; j++)
				{
					y += CellSize;
					
					var subCell = new Cell(x, y);
					subCell.Size = CellSize;
					subCell.Column = i;
					subCell.Row = j;
					subCell.Behavior = CellBehavior.Empty;

					_cells[i, j] = subCell;
				}

				x += CellSize;
				y = 0;
			}
		}
	}
}
