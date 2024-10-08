﻿using AutoMapper;
using KoiAuction.Application.Common.Mappings;
using KoiAuction.Domain.Entities;

namespace KoiAuction.Application.User.Queries
{
    public class GetUserAccountResponse : IMapFrom<AspNetUser>
    {
        public string? ID { get; set; }
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; } 

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AspNetUser, GetUserAccountResponse>();      
        }

    }
}
