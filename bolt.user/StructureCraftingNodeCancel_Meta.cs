using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001F3 RID: 499
[Token(Token = "0x20001F3")]
internal class StructureCraftingNodeCancel_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060016C8 RID: 5832 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016C8")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public StructureCraftingNodeCancel_Meta()
	{
	}

	// Token: 0x170006DD RID: 1757
	// (get) Token: 0x060016C9 RID: 5833 RVA: 0x00007680 File Offset: 0x00005880
	[Token(Token = "0x170006DD")]
	private TypeId TypeId
	{
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006DE RID: 1758
	// (get) Token: 0x060016CA RID: 5834 RVA: 0x00007698 File Offset: 0x00005898
	[Token(Token = "0x170006DE")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x8B1280", Offset = "0x8AF880", VA = "0x1808B1280", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006DF RID: 1759
	// (get) Token: 0x060016CB RID: 5835 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006DF")]
	private Type TypeObject
	{
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x8B12A0", Offset = "0x8AF8A0", VA = "0x1808B12A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016CC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016CD")]
	[Address(RVA = "0x8B1340", Offset = "0x8AF940", VA = "0x1808B1340", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016CE")]
	[Address(RVA = "0x8B1530", Offset = "0x8AFB30", VA = "0x1808B1530", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016CF")]
	[Address(RVA = "0x8B15C0", Offset = "0x8AFBC0", VA = "0x1808B15C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C9 RID: 713
	[Token(Token = "0x40002C9")]
	[FieldOffset(Offset = "0x0")]
	internal static StructureCraftingNodeCancel_Meta Instance;
}
