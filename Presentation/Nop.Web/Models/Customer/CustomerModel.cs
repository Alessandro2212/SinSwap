﻿using FluentValidation.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.Catalog;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nop.Web.Models.Customer
{
    /// <summary>
    /// Represents a customer model
    /// </summary>
    [Validator(typeof(Validators.Customer.CustomerValidator))]
    public partial class CustomerModel : BaseNopEntityModel, IAclSupportedModel
    {
        #region Ctor

        public CustomerModel()
        {
            this.AvailableTimeZones = new List<SelectListItem>();
            this.SendEmail = new SendEmailModel() { SendImmediately = true };
            this.SendPm = new SendPmModel();

            this.SelectedCustomerRoleIds = new List<int>();
            this.AvailableCustomerRoles = new List<SelectListItem>();

            this.AssociatedExternalAuthRecords = new List<CustomerAssociatedExternalAuthModel>();
            this.AvailableCountries = new List<SelectListItem>();
            this.AvailableStates = new List<SelectListItem>();
            this.AvailableVendors = new List<SelectListItem>();
            this.CustomerAttributes = new List<CustomerAttributeModel>();
            this.AvailableNewsletterSubscriptionStores = new List<SelectListItem>();
            this.SelectedNewsletterSubscriptionStoreIds = new List<int>();
            this.AddRewardPoints = new AddRewardPointsToCustomerModel();
            this.CustomerRewardPointsSearchModel = new CustomerRewardPointsSearchModel();
            this.CustomerAddressSearchModel = new CustomerAddressSearchModel();
            this.CustomerOrderSearchModel = new CustomerOrderSearchModel();
            this.CustomerShoppingCartSearchModel = new CustomerShoppingCartSearchModel();
            this.CustomerActivityLogSearchModel = new CustomerActivityLogSearchModel();
            this.CustomerBackInStockSubscriptionSearchModel = new CustomerBackInStockSubscriptionSearchModel();
        }

        #endregion

        #region Properties

        public bool UsernamesEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Username")]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Email")]
        public string Email { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Password")]
        [DataType(DataType.Password)]
        [NoTrim]
        public string Password { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Vendor")]
        public int VendorId { get; set; }

        public IList<SelectListItem> AvailableVendors { get; set; }

        //form fields & properties
        public bool GenderEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Gender")]
        public string Gender { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.FirstName")]
        public string FirstName { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.LastName")]
        public string LastName { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.FullName")]
        public string FullName { get; set; }

        public bool DateOfBirthEnabled { get; set; }

        [UIHint("DateNullable")]
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        public bool CompanyEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Company")]
        public string Company { get; set; }

        public bool StreetAddressEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.StreetAddress")]
        public string StreetAddress { get; set; }

        public bool StreetAddress2Enabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.StreetAddress2")]
        public string StreetAddress2 { get; set; }

        public bool ZipPostalCodeEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.ZipPostalCode")]
        public string ZipPostalCode { get; set; }

        public bool CityEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.City")]
        public string City { get; set; }

        public bool CountyEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.County")]
        public string County { get; set; }

        public bool CountryEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Country")]
        public int CountryId { get; set; }

        public IList<SelectListItem> AvailableCountries { get; set; }

        public bool StateProvinceEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.StateProvince")]
        public int StateProvinceId { get; set; }

        public IList<SelectListItem> AvailableStates { get; set; }

        public bool PhoneEnabled { get; set; }

        [DataType(DataType.PhoneNumber)]
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Phone")]
        public string Phone { get; set; }

        public bool FaxEnabled { get; set; }

        [DataType(DataType.PhoneNumber)]
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Fax")]
        public string Fax { get; set; }

        public List<CustomerAttributeModel> CustomerAttributes { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.RegisteredInStore")]
        public string RegisteredInStore { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.IsTaxExempt")]
        public bool IsTaxExempt { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Active")]
        public bool Active { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Affiliate")]
        public int AffiliateId { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Affiliate")]
        public string AffiliateName { get; set; }

        //time zone
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.TimeZoneId")]
        public string TimeZoneId { get; set; }

        public bool AllowCustomersToSetTimeZone { get; set; }

        public IList<SelectListItem> AvailableTimeZones { get; set; }

        //EU VAT
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.VatNumber")]
        public string VatNumber { get; set; }

        public string VatNumberStatusNote { get; set; }

        public bool DisplayVatNumber { get; set; }

        //registration date
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.LastActivityDate")]
        public DateTime LastActivityDate { get; set; }

        //IP address
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.IPAddress")]
        public string LastIpAddress { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.LastVisitedPage")]
        public string LastVisitedPage { get; set; }

        //customer roles
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.CustomerRoles")]
        public string CustomerRoleNames { get; set; }

        public IList<SelectListItem> AvailableCustomerRoles { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.CustomerRoles")]
        public IList<int> SelectedCustomerRoleIds { get; set; }

        //newsletter subscriptions (per store)
        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Newsletter")]
        public IList<SelectListItem> AvailableNewsletterSubscriptionStores { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.Fields.Newsletter")]
        public IList<int> SelectedNewsletterSubscriptionStoreIds { get; set; }

        //reward points history
        public bool DisplayRewardPointsHistory { get; set; }

        public AddRewardPointsToCustomerModel AddRewardPoints { get; set; }

        public CustomerRewardPointsSearchModel CustomerRewardPointsSearchModel { get; set; }

        //send email model
        public SendEmailModel SendEmail { get; set; }

        //send PM model
        public SendPmModel SendPm { get; set; }

        //send the welcome message
        public bool AllowSendingOfWelcomeMessage { get; set; }

        //re-send the activation message
        public bool AllowReSendingOfActivationMessage { get; set; }

        //GDPR enabled
        public bool GdprEnabled { get; set; }

        [NopResourceDisplayName("Admin.Customers.Customers.AssociatedExternalAuth")]
        public IList<CustomerAssociatedExternalAuthModel> AssociatedExternalAuthRecords { get; set; }

        public string AvatarUrl { get; internal set; }

        public CustomerAddressSearchModel CustomerAddressSearchModel { get; set; }

        public CustomerOrderSearchModel CustomerOrderSearchModel { get; set; }

        public CustomerShoppingCartSearchModel CustomerShoppingCartSearchModel { get; set; }

        public CustomerActivityLogSearchModel CustomerActivityLogSearchModel { get; set; }

        public CustomerBackInStockSubscriptionSearchModel CustomerBackInStockSubscriptionSearchModel { get; set; }

        #endregion

        #region Nested classes

        public partial class SendEmailModel : BaseNopModel
        {
            [NopResourceDisplayName("Admin.Customers.Customers.SendEmail.Subject")]
            public string Subject { get; set; }

            [NopResourceDisplayName("Admin.Customers.Customers.SendEmail.Body")]
            public string Body { get; set; }

            [NopResourceDisplayName("Admin.Customers.Customers.SendEmail.SendImmediately")]
            public bool SendImmediately { get; set; }

            [NopResourceDisplayName("Admin.Customers.Customers.SendEmail.DontSendBeforeDate")]
            [UIHint("DateTimeNullable")]
            public DateTime? DontSendBeforeDate { get; set; }
        }

        public partial class SendPmModel : BaseNopModel
        {
            [NopResourceDisplayName("Admin.Customers.Customers.SendPM.Subject")]
            public string Subject { get; set; }

            [NopResourceDisplayName("Admin.Customers.Customers.SendPM.Message")]
            public string Message { get; set; }
        }

        public partial class CustomerAttributeModel : BaseNopEntityModel
        {
            public CustomerAttributeModel()
            {
                Values = new List<CustomerAttributeValueModel>();
            }

            public string Name { get; set; }

            public bool IsRequired { get; set; }

            /// <summary>
            /// Default value for textboxes
            /// </summary>
            public string DefaultValue { get; set; }

            public AttributeControlType AttributeControlType { get; set; }

            public IList<CustomerAttributeValueModel> Values { get; set; }
        }

        public partial class CustomerAttributeValueModel : BaseNopEntityModel
        {
            public string Name { get; set; }

            public bool IsPreSelected { get; set; }
        }

        #endregion
    }
}