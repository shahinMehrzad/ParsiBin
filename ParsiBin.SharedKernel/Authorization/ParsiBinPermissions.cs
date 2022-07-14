using System.Collections.ObjectModel;

namespace ParsiBin.SharedKernel.Authorization
{
    public static class ParsiBinAction
    {
        public const string View = nameof(View);
        public const string Search = nameof(Search);
        public const string Create = nameof(Create);
        public const string Update = nameof(Update);
        public const string Delete = nameof(Delete);
        public const string Export = nameof(Export);
        public const string Generate = nameof(Generate);
        public const string Clean = nameof(Clean);
        public const string UpgradeSubscription = nameof(UpgradeSubscription);
    }

    public static class ParsiBinResource
    {
        public const string Tenants = nameof(Tenants);
        public const string Dashboard = nameof(Dashboard);
        public const string Hangfire = nameof(Hangfire);
        public const string Users = nameof(Users);
        public const string UserRoles = nameof(UserRoles);
        public const string Roles = nameof(Roles);
        public const string RoleClaims = nameof(RoleClaims);
        public const string Products = nameof(Products);
        public const string Brands = nameof(Brands);
    }

    public static class ParsiBinPermissions
    {
        private static readonly ParsiBinPermission[] _all = new ParsiBinPermission[]
        {
        new("View Dashboard", ParsiBinAction.View, ParsiBinResource.Dashboard),
        new("View Hangfire", ParsiBinAction.View, ParsiBinResource.Hangfire),
        new("View Users", ParsiBinAction.View, ParsiBinResource.Users),
        new("Search Users", ParsiBinAction.Search, ParsiBinResource.Users),
        new("Create Users", ParsiBinAction.Create, ParsiBinResource.Users),
        new("Update Users", ParsiBinAction.Update, ParsiBinResource.Users),
        new("Delete Users", ParsiBinAction.Delete, ParsiBinResource.Users),
        new("Export Users", ParsiBinAction.Export, ParsiBinResource.Users),
        new("View UserRoles", ParsiBinAction.View, ParsiBinResource.UserRoles),
        new("Update UserRoles", ParsiBinAction.Update, ParsiBinResource.UserRoles),
        new("View Roles", ParsiBinAction.View, ParsiBinResource.Roles),
        new("Create Roles", ParsiBinAction.Create, ParsiBinResource.Roles),
        new("Update Roles", ParsiBinAction.Update, ParsiBinResource.Roles),
        new("Delete Roles", ParsiBinAction.Delete, ParsiBinResource.Roles),
        new("View RoleClaims", ParsiBinAction.View, ParsiBinResource.RoleClaims),
        new("Update RoleClaims", ParsiBinAction.Update, ParsiBinResource.RoleClaims),
        new("View Products", ParsiBinAction.View, ParsiBinResource.Products, IsBasic: true),
        new("Search Products", ParsiBinAction.Search, ParsiBinResource.Products, IsBasic: true),
        new("Create Products", ParsiBinAction.Create, ParsiBinResource.Products),
        new("Update Products", ParsiBinAction.Update, ParsiBinResource.Products),
        new("Delete Products", ParsiBinAction.Delete, ParsiBinResource.Products),
        new("Export Products", ParsiBinAction.Export, ParsiBinResource.Products),
        new("View Brands", ParsiBinAction.View, ParsiBinResource.Brands, IsBasic: true),
        new("Search Brands", ParsiBinAction.Search, ParsiBinResource.Brands, IsBasic: true),
        new("Create Brands", ParsiBinAction.Create, ParsiBinResource.Brands),
        new("Update Brands", ParsiBinAction.Update, ParsiBinResource.Brands),
        new("Delete Brands", ParsiBinAction.Delete, ParsiBinResource.Brands),
        new("Generate Brands", ParsiBinAction.Generate, ParsiBinResource.Brands),
        new("Clean Brands", ParsiBinAction.Clean, ParsiBinResource.Brands),
        new("View Tenants", ParsiBinAction.View, ParsiBinResource.Tenants, IsRoot: true),
        new("Create Tenants", ParsiBinAction.Create, ParsiBinResource.Tenants, IsRoot: true),
        new("Update Tenants", ParsiBinAction.Update, ParsiBinResource.Tenants, IsRoot: true),
        new("Upgrade Tenant Subscription", ParsiBinAction.UpgradeSubscription, ParsiBinResource.Tenants, IsRoot: true)
        };

        public static IReadOnlyList<ParsiBinPermission> All { get; } = new ReadOnlyCollection<ParsiBinPermission>(_all);
        public static IReadOnlyList<ParsiBinPermission> Root { get; } = new ReadOnlyCollection<ParsiBinPermission>(_all.Where(p => p.IsRoot).ToArray());
        public static IReadOnlyList<ParsiBinPermission> Admin { get; } = new ReadOnlyCollection<ParsiBinPermission>(_all.Where(p => !p.IsRoot).ToArray());
        public static IReadOnlyList<ParsiBinPermission> Basic { get; } = new ReadOnlyCollection<ParsiBinPermission>(_all.Where(p => p.IsBasic).ToArray());
    }

    public record ParsiBinPermission(string Description, string Action, string Resource, bool IsBasic = false, bool IsRoot = false)
    {
        public string Name => NameFor(Action, Resource);
        public static string NameFor(string action, string resource) => $"Permissions.{resource}.{action}";
    }
}
