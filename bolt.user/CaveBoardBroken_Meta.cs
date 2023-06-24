using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000217 RID: 535
[Token(Token = "0x2000217")]
internal class CaveBoardBroken_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060018A6 RID: 6310 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018A6")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public CaveBoardBroken_Meta()
	{
	}

	// Token: 0x17000740 RID: 1856
	// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00007D88 File Offset: 0x00005F88
	[Token(Token = "0x17000740")]
	private TypeId TypeId
	{
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000741 RID: 1857
	// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00007DA0 File Offset: 0x00005FA0
	[Token(Token = "0x17000741")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x8C2C20", Offset = "0x8C1220", VA = "0x1808C2C20", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000742 RID: 1858
	// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000742")]
	private Type TypeObject
	{
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x8C2C40", Offset = "0x8C1240", VA = "0x1808C2C40", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018AA")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018AB")]
	[Address(RVA = "0x8C2CE0", Offset = "0x8C12E0", VA = "0x1808C2CE0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060018AC RID: 6316 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60018AC")]
	[Address(RVA = "0x8C2FF0", Offset = "0x8C15F0", VA = "0x1808C2FF0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60018AD")]
	[Address(RVA = "0x8C3080", Offset = "0x8C1680", VA = "0x1808C3080", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002D5 RID: 725
	[Token(Token = "0x40002D5")]
	[FieldOffset(Offset = "0x0")]
	internal static CaveBoardBroken_Meta Instance;
}
