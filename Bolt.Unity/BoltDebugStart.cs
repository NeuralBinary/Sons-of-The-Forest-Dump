using System;
using BoltInternal;
using Il2CppDummyDll;
using UdpKit;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class BoltDebugStart : GlobalEventListenerBase
{
	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7A4210", Offset = "0x7A2810", VA = "0x1807A4210")]
	private void Awake()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7A42E0", Offset = "0x7A28E0", VA = "0x1807A42E0")]
	private void Start()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7A45D0", Offset = "0x7A2BD0", VA = "0x1807A45D0", Slot = "13")]
	public override void BoltStartDone()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7A4710", Offset = "0x7A2D10", VA = "0x1807A4710", Slot = "19")]
	public override void SceneLoadLocalDone(string arg)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x7A47A0", Offset = "0x7A2DA0", VA = "0x1807A47A0")]
	public BoltDebugStart()
	{
	}

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x38")]
	private UdpEndPoint _serverEndPoint;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x40")]
	private UdpEndPoint _clientEndPoint;
}
