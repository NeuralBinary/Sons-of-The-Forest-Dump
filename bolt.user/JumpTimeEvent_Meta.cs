using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000229 RID: 553
[Token(Token = "0x2000229")]
internal class JumpTimeEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001982 RID: 6530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001982")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public JumpTimeEvent_Meta()
	{
	}

	// Token: 0x17000766 RID: 1894
	// (get) Token: 0x06001983 RID: 6531 RVA: 0x00008010 File Offset: 0x00006210
	[Token(Token = "0x17000766")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000767 RID: 1895
	// (get) Token: 0x06001984 RID: 6532 RVA: 0x00008028 File Offset: 0x00006228
	[Token(Token = "0x17000767")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x8C9F60", Offset = "0x8C8560", VA = "0x1808C9F60", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000768 RID: 1896
	// (get) Token: 0x06001985 RID: 6533 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000768")]
	private Type TypeObject
	{
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x8C9F80", Offset = "0x8C8580", VA = "0x1808C9F80", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001986")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001987")]
	[Address(RVA = "0x8CA020", Offset = "0x8C8620", VA = "0x1808CA020", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001988")]
	[Address(RVA = "0x8CA7B0", Offset = "0x8C8DB0", VA = "0x1808CA7B0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001989")]
	[Address(RVA = "0x8CA840", Offset = "0x8C8E40", VA = "0x1808CA840", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002DB RID: 731
	[Token(Token = "0x40002DB")]
	[FieldOffset(Offset = "0x0")]
	internal static JumpTimeEvent_Meta Instance;
}
