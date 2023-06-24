using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000126 RID: 294
[Token(Token = "0x2000126")]
public class flyingObjectFixerFrame : MonoBehaviour
{
	// Token: 0x060008D4 RID: 2260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x368C850", Offset = "0x368AE50", VA = "0x18368C850")]
	private void OnEnable()
	{
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x368CBC0", Offset = "0x368B1C0", VA = "0x18368CBC0")]
	private void OnDisable()
	{
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x368CD00", Offset = "0x368B300", VA = "0x18368CD00")]
	private IEnumerator dampRigidBody()
	{
		return null;
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x368CD90", Offset = "0x368B390", VA = "0x18368CD90")]
	public flyingObjectFixerFrame()
	{
	}

	// Token: 0x04000700 RID: 1792
	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x20")]
	public int frames;

	// Token: 0x04000701 RID: 1793
	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x24")]
	private float initAngularDrag;

	// Token: 0x04000702 RID: 1794
	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x28")]
	private float initDrag;

	// Token: 0x04000703 RID: 1795
	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rb;
}
