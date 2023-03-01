using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A1 RID: 417
[Token(Token = "0x20001A1")]
public class FTEM_StopCam : MonoBehaviour
{
	// Token: 0x06000BFB RID: 3067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFB")]
	[Address(RVA = "0x2F634B0", Offset = "0x2F624B0", VA = "0x182F634B0")]
	private void Start()
	{
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x2F63450", Offset = "0x2F62450", VA = "0x182F63450")]
	private void OnMouseDown()
	{
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x6CBFC0", Offset = "0x6CAFC0", VA = "0x1806CBFC0")]
	public FTEM_StopCam()
	{
	}

	// Token: 0x04000AB8 RID: 2744
	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x20")]
	public bool myCheck;

	// Token: 0x04000AB9 RID: 2745
	[Token(Token = "0x4000AB9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject camObject;

	// Token: 0x04000ABA RID: 2746
	[Token(Token = "0x4000ABA")]
	[FieldOffset(Offset = "0x30")]
	private Animator camAnim;
}
