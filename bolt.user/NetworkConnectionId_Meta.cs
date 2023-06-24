using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
internal class NetworkConnectionId_Meta : NetworkObj_Meta, IFactory
{
	// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x7BA310", Offset = "0x7B8910", VA = "0x1807BA310")]
	public NetworkConnectionId_Meta()
	{
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x0600007F RID: 127 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x17000031")]
	private TypeId TypeId
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "7")]
		get
		{
			return default(TypeId);
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000080 RID: 128 RVA: 0x000023E8 File Offset: 0x000005E8
	[Token(Token = "0x17000032")]
	private UniqueId TypeKey
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x7BA360", Offset = "0x7B8960", VA = "0x1807BA360", Slot = "8")]
		get
		{
			return default(UniqueId);
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000081 RID: 129 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000033")]
	private Type TypeObject
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x7BA380", Offset = "0x7B8980", VA = "0x1807BA380", Slot = "6")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
	internal override void InitObject(NetworkObj obj, NetworkObj_Meta.Offsets offsets)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x7BA420", Offset = "0x7B8A20", VA = "0x1807BA420", Slot = "5")]
	internal override void InitMeta()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x7BA610", Offset = "0x7B8C10", VA = "0x1807BA610", Slot = "9")]
	private object Create()
	{
		return null;
	}

	// Token: 0x0400022A RID: 554
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x0")]
	internal static NetworkConnectionId_Meta Instance;
}
