using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
internal class DestroyedTierObject_Meta : NetworkObj_Meta, IFactory
{
	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x7B58E0", Offset = "0x7B3EE0", VA = "0x1807B58E0")]
	public DestroyedTierObject_Meta()
	{
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600001F RID: 31 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x1700000A")]
	private TypeId TypeId
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000020 RID: 32 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x1700000B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x7B5930", Offset = "0x7B3F30", VA = "0x1807B5930", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000021 RID: 33 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700000C")]
	private Type TypeObject
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x7B5950", Offset = "0x7B3F50", VA = "0x1807B5950", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x7B59F0", Offset = "0x7B3FF0", VA = "0x1807B59F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x7B5EA0", Offset = "0x7B44A0", VA = "0x1807B5EA0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000223 RID: 547
	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x0")]
	internal static DestroyedTierObject_Meta Instance;
}
