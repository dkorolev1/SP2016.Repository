﻿using Microsoft.SharePoint;
using SP2016.Repository.Tests.Data.Rooms;
using SP2016.Repository.Tests.Mock;
using System;

namespace SP2016.Repository.Tests
{
    public class BaseRepoTest
    {
        protected UsersRepository UsersRepository { get; private set; }
        protected DepartmentsRepository DepartmentsRepository { get; private set; }
        protected RoomsRepository RoomsRepository { get; private set; }
        protected virtual string WebUrl => "http://wm-windows2012r/training/";

        protected MockUsers MockUsers { get; private set; }
        protected MockDepartments MockDepartments { get; private set; }

        public BaseRepoTest()
        {
            UsersRepository = new UsersRepository();
            DepartmentsRepository = new DepartmentsRepository();

            MockUsers = new MockUsers();
            MockDepartments = new MockDepartments();

            RoomsRepository = new RoomsRepository();
        }

        protected void Perform(Action<SPWeb> action)
        {
            using (var site = new SPSite(WebUrl))
            {
                using (var web = site.OpenWeb())
                {
                    action(web);
                }
            }
        }
    }
}
