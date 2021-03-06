﻿using VirtoCommerce.B2BCustomerModule.Core.Model;
using VirtoCommerce.Domain.Commerce.Model;
using VirtoCommerce.Platform.Core.Security;

namespace VirtoCommerce.B2BCustomerModule.Web.Model.Security
{
    public abstract class RegistrationDataBase
    {
        public string StoreId { get; set; }

        public string CompanyName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public string RecaptchaResponse { get; set; }

        public virtual ApplicationUserExtended ToApplicationUserExtended()
        {
            return new ApplicationUserExtended
            {
                StoreId = StoreId,
                Email = Email,
                UserName = UserName,
                Password = Password,
                UserType = AccountType.Customer.ToString(),
                UserState = AccountState.Approved
            };
        }

        public virtual CompanyMember ToCompanyMember(CompanyMember companyMember, string memberId)
        {
            companyMember.Id = memberId;
            companyMember.Name = $"{FirstName} {LastName}";
            companyMember.FullName = $"{FirstName} {LastName}";
            companyMember.FirstName = FirstName;
            companyMember.LastName = LastName;
            companyMember.IsActive = IsActive;
            companyMember.Title = Title;
            companyMember.Emails = new[] { Email };
            Address.FirstName = FirstName;
            Address.LastName = LastName;
            companyMember.Addresses = new[] { Address };
            companyMember.Phones = new[] { Address.Phone };
            return companyMember;
        }
    }
}