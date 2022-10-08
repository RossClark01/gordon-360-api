﻿using Gordon360.Authorization;
using Gordon360.Models.CCT.Context;
using Gordon360.Exceptions;
using Gordon360.Models.CCT;
using Gordon360.Models.ViewModels;
using Gordon360.Static.Names;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gordon360.Services
{

    /// <summary>
    /// Service Class that facilitates data transactions between the AccountsController and the Account database model.
    /// </summary>
    public class AccountService : IAccountService
    {
        private readonly CCTContext _context;

        public AccountService(CCTContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Fetches a single account record whose id matches the id provided as an argument
        /// </summary>
        /// <param name="id">The person's gordon id</param>
        /// <returns>AccountViewModel if found, null if not found</returns>
        [StateYourBusiness(operation = Operation.READ_ONE, resource = Resource.ACCOUNT)]
        public AccountViewModel GetAccountByID(string id)
        {
            var account = _context.ACCOUNT.FirstOrDefault(x => x.gordon_id == id);
            if (account == null)
            {
                // Custom Exception is thrown that will be cauth in the controller Exception filter.
                throw new ResourceNotFoundException() { ExceptionMessage = "The Account was not found." };
            }

            return account;
        }

        /// <summary>
        /// Fetches all the account records from storage.
        /// </summary>
        /// <returns>AccountViewModel IEnumerable. If no records were found, an empty IEnumerable is returned.</returns>
        [StateYourBusiness(operation = Operation.READ_ALL, resource = Resource.ACCOUNT)]
        public IEnumerable<AccountViewModel> GetAll()
        {
            return (IEnumerable<AccountViewModel>)_context.ACCOUNT; //Map the database model to a more presentable version (a ViewModel)
        }

        /// <summary>
        /// Fetches the account record with the specified email.
        /// </summary>
        /// <param name="email">The email address associated with the account.</param>
        /// <returns>the student account information</returns>
        public AccountViewModel GetAccountByEmail(string email)
        {
            var account = _context.ACCOUNT.FirstOrDefault(x => x.email == email);
            if (account == null)
            {
                throw new ResourceNotFoundException() { ExceptionMessage = "The Account was not found." };
            }

            return account;
        }

        /// <summary>
        /// Fetches the account record with the specified username.
        /// </summary>
        /// <param name="username">The AD username associated with the account.</param>
        /// <returns>the student account information</returns>
        public AccountViewModel GetAccountByUsername(string username)
        {
            var account = _context.ACCOUNT.FirstOrDefault(x => x.AD_Username == username);
            if (account == null)
            {
                throw new ResourceNotFoundException() { ExceptionMessage = "The Account was not found." };
            }

            return account;
        }

        /// <summary>
        /// Given a list of accounts, and search params, return all the accounts that match those search params.
        /// </summary>
        /// <param name="accounts">The accounts that should be searched, converted to an AdvancedSearchViewModel</param>
        /// <param name="firstname">The firstname search param</param>
        /// <param name="lastname">The lastname search param</param>
        /// <param name="major">The major search param</param>
        /// <param name="minor">The minor search param</param>
        /// <param name="hall">The hall search param</param>
        /// <param name="classType">The class type search param, e.g. 'Sophomore', 'Senior', 'Undergraduate Conferred'</param>
        /// <param name="homeCity">The home city search param</param>
        /// <param name="state">The state search param</param>
        /// <param name="country">The country search param</param>
        /// <param name="department">The department search param</param>
        /// <param name="building">The building search param</param>
        /// <returns>The accounts from the provided list that match the given search params</returns>
        public IEnumerable<AdvancedSearchViewModel> AdvancedSearch(
            IEnumerable<AdvancedSearchViewModel> accounts,
            string firstname,
            string lastname,
            string major,
            string minor,
            string hall,
            string classType,
            string homeCity,
            string state,
            string country,
            string department,
            string building)
        {
            // Accept common town abbreviations in advanced people search
            // East = E, West = W, South = S, North = N
            if (
                !string.IsNullOrEmpty(homeCity)
                && (
                  homeCity.StartsWith("e ") ||
                  homeCity.StartsWith("w ") ||
                  homeCity.StartsWith("s ") ||
                  homeCity.StartsWith("n ")
                )
              )
            {
                homeCity =
                    homeCity
                        .Replace("e ", "east ")
                        .Replace("w ", "west ")
                        .Replace("s ", "south ")
                        .Replace("n ", "north ");
            }

            return accounts
                .Where(a =>
                       (
                               a.FirstName.ToLower().StartsWith(firstname)
                            || a.NickName.ToLower().StartsWith(firstname)
                       )
                    && (
                               a.LastName.ToLower().StartsWith(lastname)
                            || a.MaidenName.ToLower().StartsWith(lastname)
                       )
                    && (
                               a.Major1Description == major
                            || a.Major2Description == major
                            || a.Major3Description == major
                       )
                    && (
                               a.Minor1Description == minor
                            || a.Minor2Description == minor
                            || a.Minor3Description == minor
                       )
                    && a.Hall.StartsWith(hall)
                    && a.Class.StartsWith(classType)
                    && a.HomeCity.ToLower().StartsWith(homeCity)
                    && a.HomeState.StartsWith(state)
                    && a.Country.StartsWith(country)
                    && a.OnCampusDepartment.StartsWith(department)
                    && a.BuildingDescription.StartsWith(building)
                )
                .OrderBy(a => a.LastName)
                .ThenBy(a => a.FirstName);
        }

        /// <summary>
        /// Get the list of accounts a user can search, based on the types of accounts they want to search, their authorization, and whether they're searching sensitive info.
        /// </summary>
        /// <param name="accountTypes">A list of account types that will be searched: 'student', 'alumni', and/or 'facstaff'</param>
        /// <param name="authGroups">The authorization groups of the searching user, to decide what accounts they are permitted to search</param>
        /// <param name="homeCity">The home city search param, since it is considered sensitive info</param>
        /// <returns>The list of accounts that may be searched, converted to AdvancedSearchViewModels.</returns>
        public IEnumerable<AdvancedSearchViewModel> GetAccountsToSearch(List<string> accountTypes, IEnumerable<AuthGroup> authGroups, string homeCity)
        {
            IEnumerable<Student> students = Enumerable.Empty<Student>();
            if (accountTypes.Contains("student")
                // Only students and FacStaff are authorized to search for students
                && (authGroups.Contains(AuthGroup.FacStaff) || authGroups.Contains(AuthGroup.Student)))
            {
                students = _context.Student;
            }

            // Only Faculy and Staff can see Private students
            if (!authGroups.Contains(AuthGroup.FacStaff))
            {
                students = students.Where(s => s.KeepPrivate != "P");
            }

            IEnumerable<FacStaff> facstaff = Enumerable.Empty<FacStaff>();
            if (accountTypes.Contains("facstaff"))
            {
                facstaff = _context.FacStaff;
            }

            IEnumerable<Alumni> alumni = Enumerable.Empty<Alumni>();
            if (accountTypes.Contains("alumni"))
            {
                alumni = _context.Alumni;
            }

            // Do not indirectly reveal the address of facstaff and alumni who have requested to keep it private.
            if (!string.IsNullOrEmpty(homeCity))
            {
                facstaff = facstaff.Where(a => a.KeepPrivate == "0");
                alumni = alumni.Where(a => a.ShareAddress != "N");
            }

            return students.Select<Student, AdvancedSearchViewModel>(s => s)
                .UnionBy(facstaff.Select<FacStaff, AdvancedSearchViewModel>(fs => fs), a => a.AD_Username)
                .UnionBy(alumni.Select<Alumni, AdvancedSearchViewModel>(a => a), a => a.AD_Username);
        }

        /// <summary>
        /// Get basic info for all accounts
        /// </summary>
        /// <returns>BasicInfoViewModel of all accounts</returns>
        public async Task<IEnumerable<BasicInfoViewModel>> GetAllBasicInfoAsync()
        {

            var basicInfo = await _context.Procedures.ALL_BASIC_INFOAsync();
            return basicInfo.Select(
                b => new BasicInfoViewModel
                {
                    FirstName = b.FirstName,
                    LastName = b.LastName,
                    Nickname = b.Nickname,
                    UserName = b.UserName
                });
        }

        /// <summary>
        /// Get basic info for all accounts except alumni
        /// </summary>
        /// <returns>BasicInfoViewModel of all accounts except alumni</returns>
        public async Task<IEnumerable<BasicInfoViewModel>> GetAllBasicInfoExceptAlumniAsync()
        {
            var basicInfo = await _context.Procedures.ALL_BASIC_INFO_NOT_ALUMNIAsync();
            return basicInfo.Select(
                b => new BasicInfoViewModel
                {
                    FirstName = b.firstname,
                    LastName = b.lastname,
                    Nickname = b.Nickname,
                    UserName = b.Username
                });
        }
    }
}