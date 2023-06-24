using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C2 RID: 194
[Token(Token = "0x20000C2")]
public class CoopOnDestroyCallback : MonoBehaviour
{
	// Token: 0x06000632 RID: 1586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000632")]
	[Address(RVA = "0x2E1C8C0", Offset = "0x2E1AEC0", VA = "0x182E1C8C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000633")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CoopOnDestroyCallback()
	{
	}

	// Token: 0x04000553 RID: 1363
	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x20")]
	public Action Callback;
}
