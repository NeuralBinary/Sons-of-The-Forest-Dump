using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000259 RID: 601
[Token(Token = "0x2000259")]
internal class DeathMarkerRequest_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001BC4 RID: 7108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DeathMarkerRequest_Meta()
	{
	}

	// Token: 0x170007C7 RID: 1991
	// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x00008670 File Offset: 0x00006870
	[Token(Token = "0x170007C7")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007C8 RID: 1992
	// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00008688 File Offset: 0x00006888
	[Token(Token = "0x170007C8")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x7E2B30", Offset = "0x7E1130", VA = "0x1807E2B30", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007C9 RID: 1993
	// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007C9")]
	private Type TypeObject
	{
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x7E2B50", Offset = "0x7E1150", VA = "0x1807E2B50", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BC9")]
	[Address(RVA = "0x7E2BF0", Offset = "0x7E11F0", VA = "0x1807E2BF0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0x7E3420", Offset = "0x7E1A20", VA = "0x1807E3420", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001BCB RID: 7115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001BCB")]
	[Address(RVA = "0x7E34B0", Offset = "0x7E1AB0", VA = "0x1807E34B0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002EB RID: 747
	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x0")]
	internal static DeathMarkerRequest_Meta Instance;
}
