﻿using Core.DataAccess.EntityFramework;
using DataAccess.Concretes.EntityFramework.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfColorDal:EfEntityRepositoryBase<Color,RentalContext>
    {
    }
}