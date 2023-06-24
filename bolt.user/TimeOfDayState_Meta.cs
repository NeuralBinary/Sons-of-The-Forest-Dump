using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000083 RID: 131
[Token(Token = "0x2000083")]
internal class TimeOfDayState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000458")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public TimeOfDayState_Meta()
	{
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x06000459 RID: 1113 RVA: 0x000037C8 File Offset: 0x000019C8
	[Token(Token = "0x17000231")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x0600045A RID: 1114 RVA: 0x000037E0 File Offset: 0x000019E0
	[Token(Token = "0x17000232")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x80E7C0", Offset = "0x80CDC0", VA = "0x18080E7C0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x0600045B RID: 1115 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000233")]
	private Type TypeObject
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x80E7E0", Offset = "0x80CDE0", VA = "0x18080E7E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600045C")]
	[Address(RVA = "0x80E880", Offset = "0x80CE80", VA = "0x18080E880", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600045D")]
	[Address(RVA = "0x80E9B0", Offset = "0x80CFB0", VA = "0x18080E9B0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600045E")]
	[Address(RVA = "0x80EBE0", Offset = "0x80D1E0", VA = "0x18080EBE0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400024E RID: 590
	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x0")]
	internal static TimeOfDayState_Meta Instance;
}
