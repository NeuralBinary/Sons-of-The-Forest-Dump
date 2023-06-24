using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002B6 RID: 694
[Token(Token = "0x20002B6")]
internal class PlayerInteractionEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001FA2 RID: 8098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PlayerInteractionEvent_Meta()
	{
	}

	// Token: 0x17000864 RID: 2148
	// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x00009018 File Offset: 0x00007218
	[Token(Token = "0x17000864")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000865 RID: 2149
	// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x00009030 File Offset: 0x00007230
	[Token(Token = "0x17000865")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0x8012A0", Offset = "0x7FF8A0", VA = "0x1808012A0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000866 RID: 2150
	// (get) Token: 0x06001FA5 RID: 8101 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000866")]
	private Type TypeObject
	{
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0x8012C0", Offset = "0x7FF8C0", VA = "0x1808012C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA7")]
	[Address(RVA = "0x801360", Offset = "0x7FF960", VA = "0x180801360", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001FA8")]
	[Address(RVA = "0x801780", Offset = "0x7FFD80", VA = "0x180801780", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0x801810", Offset = "0x7FFE10", VA = "0x180801810", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400030A RID: 778
	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x0")]
	internal static PlayerInteractionEvent_Meta Instance;
}
