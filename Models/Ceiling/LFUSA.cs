﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class LFUSA : IModel
    {
        public int LFUSAId { get; set; }
        public int ModuleTreeId { get; set; }
        //基本参数
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public int SuNo { get; set; }
        public decimal SuDia { get; set; }//200/250
        public decimal SuDis { get; set; }
        public string SidePanel { get; set; }
        public string Japan { get; set; }
    }
}
