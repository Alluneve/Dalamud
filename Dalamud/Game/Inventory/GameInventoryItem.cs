using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using FFXIVClientStructs.FFXIV.Client.Game;

namespace Dalamud.Game.Inventory;

/// <summary>
/// Dalamud wrapper around a ClientStructs InventoryItem.
/// </summary>
[StructLayout(LayoutKind.Explicit, Size = InventoryItem.StructSize)]
public unsafe struct GameInventoryItem : IEquatable<GameInventoryItem>
{
    /// <summary>
    /// The actual data.
    /// </summary>
    [FieldOffset(0)]
    internal readonly InventoryItem InternalItem;

    /// <summary>
    /// The view of the backing data, in <see cref="ulong"/>.
    /// </summary>
    [FieldOffset(0)]
    private fixed ulong dataUInt64[InventoryItem.StructSize / 0x8];

    /// <summary>
    /// Initializes a new instance of the <see cref="GameInventoryItem"/> struct.
    /// </summary>
    /// <param name="item">Inventory item to wrap.</param>
    internal GameInventoryItem(InventoryItem item) => this.InternalItem = item;

    /// <summary>
    /// Gets a value indicating whether the this <see cref="GameInventoryItem"/> is empty.
    /// </summary>
    public bool IsEmpty => this.InternalItem.ItemId == 0;

    /// <summary>
    /// Gets the container inventory type.
    /// </summary>
    public GameInventoryType ContainerType => (GameInventoryType)this.InternalItem.Container;

    /// <summary>
    /// Gets the inventory slot index this item is in.
    /// </summary>
    public uint InventorySlot => (uint)this.InternalItem.Slot;

    /// <summary>
    /// Gets the item id.
    /// </summary>
    public uint ItemId => this.InternalItem.ItemId;

    /// <summary>
    /// Gets the quantity of items in this item stack.
    /// </summary>
    public int Quantity => this.InternalItem.Quantity;

    /// <summary>
    /// Gets the spiritbond or collectability of this item.
    /// </summary>
    public uint SpiritbondOrCollectability => this.InternalItem.SpiritbondOrCollectability;

    /// <summary>
    /// Gets the spiritbond of this item.
    /// </summary>
    [Obsolete($"Renamed to {nameof(SpiritbondOrCollectability)}", true)]
    public uint Spiritbond => this.SpiritbondOrCollectability;

    /// <summary>
    /// Gets the repair condition of this item.
    /// </summary>
    public uint Condition => this.InternalItem.Condition;

    /// <summary>
    /// Gets a value indicating whether the item is High Quality.
    /// </summary>
    public bool IsHq => (this.InternalItem.Flags & InventoryItem.ItemFlags.HighQuality) != 0;

    /// <summary>
    /// Gets a value indicating whether the  item has a company crest applied.
    /// </summary>
    public bool IsCompanyCrestApplied => (this.InternalItem.Flags & InventoryItem.ItemFlags.CompanyCrestApplied) != 0;

    /// <summary>
    /// Gets a value indicating whether the item is a relic.
    /// </summary>
    public bool IsRelic => (this.InternalItem.Flags & InventoryItem.ItemFlags.Relic) != 0;

    /// <summary>
    /// Gets a value indicating whether the is a collectable.
    /// </summary>
    public bool IsCollectable => (this.InternalItem.Flags & InventoryItem.ItemFlags.Collectable) != 0;

    /// <summary>
    /// Gets the array of materia types.
    /// </summary>
    public ReadOnlySpan<ushort> Materia => new(Unsafe.AsPointer(ref this.InternalItem.Materia[0]), 5);

    /// <summary>
    /// Gets the array of materia grades.
    /// </summary>
    public ReadOnlySpan<byte> MateriaGrade => new(Unsafe.AsPointer(ref this.InternalItem.MateriaGrades[0]), 5);

    /// <summary>
    /// Gets the address of native inventory item in the game.<br />
    /// Can be 0 if this instance of <see cref="GameInventoryItem"/> does not point to a valid set of container type and slot.<br />
    /// Note that this instance of <see cref="GameInventoryItem"/> can be a snapshot; it may not necessarily match the
    /// data you can query from the game using this address value.
    /// </summary>
    public nint Address
    {
        get
        {
            var s = GetReadOnlySpanOfInventory(this.ContainerType);
            if (s.IsEmpty)
                return 0;

            foreach (ref readonly var i in s)
            {
                if (i.InventorySlot == this.InventorySlot)
                    return (nint)Unsafe.AsPointer(ref Unsafe.AsRef(in i));
            }

            return 0;
        }
    }

    /// <summary>
    /// Gets the color used for this item.
    /// </summary>
    public ReadOnlySpan<byte> Stains => new(Unsafe.AsPointer(ref this.InternalItem.Stains[0]), 2);

    /// <summary>
    /// Gets the glamour id for this item.
    /// </summary>
    public uint GlamourId => this.InternalItem.GlamourId;

    /// <summary>
    /// Gets the items crafter's content id.
    /// NOTE: I'm not sure if this is a good idea to include or not in the dalamud api. Marked internal for now.
    /// </summary>
    internal ulong CrafterContentId => this.InternalItem.CrafterContentId;

    public static bool operator ==(in GameInventoryItem l, in GameInventoryItem r) => l.Equals(r);

    public static bool operator !=(in GameInventoryItem l, in GameInventoryItem r) => !l.Equals(r);

    /// <inheritdoc/>
    readonly bool IEquatable<GameInventoryItem>.Equals(GameInventoryItem other) => this.Equals(other);

    /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><c>true</c> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <c>false</c>.</returns>
    public readonly bool Equals(in GameInventoryItem other)
    {
        for (var i = 0; i < InventoryItem.StructSize / 8; i++)
        {
            if (this.dataUInt64[i] != other.dataUInt64[i])
                return false;
        }

        return true;
    }

    /// <inheritdoc cref="object.Equals(object?)" />
    public override bool Equals(object obj) => obj is GameInventoryItem gii && this.Equals(gii);

    /// <inheritdoc cref="object.GetHashCode" />
    public override int GetHashCode()
    {
        var k = 0x5a8447b91aff51b4UL;
        for (var i = 0; i < InventoryItem.StructSize / 8; i++)
            k ^= this.dataUInt64[i];
        return unchecked((int)(k ^ (k >> 32)));
    }

    /// <inheritdoc cref="object.ToString"/>
    public override string ToString() =>
        this.IsEmpty
            ? "empty"
            : $"item({this.ItemId}@{this.ContainerType}#{this.InventorySlot})";

    /// <summary>
    /// Gets a <see cref="Span{T}"/> view of <see cref="InventoryItem"/>s, wrapped as <see cref="GameInventoryItem"/>.
    /// </summary>
    /// <param name="type">The inventory type.</param>
    /// <returns>The span.</returns>
    internal static ReadOnlySpan<GameInventoryItem> GetReadOnlySpanOfInventory(GameInventoryType type)
    {
        var inventoryManager = InventoryManager.Instance();
        if (inventoryManager is null) return default;

        var inventory = inventoryManager->GetInventoryContainer((InventoryType)type);
        if (inventory is null) return default;

        return new ReadOnlySpan<GameInventoryItem>(inventory->Items, (int)inventory->Size);
    }
}
