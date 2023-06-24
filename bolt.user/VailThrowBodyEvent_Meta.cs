using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000226 RID: 550
[Token(Token = "0x2000226")]
internal class VailThrowBodyEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001958 RID: 6488 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001958")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public VailThrowBodyEvent_Meta()
	{
	}

	// Token: 0x1700075D RID: 1885
	// (get) Token: 0x06001959 RID: 6489 RVA: 0x00007F50 File Offset: 0x00006150
	[Token(Token = "0x1700075D")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700075E RID: 1886
	// (get) Token: 0x0600195A RID: 6490 RVA: 0x00007F68 File Offset: 0x00006168
	[Token(Token = "0x1700075E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x8C87D0", Offset = "0x8C6DD0", VA = "0x1808C87D0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700075F RID: 1887
	// (get) Token: 0x0600195B RID: 6491 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700075F")]
	private Type TypeObject
	{
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x8C87F0", Offset = "0x8C6DF0", VA = "0x1808C87F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600195C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600195D")]
	[Address(RVA = "0x8C8890", Offset = "0x8C6E90", VA = "0x1808C8890", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600195E")]
	[Address(RVA = "0x8C8E70", Offset = "0x8C7470", VA = "0x1808C8E70", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600195F")]
	[Address(RVA = "0x8C8F00", Offset = "0x8C7500", VA = "0x1808C8F00", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002DA RID: 730
	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x0")]
	internal static VailThrowBodyEvent_Meta Instance;
}
