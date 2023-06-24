using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000CA RID: 202
[Token(Token = "0x20000CA")]
internal class PlayerHitEnemy_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000976 RID: 2422 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000976")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerHitEnemy_Meta()
	{
	}

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06000977 RID: 2423 RVA: 0x000055F8 File Offset: 0x000037F8
	[Token(Token = "0x170004C0")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x06000978 RID: 2424 RVA: 0x00005610 File Offset: 0x00003810
	[Token(Token = "0x170004C1")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x842770", Offset = "0x840D70", VA = "0x180842770", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x06000979 RID: 2425 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004C2")]
	private Type TypeObject
	{
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x842790", Offset = "0x840D90", VA = "0x180842790", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600097A RID: 2426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600097A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600097B")]
	[Address(RVA = "0x842830", Offset = "0x840E30", VA = "0x180842830", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600097C RID: 2428 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600097C")]
	[Address(RVA = "0x843820", Offset = "0x841E20", VA = "0x180843820", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600097D")]
	[Address(RVA = "0x8438B0", Offset = "0x841EB0", VA = "0x1808438B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000266 RID: 614
	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerHitEnemy_Meta Instance;
}
