using MvcCrud.Models;
using MvcCrud.ViewModels;
using System.Collections.Generic;

namespace MvcCrud.Services
{
    public interface ISchoolService
    {
        List<School> GetAllSchools();
        void AddSchool(School school);
        School GetSingleSchoolById(int id);
        void UpdateSchool(School newSchool);
        void DeleteSchool(int id);
        List<Teacher> GetTeachersBySchoolId(int schoolId);
        SchoolViewModel SchoolDeletionConfirmation(int id);
        SchoolViewModel SchoolDetails(int id);

    }
}
