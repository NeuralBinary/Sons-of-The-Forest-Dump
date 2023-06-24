using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200014E RID: 334
[Token(Token = "0x200014E")]
internal class ClientACK_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000F5C RID: 3932 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public ClientACK_Meta()
	{
	}

	// Token: 0x170005A5 RID: 1445
	// (get) Token: 0x06000F5D RID: 3933 RVA: 0x00006360 File Offset: 0x00004560
	[Token(Token = "0x170005A5")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170005A6 RID: 1446
	// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00006378 File Offset: 0x00004578
	[Token(Token = "0x170005A6")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x874610", Offset = "0x872C10", VA = "0x180874610", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170005A7 RID: 1447
	// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170005A7")]
	private Type TypeObject
	{
		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x874630", Offset = "0x872C30", VA = "0x180874630", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x8746D0", Offset = "0x872CD0", VA = "0x1808746D0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x874780", Offset = "0x872D80", VA = "0x180874780", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x874810", Offset = "0x872E10", VA = "0x180874810", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000292 RID: 658
	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x0")]
	internal static ClientACK_Meta Instance;
}
