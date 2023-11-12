﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    //İş kodu katmanındaki interfaceleri Service olaran adlandırır.
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
