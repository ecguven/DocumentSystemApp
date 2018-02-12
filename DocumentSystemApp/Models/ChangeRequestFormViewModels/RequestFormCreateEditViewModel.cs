using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystemApp.Models.ChangeRequestFormViewModels
{
    public class RequestFormCreateEditViewModel
    {
        public int? ChangeRequestFormId { get; set; }
        #region Initial
        public int CompanyId { get; set; }

        [Required]
        [DisplayName("System/Product/Service")]
        public string SPRS { get; set; }

        [Required]
        [DisplayName("Version")]
        public string Version { get; set; }

        [Required]
        [DisplayName("Change Request ID #:")]
        public string ChangeRequestID { get; set; }
        [DisplayName("Description of Change Requested: ")]
        public string ChangeRequestDescrpition { get; set; }
        [DisplayName("Reason for Change")]
        public string ChangeReason { get; set; }
        [DisplayName("Emergency")]
        public bool PriorityEmergency { get; set; }
        [DisplayName("Routine")]
        public bool PriorityRoutine { get; set; }
        [DisplayName("Next Version")]
        public bool PriorityNextVersion { get; set; }
        [DisplayName("Date Required")]
        public DateTime Date { get; set; }
        [DisplayName("Reference Number")]
        public string ReferenceNumber { get; set; }
        [DisplayName("Initiated By")]
        public string InitiatedBy { get; set; }
        [DisplayName("Signature / Date")]
        public DateTime SignatureDate { get; set; }

        #endregion

        #region Evaluation 
        [DisplayName("Hardware")]
        public bool ConfigurationHardware { get; set; }
        [DisplayName("Software")]
        public bool ConfigurationSoftware { get; set; }
        [DisplayName("System Documentation")]
        public bool ConfigurationSystemDocumentation { get; set; }
        [DisplayName("User Training")]
        public bool ConfigurationUserTraining { get; set; }
        [DisplayName("Firmware")]
        public bool ConfigurationFirmware { get; set; }


        [DisplayName("New Requirement")]
        public bool ChangeType1NewRequirement { get; set; }
        [DisplayName("Requirement Change")]
        public bool ChangeType1RequirementChange { get; set; }
        [DisplayName("Design Change")]
        public bool ChangeType1DesignChange { get; set; }
        [DisplayName("Other")]
        public bool ChangeType1Other { get; set; }
        [DisplayName("Bug Fixing")]
        public bool ChangeType1BugFixing { get; set; }

        [DisplayName("Commercial")]
        public bool ChangeType2Commercial { get; set; }
        [DisplayName("Investment")]
        public bool ChangeType2Investment { get; set; }
        [DisplayName("Text")]
        public string ChangeType2Text { get; set; }

        [DisplayName("Type of Software/Hardware/etc. Affected:")]
        public bool bImpactAssessmentToA { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentToA { get; set; }
        [DisplayName("Modules/Screens/Tables/Files Affected:")]
        public bool bImpactAssessmentMA { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentMA { get; set; }
        [DisplayName("Documents to be changed")]
        public bool bImpactAssessmentDC { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentDC { get; set; }
        [DisplayName("Test to execute")]
        public bool bImpactAssessmentTtE { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentTtE { get; set; }
        [DisplayName("Other activities to complete the change")]
        public bool bImpactAssessmentOth { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentOth { get; set; }

        [DisplayName("Accept")]
        public bool ChangeAccept { get; set; }
        [DisplayName("Reject")]
        public bool ChangeReject { get; set; }
        [DisplayName("(Justification):")]
        public string ChangeJustification { get; set; }


        public string CHARole1 { get; set; }
        public string CHAPrintName1 { get; set; }
        public string CHASignatureDate1 { get; set; }
        public string CHARole2 { get; set; }
        public string CHAPrintName2 { get; set; }
        public string CHASignatureDate2 { get; set; }
        public string CHARole3 { get; set; }
        public string CHAPrintName3 { get; set; }
        public string CHASignatureDate3 { get; set; }
        #endregion

        #region Realization and Installation
        [DisplayName("Summary of Results")]
        [DataType(DataType.MultilineText)]
        public string SummaryofResults { get; set; }
        [DisplayName("Attachments:")]
        [DataType(DataType.MultilineText)]
        public string Attachments { get; set; }

        public string FARole1 { get; set; }
        public string FAPrintName1 { get; set; }
        public string FASignatureDate1 { get; set; }
        public string FARole2 { get; set; }
        public string FAPrintName2 { get; set; }
        public string FASignatureDate2 { get; set; }
        public string FARole3 { get; set; }
        public string FAPrintName3 { get; set; }
        public string FASignatureDate3 { get; set; }

        #endregion
    }
}
