using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001F0 RID: 496
[Token(Token = "0x20001F0")]
internal class PlayerConnectivityAction_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060016A8 RID: 5800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerConnectivityAction_Meta()
	{
	}

	// Token: 0x170006D9 RID: 1753
	// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00007650 File Offset: 0x00005850
	[Token(Token = "0x170006D9")]
	private TypeId TypeId
	{
		[Token(Token = "0x60016A9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006DA RID: 1754
	// (get) Token: 0x060016AA RID: 5802 RVA: 0x00007668 File Offset: 0x00005868
	[Token(Token = "0x170006DA")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x8B0140", Offset = "0x8AE740", VA = "0x1808B0140", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006DB RID: 1755
	// (get) Token: 0x060016AB RID: 5803 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006DB")]
	private Type TypeObject
	{
		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x8B0160", Offset = "0x8AE760", VA = "0x1808B0160", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016AC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016AD")]
	[Address(RVA = "0x8B0200", Offset = "0x8AE800", VA = "0x1808B0200", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60016AE")]
	[Address(RVA = "0x8B0630", Offset = "0x8AEC30", VA = "0x1808B0630", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60016AF")]
	[Address(RVA = "0x8B06C0", Offset = "0x8AECC0", VA = "0x1808B06C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C8 RID: 712
	[Token(Token = "0x40002C8")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerConnectivityAction_Meta Instance;
}
