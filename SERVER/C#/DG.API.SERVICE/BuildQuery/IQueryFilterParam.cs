﻿using System.Collections.Generic;

namespace DG.API.SERVICE.BuildQuery
{
    public interface IQueryFilterParam
    {
        int Count { get; set; }
        List<object> Params { get; set; }

        string GetNextParam(object param = null);
    }
}