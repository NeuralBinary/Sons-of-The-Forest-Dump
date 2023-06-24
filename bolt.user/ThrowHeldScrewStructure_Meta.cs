using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000286 RID: 646
[Token(Token = "0x2000286")]
internal class ThrowHeldScrewStructure_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001DA2 RID: 7586 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ThrowHeldScrewStructure_Meta()
	{
	}

	// Token: 0x17000810 RID: 2064
	// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00008AD8 File Offset: 0x00006CD8
	[Token(Token = "0x17000810")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001DA3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000811 RID: 2065
	// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00008AF0 File Offset: 0x00006CF0
	[Token(Token = "0x17000811")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001DA4")]
		[Address(RVA = "0x7F0DD0", Offset = "0x7EF3D0", VA = "0x1807F0DD0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000812 RID: 2066
	// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000812")]
	private Type TypeObject
	{
		[Token(Token = "0x6001DA5")]
		[Address(RVA = "0x7F0DF0", Offset = "0x7EF3F0", VA = "0x1807F0DF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0x7F0E90", Offset = "0x7EF490", VA = "0x1807F0E90", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DA8")]
	[Address(RVA = "0x7F0F40", Offset = "0x7EF540", VA = "0x1807F0F40", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0x7F0FD0", Offset = "0x7EF5D0", VA = "0x1807F0FD0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002FA RID: 762
	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x0")]
	internal static ThrowHeldScrewStructure_Meta Instance;
}
