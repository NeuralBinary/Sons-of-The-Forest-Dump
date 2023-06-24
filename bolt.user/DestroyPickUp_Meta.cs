using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000BB RID: 187
[Token(Token = "0x20000BB")]
internal class DestroyPickUp_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600089A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public DestroyPickUp_Meta()
	{
	}

	// Token: 0x1700048E RID: 1166
	// (get) Token: 0x0600089B RID: 2203 RVA: 0x00005250 File Offset: 0x00003450
	[Token(Token = "0x1700048E")]
	private TypeId TypeId
	{
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700048F RID: 1167
	// (get) Token: 0x0600089C RID: 2204 RVA: 0x00005268 File Offset: 0x00003468
	[Token(Token = "0x1700048F")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x8398D0", Offset = "0x837ED0", VA = "0x1808398D0", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000490 RID: 1168
	// (get) Token: 0x0600089D RID: 2205 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000490")]
	private Type TypeObject
	{
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x8398F0", Offset = "0x837EF0", VA = "0x1808398F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600089E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600089F")]
	[Address(RVA = "0x839990", Offset = "0x837F90", VA = "0x180839990", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x839FD0", Offset = "0x8385D0", VA = "0x180839FD0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x83A060", Offset = "0x838660", VA = "0x18083A060", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000261 RID: 609
	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x0")]
	internal static DestroyPickUp_Meta Instance;
}
