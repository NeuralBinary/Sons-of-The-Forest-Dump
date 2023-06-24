using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000E2 RID: 226
[Token(Token = "0x20000E2")]
internal class SendMessageEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000A8E RID: 2702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SendMessageEvent_Meta()
	{
	}

	// Token: 0x170004EE RID: 1262
	// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00005880 File Offset: 0x00003A80
	[Token(Token = "0x170004EE")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004EF RID: 1263
	// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00005898 File Offset: 0x00003A98
	[Token(Token = "0x170004EF")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x84CC70", Offset = "0x84B270", VA = "0x18084CC70", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004F0")]
	private Type TypeObject
	{
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x84CC90", Offset = "0x84B290", VA = "0x18084CC90", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x84CD30", Offset = "0x84B330", VA = "0x18084CD30", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x84D020", Offset = "0x84B620", VA = "0x18084D020", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x84D0B0", Offset = "0x84B6B0", VA = "0x18084D0B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400026E RID: 622
	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x0")]
	internal static SendMessageEvent_Meta Instance;
}
