using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001A2 RID: 418
[Token(Token = "0x20001A2")]
internal class debugCommand_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001326 RID: 4902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001326")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public debugCommand_Meta()
	{
	}

	// Token: 0x1700063A RID: 1594
	// (get) Token: 0x06001327 RID: 4903 RVA: 0x00006BD0 File Offset: 0x00004DD0
	[Token(Token = "0x1700063A")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001327")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700063B RID: 1595
	// (get) Token: 0x06001328 RID: 4904 RVA: 0x00006BE8 File Offset: 0x00004DE8
	[Token(Token = "0x1700063B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x8939B0", Offset = "0x891FB0", VA = "0x1808939B0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700063C RID: 1596
	// (get) Token: 0x06001329 RID: 4905 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700063C")]
	private Type TypeObject
	{
		[Token(Token = "0x6001329")]
		[Address(RVA = "0x8939D0", Offset = "0x891FD0", VA = "0x1808939D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600132A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600132B")]
	[Address(RVA = "0x893A70", Offset = "0x892070", VA = "0x180893A70", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600132C")]
	[Address(RVA = "0x893E80", Offset = "0x892480", VA = "0x180893E80", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600132D")]
	[Address(RVA = "0x893F10", Offset = "0x892510", VA = "0x180893F10", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002AE RID: 686
	[Token(Token = "0x40002AE")]
	[FieldOffset(Offset = "0x0")]
	internal static debugCommand_Meta Instance;
}
