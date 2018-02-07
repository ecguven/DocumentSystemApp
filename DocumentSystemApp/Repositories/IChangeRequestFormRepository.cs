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
    }
}
