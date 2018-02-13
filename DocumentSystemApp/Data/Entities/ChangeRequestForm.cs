using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentSystemApp.Data.Entities
{
    public class ChangeRequestForm : IAudit
    {
        public int ChangeRequestFormId { get; set; }
        #region Initial
        public int CompanyId { get; set; }
        public string SPRS { get; set; }
        public string Version { get; set; }
        public string ChangeRequestID { get; set; }
        public string ChangeRequestDescrpition { get; set; }
        public string ChangeReason { get; set; }
        public bool PriorityEmergency { get; set; }
        public bool PriorityRoutine { get; set; }
        public bool PriorityNextVersion { get; set; }
        public DateTime Date { get; set; }
        public string ReferenceNumber { get; set; }
        public string InitiatedBy { get; set; }
        public DateTime SignatureDate { get; set; }

        #endregion

        #region Evaluation 
        public bool ConfigurationHardware { get; set; }
        public bool ConfigurationSoftware { get; set; }
        public bool ConfigurationSystemDocumentation { get; set; }
        public bool ConfigurationUserTraining { get; set; }
        public bool ConfigurationFirmware { get; set; }


        public bool ChangeType1NewRequirement { get; set; }
        public bool ChangeType1RequirementChange { get; set; }
        public bool ChangeType1DesignChange { get; set; }
        public bool ChangeType1Other { get; set; }
        public bool ChangeType1BugFixing { get; set; }

        public bool ChangeType2Commercial { get; set; }
        public bool ChangeType2Investment { get; set; }
        public string ChangeType2Text { get; set; }

        public bool bImpactAssessmentToA { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentToA { get; set; }
        public bool bImpactAssessmentMA { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentMA { get; set; }
        public bool bImpactAssessmentDC { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentDC { get; set; }
        public bool bImpactAssessmentTtE { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentTtE { get; set; }
        public bool bImpactAssessmentOth { get; set; }
        [DataType(DataType.MultilineText)]
        public string ImpactAssessmentOth { get; set; }

        public bool ChangeAccept { get; set; }
        public bool ChangeReject { get; set; }
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
        [DataType(DataType.MultilineText)]
        public string SummaryofResults { get; set; }
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

        #region IAudit 
        public DateTime CreateDate { get; set; }
        public string CreatorUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdaterUserId { get; set; }
        #endregion
    }
}
