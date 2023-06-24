using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002A7 RID: 679
[Token(Token = "0x20002A7")]
internal class SetPlayerSpawnPoint_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001F1A RID: 7962 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public SetPlayerSpawnPoint_Meta()
	{
	}

	// Token: 0x1700084C RID: 2124
	// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00008E98 File Offset: 0x00007098
	[Token(Token = "0x1700084C")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001F1B")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700084D RID: 2125
	// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00008EB0 File Offset: 0x000070B0
	[Token(Token = "0x1700084D")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x7FC800", Offset = "0x7FAE00", VA = "0x1807FC800", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700084E RID: 2126
	// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700084E")]
	private Type TypeObject
	{
		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x7FC820", Offset = "0x7FAE20", VA = "0x1807FC820", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001F1F RID: 7967 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0x7FC8C0", Offset = "0x7FAEC0", VA = "0x1807FC8C0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x7FCDD0", Offset = "0x7FB3D0", VA = "0x1807FCDD0", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F21")]
	[Address(RVA = "0x7FCE60", Offset = "0x7FB460", VA = "0x1807FCE60", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000305 RID: 773
	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x0")]
	internal static SetPlayerSpawnPoint_Meta Instance;
}
