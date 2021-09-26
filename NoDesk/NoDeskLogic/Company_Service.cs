using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoDeskDAL;
using NoDeskModels;

namespace NoDeskLogic
{
    public class Company_Service
    {
        private Company_DAL _Company_DAL;

        public Company_Service()
        {
            _Company_DAL = new Company_DAL();
        }

        public void InsertCompany(Company company)
        {
            _Company_DAL.InsertCompany(company);
        }

        public List<Company> GetCompanies()
        {
            return _Company_DAL.GetCompanies();
        }

        public void UpdateCompany(Company company)
        {
            _Company_DAL.UpdateCompany(company);
        }

        public void DeleteCompanyById(User user)
        {
            _Company_DAL.DeleteCompanyById(user);
        }
    }
}
