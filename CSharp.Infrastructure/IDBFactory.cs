﻿using CSharp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        CSharpEntities Init();

    }
}
