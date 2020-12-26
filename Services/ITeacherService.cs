using MvcCrud.Models;
using MvcCrud.ViewModels;
using System.Collections.Generic;

namespace MvcCrud.Services
{
    public interface ITeacherService
    {
        List<Teacher> GetAllTeachers();
        void AddTeacher(Teacher teacher);
        Teacher GetSingleTeacherById(int id);
        void UpdateTeacher(Teacher newTeacher);
        void DeleteTeacher(int id);
        List<Student> GetStudentsByTeacherId(int teacherId);
        TeacherViewModel TeacherDeletionConfirmation(int id);
        TeacherViewModel TeacherDetails(int id);

    }
}
