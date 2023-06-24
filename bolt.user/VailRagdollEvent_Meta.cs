using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200028F RID: 655
[Token(Token = "0x200028F")]
internal class VailRagdollEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001E0C RID: 7692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E0C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public VailRagdollEvent_Meta()
	{
	}

	// Token: 0x17000821 RID: 2081
	// (get) Token: 0x06001E0D RID: 7693 RVA: 0x00008BE0 File Offset: 0x00006DE0
	[Token(Token = "0x17000821")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000822 RID: 2082
	// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00008BF8 File Offset: 0x00006DF8
	[Token(Token = "0x17000822")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x7F42B0", Offset = "0x7F28B0", VA = "0x1807F42B0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000823 RID: 2083
	// (get) Token: 0x06001E0F RID: 7695 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000823")]
	private Type TypeObject
	{
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x7F42D0", Offset = "0x7F28D0", VA = "0x1807F42D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E10")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E11")]
	[Address(RVA = "0x7F4370", Offset = "0x7F2970", VA = "0x1807F4370", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001E12")]
	[Address(RVA = "0x7F49F0", Offset = "0x7F2FF0", VA = "0x1807F49F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001E13")]
	[Address(RVA = "0x7F4A80", Offset = "0x7F3080", VA = "0x1807F4A80", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x0")]
	internal static VailRagdollEvent_Meta Instance;
}
