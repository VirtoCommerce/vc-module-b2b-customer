﻿using VirtoCommerce.CustomerModule.Data.Search;

namespace VirtoCommerce.B2BCustomerModule.Data.Services
{
    public class MemberSearchServiceDecorator : CustomerModule.Data.Services.MemberSearchServiceDecorator
    {
        public MemberSearchServiceDecorator(CorporateMembersServiceImpl memberSearchService, MemberIndexedSearchService memberIndexedSearchService) 
            : base(memberSearchService, memberIndexedSearchService)
        {
        }
    }
}