using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200008F RID: 143
[Token(Token = "0x200008F")]
internal class CookingState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000509")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public CookingState_Meta()
	{
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x0600050A RID: 1290 RVA: 0x00003B70 File Offset: 0x00001D70
	[Token(Token = "0x17000287")]
	private TypeId TypeId
	{
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x0600050B RID: 1291 RVA: 0x00003B88 File Offset: 0x00001D88
	[Token(Token = "0x17000288")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x815870", Offset = "0x813E70", VA = "0x180815870", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x0600050C RID: 1292 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000289")]
	private Type TypeObject
	{
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x815890", Offset = "0x813E90", VA = "0x180815890", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050D")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600050E")]
	[Address(RVA = "0x815930", Offset = "0x813F30", VA = "0x180815930", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600050F")]
	[Address(RVA = "0x816030", Offset = "0x814630", VA = "0x180816030", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000252 RID: 594
	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x0")]
	internal static CookingState_Meta Instance;
}
