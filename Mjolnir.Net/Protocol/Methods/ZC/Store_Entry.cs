﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mjolnir.Net.Protocol.Methods.ZC
{
    [Method(methodId: 0x0131, size: 86, name: "ZC_STORE_ENTRY", direction: MethodAttribute.packetdirection.pd_in)]
    public class Store_Entry : IMethodIn
    {
        public void Parse(Header header, byte[] data)
        {
        }
    }
}