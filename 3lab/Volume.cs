using System;
using System.Collections.Generic;
using System.Text;

namespace _3lab
{
    public enum VolumeType { m3, ml, l, barr };
    public class Volume
    {
        private double value;
        private VolumeType type;

        public Volume(double value, VolumeType type)
        {
            this.value = value;
            this.type = type;
        }

        public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case VolumeType.m3:
                    typeVerbose = "м3";
                    break;
                case VolumeType.ml:
                    typeVerbose = "мл";
                    break;
                case VolumeType.l:
                    typeVerbose = "л";
                    break;
                case VolumeType.barr:
                    typeVerbose = "барр";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }
    }
}
