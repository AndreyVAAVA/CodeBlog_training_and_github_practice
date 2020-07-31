using System;

namespace CodeBlog_1
{
	class NB : IComponents
	{
		int IComponents.GraphicsCard { get; set; }
		int IComponents.CPU { get; set; }
		int IComponents.RAM { get; set; }
		int IComponents.DriveDevice { get; set; }
		int IComponents.Motherboard { get; set; }
		int IComponents.PowerSupply { get; set; }
		int IComponents.Cooler { get; set; }
	}
}
