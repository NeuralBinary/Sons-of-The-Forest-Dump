using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000F4 RID: 244
[Token(Token = "0x20000F4")]
internal class SfxHurt_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SfxHurt_Meta()
	{
	}

	// Token: 0x17000509 RID: 1289
	// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00005A78 File Offset: 0x00003C78
	[Token(Token = "0x17000509")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00005A90 File Offset: 0x00003C90
	[Token(Token = "0x1700050A")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x852F20", Offset = "0x851520", VA = "0x180852F20", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700050B RID: 1291
	// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700050B")]
	private Type TypeObject
	{
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x852F40", Offset = "0x851540", VA = "0x180852F40", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x852FE0", Offset = "0x8515E0", VA = "0x180852FE0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x853090", Offset = "0x851690", VA = "0x180853090", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0x853120", Offset = "0x851720", VA = "0x180853120", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000274 RID: 628
	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x0")]
	internal static SfxHurt_Meta Instance;
}
