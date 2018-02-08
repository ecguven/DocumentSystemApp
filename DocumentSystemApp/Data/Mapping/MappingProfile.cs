using AutoMapper;
using DocumentSystemApp.Data.Entities;
using DocumentSystemApp.Models.ChangeRequestFormViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystemApp.Data.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<ChangeRequestForm, RequestFormCreateEditViewModel>();
            CreateMap<RequestFormCreateEditViewModel, ChangeRequestForm>();
        }
    }
}
