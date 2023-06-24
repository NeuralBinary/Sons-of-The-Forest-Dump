using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200002C RID: 44
[Token(Token = "0x200002C")]
internal class DynamicPickupWithInstanceModules_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public DynamicPickupWithInstanceModules_Meta()
	{
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060000E7 RID: 231 RVA: 0x000025C8 File Offset: 0x000007C8
	[Token(Token = "0x1700005D")]
	private TypeId TypeId
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060000E8 RID: 232 RVA: 0x000025E0 File Offset: 0x000007E0
	[Token(Token = "0x1700005E")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x7BDE20", Offset = "0x7BC420", VA = "0x1807BDE20", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700005F")]
	private Type TypeObject
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x7BDE40", Offset = "0x7BC440", VA = "0x1807BDE40", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x7BDEE0", Offset = "0x7BC4E0", VA = "0x1807BDEE0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x7BE390", Offset = "0x7BC990", VA = "0x1807BE390", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000231 RID: 561
	[Token(Token = "0x4000231")]
	[FieldOffset(Offset = "0x0")]
	internal static DynamicPickupWithInstanceModules_Meta Instance;
}
