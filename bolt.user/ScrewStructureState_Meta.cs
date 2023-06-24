using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000098 RID: 152
[Token(Token = "0x2000098")]
internal class ScrewStructureState_Meta : NetworkState_Meta, ISerializerFactory, IFactory
{
	// Token: 0x06000693 RID: 1683 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000693")]
	[Address(RVA = "0x7BA8C0", Offset = "0x7B8EC0", VA = "0x1807BA8C0")]
	public ScrewStructureState_Meta()
	{
	}

	// Token: 0x170003AD RID: 941
	// (get) Token: 0x06000694 RID: 1684 RVA: 0x00004788 File Offset: 0x00002988
	[Token(Token = "0x170003AD")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170003AE RID: 942
	// (get) Token: 0x06000695 RID: 1685 RVA: 0x000047A0 File Offset: 0x000029A0
	[Token(Token = "0x170003AE")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x824BA0", Offset = "0x8231A0", VA = "0x180824BA0", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x06000696 RID: 1686 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170003AF")]
	private Type TypeObject
	{
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x824BC0", Offset = "0x8231C0", VA = "0x180824BC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000697")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000698")]
	[Address(RVA = "0x824C60", Offset = "0x823260", VA = "0x180824C60", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000699")]
	[Address(RVA = "0x825110", Offset = "0x823710", VA = "0x180825110", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x04000255 RID: 597
	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x0")]
	internal static ScrewStructureState_Meta Instance;
}
