using AutoMapper;
using Scrumer.Infrastrucutre.Entities;
using Scrumer.Models.UserViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrumer.MapperConfig
{
    public static class MapperProvider
    {
        public static MapperConfiguration Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {

                cfg.CreateMap<AddUserViewModel, User>();
                cfg.CreateMap<User, UserViewModel>();
                cfg.CreateMap<User, EditUserViewModel>();
                cfg.CreateMap<EditUserViewModel, User>();
            }

            );

            return config;

        }
    }
}