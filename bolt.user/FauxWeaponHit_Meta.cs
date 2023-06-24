using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000E8 RID: 232
[Token(Token = "0x20000E8")]
internal class FauxWeaponHit_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000ADC RID: 2780 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FauxWeaponHit_Meta()
	{
	}

	// Token: 0x170004FD RID: 1277
	// (get) Token: 0x06000ADD RID: 2781 RVA: 0x000059B8 File Offset: 0x00003BB8
	[Token(Token = "0x170004FD")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x06000ADE RID: 2782 RVA: 0x000059D0 File Offset: 0x00003BD0
	[Token(Token = "0x170004FE")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x84FD40", Offset = "0x84E340", VA = "0x18084FD40", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004FF")]
	private Type TypeObject
	{
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x84FD60", Offset = "0x84E360", VA = "0x18084FD60", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AE0")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AE1")]
	[Address(RVA = "0x84FE00", Offset = "0x84E400", VA = "0x18084FE00", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000AE2 RID: 2786 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AE2")]
	[Address(RVA = "0x8501D0", Offset = "0x84E7D0", VA = "0x1808501D0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AE3")]
	[Address(RVA = "0x850260", Offset = "0x84E860", VA = "0x180850260", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000270 RID: 624
	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x0")]
	internal static FauxWeaponHit_Meta Instance;
}
