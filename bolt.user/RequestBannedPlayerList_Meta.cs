using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020002B0 RID: 688
[Token(Token = "0x20002B0")]
internal class RequestBannedPlayerList_Meta : Event_Meta, IEventFactory, IFactory
{
	// Token: 0x06001F5C RID: 8028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F5C")]
	[Address(RVA = "0x7D7A90", Offset = "0x7D6090", VA = "0x1807D7A90")]
	public RequestBannedPlayerList_Meta()
	{
	}

	// Token: 0x17000859 RID: 2137
	// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00008F70 File Offset: 0x00007170
	[Token(Token = "0x17000859")]
	private TypeId TypeId
	{
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "8")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x1700085A RID: 2138
	// (get) Token: 0x06001F5E RID: 8030 RVA: 0x00008F88 File Offset: 0x00007188
	[Token(Token = "0x1700085A")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0x7FF120", Offset = "0x7FD720", VA = "0x1807FF120", Slot = "9")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x1700085B RID: 2139
	// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700085B")]
	private Type TypeObject
	{
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x7FF140", Offset = "0x7FD740", VA = "0x1807FF140", Slot = "7")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001F60 RID: 8032 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F60")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F61")]
	[Address(RVA = "0x7FF1E0", Offset = "0x7FD7E0", VA = "0x1807FF1E0", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F62")]
	[Address(RVA = "0x7FF290", Offset = "0x7FD890", VA = "0x1807FF290", Slot = "10")]
	private object Create()
	{
		return null;
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F63")]
	[Address(RVA = "0x7FF320", Offset = "0x7FD920", VA = "0x1807FF320", Slot = "6")]
	private void Dispatch(Event ev, object target)
	{
	}

	// Token: 0x04000308 RID: 776
	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x0")]
	internal static RequestBannedPlayerList_Meta Instance;
}
