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
    public class GroupSupportRepo : RepositoryBase<GroupSupport>
    {
        public List<GroupSupport> findAllGroupSupport()
        {
            var groupSupport = (from gs in SessionProxy.Query<GroupSupport>()
                                select gs).ToList();
            return groupSupport;
        }
    }
}
