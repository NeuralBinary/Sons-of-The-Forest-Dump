using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000039")]
public class BreakableObjectBreaker : MonoBehaviour
{
	// Token: 0x06000177 RID: 375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x2F7EAF0", Offset = "0x2F7D0F0", VA = "0x182F7EAF0")]
	private void Start()
	{
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x2F7ECC0", Offset = "0x2F7D2C0", VA = "0x182F7ECC0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x2F7ECD0", Offset = "0x2F7D2D0", VA = "0x182F7ECD0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x2F7ED20", Offset = "0x2F7D320", VA = "0x182F7ED20")]
	private void TryBreak(Collider other)
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public BreakableObjectBreaker()
	{
	}

	// Token: 0x0400017D RID: 381
	[Token(Token = "0x400017D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _checkForBreakableTag;
}
