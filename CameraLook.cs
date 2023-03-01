using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D7 RID: 471
[Token(Token = "0x20001D7")]
public class CameraLook : MonoBehaviour
{
	// Token: 0x06000D2F RID: 3375 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D2F")]
	[Address(RVA = "0x2F7EBD0", Offset = "0x2F7DBD0", VA = "0x182F7EBD0")]
	private void Update()
	{
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D30")]
	[Address(RVA = "0x2F7F080", Offset = "0x2F7E080", VA = "0x182F7F080")]
	public CameraLook()
	{
	}

	// Token: 0x04000C1F RID: 3103
	[Token(Token = "0x4000C1F")]
	[FieldOffset(Offset = "0x20")]
	public CameraLook.RotationAxes axes;

	// Token: 0x04000C20 RID: 3104
	[Token(Token = "0x4000C20")]
	[FieldOffset(Offset = "0x24")]
	public float mousesensitivityX;

	// Token: 0x04000C21 RID: 3105
	[Token(Token = "0x4000C21")]
	[FieldOffset(Offset = "0x28")]
	public float mousesensitivityY;

	// Token: 0x04000C22 RID: 3106
	[Token(Token = "0x4000C22")]
	[FieldOffset(Offset = "0x2C")]
	public float joysensitivityX;

	// Token: 0x04000C23 RID: 3107
	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0x30")]
	public float joysensitivityY;

	// Token: 0x04000C24 RID: 3108
	[Token(Token = "0x4000C24")]
	[FieldOffset(Offset = "0x34")]
	public float minimumX;

	// Token: 0x04000C25 RID: 3109
	[Token(Token = "0x4000C25")]
	[FieldOffset(Offset = "0x38")]
	public float maximumX;

	// Token: 0x04000C26 RID: 3110
	[Token(Token = "0x4000C26")]
	[FieldOffset(Offset = "0x3C")]
	public float minimumY;

	// Token: 0x04000C27 RID: 3111
	[Token(Token = "0x4000C27")]
	[FieldOffset(Offset = "0x40")]
	public float maximumY;

	// Token: 0x04000C28 RID: 3112
	[Token(Token = "0x4000C28")]
	[FieldOffset(Offset = "0x44")]
	private float rotationY;

	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	public enum RotationAxes
	{
		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		MouseXAndY,
		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		MouseX,
		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		MouseY
	}
}
