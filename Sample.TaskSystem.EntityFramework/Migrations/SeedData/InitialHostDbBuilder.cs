﻿using Sample.TaskSystem.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Sample.TaskSystem.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TaskSystemDbContext _context;

        public InitialHostDbBuilder(TaskSystemDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
