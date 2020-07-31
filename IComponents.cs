using System;

namespace CodeBlog_1
{
    public interface IComponents
    {
        int GraphicsCard { get; set; }
        int CPU { get; set; }
        int RAM { get; set; }
        int DriveDevice { get; set; }
        int Motherboard { get; set; }
        int PowerSupply { get; set; }
        int Cooler { get; set; }
    }
}
