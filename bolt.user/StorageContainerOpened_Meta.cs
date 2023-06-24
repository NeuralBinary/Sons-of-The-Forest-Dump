using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020001ED RID: 493
[Token(Token = "0x20001ED")]
internal class StorageContainerOpened_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001688 RID: 5768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001688")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public StorageContainerOpened_Meta()
	{
	}

	// Token: 0x170006D3 RID: 1747
	// (get) Token: 0x06001689 RID: 5769 RVA: 0x000075F0 File Offset: 0x000057F0
	[Token(Token = "0x170006D3")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x170006D4 RID: 1748
	// (get) Token: 0x0600168A RID: 5770 RVA: 0x00007608 File Offset: 0x00005808
	[Token(Token = "0x170006D4")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600168A")]
		[Address(RVA = "0x8AF560", Offset = "0x8ADB60", VA = "0x1808AF560", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x170006D5 RID: 1749
	// (get) Token: 0x0600168B RID: 5771 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170006D5")]
	private Type TypeObject
	{
		[Token(Token = "0x600168B")]
		[Address(RVA = "0x8AF580", Offset = "0x8ADB80", VA = "0x1808AF580", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600168C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600168D")]
	[Address(RVA = "0x8AF620", Offset = "0x8ADC20", VA = "0x1808AF620", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600168E")]
	[Address(RVA = "0x8AF930", Offset = "0x8ADF30", VA = "0x1808AF930", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600168F")]
	[Address(RVA = "0x8AF9C0", Offset = "0x8ADFC0", VA = "0x1808AF9C0", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x040002C7 RID: 711
	[Token(Token = "0x40002C7")]
	[FieldOffset(Offset = "0x0")]
	internal static StorageContainerOpened_Meta Instance;
}
