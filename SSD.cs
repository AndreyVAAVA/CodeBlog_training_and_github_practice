using System;

namespace CodeBlog_1
{
    class SSD : IDriveDevice
    {
        public int SIZE { get; set; }

        public int Resorce(int type)
        {
            return type / 100;
        }

        public int Speed(int wsp)
        {
            return SIZE * wsp;
        }
    }
}
