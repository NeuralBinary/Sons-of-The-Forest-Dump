using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200010F RID: 271
[Token(Token = "0x200010F")]
internal class SetCorpsePosition_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000C82 RID: 3202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SetCorpsePosition_Meta()
	{
	}

	// Token: 0x17000534 RID: 1332
	// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00005D18 File Offset: 0x00003F18
	[Token(Token = "0x17000534")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000535 RID: 1333
	// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00005D30 File Offset: 0x00003F30
	[Token(Token = "0x17000535")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x85BAF0", Offset = "0x85A0F0", VA = "0x18085BAF0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000536 RID: 1334
	// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000536")]
	private Type TypeObject
	{
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x85BB10", Offset = "0x85A110", VA = "0x18085BB10", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x85BBB0", Offset = "0x85A1B0", VA = "0x18085BBB0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x85C320", Offset = "0x85A920", VA = "0x18085C320", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x85C3B0", Offset = "0x85A9B0", VA = "0x18085C3B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400027D RID: 637
	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x0")]
	internal static SetCorpsePosition_Meta Instance;
}
