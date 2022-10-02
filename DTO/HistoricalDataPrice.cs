using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrapiSDK.DTO
{
	public class HistoricalDataPrice
	{
		public int date { get; set; }
		public float open { get; set; }
		public float high { get; set; }
		public float low { get; set; }
		public float close { get; set; }
		public long volume { get; set; }
	}
}
