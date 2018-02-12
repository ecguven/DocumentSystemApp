using DocumentSystemApp.Data.Entities;
using DocumentSystemApp.Models.ChangeRequestFormViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystemApp.Repositories
{
    public interface IChangeRequestFormRepository
    {
        IEnumerable<RequestFormListViewModel> ChangeRequestFormLists();
        ChangeRequestForm GetById(int id);
        void Create(ChangeRequestForm requestFormModel);
        void Update(ChangeRequestForm requestFormModel);
    }
}
