﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SASRip.Interfaces
{
    public interface ICacheInfo
    {
        public enum Statuses
        {
            Ready = 0,
            Processing = 1,
            Failed = 2
        }
        public DateTime TimeOfCreation { get; set; }
        public Statuses Status { get; set; }
        public string AbsolutePath { get; set; }
    }
}
