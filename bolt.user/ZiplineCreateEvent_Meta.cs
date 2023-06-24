using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200024D RID: 589
[Token(Token = "0x200024D")]
internal class ZiplineCreateEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001B3A RID: 6970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B3A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ZiplineCreateEvent_Meta()
	{
	}

	// Token: 0x170007B2 RID: 1970
	// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00008520 File Offset: 0x00006720
	[Token(Token = "0x170007B2")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007B3 RID: 1971
	// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00008538 File Offset: 0x00006738
	[Token(Token = "0x170007B3")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x7DE420", Offset = "0x7DCA20", VA = "0x1807DE420", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007B4 RID: 1972
	// (get) Token: 0x06001B3D RID: 6973 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007B4")]
	private Type TypeObject
	{
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x7DE440", Offset = "0x7DCA40", VA = "0x1807DE440", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B3E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B3F")]
	[Address(RVA = "0x7DE4E0", Offset = "0x7DCAE0", VA = "0x1807DE4E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B40")]
	[Address(RVA = "0x7DEC00", Offset = "0x7DD200", VA = "0x1807DEC00", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B41")]
	[Address(RVA = "0x7DEC90", Offset = "0x7DD290", VA = "0x1807DEC90", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E7 RID: 743
	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x0")]
	internal static ZiplineCreateEvent_Meta Instance;
}
