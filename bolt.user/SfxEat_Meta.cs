using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000EE RID: 238
[Token(Token = "0x20000EE")]
internal class SfxEat_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000B18 RID: 2840 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SfxEat_Meta()
	{
	}

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00005A18 File Offset: 0x00003C18
	[Token(Token = "0x17000503")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x06000B1A RID: 2842 RVA: 0x00005A30 File Offset: 0x00003C30
	[Token(Token = "0x17000504")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x8517C0", Offset = "0x84FDC0", VA = "0x1808517C0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000505 RID: 1285
	// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000505")]
	private Type TypeObject
	{
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x8517E0", Offset = "0x84FDE0", VA = "0x1808517E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x851880", Offset = "0x84FE80", VA = "0x180851880", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B1E")]
	[Address(RVA = "0x851930", Offset = "0x84FF30", VA = "0x180851930", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B1F")]
	[Address(RVA = "0x8519C0", Offset = "0x84FFC0", VA = "0x1808519C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000272 RID: 626
	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x0")]
	internal static SfxEat_Meta Instance;
}
