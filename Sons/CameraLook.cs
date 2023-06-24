using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D6 RID: 470
[Token(Token = "0x20001D6")]
public class CameraLook : MonoBehaviour
{
	// Token: 0x06000D8A RID: 3466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x37029C0", Offset = "0x3700FC0", VA = "0x1837029C0")]
	private void Update()
	{
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x3703000", Offset = "0x3701600", VA = "0x183703000")]
	public CameraLook()
	{
	}

	// Token: 0x04000C4E RID: 3150
	[Token(Token = "0x4000C4E")]
	[FieldOffset(Offset = "0x20")]
	public CameraLook.RotationAxes axes;

	// Token: 0x04000C4F RID: 3151
	[Token(Token = "0x4000C4F")]
	[FieldOffset(Offset = "0x24")]
	public float mousesensitivityX;

	// Token: 0x04000C50 RID: 3152
	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x28")]
	public float mousesensitivityY;

	// Token: 0x04000C51 RID: 3153
	[Token(Token = "0x4000C51")]
	[FieldOffset(Offset = "0x2C")]
	public float joysensitivityX;

	// Token: 0x04000C52 RID: 3154
	[Token(Token = "0x4000C52")]
	[FieldOffset(Offset = "0x30")]
	public float joysensitivityY;

	// Token: 0x04000C53 RID: 3155
	[Token(Token = "0x4000C53")]
	[FieldOffset(Offset = "0x34")]
	public float minimumX;

	// Token: 0x04000C54 RID: 3156
	[Token(Token = "0x4000C54")]
	[FieldOffset(Offset = "0x38")]
	public float maximumX;

	// Token: 0x04000C55 RID: 3157
	[Token(Token = "0x4000C55")]
	[FieldOffset(Offset = "0x3C")]
	public float minimumY;

	// Token: 0x04000C56 RID: 3158
	[Token(Token = "0x4000C56")]
	[FieldOffset(Offset = "0x40")]
	public float maximumY;

	// Token: 0x04000C57 RID: 3159
	[Token(Token = "0x4000C57")]
	[FieldOffset(Offset = "0x44")]
	private float rotationY;

	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	public enum RotationAxes
	{
		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		MouseXAndY,
		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		MouseX,
		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		MouseY
	}
}
