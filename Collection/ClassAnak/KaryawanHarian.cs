﻿using Collection.ClassInduk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.ClassAnak
{
    class KaryawanHarian : Karyawan 
    {
        public int UpahPerJam { get; set; }
        public int JumlahJamKerja { get; set; }
        public override double Gaji()
        {
            return UpahPerJam * JumlahJamKerja;
        }
    }
}
