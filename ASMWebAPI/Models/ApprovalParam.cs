﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASMWebAPI.Models
{
    public class ApprovalParam
    {
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public string approved { get; set; }
    }
}