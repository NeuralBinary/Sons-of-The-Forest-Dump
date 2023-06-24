using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AD RID: 173
[Token(Token = "0x20000AD")]
public class CoopDisabledOtherOnEnable : MonoBehaviour
{
	// Token: 0x060005DD RID: 1501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x350F6E0", Offset = "0x350DCE0", VA = "0x18350F6E0")]
	private void OnEnable()
	{
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CoopDisabledOtherOnEnable()
	{
	}

	// Token: 0x04000524 RID: 1316
	[Token(Token = "0x4000524")]
	[FieldOffset(Offset = "0x20")]
	public bool OnlyOnClient;

	// Token: 0x04000525 RID: 1317
	[Token(Token = "0x4000525")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Other;
}
