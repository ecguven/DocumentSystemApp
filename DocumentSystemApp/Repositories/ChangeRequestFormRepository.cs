using AutoMapper;
using DocumentSystemApp.Data;
using DocumentSystemApp.Data.Entities;
using DocumentSystemApp.Models.ChangeRequestFormViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystemApp.Repositories
{
    public class ChangeRequestFormRepository : IChangeRequestFormRepository
    {
        private readonly DocumentSystemDbContext _appDbContext;
        private readonly IMapper _mapper;


        public ChangeRequestFormRepository(DocumentSystemDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public IEnumerable<RequestFormListViewModel> ChangeRequestFormLists()
        {
            var result = _appDbContext.ChangeRequestForms.Select(x => new RequestFormListViewModel
            {
                ChangeRequestFormId=x.ChangeRequestFormId,
                ChangeRequestID = x.ChangeRequestID,
                ChangeRequestDescrpition = x.ChangeRequestDescrpition,
                CompanyId = x.CompanyId,
                Date = x.Date,
                InitiatedBy=x.InitiatedBy,
                ReferenceNumber = x.ReferenceNumber,
                CreatedUserName = _appDbContext.Users.FirstOrDefault(y=>y.Id == x.CreatorUserId).UserName
            });

            return result;
        }

        public RequestFormCreateEditViewModel GetById(int id)
        {
            var changeForm = _appDbContext.ChangeRequestForms.FirstOrDefault(x => x.ChangeRequestFormId == id);
            if (changeForm != null)
            {
                var model = _mapper.Map<ChangeRequestForm, RequestFormCreateEditViewModel>(changeForm);
                return model;
            }

            return null;
        }


    }
}
