﻿using System;
using System.Linq;
using FluentValidation;
using VirtoCommerce.B2BCustomerModule.Core.Model;
using VirtoCommerce.B2BCustomerModule.Core.Model.Search;
using VirtoCommerce.B2BCustomerModule.Core.Resources;
using VirtoCommerce.Domain.Customer.Services;

namespace VirtoCommerce.B2BCustomerModule.Core.Services.Validation
{
    [CLSCompliant(false)]
    public class CompanyMemberValidator : AbstractValidator<CompanyMember>
    {
        public CompanyMemberValidator(IMemberService memberService, IMemberSearchService memberSearchService)
        {
            //CascadeMode = CascadeMode.StopOnFirstFailure;

            //// User must have only one and unique email
            //RuleFor(x => x.Emails).NotNull().Must(e => e.Count == 1).WithMessage(B2BCustomerResources.InvalidEmailCount)
            //.Must(e => memberSearchService.SearchMembers(new CorporateMembersSearchCriteria { Email = e.SingleOrDefault(), MemberType = typeof(CompanyMember).Name }).TotalCount == 0)
            //.WithMessage(string.Format(B2BCustomerResources.EmailAlreadyUsed, Constants.PropertyValue));

            //// User must be a member of one and only one company
            //RuleFor(x => x.Organizations).NotNull().Must(o => o.Count == 1).WithMessage(B2BCustomerResources.InvalidCompanyCount)
            //.Must(o => memberService.GetByIds(new[] { o.SingleOrDefault() }).Length == 1)
            //.WithMessage(string.Format(B2BCustomerResources.CompanyDoesNotExist, string.Format(B2BCustomerResources.WithId, Constants.PropertyValue)));
        }
    }
}