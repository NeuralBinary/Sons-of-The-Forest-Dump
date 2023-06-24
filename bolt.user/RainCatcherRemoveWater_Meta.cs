using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200028C RID: 652
[Token(Token = "0x200028C")]
internal class RainCatcherRemoveWater_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001DE6 RID: 7654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DE6")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RainCatcherRemoveWater_Meta()
	{
	}

	// Token: 0x1700081A RID: 2074
	// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00008B68 File Offset: 0x00006D68
	[Token(Token = "0x1700081A")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001DE7")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700081B RID: 2075
	// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00008B80 File Offset: 0x00006D80
	[Token(Token = "0x1700081B")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0x7F2D20", Offset = "0x7F1320", VA = "0x1807F2D20", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700081C RID: 2076
	// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700081C")]
	private Type TypeObject
	{
		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0x7F2D40", Offset = "0x7F1340", VA = "0x1807F2D40", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DEB")]
	[Address(RVA = "0x7F2DE0", Offset = "0x7F13E0", VA = "0x1807F2DE0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0x7F3110", Offset = "0x7F1710", VA = "0x1807F3110", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DED")]
	[Address(RVA = "0x7F31A0", Offset = "0x7F17A0", VA = "0x1807F31A0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002FC RID: 764
	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x0")]
	internal static RainCatcherRemoveWater_Meta Instance;
}
