namespace LibraryManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'30ed4024-0757-45a0-99ed-c915c691409e', N'guest@gmail.com', 0, N'AO5bvdzgyFdkLWz4ycLTsoZbWFi3ghQpaY0OlgOWkK85AZhOlbq7GcSJN6vILx+8jQ==', N'bf5c2ad1-2d6c-4f2e-ac70-ad0cfbdd73d7', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3130ceb7-3a2f-4bc7-97d8-ccd951e4c7bb', N'guest@home.ca', 0, N'AAoOmdYB3Dvq8BAWarTCiZb5vQHqlL/5d2tLMJxU3G2hCuXD+8Dq8azBsY511OKeJA==', N'd947c92d-eaa9-404e-9e7a-2705fd6eedde', NULL, 0, 0, NULL, 1, 0, N'guest@home.ca')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9424a701-77d6-4edb-8e58-83706d007340', N'dan@home.ca', 0, N'ABYfq9ZgVUvbSCiS4qQW1tiPe0N6AEKHObS1iWnGC1Y+jlwvSIXel8FVJ/27zSTA+g==', N'447c2e67-44bd-4364-b6d2-4e174e5f6a2d', NULL, 0, 0, NULL, 1, 0, N'dan@home.ca')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'aa1c896b-061a-4d45-bf5a-f8dd5ad821f6', N'admin@librarymanager.com', 0, N'AEjfRYQ4or25NzJPQ0Qz+5ray61xNpPbQ1C7tGamKJC2mngSxbijWlAC6CkuupxUUg==', N'b1dafe42-6b5e-4540-93e6-954e1260a86f', NULL, 0, 0, NULL, 1, 0, N'admin@librarymanager.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd471c318-152e-4598-b75c-3f9fe43abf8d', N'guest@librarymanager.com', 0, N'ALaYJggBJQHAI359PbM2vOJVeVJIMw+sDDXewpyEvn04fctLfqayqSzD7qyYDbcOPQ==', N'aa00c1ba-c0c0-4a12-b3a8-f7ddbb3e3ebb', NULL, 0, 0, NULL, 1, 0, N'guest@librarymanager.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ed40a8e4-ddf7-4175-8ca7-bf6120ccf6a9', N'CanManageBooks')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aa1c896b-061a-4d45-bf5a-f8dd5ad821f6', N'ed40a8e4-ddf7-4175-8ca7-bf6120ccf6a9')
");
        }
        
        public override void Down()
        {
        }
    }
}
