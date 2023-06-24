using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000253 RID: 595
[Token(Token = "0x2000253")]
internal class FireStokeEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001B7A RID: 7034 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B7A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FireStokeEvent_Meta()
	{
	}

	// Token: 0x170007BA RID: 1978
	// (get) Token: 0x06001B7B RID: 7035 RVA: 0x00008580 File Offset: 0x00006780
	[Token(Token = "0x170007BA")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170007BB RID: 1979
	// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00008598 File Offset: 0x00006798
	[Token(Token = "0x170007BB")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001B7C")]
		[Address(RVA = "0x7E0750", Offset = "0x7DED50", VA = "0x1807E0750", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170007BC RID: 1980
	// (get) Token: 0x06001B7D RID: 7037 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170007BC")]
	private Type TypeObject
	{
		[Token(Token = "0x6001B7D")]
		[Address(RVA = "0x7E0770", Offset = "0x7DED70", VA = "0x1807E0770", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B7E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B7F")]
	[Address(RVA = "0x7E0810", Offset = "0x7DEE10", VA = "0x1807E0810", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001B80")]
	[Address(RVA = "0x7E0A00", Offset = "0x7DF000", VA = "0x1807E0A00", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B81")]
	[Address(RVA = "0x7E0A90", Offset = "0x7DF090", VA = "0x1807E0A90", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002E9 RID: 745
	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x0")]
	internal static FireStokeEvent_Meta Instance;
}
