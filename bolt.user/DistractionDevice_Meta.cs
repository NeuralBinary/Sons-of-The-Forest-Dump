using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000050 RID: 80
[Token(Token = "0x2000050")]
internal class DistractionDevice_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public DistractionDevice_Meta()
	{
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x060002F9 RID: 761 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x17000189")]
	private TypeId TypeId
	{
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x060002FA RID: 762 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x1700018A")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x7D4840", Offset = "0x7D2E40", VA = "0x1807D4840", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x060002FB RID: 763 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700018B")]
	private Type TypeObject
	{
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x7D4860", Offset = "0x7D2E60", VA = "0x1807D4860", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x7D4900", Offset = "0x7D2F00", VA = "0x1807D4900", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x7D4DD0", Offset = "0x7D33D0", VA = "0x1807D4DD0", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400023D RID: 573
	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x0")]
	internal static DistractionDevice_Meta Instance;
}
