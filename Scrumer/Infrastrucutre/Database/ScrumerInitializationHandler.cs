using Scrumer.Infrastrucutre.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scrumer.Infrastrucutre.Database
{
    public static class ScrumerInitializationHandler
    {
        public static void Initialize()
        {
            System.Data.Entity.Database.SetInitializer(new ScrumerDBInitializer());
            using (var db = new ScrumerContext())
            {
                {
                    db.Database.Initialize(true);
                }
            }
        }
    }
}