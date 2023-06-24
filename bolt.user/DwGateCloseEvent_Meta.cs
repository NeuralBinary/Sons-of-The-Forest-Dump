using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000220 RID: 544
[Token(Token = "0x2000220")]
internal class DwGateCloseEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001910 RID: 6416 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001910")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DwGateCloseEvent_Meta()
	{
	}

	// Token: 0x17000751 RID: 1873
	// (get) Token: 0x06001911 RID: 6417 RVA: 0x00007EA8 File Offset: 0x000060A8
	[Token(Token = "0x17000751")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000752 RID: 1874
	// (get) Token: 0x06001912 RID: 6418 RVA: 0x00007EC0 File Offset: 0x000060C0
	[Token(Token = "0x17000752")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x8C6200", Offset = "0x8C4800", VA = "0x1808C6200", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000753 RID: 1875
	// (get) Token: 0x06001913 RID: 6419 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000753")]
	private Type TypeObject
	{
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x8C6220", Offset = "0x8C4820", VA = "0x1808C6220", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001914")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001915")]
	[Address(RVA = "0x8C62C0", Offset = "0x8C48C0", VA = "0x1808C62C0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001916")]
	[Address(RVA = "0x8C65D0", Offset = "0x8C4BD0", VA = "0x1808C65D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001917")]
	[Address(RVA = "0x8C6660", Offset = "0x8C4C60", VA = "0x1808C6660", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D8 RID: 728
	[Token(Token = "0x40002D8")]
	[FieldOffset(Offset = "0x0")]
	internal static DwGateCloseEvent_Meta Instance;
}
