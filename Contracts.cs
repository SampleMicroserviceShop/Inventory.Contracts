using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Contracts;
public record GrantItems(Guid UserId, Guid CatalogItemId, int Quantity, Guid CorrelationId);
public record InventoryItemsGranted(Guid CorrelationId);
public record SubtractItems(Guid UserId, Guid CatalogItemId, int Quantity, Guid CorrelationId);
public record InventoryItemsSubtracted(Guid CorrelationId);
public record InventoryItemUpdated(Guid UserId, Guid CatalogItemId, int NewTotalQuantity);
