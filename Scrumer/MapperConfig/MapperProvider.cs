using AutoMapper;
using Scrumer.Infrastrucutre.Entities;
using Scrumer.Models.ProjectViewModel;
using Scrumer.Models.SprintViewModel;
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
                cfg.CreateMap<User, AddUserViewModel>();
                cfg.CreateMap<User, UserViewModel>();
                cfg.CreateMap<User, EditUserViewModel>();
                cfg.CreateMap<EditUserViewModel, User>();
                cfg.CreateMap<User, DetailsUserViewModel>();

                cfg.CreateMap<Sprint, SprintViewModel>();
                cfg.CreateMap<AddSprintViewModel, Sprint>();
                cfg.CreateMap<Sprint, EditSprintViewModel>();
                cfg.CreateMap<EditSprintViewModel, Sprint>();

                cfg.CreateMap<Project, ProjectViewModel>();
                cfg.CreateMap<ProjectViewModel, Project>();
                cfg.CreateMap<AddProjectViewModel, Project>();
                cfg.CreateMap<Project, DetailsProjectViewModel>();
                cfg.CreateMap<EditProjectViewModel, Project>();
                cfg.CreateMap<Project, EditProjectViewModel>();
            }

            );

            return config;

        }
    }
}