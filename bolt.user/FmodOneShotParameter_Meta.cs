using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000142 RID: 322
[Token(Token = "0x2000142")]
internal class FmodOneShotParameter_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EDC")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FmodOneShotParameter_Meta()
	{
	}

	// Token: 0x17000595 RID: 1429
	// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000062A0 File Offset: 0x000044A0
	[Token(Token = "0x17000595")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000596 RID: 1430
	// (get) Token: 0x06000EDE RID: 3806 RVA: 0x000062B8 File Offset: 0x000044B8
	[Token(Token = "0x17000596")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x8702F0", Offset = "0x86E8F0", VA = "0x1808702F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000597 RID: 1431
	// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000597")]
	private Type TypeObject
	{
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x870310", Offset = "0x86E910", VA = "0x180870310", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE1")]
	[Address(RVA = "0x8703B0", Offset = "0x86E9B0", VA = "0x1808703B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000EE2")]
	[Address(RVA = "0x8709C0", Offset = "0x86EFC0", VA = "0x1808709C0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000EE3")]
	[Address(RVA = "0x870A50", Offset = "0x86F050", VA = "0x180870A50", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400028E RID: 654
	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x0")]
	internal static FmodOneShotParameter_Meta Instance;
}
