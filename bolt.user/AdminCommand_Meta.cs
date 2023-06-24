using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200016C RID: 364
[Token(Token = "0x200016C")]
internal class AdminCommand_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x060010B2 RID: 4274 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public AdminCommand_Meta()
	{
	}

	// Token: 0x170005D8 RID: 1496
	// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00006600 File Offset: 0x00004800
	[Token(Token = "0x170005D8")]
	private TypeId TypeId
	{
		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005D9 RID: 1497
	// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00006618 File Offset: 0x00004818
	[Token(Token = "0x170005D9")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x87F3D0", Offset = "0x87D9D0", VA = "0x18087F3D0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005DA RID: 1498
	// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005DA")]
	private Type TypeObject
	{
		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x87F3F0", Offset = "0x87D9F0", VA = "0x18087F3F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x87F490", Offset = "0x87DA90", VA = "0x18087F490", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x87F790", Offset = "0x87DD90", VA = "0x18087F790", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x87F820", Offset = "0x87DE20", VA = "0x18087F820", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400029C RID: 668
	[Token(Token = "0x400029C")]
	[FieldOffset(Offset = "0x0")]
	internal static AdminCommand_Meta Instance;
}
