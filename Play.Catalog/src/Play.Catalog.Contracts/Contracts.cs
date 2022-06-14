using System;

namespace Play.Catalog.Contracts
{
    public record CatalogItemCreated(Guid ItemID, string Name, string Description);
    public record CatalogItemUpdated(Guid ItemID, string Name, string Description);
    public record CatalogItemDeleted(Guid ItemID);

}