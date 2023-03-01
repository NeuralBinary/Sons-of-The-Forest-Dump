using System;
using Il2CppDummyDll;
using Sons.Input;
using UnityEngine;

// Token: 0x0200022C RID: 556
[Token(Token = "0x200022C")]
public class MouseTester : MonoBehaviour
{
	// Token: 0x06000F1B RID: 3867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0x2F9B510", Offset = "0x2F9A510", VA = "0x182F9B510")]
	private void ToggleCursorLock()
	{
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0x2F9B5A0", Offset = "0x2F9A5A0", VA = "0x182F9B5A0")]
	private void ToggleCursorVis()
	{
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0x2F9B5C0", Offset = "0x2F9A5C0", VA = "0x182F9B5C0")]
	private void Update()
	{
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0x2F9B8E0", Offset = "0x2F9A8E0", VA = "0x182F9B8E0")]
	public MouseTester()
	{
	}

	// Token: 0x04000E23 RID: 3619
	[Token(Token = "0x4000E23")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 _mouse;

	// Token: 0x04000E24 RID: 3620
	[Token(Token = "0x4000E24")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 _mouseUnity;

	// Token: 0x04000E25 RID: 3621
	[Token(Token = "0x4000E25")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 _mouseNew;

	// Token: 0x04000E26 RID: 3622
	[Token(Token = "0x4000E26")]
	[FieldOffset(Offset = "0x38")]
	public SonsInputMapping _newMapping;

	// Token: 0x04000E27 RID: 3623
	[Token(Token = "0x4000E27")]
	[FieldOffset(Offset = "0x40")]
	public string CursorState;
}
