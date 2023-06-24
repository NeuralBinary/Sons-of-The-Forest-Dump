using System;
using Il2CppDummyDll;
using Sons.Input;
using UnityEngine;

// Token: 0x0200022B RID: 555
[Token(Token = "0x200022B")]
public class MouseTester : MonoBehaviour
{
	// Token: 0x06000F81 RID: 3969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F81")]
	[Address(RVA = "0x3729C10", Offset = "0x3728210", VA = "0x183729C10")]
	private void ToggleCursorLock()
	{
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x3729D90", Offset = "0x3728390", VA = "0x183729D90")]
	private void ToggleCursorVis()
	{
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x3729E60", Offset = "0x3728460", VA = "0x183729E60")]
	private void Update()
	{
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x372A5C0", Offset = "0x3728BC0", VA = "0x18372A5C0")]
	public MouseTester()
	{
	}

	// Token: 0x04000E58 RID: 3672
	[Token(Token = "0x4000E58")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 _mouse;

	// Token: 0x04000E59 RID: 3673
	[Token(Token = "0x4000E59")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 _mouseUnity;

	// Token: 0x04000E5A RID: 3674
	[Token(Token = "0x4000E5A")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 _mouseNew;

	// Token: 0x04000E5B RID: 3675
	[Token(Token = "0x4000E5B")]
	[FieldOffset(Offset = "0x38")]
	public SonsInputMapping _newMapping;

	// Token: 0x04000E5C RID: 3676
	[Token(Token = "0x4000E5C")]
	[FieldOffset(Offset = "0x40")]
	public string CursorState;
}
