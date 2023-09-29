using CoreMVC_Exam.Areas.Identity.Data;
using CoreMVC_Exam.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CoreMVC_Exam.ViewModels
{
    public class AdministrationFormViewModel
    {
        public List<IdentityRole> Roles { get; set; }

        public List<ApplicationUser> Users { get; set; }

        public List<Client> Clients { get; set; }

        public List<ClientOrder> ClientOrders { get; set; }
    }
}