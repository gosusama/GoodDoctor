﻿using DG.API.SERVICE.BuildQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DG.API.SERVICE.Services
{
    public interface IDataSearch
    {
        string DefaultOrder { get; }
        void LoadGeneralParam(string summary);
        List<IQueryFilter> GetFilters();
        
        List<IQueryFilter> GetQuickFilters();
    }
}