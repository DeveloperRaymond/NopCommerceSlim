﻿using System;
using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;

namespace Nop.Admin.Models.Common
{
    public partial class MaintenanceModel : BaseNopModel
    {
        public MaintenanceModel()
        {
            DeleteGuests = new DeleteGuestsModel();
            DeleteExportedFiles = new DeleteExportedFilesModel();
        }

        public DeleteGuestsModel DeleteGuests { get; set; }
        public DeleteExportedFilesModel DeleteExportedFiles { get; set; }
        
        #region Nested classes

        public partial class DeleteGuestsModel : BaseNopModel
        {
            [NopResourceDisplayName("Admin.System.Maintenance.DeleteGuests.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [NopResourceDisplayName("Admin.System.Maintenance.DeleteGuests.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            public int? NumberOfDeletedCustomers { get; set; }
        }

        public partial class DeleteExportedFilesModel : BaseNopModel
        {
            [NopResourceDisplayName("Admin.System.Maintenance.DeleteExportedFiles.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [NopResourceDisplayName("Admin.System.Maintenance.DeleteExportedFiles.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }

            public int? NumberOfDeletedFiles { get; set; }
        }

        #endregion
    }
}