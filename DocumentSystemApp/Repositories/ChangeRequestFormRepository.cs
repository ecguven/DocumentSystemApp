using DocumentSystemApp.Data;
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


        public ChangeRequestFormRepository(DocumentSystemDbContext appDbContext)
        {
            _appDbContext = appDbContext;
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


    }
}
