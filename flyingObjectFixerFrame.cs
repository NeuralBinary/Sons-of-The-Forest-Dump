using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000129 RID: 297
[Token(Token = "0x2000129")]
public class flyingObjectFixerFrame : MonoBehaviour
{
	// Token: 0x0600088D RID: 2189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088D")]
	[Address(RVA = "0x2F48880", Offset = "0x2F47880", VA = "0x182F48880")]
	private void OnEnable()
	{
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088E")]
	[Address(RVA = "0x2F487E0", Offset = "0x2F477E0", VA = "0x182F487E0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600088F")]
	[Address(RVA = "0x2F489F0", Offset = "0x2F479F0", VA = "0x182F489F0")]
	private IEnumerator dampRigidBody()
	{
		return null;
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000890")]
	[Address(RVA = "0x2F489E0", Offset = "0x2F479E0", VA = "0x182F489E0")]
	public flyingObjectFixerFrame()
	{
	}

	// Token: 0x040006E4 RID: 1764
	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x20")]
	public int frames;

	// Token: 0x040006E5 RID: 1765
	[Token(Token = "0x40006E5")]
	[FieldOffset(Offset = "0x24")]
	private float initAngularDrag;

	// Token: 0x040006E6 RID: 1766
	[Token(Token = "0x40006E6")]
	[FieldOffset(Offset = "0x28")]
	private float initDrag;

	// Token: 0x040006E7 RID: 1767
	[Token(Token = "0x40006E7")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rb;
}
