using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200009B RID: 155
[Token(Token = "0x200009B")]
internal class RainCatcherStructureState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public RainCatcherStructureState_Meta()
	{
	}

	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x060006AA RID: 1706 RVA: 0x000047E8 File Offset: 0x000029E8
	[Token(Token = "0x170003B8")]
	private TypeId TypeId
	{
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x060006AB RID: 1707 RVA: 0x00004800 File Offset: 0x00002A00
	[Token(Token = "0x170003B9")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x825860", Offset = "0x823E60", VA = "0x180825860", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x060006AC RID: 1708 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003BA")]
	private Type TypeObject
	{
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x825880", Offset = "0x823E80", VA = "0x180825880", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x825920", Offset = "0x823F20", VA = "0x180825920", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x825CB0", Offset = "0x8242B0", VA = "0x180825CB0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x826660", Offset = "0x824C60", VA = "0x180826660", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000256 RID: 598
	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x0")]
	internal static RainCatcherStructureState_Meta Instance;
}
