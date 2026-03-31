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

        public double GetValue()
        {
            return this.value;
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
                    typeVerbose = "б";
                    break;
            }
            return String.Format("{0} {1}", Math.Round(this.value, 6), typeVerbose);
        }

        public Volume To(VolumeType newType)
        {
            double newValue = this.value;
           
            if (this.type == VolumeType.m3)
            {
                switch (newType)
                {
                    case VolumeType.m3:
                        newValue = this.value;
                        break;
                    case VolumeType.ml:
                        newValue = this.value / 0.000001;
                        break;
                    case VolumeType.l:
                        newValue = this.value / 0.001;
                        break;
                    case VolumeType.barr:
                        newValue = this.value / 0.158987;
                        break;
                }
            }
            else if (newType == VolumeType.m3)
            {     
                switch (this.type)
                {
                    case VolumeType.m3:
                        newValue = this.value;
                        break;
                    case VolumeType.ml:
                        newValue = this.value * 0.000001;
                        break;
                    case VolumeType.l:
                        newValue = this.value * 0.001;
                        break;
                    case VolumeType.barr:
                        newValue = this.value * 0.158987;
                        break;
                }
            }
            else
            {              
                newValue = this.To(VolumeType.m3).To(newType).value;
            }

            return new Volume(newValue, newType);
        }
    }
}
