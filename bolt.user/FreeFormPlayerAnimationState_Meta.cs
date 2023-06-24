using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000095 RID: 149
[Token(Token = "0x2000095")]
internal class FreeFormPlayerAnimationState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000684")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public FreeFormPlayerAnimationState_Meta()
	{
	}

	// Token: 0x170003A6 RID: 934
	// (get) Token: 0x06000685 RID: 1669 RVA: 0x00004758 File Offset: 0x00002958
	[Token(Token = "0x170003A6")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170003A7 RID: 935
	// (get) Token: 0x06000686 RID: 1670 RVA: 0x00004770 File Offset: 0x00002970
	[Token(Token = "0x170003A7")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x824230", Offset = "0x822830", VA = "0x180824230", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170003A8 RID: 936
	// (get) Token: 0x06000687 RID: 1671 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003A8")]
	private Type TypeObject
	{
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x824250", Offset = "0x822850", VA = "0x180824250", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000688")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000689")]
	[Address(RVA = "0x8242F0", Offset = "0x8228F0", VA = "0x1808242F0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600068A")]
	[Address(RVA = "0x824740", Offset = "0x822D40", VA = "0x180824740", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000254 RID: 596
	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x0")]
	internal static FreeFormPlayerAnimationState_Meta Instance;
}
