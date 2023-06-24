using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000193 RID: 403
[Token(Token = "0x2000193")]
internal class RequestAnimationSequenceProxy_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001270 RID: 4720 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001270")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RequestAnimationSequenceProxy_Meta()
	{
	}

	// Token: 0x1700061B RID: 1563
	// (get) Token: 0x06001271 RID: 4721 RVA: 0x00006A38 File Offset: 0x00004C38
	[Token(Token = "0x1700061B")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700061C RID: 1564
	// (get) Token: 0x06001272 RID: 4722 RVA: 0x00006A50 File Offset: 0x00004C50
	[Token(Token = "0x1700061C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001272")]
		[Address(RVA = "0x88D470", Offset = "0x88BA70", VA = "0x18088D470", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700061D RID: 1565
	// (get) Token: 0x06001273 RID: 4723 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700061D")]
	private Type TypeObject
	{
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x88D490", Offset = "0x88BA90", VA = "0x18088D490", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001275")]
	[Address(RVA = "0x88D530", Offset = "0x88BB30", VA = "0x18088D530", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x88D7A0", Offset = "0x88BDA0", VA = "0x18088D7A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001277")]
	[Address(RVA = "0x88D830", Offset = "0x88BE30", VA = "0x18088D830", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A9 RID: 681
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x0")]
	internal static RequestAnimationSequenceProxy_Meta Instance;
}
