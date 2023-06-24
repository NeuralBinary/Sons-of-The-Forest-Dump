using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

// Token: 0x020000ED RID: 237
[Token(Token = "0x20000ED")]
public class CoopDedicatedClientStarter : MonoBehaviour
{
	// Token: 0x06000742 RID: 1858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000742")]
	[Address(RVA = "0x3673430", Offset = "0x3671A30", VA = "0x183673430")]
	private void Awake()
	{
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000743")]
	[Address(RVA = "0x36735A0", Offset = "0x3671BA0", VA = "0x1836735A0")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000744")]
	[Address(RVA = "0x3673630", Offset = "0x3671C30", VA = "0x183673630")]
	private void Connect()
	{
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CoopDedicatedClientStarter()
	{
	}

	// Token: 0x040005E1 RID: 1505
	[Token(Token = "0x40005E1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ClientStarterSteam clientStarter;

	// Token: 0x040005E2 RID: 1506
	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x28")]
	public LoadAsync loadAsync;
}
