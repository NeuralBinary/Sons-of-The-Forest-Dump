using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000FA RID: 250
[Token(Token = "0x20000FA")]
internal class SfxFallHeavy_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000B90 RID: 2960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B90")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SfxFallHeavy_Meta()
	{
	}

	// Token: 0x1700050F RID: 1295
	// (get) Token: 0x06000B91 RID: 2961 RVA: 0x00005AD8 File Offset: 0x00003CD8
	[Token(Token = "0x1700050F")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000510 RID: 1296
	// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00005AF0 File Offset: 0x00003CF0
	[Token(Token = "0x17000510")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x854680", Offset = "0x852C80", VA = "0x180854680", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000511 RID: 1297
	// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000511")]
	private Type TypeObject
	{
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x8546A0", Offset = "0x852CA0", VA = "0x1808546A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x854740", Offset = "0x852D40", VA = "0x180854740", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000B96")]
	[Address(RVA = "0x8547F0", Offset = "0x852DF0", VA = "0x1808547F0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B97")]
	[Address(RVA = "0x854880", Offset = "0x852E80", VA = "0x180854880", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000276 RID: 630
	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x0")]
	internal static SfxFallHeavy_Meta Instance;
}
