using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001F6 RID: 502
[Token(Token = "0x20001F6")]
internal class StructureCraftingNodeAddIngredient_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060016EC RID: 5868 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016EC")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public StructureCraftingNodeAddIngredient_Meta()
	{
	}

	// Token: 0x170006E3 RID: 1763
	// (get) Token: 0x060016ED RID: 5869 RVA: 0x000076E0 File Offset: 0x000058E0
	[Token(Token = "0x170006E3")]
	private TypeId TypeId
	{
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006E4 RID: 1764
	// (get) Token: 0x060016EE RID: 5870 RVA: 0x000076F8 File Offset: 0x000058F8
	[Token(Token = "0x170006E4")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x8B2320", Offset = "0x8B0920", VA = "0x1808B2320", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006E5 RID: 1765
	// (get) Token: 0x060016EF RID: 5871 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006E5")]
	private Type TypeObject
	{
		[Token(Token = "0x60016EF")]
		[Address(RVA = "0x8B2340", Offset = "0x8B0940", VA = "0x1808B2340", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060016F0 RID: 5872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016F0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060016F1 RID: 5873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016F1")]
	[Address(RVA = "0x8B23E0", Offset = "0x8B09E0", VA = "0x1808B23E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060016F2 RID: 5874 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016F2")]
	[Address(RVA = "0x8B2800", Offset = "0x8B0E00", VA = "0x1808B2800", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016F3")]
	[Address(RVA = "0x8B2890", Offset = "0x8B0E90", VA = "0x1808B2890", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002CA RID: 714
	[Token(Token = "0x40002CA")]
	[FieldOffset(Offset = "0x0")]
	internal static StructureCraftingNodeAddIngredient_Meta Instance;
}
