using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000232 RID: 562
[Token(Token = "0x2000232")]
internal class VailRequestVillageData_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060019E4 RID: 6628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public VailRequestVillageData_Meta()
	{
	}

	// Token: 0x17000773 RID: 1907
	// (get) Token: 0x060019E5 RID: 6629 RVA: 0x000080D0 File Offset: 0x000062D0
	[Token(Token = "0x17000773")]
	private TypeId TypeId
	{
		[Token(Token = "0x60019E5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000774 RID: 1908
	// (get) Token: 0x060019E6 RID: 6630 RVA: 0x000080E8 File Offset: 0x000062E8
	[Token(Token = "0x17000774")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60019E6")]
		[Address(RVA = "0x8CD2F0", Offset = "0x8CB8F0", VA = "0x1808CD2F0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000775 RID: 1909
	// (get) Token: 0x060019E7 RID: 6631 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000775")]
	private Type TypeObject
	{
		[Token(Token = "0x60019E7")]
		[Address(RVA = "0x8CD310", Offset = "0x8CB910", VA = "0x1808CD310", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019E9")]
	[Address(RVA = "0x8CD3B0", Offset = "0x8CB9B0", VA = "0x1808CD3B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x8CD460", Offset = "0x8CBA60", VA = "0x1808CD460", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x8CD4F0", Offset = "0x8CBAF0", VA = "0x1808CD4F0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002DE RID: 734
	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x0")]
	internal static VailRequestVillageData_Meta Instance;
}
