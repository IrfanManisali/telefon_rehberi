using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace telefon_rehberi
{
    class Kisi
    {
        private string ad;
        private string soyad;
        private string telNo;
        public string Ad {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public string TelNo {
            get
            {
                return telNo;
            }
            set
            {
                telNo = value;
            }
        }
        public Kisi()
        {
            this.Ad = "*";
            this.Soyad = "*";
            this.TelNo = "*";
        }
        public Kisi(string ad, string soyad, string telNo) 
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.TelNo = telNo;
        }
    }
}