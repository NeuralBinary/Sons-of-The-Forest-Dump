using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020F RID: 527
[Token(Token = "0x200020F")]
public class LakeTrigger : MonoBehaviour
{
	// Token: 0x06000E65 RID: 3685 RVA: 0x00005760 File Offset: 0x00003960
	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x3718020", Offset = "0x3716620", VA = "0x183718020")]
	private Vector3 GetSplashPosition(Vector3 position)
	{
		return default(Vector3);
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E66")]
	[Address(RVA = "0x3718120", Offset = "0x3716720", VA = "0x183718120")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E67")]
	[Address(RVA = "0x37184C0", Offset = "0x3716AC0", VA = "0x1837184C0")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E68")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public LakeTrigger()
	{
	}

	// Token: 0x04000D53 RID: 3411
	[Token(Token = "0x4000D53")]
	[FieldOffset(Offset = "0x20")]
	public Transform MyParticle;

	// Token: 0x04000D54 RID: 3412
	[Token(Token = "0x4000D54")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BigSplash;
}
