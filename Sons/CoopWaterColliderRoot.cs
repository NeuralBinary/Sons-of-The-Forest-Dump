using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D7 RID: 215
[Token(Token = "0x20000D7")]
public class CoopWaterColliderRoot : MonoBehaviour
{
	// Token: 0x060006AB RID: 1707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x35222E0", Offset = "0x35208E0", VA = "0x1835222E0")]
	private void Awake()
	{
	}

	// Token: 0x060006AC RID: 1708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public CoopWaterColliderRoot()
	{
	}

	// Token: 0x04000586 RID: 1414
	[Token(Token = "0x4000586")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CoopWaterCollider[] _all;

	// Token: 0x04000587 RID: 1415
	[Token(Token = "0x4000587")]
	[FieldOffset(Offset = "0x0")]
	public static CoopWaterCollider[] All;
}
