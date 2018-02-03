using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystemApp.Data.Entities
{
    public interface IAudit
    {
        DateTime CreateDate { get; set; }
        string CreatorUserId { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdaterUserId { get; set; }
    }
}
