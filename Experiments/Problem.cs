using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Experiments
{
	[Serializable]
	public class Problem
	{
		private List<string> _experimentSolution;
		private List<string> _picturesImageList;
		private List<string> _pictureNames;

		public string ExperimentLink { get; set; }

		public string ExperimentExtraInfo { get; set; }

		public string ExperimentName { get; set; }

		public List<string> ExperimentSolution
		{
			get
			{
				return _experimentSolution;
			}
		}

		public List<string> PictureNames
		{
			get
			{
				return _pictureNames;
			}
		}

		public List<String> PicturesImageList
		{
			get
			{
				return _picturesImageList;
			}
		}

		public int ExperimentSteps { get; set; }

		public Problem()
		{
			_experimentSolution = new List<string>();
			_picturesImageList = new List<string>();
			_pictureNames = new List<string>();
		}

		public ImageList GetImageList()
		{
			if (_pictureNames.Count == _picturesImageList.Count)
			{
				ImageList imageList = new ImageList();
				imageList.ImageSize = new Size(96, 96);

				for (int i = 0; i < _pictureNames.Count; i++)
				{
					byte[] array = Convert.FromBase64String(_picturesImageList[i]);
					Image image = Image.FromStream(new MemoryStream(array));
					imageList.Images.Add(_pictureNames[i], image);
				}

				return imageList;
			}
			else
				throw new Exception("Error in parsing names and images.");
		}
	}
}
