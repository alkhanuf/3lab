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


        public static Volume operator +(Volume val, double number)
        {
            return new Volume(val.value + number, val.type);
        }

        public static Volume operator +(double number, Volume val)
        {
            return val + number;
        }



        public static Volume operator -(Volume val, double number)
        {
            return new Volume(val.value - number, val.type);
        }

        public static Volume operator -(double number, Volume val)
        {
            return new Volume(number - val.value, val.type);
        }


        public static Volume operator *(Volume val, double number)
        {
            return new Volume(val.value * number, val.type);
        }

        public static Volume operator *(double number, Volume val)
        {
            return val * number;
        }



        public static Volume operator /(Volume val, double number)
        {
            return new Volume(val.value / number, val.type);
        }

        public static Volume operator /(double number, Volume val)
        {            
            return new Volume(number / val.value, val.type);
        }



        public static Volume operator +(Volume val1, Volume val2)
        {
            return val1 + val2.To(val1.type).value;
        }


        public static Volume operator -(Volume val1, Volume val2)
        {
            return val1 - val2.To(val1.type).value;
        }



        public static bool operator >(Volume val1, Volume val2)
        {
            double value1InM3 = val1.To(VolumeType.m3).value;
            double value2InM3 = val2.To(VolumeType.m3).value;
            return value1InM3 > value2InM3;
        }

        public static bool operator <(Volume val1, Volume val2)
        {
            double value1InM3 = val1.To(VolumeType.m3).value;
            double value2InM3 = val2.To(VolumeType.m3).value;
            return value1InM3 < value2InM3;
        }

        public static bool operator >=(Volume val1, Volume val2)
        {
            return val1 > val2 || val1 == val2;
        }

        public static bool operator <=(Volume val1, Volume val2)
        {
            return val1 < val2 || val1 == val2;
        }

        public static bool operator ==(Volume val1, Volume val2)
        {
            if (ReferenceEquals(val1, null) || ReferenceEquals(val2, null))
            {
                return ReferenceEquals(val1, val2);
            }
               

            double value1InM3 = val1.To(VolumeType.m3).value;
            double value2InM3 = val2.To(VolumeType.m3).value;
            return Math.Abs(value1InM3 - value2InM3) < 0.000001;
        }

        public static bool operator !=(Volume val1, Volume val2)
        {
            return !(val1 == val2);
        }
    }
}
