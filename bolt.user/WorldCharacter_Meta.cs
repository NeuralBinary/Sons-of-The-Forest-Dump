using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200003E RID: 62
[Token(Token = "0x200003E")]
internal class WorldCharacter_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public WorldCharacter_Meta()
	{
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000179 RID: 377 RVA: 0x000028B0 File Offset: 0x00000AB0
	[Token(Token = "0x170000A5")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x0600017A RID: 378 RVA: 0x000028C8 File Offset: 0x00000AC8
	[Token(Token = "0x170000A6")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x7C4250", Offset = "0x7C2850", VA = "0x1807C4250", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600017B RID: 379 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170000A7")]
	private Type TypeObject
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x7C4270", Offset = "0x7C2870", VA = "0x1807C4270", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x7C4310", Offset = "0x7C2910", VA = "0x1807C4310", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x7C4640", Offset = "0x7C2C40", VA = "0x1807C4640", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x7C4D50", Offset = "0x7C3350", VA = "0x1807C4D50", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000237 RID: 567
	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x0")]
	internal static WorldCharacter_Meta Instance;
}
