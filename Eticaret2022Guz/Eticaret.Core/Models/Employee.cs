using System;

namespace Eticaret.Core.Models
{
    public class Employee : IEntity
    {
        
        public int EmployeeId { get; set; }

    
        public string EmployeeName { get; set; }

        public string EmployeeLastname { get; set; }

        /// <summary>
        /// Employee User Name
        /// </summary>
        public string EmployeeUserName { get; set; }

        /// <summary>
        /// Employee Email
        /// </summary>
        public string EmployeeEmail { get; set; }
        /// <summary>
        /// Statu 0-> Pasif , 1 -> Aktif
        /// </summary>
        public bool EmployeeStatu { get; set; }
        /// <summary>
        /// Employe create date datetimestamp
        /// </summary>
       // public DateTime StartDate { get; set; }

        // RoleId manuel olarak eklemesem.. EF benim yerime kendisi ekliyor..
       // public int RoleId { get; set; }
        //public Role Role { get; set; }
    }
}
