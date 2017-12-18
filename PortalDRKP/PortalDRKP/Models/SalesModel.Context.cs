﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalDRKP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SalesEntities : DbContext
    {
        public SalesEntities()
            : base("name=SalesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<UserSpr> MapFindSpr(string nameru)
        {
            var nameruParameter = nameru != null ?
                new ObjectParameter("nameru", nameru) :
                new ObjectParameter("nameru", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserSpr>("MapFindSpr", nameruParameter);
        }
    
        public virtual int MapUserUpd(string firstNameRU, string lastNameRU, string firstNameEn, string lastNameEn, string domainName, string mail, Nullable<int> userID, Nullable<int> iD1C, string iDCRM, string staffCode, string empDate, string dismissDate)
        {
            var firstNameRUParameter = firstNameRU != null ?
                new ObjectParameter("FirstNameRU", firstNameRU) :
                new ObjectParameter("FirstNameRU", typeof(string));
    
            var lastNameRUParameter = lastNameRU != null ?
                new ObjectParameter("LastNameRU", lastNameRU) :
                new ObjectParameter("LastNameRU", typeof(string));
    
            var firstNameEnParameter = firstNameEn != null ?
                new ObjectParameter("FirstNameEn", firstNameEn) :
                new ObjectParameter("FirstNameEn", typeof(string));
    
            var lastNameEnParameter = lastNameEn != null ?
                new ObjectParameter("LastNameEn", lastNameEn) :
                new ObjectParameter("LastNameEn", typeof(string));
    
            var domainNameParameter = domainName != null ?
                new ObjectParameter("DomainName", domainName) :
                new ObjectParameter("DomainName", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("Mail", mail) :
                new ObjectParameter("Mail", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            var iD1CParameter = iD1C.HasValue ?
                new ObjectParameter("ID1C", iD1C) :
                new ObjectParameter("ID1C", typeof(int));
    
            var iDCRMParameter = iDCRM != null ?
                new ObjectParameter("IDCRM", iDCRM) :
                new ObjectParameter("IDCRM", typeof(string));
    
            var staffCodeParameter = staffCode != null ?
                new ObjectParameter("StaffCode", staffCode) :
                new ObjectParameter("StaffCode", typeof(string));
    
            var empDateParameter = empDate != null ?
                new ObjectParameter("EmpDate", empDate) :
                new ObjectParameter("EmpDate", typeof(string));
    
            var dismissDateParameter = dismissDate != null ?
                new ObjectParameter("dismissDate", dismissDate) :
                new ObjectParameter("dismissDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MapUserUpd", firstNameRUParameter, lastNameRUParameter, firstNameEnParameter, lastNameEnParameter, domainNameParameter, mailParameter, userIDParameter, iD1CParameter, iDCRMParameter, staffCodeParameter, empDateParameter, dismissDateParameter);
        }
    }
}