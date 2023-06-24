using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000F7 RID: 247
[Token(Token = "0x20000F7")]
internal class SfxFallLight_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000B72 RID: 2930 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SfxFallLight_Meta()
	{
	}

	// Token: 0x1700050C RID: 1292
	// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00005AA8 File Offset: 0x00003CA8
	[Token(Token = "0x1700050C")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700050D RID: 1293
	// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00005AC0 File Offset: 0x00003CC0
	[Token(Token = "0x1700050D")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x853AD0", Offset = "0x8520D0", VA = "0x180853AD0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700050E RID: 1294
	// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700050E")]
	private Type TypeObject
	{
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x853AF0", Offset = "0x8520F0", VA = "0x180853AF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x853B90", Offset = "0x852190", VA = "0x180853B90", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x853C40", Offset = "0x852240", VA = "0x180853C40", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x853CD0", Offset = "0x8522D0", VA = "0x180853CD0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000275 RID: 629
	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x0")]
	internal static SfxFallLight_Meta Instance;
}
