/* http://www.zkea.net/ 
 * Copyright 2017 ZKEASOFT 
 * http://www.zkea.net/licenses 
 */

using Easy.RepositoryPattern;
using System;
using System.Collections.Generic;
using ZKEACMS.Product.Models;
using Easy;
using Microsoft.EntityFrameworkCore;

namespace ZKEACMS.Product.Service
{
    public class ProductTagService : ServiceBase<ProductTag>, IProductTagService
    {
        public ProductTagService(IApplicationContext applicationContext, ProductDbContext dbContext) : base(applicationContext, dbContext)
        {
        }

        public override DbSet<ProductTag> CurrentDbSet
        {
            get
            {
                return (DbContext as ProductDbContext).ProductTag;
            }
        }

    }
}
