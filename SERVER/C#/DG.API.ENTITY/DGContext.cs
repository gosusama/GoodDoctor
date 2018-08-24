using DG.API.ENTITY.Models;
using DG.API.ENTITY.Models.Authorize;
using DG.API.ENTITY.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.ENTITY
{
    class DGContext : DataContext
    {
        public DGContext() : base("name=DGDB")
        {

        }

        //Auth
        public DbSet<AU_GROUP_PERMISION> AU_GROUP_PERMISIONs { get; set; }
        public DbSet<AU_GRP_PERMISION_FUNC> AU_GRP_PERMISION_FUNCs { get; set; }
        public DbSet<AU_USER_GROUP_PERMISION> AU_USER_GROUP_PERMISIONs { get; set; }
        public DbSet<AU_USER_PERMISION> AU_USER_PERMISIONs { get; set; }

        //Data
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Diseases> Diseases { get; set; }
        public DbSet<DiseasesType> DiseasesTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
