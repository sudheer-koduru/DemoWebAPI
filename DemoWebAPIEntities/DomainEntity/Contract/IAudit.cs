﻿using System;

namespace Demo.Entities.DomainEntity.Contract
{
    public interface IAudit
    {
        string CreatedBy { get; set; }

        DateTime? CreatedDate { get; set; }

        string UpdatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }
    }
}
