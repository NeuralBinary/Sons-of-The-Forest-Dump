using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200015D RID: 349
[Token(Token = "0x200015D")]
internal class PushRaft_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600100A RID: 4106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public PushRaft_Meta()
	{
	}

	// Token: 0x170005C0 RID: 1472
	// (get) Token: 0x0600100B RID: 4107 RVA: 0x000064F8 File Offset: 0x000046F8
	[Token(Token = "0x170005C0")]
	private TypeId TypeId
	{
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005C1 RID: 1473
	// (get) Token: 0x0600100C RID: 4108 RVA: 0x00006510 File Offset: 0x00004710
	[Token(Token = "0x170005C1")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x879E40", Offset = "0x878440", VA = "0x180879E40", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005C2 RID: 1474
	// (get) Token: 0x0600100D RID: 4109 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005C2")]
	private Type TypeObject
	{
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x879E60", Offset = "0x878460", VA = "0x180879E60", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600100F")]
	[Address(RVA = "0x879F00", Offset = "0x878500", VA = "0x180879F00", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001010")]
	[Address(RVA = "0x87A2A0", Offset = "0x8788A0", VA = "0x18087A2A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001011")]
	[Address(RVA = "0x87A330", Offset = "0x878930", VA = "0x18087A330", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x0")]
	internal static PushRaft_Meta Instance;
}
