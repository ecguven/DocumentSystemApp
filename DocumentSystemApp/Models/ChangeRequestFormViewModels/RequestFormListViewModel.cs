using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystemApp.Models.ChangeRequestFormViewModels
{
    public class RequestFormListViewModel
    {
        public int ChangeRequestFormId { get; set; }

        [DisplayName("Company")]
        public int CompanyId { get; set; }
        [DisplayName("Change Request ID")]
        public string ChangeRequestID { get; set; }
        [DisplayName("Description ")]
        public string ChangeRequestDescrpition { get; set; }
        [DisplayName("Date Required")]
        public DateTime Date { get; set; }
        [DisplayName("Reference Number")]
        public string ReferenceNumber { get; set; }
        [DisplayName("Initiated By")]
        public string InitiatedBy { get; set; }

        [DisplayName("Created UserName")]
        public string CreatedUserName { get; set; }
    }
}
