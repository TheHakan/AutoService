using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoService
{
    public class NewCarClass
    {
        private string _Name;
        private string _SurName;
        public int CarYear { get; set; }
        public string Mail { get; set; }
        public string CarModel { get; set; }
        public string CarMark { get; set; }
        public string CarPlate { get; set; }
        public int ContactNumber { get; set; }

        public string OwnerName
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Istifadeci adini daxil edin...");
                }

                _Name = value;
            }



        }

        public string SurName
        {
            get
            {
                return _SurName;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Istifadeci soyadini daxil edin...");
                }

                _SurName = value;
            }
        }
        

    }
}
