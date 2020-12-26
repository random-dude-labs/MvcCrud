using MvcCrud.Models;
using System.Collections.Generic;

namespace MvcCrud.ViewModels
{
    public class SchoolViewModel
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
