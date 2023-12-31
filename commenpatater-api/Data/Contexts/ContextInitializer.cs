﻿using Microsoft.EntityFrameworkCore;

namespace commenpatater_api.Data.Contexts
{
    public class ContextInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new CommentContext(serviceProvider.GetRequiredService<DbContextOptions<CommentContext>>()))
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
