using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000DF RID: 223
[Token(Token = "0x20000DF")]
internal class ItemHolderTakeItem_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000A6C RID: 2668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ItemHolderTakeItem_Meta()
	{
	}

	// Token: 0x170004E9 RID: 1257
	// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00005850 File Offset: 0x00003A50
	[Token(Token = "0x170004E9")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00005868 File Offset: 0x00003A68
	[Token(Token = "0x170004EA")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x84B850", Offset = "0x849E50", VA = "0x18084B850", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004EB")]
	private Type TypeObject
	{
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x84B870", Offset = "0x849E70", VA = "0x18084B870", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A70")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A71")]
	[Address(RVA = "0x84B910", Offset = "0x849F10", VA = "0x18084B910", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A72")]
	[Address(RVA = "0x84BE50", Offset = "0x84A450", VA = "0x18084BE50", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A73")]
	[Address(RVA = "0x84BEE0", Offset = "0x84A4E0", VA = "0x18084BEE0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400026D RID: 621
	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x0")]
	internal static ItemHolderTakeItem_Meta Instance;
}
