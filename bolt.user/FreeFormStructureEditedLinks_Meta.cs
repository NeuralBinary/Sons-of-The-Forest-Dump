using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001D8 RID: 472
[Token(Token = "0x20001D8")]
internal class FreeFormStructureEditedLinks_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001580 RID: 5504 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001580")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormStructureEditedLinks_Meta()
	{
	}

	// Token: 0x170006A1 RID: 1697
	// (get) Token: 0x06001581 RID: 5505 RVA: 0x00007260 File Offset: 0x00005460
	[Token(Token = "0x170006A1")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001581")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006A2 RID: 1698
	// (get) Token: 0x06001582 RID: 5506 RVA: 0x00007278 File Offset: 0x00005478
	[Token(Token = "0x170006A2")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001582")]
		[Address(RVA = "0x8A5E30", Offset = "0x8A4430", VA = "0x1808A5E30", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x06001583 RID: 5507 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006A3")]
	private Type TypeObject
	{
		[Token(Token = "0x6001583")]
		[Address(RVA = "0x8A5E50", Offset = "0x8A4450", VA = "0x1808A5E50", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001584")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001585")]
	[Address(RVA = "0x8A5EF0", Offset = "0x8A44F0", VA = "0x1808A5EF0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001586")]
	[Address(RVA = "0x8A6440", Offset = "0x8A4A40", VA = "0x1808A6440", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001587 RID: 5511 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001587")]
	[Address(RVA = "0x8A64D0", Offset = "0x8A4AD0", VA = "0x1808A64D0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C0 RID: 704
	[Token(Token = "0x40002C0")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureEditedLinks_Meta Instance;
}
