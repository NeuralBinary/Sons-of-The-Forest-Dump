using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001F9 RID: 505
[Token(Token = "0x20001F9")]
internal class StructureCraftingNodeComplete_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600170C RID: 5900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600170C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public StructureCraftingNodeComplete_Meta()
	{
	}

	// Token: 0x170006E7 RID: 1767
	// (get) Token: 0x0600170D RID: 5901 RVA: 0x00007710 File Offset: 0x00005910
	[Token(Token = "0x170006E7")]
	private TypeId TypeId
	{
		[Token(Token = "0x600170D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006E8 RID: 1768
	// (get) Token: 0x0600170E RID: 5902 RVA: 0x00007728 File Offset: 0x00005928
	[Token(Token = "0x170006E8")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600170E")]
		[Address(RVA = "0x8B3450", Offset = "0x8B1A50", VA = "0x1808B3450", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006E9 RID: 1769
	// (get) Token: 0x0600170F RID: 5903 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006E9")]
	private Type TypeObject
	{
		[Token(Token = "0x600170F")]
		[Address(RVA = "0x8B3470", Offset = "0x8B1A70", VA = "0x1808B3470", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001710")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001711")]
	[Address(RVA = "0x8B3510", Offset = "0x8B1B10", VA = "0x1808B3510", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001712")]
	[Address(RVA = "0x8B3700", Offset = "0x8B1D00", VA = "0x1808B3700", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001713")]
	[Address(RVA = "0x8B3790", Offset = "0x8B1D90", VA = "0x1808B3790", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002CB RID: 715
	[Token(Token = "0x40002CB")]
	[FieldOffset(Offset = "0x0")]
	internal static StructureCraftingNodeComplete_Meta Instance;
}
