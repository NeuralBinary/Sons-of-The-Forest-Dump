using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000210 RID: 528
[Token(Token = "0x2000210")]
public class LakeTrigger : MonoBehaviour
{
	// Token: 0x06000E0A RID: 3594 RVA: 0x00005520 File Offset: 0x00003720
	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x2F8EE00", Offset = "0x2F8DE00", VA = "0x182F8EE00")]
	private Vector3 GetSplashPosition(Vector3 position)
	{
		return default(Vector3);
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x2F8EE60", Offset = "0x2F8DE60", VA = "0x182F8EE60")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x2F8F020", Offset = "0x2F8E020", VA = "0x182F8F020")]
	private void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public LakeTrigger()
	{
	}

	// Token: 0x04000D24 RID: 3364
	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0x20")]
	public Transform MyParticle;

	// Token: 0x04000D25 RID: 3365
	[Token(Token = "0x4000D25")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BigSplash;
}
