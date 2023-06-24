using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000038")]
internal class GameModeState_Mod_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000144")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public GameModeState_Mod_Meta()
	{
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000145 RID: 325 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x1700008B")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000146 RID: 326 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x1700008C")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x7C2550", Offset = "0x7C0B50", VA = "0x1807C2550", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000147 RID: 327 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700008D")]
	private Type TypeObject
	{
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x7C2570", Offset = "0x7C0B70", VA = "0x1807C2570", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000149")]
	[Address(RVA = "0x7C2610", Offset = "0x7C0C10", VA = "0x1807C2610", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x7C2CC0", Offset = "0x7C12C0", VA = "0x1807C2CC0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000235 RID: 565
	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x0")]
	internal static GameModeState_Mod_Meta Instance;
}
