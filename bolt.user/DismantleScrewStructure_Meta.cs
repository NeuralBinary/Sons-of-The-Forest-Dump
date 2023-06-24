using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000283 RID: 643
[Token(Token = "0x2000283")]
internal class DismantleScrewStructure_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001D88 RID: 7560 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D88")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DismantleScrewStructure_Meta()
	{
	}

	// Token: 0x1700080D RID: 2061
	// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00008AA8 File Offset: 0x00006CA8
	[Token(Token = "0x1700080D")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001D89")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700080E RID: 2062
	// (get) Token: 0x06001D8A RID: 7562 RVA: 0x00008AC0 File Offset: 0x00006CC0
	[Token(Token = "0x1700080E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001D8A")]
		[Address(RVA = "0x7F04F0", Offset = "0x7EEAF0", VA = "0x1807F04F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700080F RID: 2063
	// (get) Token: 0x06001D8B RID: 7563 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700080F")]
	private Type TypeObject
	{
		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0x7F0510", Offset = "0x7EEB10", VA = "0x1807F0510", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D8D")]
	[Address(RVA = "0x7F05B0", Offset = "0x7EEBB0", VA = "0x1807F05B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001D8E")]
	[Address(RVA = "0x7F07A0", Offset = "0x7EEDA0", VA = "0x1807F07A0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001D8F")]
	[Address(RVA = "0x7F0830", Offset = "0x7EEE30", VA = "0x1807F0830", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002F9 RID: 761
	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x0")]
	internal static DismantleScrewStructure_Meta Instance;
}
