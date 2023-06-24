using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000202 RID: 514
[Token(Token = "0x2000202")]
internal class BreakableObjectBroken_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001768 RID: 5992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001768")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public BreakableObjectBroken_Meta()
	{
	}

	// Token: 0x170006F3 RID: 1779
	// (get) Token: 0x06001769 RID: 5993 RVA: 0x000077B8 File Offset: 0x000059B8
	[Token(Token = "0x170006F3")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006F4 RID: 1780
	// (get) Token: 0x0600176A RID: 5994 RVA: 0x000077D0 File Offset: 0x000059D0
	[Token(Token = "0x170006F4")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600176A")]
		[Address(RVA = "0x8B5D60", Offset = "0x8B4360", VA = "0x1808B5D60", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006F5 RID: 1781
	// (get) Token: 0x0600176B RID: 5995 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006F5")]
	private Type TypeObject
	{
		[Token(Token = "0x600176B")]
		[Address(RVA = "0x8B5D80", Offset = "0x8B4380", VA = "0x1808B5D80", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600176C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600176D")]
	[Address(RVA = "0x8B5E20", Offset = "0x8B4420", VA = "0x1808B5E20", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600176E")]
	[Address(RVA = "0x8B6010", Offset = "0x8B4610", VA = "0x1808B6010", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600176F")]
	[Address(RVA = "0x8B60A0", Offset = "0x8B46A0", VA = "0x1808B60A0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002CE RID: 718
	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x0")]
	internal static BreakableObjectBroken_Meta Instance;
}
