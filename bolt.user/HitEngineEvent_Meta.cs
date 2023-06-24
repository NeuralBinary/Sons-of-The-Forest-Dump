using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000214 RID: 532
[Token(Token = "0x2000214")]
internal class HitEngineEvent_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001884 RID: 6276 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001884")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public HitEngineEvent_Meta()
	{
	}

	// Token: 0x1700073B RID: 1851
	// (get) Token: 0x06001885 RID: 6277 RVA: 0x00007D40 File Offset: 0x00005F40
	[Token(Token = "0x1700073B")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001885")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700073C RID: 1852
	// (get) Token: 0x06001886 RID: 6278 RVA: 0x00007D58 File Offset: 0x00005F58
	[Token(Token = "0x1700073C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x8C1A70", Offset = "0x8C0070", VA = "0x1808C1A70", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700073D RID: 1853
	// (get) Token: 0x06001887 RID: 6279 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700073D")]
	private Type TypeObject
	{
		[Token(Token = "0x6001887")]
		[Address(RVA = "0x8C1A90", Offset = "0x8C0090", VA = "0x1808C1A90", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001888")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001889")]
	[Address(RVA = "0x8C1B30", Offset = "0x8C0130", VA = "0x1808C1B30", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600188A")]
	[Address(RVA = "0x8C1F60", Offset = "0x8C0560", VA = "0x1808C1F60", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600188B")]
	[Address(RVA = "0x8C1FF0", Offset = "0x8C05F0", VA = "0x1808C1FF0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D4 RID: 724
	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x0")]
	internal static HitEngineEvent_Meta Instance;
}
