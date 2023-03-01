using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000E6 RID: 230
[Token(Token = "0x20000E6")]
public class ServerShutdownAlert : MonoBehaviour
{
	// Token: 0x060006A0 RID: 1696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x2E894F0", Offset = "0x2E884F0", VA = "0x182E894F0")]
	private void Awake()
	{
	}

	// Token: 0x060006A1 RID: 1697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x2E896B0", Offset = "0x2E886B0", VA = "0x182E896B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060006A2 RID: 1698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x2E897E0", Offset = "0x2E887E0", VA = "0x182E897E0")]
	private void OnServerShutdown(string message)
	{
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public ServerShutdownAlert()
	{
	}

	// Token: 0x0400059F RID: 1439
	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _ui;

	// Token: 0x040005A0 RID: 1440
	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Text _messageText;
}
