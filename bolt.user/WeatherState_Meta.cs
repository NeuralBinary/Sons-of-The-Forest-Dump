using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000080 RID: 128
[Token(Token = "0x2000080")]
internal class WeatherState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600044D")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public WeatherState_Meta()
	{
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x0600044E RID: 1102 RVA: 0x00003798 File Offset: 0x00001998
	[Token(Token = "0x1700022C")]
	private TypeId TypeId
	{
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x0600044F RID: 1103 RVA: 0x000037B0 File Offset: 0x000019B0
	[Token(Token = "0x1700022D")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x80D2F0", Offset = "0x80B8F0", VA = "0x18080D2F0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x06000450 RID: 1104 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700022E")]
	private Type TypeObject
	{
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x80D310", Offset = "0x80B910", VA = "0x18080D310", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000451")]
	[Address(RVA = "0x80D3B0", Offset = "0x80B9B0", VA = "0x18080D3B0", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000452")]
	[Address(RVA = "0x80D4E0", Offset = "0x80BAE0", VA = "0x18080D4E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000453")]
	[Address(RVA = "0x80E500", Offset = "0x80CB00", VA = "0x18080E500", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x0")]
	internal static WeatherState_Meta Instance;
}
