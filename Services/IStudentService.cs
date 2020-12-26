using MvcCrud.Models;
using MvcCrud.ViewModels;
using System.Collections.Generic;

namespace MvcCrud.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
        void AddStudent(Student student);
        Student GetSingleStudentById(int id);
        void UpdateStudent(Student newStudent);
        void DeleteStudent(int id);
        StudentViewModel StudentDeletionConfirmation(int id);
    }
}
