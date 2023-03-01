using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000AE RID: 174
[Token(Token = "0x20000AE")]
public class CoopDisabledOtherOnEnable : MonoBehaviour
{
	// Token: 0x060005A3 RID: 1443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A3")]
	[Address(RVA = "0x2E75D50", Offset = "0x2E74D50", VA = "0x182E75D50")]
	private void OnEnable()
	{
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A4")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public CoopDisabledOtherOnEnable()
	{
	}

	// Token: 0x04000503 RID: 1283
	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x20")]
	public bool OnlyOnClient;

	// Token: 0x04000504 RID: 1284
	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Other;
}
