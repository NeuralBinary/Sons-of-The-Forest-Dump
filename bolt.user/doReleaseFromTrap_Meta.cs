using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200017B RID: 379
[Token(Token = "0x200017B")]
internal class doReleaseFromTrap_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001156 RID: 4438 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001156")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public doReleaseFromTrap_Meta()
	{
	}

	// Token: 0x170005EE RID: 1518
	// (get) Token: 0x06001157 RID: 4439 RVA: 0x00006738 File Offset: 0x00004938
	[Token(Token = "0x170005EE")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005EF RID: 1519
	// (get) Token: 0x06001158 RID: 4440 RVA: 0x00006750 File Offset: 0x00004950
	[Token(Token = "0x170005EF")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x884230", Offset = "0x882830", VA = "0x180884230", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005F0 RID: 1520
	// (get) Token: 0x06001159 RID: 4441 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005F0")]
	private Type TypeObject
	{
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x884250", Offset = "0x882850", VA = "0x180884250", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x8842F0", Offset = "0x8828F0", VA = "0x1808842F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600115C")]
	[Address(RVA = "0x8844E0", Offset = "0x882AE0", VA = "0x1808844E0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600115D")]
	[Address(RVA = "0x884570", Offset = "0x882B70", VA = "0x180884570", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002A1 RID: 673
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x0")]
	internal static doReleaseFromTrap_Meta Instance;
}
