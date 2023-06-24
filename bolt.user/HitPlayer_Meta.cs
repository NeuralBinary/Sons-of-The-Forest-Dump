using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000CD RID: 205
[Token(Token = "0x20000CD")]
internal class HitPlayer_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600099E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public HitPlayer_Meta()
	{
	}

	// Token: 0x170004C8 RID: 1224
	// (get) Token: 0x0600099F RID: 2463 RVA: 0x00005688 File Offset: 0x00003888
	[Token(Token = "0x170004C8")]
	private TypeId TypeId
	{
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004C9 RID: 1225
	// (get) Token: 0x060009A0 RID: 2464 RVA: 0x000056A0 File Offset: 0x000038A0
	[Token(Token = "0x170004C9")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x844AE0", Offset = "0x8430E0", VA = "0x180844AE0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004CA")]
	private Type TypeObject
	{
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x844B00", Offset = "0x843100", VA = "0x180844B00", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x844BA0", Offset = "0x8431A0", VA = "0x180844BA0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x8452C0", Offset = "0x8438C0", VA = "0x1808452C0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x845350", Offset = "0x843950", VA = "0x180845350", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000267 RID: 615
	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x0")]
	internal static HitPlayer_Meta Instance;
}
