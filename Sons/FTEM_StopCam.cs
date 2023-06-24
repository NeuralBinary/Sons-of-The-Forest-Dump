using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A0 RID: 416
[Token(Token = "0x20001A0")]
public class FTEM_StopCam : MonoBehaviour
{
	// Token: 0x06000C55 RID: 3157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x36E5100", Offset = "0x36E3700", VA = "0x1836E5100")]
	private void Start()
	{
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x36E5190", Offset = "0x36E3790", VA = "0x1836E5190")]
	private void OnMouseDown()
	{
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
	public FTEM_StopCam()
	{
	}

	// Token: 0x04000AE3 RID: 2787
	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0x20")]
	public bool myCheck;

	// Token: 0x04000AE4 RID: 2788
	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject camObject;

	// Token: 0x04000AE5 RID: 2789
	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0x30")]
	private Animator camAnim;
}
