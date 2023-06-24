using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001C9 RID: 457
[Token(Token = "0x20001C9")]
internal class FreeFormStructureDestroyed_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060014E0 RID: 5344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E0")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public FreeFormStructureDestroyed_Meta()
	{
	}

	// Token: 0x17000683 RID: 1667
	// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00007050 File Offset: 0x00005250
	[Token(Token = "0x17000683")]
	private TypeId TypeId
	{
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000684 RID: 1668
	// (get) Token: 0x060014E2 RID: 5346 RVA: 0x00007068 File Offset: 0x00005268
	[Token(Token = "0x17000684")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x8A17F0", Offset = "0x89FDF0", VA = "0x1808A17F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000685 RID: 1669
	// (get) Token: 0x060014E3 RID: 5347 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000685")]
	private Type TypeObject
	{
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x8A1810", Offset = "0x89FE10", VA = "0x1808A1810", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E4")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E5")]
	[Address(RVA = "0x8A18B0", Offset = "0x89FEB0", VA = "0x1808A18B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60014E6")]
	[Address(RVA = "0x8A1CF0", Offset = "0x8A02F0", VA = "0x1808A1CF0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060014E7 RID: 5351 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E7")]
	[Address(RVA = "0x8A1D80", Offset = "0x8A0380", VA = "0x1808A1D80", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormStructureDestroyed_Meta Instance;
}
