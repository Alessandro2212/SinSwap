﻿using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Customer
{
    /// <summary>
    /// Represents a customer activity log search model
    /// </summary>
    public partial class CustomerActivityLogSearchModel : BaseSearchModel
    {
        #region Properties

        public int CustomerId { get; set; }

        #endregion
    }
}