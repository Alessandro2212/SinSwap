﻿using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Vendors
{
    /// <summary>
    /// Represents a vendor associated customer model
    /// </summary>
    public partial class VendorAssociatedCustomerModel : BaseNopEntityModel
    {
        #region Properties

        public string Email { get; set; }

        #endregion
    }
}