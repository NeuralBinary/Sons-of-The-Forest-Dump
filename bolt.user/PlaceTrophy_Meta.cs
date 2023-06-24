using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000166 RID: 358
[Token(Token = "0x2000166")]
internal class PlaceTrophy_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001070 RID: 4208 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001070")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlaceTrophy_Meta()
	{
	}

	// Token: 0x170005CF RID: 1487
	// (get) Token: 0x06001071 RID: 4209 RVA: 0x000065A0 File Offset: 0x000047A0
	[Token(Token = "0x170005CF")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005D0 RID: 1488
	// (get) Token: 0x06001072 RID: 4210 RVA: 0x000065B8 File Offset: 0x000047B8
	[Token(Token = "0x170005D0")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x87D640", Offset = "0x87BC40", VA = "0x18087D640", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005D1 RID: 1489
	// (get) Token: 0x06001073 RID: 4211 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005D1")]
	private Type TypeObject
	{
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x87D660", Offset = "0x87BC60", VA = "0x18087D660", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001074")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001075")]
	[Address(RVA = "0x87D700", Offset = "0x87BD00", VA = "0x18087D700", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001076")]
	[Address(RVA = "0x87DA10", Offset = "0x87C010", VA = "0x18087DA10", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001077")]
	[Address(RVA = "0x87DAA0", Offset = "0x87C0A0", VA = "0x18087DAA0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400029A RID: 666
	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x0")]
	internal static PlaceTrophy_Meta Instance;
}
