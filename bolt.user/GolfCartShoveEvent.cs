using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A9 RID: 681
[Token(Token = "0x20002A9")]
public class GolfCartShoveEvent : Event
{
	// Token: 0x06001F23 RID: 7971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001F23")]
	[Address(RVA = "0x7FCF80", Offset = "0x7FB580", VA = "0x1807FCF80")]
	public GolfCartShoveEvent()
	{
	}

	// Token: 0x1700084F RID: 2127
	// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00008EC8 File Offset: 0x000070C8
	// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700084F")]
	public Vector3 ShoveVector
	{
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x7D3CB0", Offset = "0x7D22B0", VA = "0x1807D3CB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x7FCFE0", Offset = "0x7FB5E0", VA = "0x1807FCFE0")]
		set
		{
		}
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F26")]
	[Address(RVA = "0x7FD0E0", Offset = "0x7FB6E0", VA = "0x1807FD0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F27")]
	[Address(RVA = "0x7FD190", Offset = "0x7FB790", VA = "0x1807FD190")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GolfCartShoveEvent Raise(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F28")]
	[Address(RVA = "0x7FD1A0", Offset = "0x7FB7A0", VA = "0x1807FD1A0")]
	[Obsolete("This method is obsolete, use 'Create' instead")]
	public static GolfCartShoveEvent Raise(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F29")]
	[Address(RVA = "0x7FD190", Offset = "0x7FB790", VA = "0x1807FD190")]
	public static GolfCartShoveEvent Create(BoltEntity entity)
	{
		return null;
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6001F2A")]
	[Address(RVA = "0x7FD3A0", Offset = "0x7FB9A0", VA = "0x1807FD3A0")]
	public static GolfCartShoveEvent Create(BoltEntity entity, EntityTargets targets)
	{
		return null;
	}
}
