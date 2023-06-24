using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000E5 RID: 229
[Token(Token = "0x20000E5")]
internal class SpawnCutTree_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06000ABA RID: 2746 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SpawnCutTree_Meta()
	{
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00005958 File Offset: 0x00003B58
	[Token(Token = "0x170004F8")]
	private TypeId TypeId
	{
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00005970 File Offset: 0x00003B70
	[Token(Token = "0x170004F9")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x84E560", Offset = "0x84CB60", VA = "0x18084E560", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170004FA")]
	private Type TypeObject
	{
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x84E580", Offset = "0x84CB80", VA = "0x18084E580", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000ABF")]
	[Address(RVA = "0x84E620", Offset = "0x84CC20", VA = "0x18084E620", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x84F170", Offset = "0x84D770", VA = "0x18084F170", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC1")]
	[Address(RVA = "0x84F200", Offset = "0x84D800", VA = "0x18084F200", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x0400026F RID: 623
	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x0")]
	internal static SpawnCutTree_Meta Instance;
}
