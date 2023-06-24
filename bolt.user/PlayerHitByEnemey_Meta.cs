using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000C4 RID: 196
[Token(Token = "0x20000C4")]
internal class PlayerHitByEnemey_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600091A RID: 2330 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerHitByEnemey_Meta()
	{
	}

	// Token: 0x170004AA RID: 1194
	// (get) Token: 0x0600091B RID: 2331 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x170004AA")]
	private TypeId TypeId
	{
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004AB RID: 1195
	// (get) Token: 0x0600091C RID: 2332 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x170004AB")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x83F240", Offset = "0x83D840", VA = "0x18083F240", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004AC RID: 1196
	// (get) Token: 0x0600091D RID: 2333 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004AC")]
	private Type TypeObject
	{
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x83F260", Offset = "0x83D860", VA = "0x18083F260", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600091F")]
	[Address(RVA = "0x83F300", Offset = "0x83D900", VA = "0x18083F300", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000920")]
	[Address(RVA = "0x83FA00", Offset = "0x83E000", VA = "0x18083FA00", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000921")]
	[Address(RVA = "0x83FA90", Offset = "0x83E090", VA = "0x18083FA90", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000264 RID: 612
	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerHitByEnemey_Meta Instance;
}
