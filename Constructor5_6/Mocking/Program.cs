﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor5_6.Mocking
{
    public static void Main()
    {
        var service = new VideoService();
        var title = service.ReadVideoTitle();
    }
}
