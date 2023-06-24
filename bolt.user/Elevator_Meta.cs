using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200003B RID: 59
[Token(Token = "0x200003B")]
internal class Elevator_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public Elevator_Meta()
	{
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000162 RID: 354 RVA: 0x00002850 File Offset: 0x00000A50
	[Token(Token = "0x17000098")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000163 RID: 355 RVA: 0x00002868 File Offset: 0x00000A68
	[Token(Token = "0x17000099")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x7C3430", Offset = "0x7C1A30", VA = "0x1807C3430", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000164 RID: 356 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700009A")]
	private Type TypeObject
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x7C3450", Offset = "0x7C1A50", VA = "0x1807C3450", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x7C34F0", Offset = "0x7C1AF0", VA = "0x1807C34F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000167")]
	[Address(RVA = "0x7C3B80", Offset = "0x7C2180", VA = "0x1807C3B80", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000236 RID: 566
	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x0")]
	internal static Elevator_Meta Instance;
}
