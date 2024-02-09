﻿using Buisness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService) 
        {
            _applicantService = applicantService;   
        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için Maske Verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için Maske Verilemedi");
            }
        }
    }
}
