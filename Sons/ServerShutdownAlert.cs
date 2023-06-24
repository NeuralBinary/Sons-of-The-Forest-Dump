using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

// Token: 0x020000E4 RID: 228
[Token(Token = "0x20000E4")]
public class ServerShutdownAlert : MonoBehaviour
{
	// Token: 0x060006EB RID: 1771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x3529090", Offset = "0x3527690", VA = "0x183529090")]
	private void Awake()
	{
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x35292F0", Offset = "0x35278F0", VA = "0x1835292F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x3529460", Offset = "0x3527A60", VA = "0x183529460")]
	private void OnServerShutdown(string message)
	{
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ServerShutdownAlert()
	{
	}

	// Token: 0x040005BC RID: 1468
	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _ui;

	// Token: 0x040005BD RID: 1469
	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Text _messageText;
}
