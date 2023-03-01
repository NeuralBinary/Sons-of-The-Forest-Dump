using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Multiplayer;
using UnityEngine;

// Token: 0x020000EF RID: 239
[Token(Token = "0x20000EF")]
public class CoopDedicatedClientStarter : MonoBehaviour
{
	// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x2E74A90", Offset = "0x2E73A90", VA = "0x182E74A90")]
	private void Awake()
	{
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x2E74B70", Offset = "0x2E73B70", VA = "0x182E74B70")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x2E74B10", Offset = "0x2E73B10", VA = "0x182E74B10")]
	private void Connect()
	{
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public CoopDedicatedClientStarter()
	{
	}

	// Token: 0x040005C2 RID: 1474
	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ClientStarterSteam clientStarter;

	// Token: 0x040005C3 RID: 1475
	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x28")]
	public LoadAsync loadAsync;
}
