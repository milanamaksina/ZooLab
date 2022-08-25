﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab.Employees;

namespace ZooLab.Validators
{
    public class VeterinarianHireValidator: IHireValidator
    {
        public List<ValidationError> ValidateEmployee(IEmployee employee, Zoo zoo)
        {
            var possibleWorker = employee as Veterinarian;
            List<ValidationError> errors = new();

            foreach (var enclosure in zoo.Enclosures)
            {
                foreach (var creature in enclosure.Animals)
                {
                    if (!possibleWorker.Experience.Contains(creature.GetType().Name))
                    {
                        errors.Add(new ValidationError($"{possibleWorker.FirstName} {possibleWorker.LastName} has no expirience with {creature.GetType().Name}"));
                    }
                }
            }
            return errors;
        }
    }
}
