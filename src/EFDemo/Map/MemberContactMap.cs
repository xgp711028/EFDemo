﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDemo.Entity;

namespace EFDemo.Map
{
    public class MemberContactMap : EntityTypeConfiguration<MemberContact>
    {
        public MemberContactMap()
        {
            ToTable("MemberContacts");

            HasKey(a => a.Id);

            Property(a => a.Id).HasColumnName("MemberId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}