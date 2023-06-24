using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200007A RID: 122
[Token(Token = "0x200007A")]
internal class WoodPlanksProxy_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000404 RID: 1028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000404")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public WoodPlanksProxy_Meta()
	{
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x06000405 RID: 1029 RVA: 0x00003600 File Offset: 0x00001800
	[Token(Token = "0x17000209")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x06000406 RID: 1030 RVA: 0x00003618 File Offset: 0x00001818
	[Token(Token = "0x1700020A")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x80B630", Offset = "0x809C30", VA = "0x18080B630", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06000407 RID: 1031 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700020B")]
	private Type TypeObject
	{
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x80B650", Offset = "0x809C50", VA = "0x18080B650", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000408")]
	[Address(RVA = "0x80B6F0", Offset = "0x809CF0", VA = "0x18080B6F0", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x80B820", Offset = "0x809E20", VA = "0x18080B820", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x80BB80", Offset = "0x80A180", VA = "0x18080BB80", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x0")]
	internal static WoodPlanksProxy_Meta Instance;
}
