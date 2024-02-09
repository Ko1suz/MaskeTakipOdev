﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IApplicantService
    {
      void ApllyForMask(Person person);
      List<Person> GetList();
      bool CheckPerson(Person person);
       
    }
}
