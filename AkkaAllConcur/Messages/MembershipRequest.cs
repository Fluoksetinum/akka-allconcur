﻿using System;
using System.Collections.Generic;
using System.Text;
using AkkaAllConcur.Configuration;

namespace AkkaAllConcur.Messages
{
    class MembershipRequest
    {
        public Host NewHost { get; private set; }
        public MembershipRequest(Host nh)
        {
            NewHost = nh;
        }
    }
}
