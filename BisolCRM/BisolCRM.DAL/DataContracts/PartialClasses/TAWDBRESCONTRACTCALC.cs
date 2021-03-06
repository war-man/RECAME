﻿using BisolCRM.Common.Constants;
using BisolCRM.DAL.DataContracts;
using BisolCRM.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisolCRM.DAL
{
    public partial class TAWDBRESCONTRACTCALC : ModelBase, IObjectInfo
    {
        #region IObjectInfo

        public long SelfId
        {
            get { return ID; }
        }

        public ObjectTypeEnum SelfType
        {
            get { return ObjectTypeEnum.TAWDBRESCONTRACTCALC; }
        }

        public override bool IsLoggingChanges
        {
            get { return true; }
        }

        public bool IsSendingChanges
        {
            get { return true; }
        }

        #endregion
    }
}
