
using App.Application.Student.Prf.Models;
using App.Persistence.Context;
using Clean.Common.Dates;
using Clean.Common.Service;
using Clean.Persistence.Identity;
using Clean.Persistence.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace App.Application.Student.Prf.Queries
{
    public class SearchProfileQuery : IRequest<IEnumerable<SearchProfileModel>>

    {
        public decimal? ID { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public int? ProcessID { get; set; }
        public bool? InitialProcess { get; set; }

    }

    public class SearchProfileQueryHandler : IRequestHandler<SearchProfileQuery, IEnumerable<SearchProfileModel>>
    {
        private readonly AppDbContext context;
        private ICurrentUser User;

        private AppIdentityDbContext IDContext;

        public SearchProfileQueryHandler(AppDbContext context, ICurrentUser currentUser, AppIdentityDbContext idContext)
        {
            this.context = context;
            User = currentUser;
            IDContext = idContext;
        }
        public async Task<IEnumerable<SearchProfileModel>> Handle(SearchProfileQuery request, CancellationToken cancellationToken)
        {
            var query = context.Profiles.AsQueryable();
            if (request.ProcessID.HasValue)
            {
                if (request.InitialProcess.HasValue && request.InitialProcess.Value)
                {
                    query = (from f in query
                             join q in context.ProfileProcesses on f.Id equals q.ID
                             where q.ApplicationID == null || q.ProcessID == request.ProcessID
                             select f);
                }
                else
                {
                    query = (from f in query
                             join q in context.ProfileProcesses on f.Id equals q.ID
                             where q.ProcessID == request.ProcessID
                             select f);
                }
            }

            if (!(await User.IsSuperAdmin()).Value)
            {
                var og = await User.GetOfficeID();

                var provincesUsers = IDContext.Users.Where(e => e.OfficeID == og).Select(e => e.Id).ToList();

                query = query.Where(e => provincesUsers.Contains((int)e.CreatedBy));

            }

            if (request.ID.HasValue)
            {
                query = query.Where(e => e.Id == request.ID.Value);
            }

            if (!String.IsNullOrEmpty(request.Code))
            {
                query = query.Where(e => e.Code == request.Code);
            }

            if (!String.IsNullOrEmpty(request.FirstName))
            {
                query = query.Where(e => EF.Functions.Like(e.FirstName, String.Concat("%", request.FirstName, "%")));
            }

            if (!String.IsNullOrEmpty(request.FatherName))
            {
                query = query.Where(e => EF.Functions.Like(e.FatherName, String.Concat("%", request.FatherName, "%")));
            }
            return (await query.OrderBy(x => x.Id).Select(p => new SearchProfileModel
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                FatherName = p.FatherName,
                FirstNameEng = p.FirstNameEng,
                LastNameEng = p.LastNameEng,
                FatherNameEng = p.FatherNameEng,
                GenderId = p.GenderId,
                DateOfBirth = p.DateOfBirth,
                GrandFatherName = p.GrandFatherName,
                PhotoPath = p.PhotoPath,
                Code = p.Code,
                BirthLocationId = p.BirthLocationId,
                MaritalStatusId = p.MaritalStatusId,
                ReligionId = p.ReligionId,
                EthnicityId = p.EthnicityId,
                BloodGroupId = p.BloodGroupId,
                GenderText = p.Gender.Name,
                Email = p.Email,
                EthnicityText = p.Ethnicity.Name,
                Mobile = p.Mobile,
                DocumentTypeId = p.DocumentTypeId,
                DocumentTypeText = p.DocumentType.Name,
                NID = p.NationalId,
                Province = p.Province,
                ProvinceText = p.ProvinceNavigation.Dari,
                District = p.District,
                DistrictText = p.DistrictNavigation.Dari,
                MotherLanguageId = p.MotherLanguageId,
                MotherLanguageName = p.Languages.Name,
                BirthLocationName = p.ProvinceNavigation.Dari,
                QuranChapter = context.QuranChapterMemorizes.Where(q => q.ProfileId == p.Id).Select(f => f.Chapter).Single(),
                DobShamsi = PersianDate.GetFormatedString(p.DateOfBirth),
                YearOfBirth = Convert.ToInt32(p.DateOfBirth.Year).ToString(),
                Age = (Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(p.DateOfBirth.Year)).ToString() + " ساله"

            }).Take(10).ToListAsync()).Select(cur =>
                {
                    cur.NIDText = NationalIDReader.ConvertJSONToString(cur.NID, cur.DocumentTypeText);
                    return cur;
                }).ToList();
        }
    }

}