using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000EB RID: 235
[Token(Token = "0x20000EB")]
internal class SfxHammer_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000AFA RID: 2810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SfxHammer_Meta()
	{
	}

	// Token: 0x17000500 RID: 1280
	// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000059E8 File Offset: 0x00003BE8
	[Token(Token = "0x17000500")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000501 RID: 1281
	// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00005A00 File Offset: 0x00003C00
	[Token(Token = "0x17000501")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x850C10", Offset = "0x84F210", VA = "0x180850C10", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000502")]
	private Type TypeObject
	{
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x850C30", Offset = "0x84F230", VA = "0x180850C30", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x850CD0", Offset = "0x84F2D0", VA = "0x180850CD0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x850D80", Offset = "0x84F380", VA = "0x180850D80", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x850E10", Offset = "0x84F410", VA = "0x180850E10", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000271 RID: 625
	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x0")]
	internal static SfxHammer_Meta Instance;
}
