using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200008C RID: 140
[Token(Token = "0x200008C")]
internal class HierarchyObjectState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public HierarchyObjectState_Meta()
	{
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00003B10 File Offset: 0x00001D10
	[Token(Token = "0x1700027D")]
	private TypeId TypeId
	{
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00003B28 File Offset: 0x00001D28
	[Token(Token = "0x1700027E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x814EF0", Offset = "0x8134F0", VA = "0x180814EF0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700027F")]
	private Type TypeObject
	{
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x814F10", Offset = "0x813510", VA = "0x180814F10", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x814FB0", Offset = "0x8135B0", VA = "0x180814FB0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x8151C0", Offset = "0x8137C0", VA = "0x1808151C0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000251 RID: 593
	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x0")]
	internal static HierarchyObjectState_Meta Instance;
}
