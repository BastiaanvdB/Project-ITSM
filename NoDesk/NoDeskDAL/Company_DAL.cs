﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoDeskModels;
using MongoDB.Driver;
namespace NoDeskDAL
{
    public class Company_DAL : Base
    {
        public void InsertCompany(Company company)
        {
            InsertRecord("Companies", company);
        }

        public List<Company> GetCompanies()
        {
            return LoadRecords<Company>("Companies");
        }

        public void UpdateCompany(Company company)
        {
            var update = Builders<Company>.Update
                .Set(P => P.CompanyName, company.CompanyName)
                .Set(P => P.ActivationKey, company.ActivationKey);
            UpdateRecordById("Companies", company.Id, update);
        }

        public void DeleteCompanyById(User user)
        {
            DeleteRecordById<User>("Users", user.Id);
        }
    }
}
