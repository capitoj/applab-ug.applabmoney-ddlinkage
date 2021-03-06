﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using DigitizingDataDomain.Model;
using NHibernate.Criterion;

namespace DigitizingDataBizLayer.Repositories
{
    public class VslaRepo : RepositoryBase<Vsla>
    {
        public Vsla FindVslaByCode(string vslaCode)
        {
            var vsla = (from v in SessionProxy.Query<Vsla>()
                        where v.VslaCode.ToUpper() == vslaCode.ToUpper()
                        select v).FirstOrDefault();
            return vsla;
        }

        public Vsla FindVslaById(int vslaId)
        {
            var vsla = (from v in SessionProxy.Query<Vsla>()
                        where v.VslaId == vslaId
                        select v).FirstOrDefault();
            return vsla;
        }

        // Find vsla by name
        public List<Vsla> FindVslaByName(string vslaName)
        {
            var vsla = (from v in SessionProxy.Query<Vsla>()
                        where v.VslaName.Contains(vslaName.ToLower())
                        select v).ToList();
            return vsla;
        }
        // Count the number of VSLAs
        public long countVslas()
        {
            var vslas = (from v in SessionProxy.Query<Vsla>()
                         select v).Count();
            return vslas;
        }

        // Get all Vslas
        public List<Vsla> findAllVslas()
        {
            var vslas = (from v in SessionProxy.Query<Vsla>()
                         select v).ToList();
            return vslas;
        }
    }
}