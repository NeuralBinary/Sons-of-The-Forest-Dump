using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001C0 RID: 448
[Token(Token = "0x20001C0")]
internal class TakeClothingOutfit_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600146E RID: 5230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600146E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public TakeClothingOutfit_Meta()
	{
	}

	// Token: 0x1700066A RID: 1642
	// (get) Token: 0x0600146F RID: 5231 RVA: 0x00006E88 File Offset: 0x00005088
	[Token(Token = "0x1700066A")]
	private TypeId TypeId
	{
		[Token(Token = "0x600146F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700066B RID: 1643
	// (get) Token: 0x06001470 RID: 5232 RVA: 0x00006EA0 File Offset: 0x000050A0
	[Token(Token = "0x1700066B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x89D6B0", Offset = "0x89BCB0", VA = "0x18089D6B0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x06001471 RID: 5233 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700066C")]
	private Type TypeObject
	{
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x89D6D0", Offset = "0x89BCD0", VA = "0x18089D6D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001472")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001473")]
	[Address(RVA = "0x89D770", Offset = "0x89BD70", VA = "0x18089D770", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001474")]
	[Address(RVA = "0x89D960", Offset = "0x89BF60", VA = "0x18089D960", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001475")]
	[Address(RVA = "0x89D9F0", Offset = "0x89BFF0", VA = "0x18089D9F0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x0")]
	internal static TakeClothingOutfit_Meta Instance;
}
