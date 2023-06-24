using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000032 RID: 50
[Token(Token = "0x2000032")]
internal class ScrewStructureWithStorageState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public ScrewStructureWithStorageState_Meta()
	{
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000108 RID: 264 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x1700006D")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000109 RID: 265 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x1700006E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x7BF010", Offset = "0x7BD610", VA = "0x1807BF010", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x0600010A RID: 266 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700006F")]
	private Type TypeObject
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x7BF030", Offset = "0x7BD630", VA = "0x1807BF030", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010B")]
	[Address(RVA = "0x7BF0D0", Offset = "0x7BD6D0", VA = "0x1807BF0D0", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x7BF460", Offset = "0x7BDA60", VA = "0x1807BF460", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x7BFB90", Offset = "0x7BE190", VA = "0x1807BFB90", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000233 RID: 563
	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x0")]
	internal static ScrewStructureWithStorageState_Meta Instance;
}
