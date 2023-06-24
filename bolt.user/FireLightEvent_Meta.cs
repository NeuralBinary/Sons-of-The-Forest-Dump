using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001FF RID: 511
[Token(Token = "0x20001FF")]
internal class FireLightEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001748 RID: 5960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001748")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FireLightEvent_Meta()
	{
	}

	// Token: 0x170006EF RID: 1775
	// (get) Token: 0x06001749 RID: 5961 RVA: 0x00007788 File Offset: 0x00005988
	[Token(Token = "0x170006EF")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001749")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006F0 RID: 1776
	// (get) Token: 0x0600174A RID: 5962 RVA: 0x000077A0 File Offset: 0x000059A0
	[Token(Token = "0x170006F0")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600174A")]
		[Address(RVA = "0x8B4D80", Offset = "0x8B3380", VA = "0x1808B4D80", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006F1 RID: 1777
	// (get) Token: 0x0600174B RID: 5963 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006F1")]
	private Type TypeObject
	{
		[Token(Token = "0x600174B")]
		[Address(RVA = "0x8B4DA0", Offset = "0x8B33A0", VA = "0x1808B4DA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174D")]
	[Address(RVA = "0x8B4E40", Offset = "0x8B3440", VA = "0x1808B4E40", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600174E")]
	[Address(RVA = "0x8B5030", Offset = "0x8B3630", VA = "0x1808B5030", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600174F")]
	[Address(RVA = "0x8B50C0", Offset = "0x8B36C0", VA = "0x1808B50C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002CD RID: 717
	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x0")]
	internal static FireLightEvent_Meta Instance;
}
