﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using DigitizingDataDomain.Model;

namespace DigitizingDataBizLayer.Repositories
{
    public class Cbt_infoRepo : RepositoryBase<Cbt_info>
    {
        public Cbt_info checkIfTrainerExists(string Username, String Passkey)
        {
            var trainer = (from t in SessionProxy.Query<Cbt_info>()
                           where t.Username == Username && t.Passkey == Passkey
                           select t).FirstOrDefault();
            return trainer;

        }
    }
}
