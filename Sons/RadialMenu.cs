using System;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR.InteractionSystem;

// Token: 0x0200029C RID: 668
[Token(Token = "0x200029C")]
public class RadialMenu : MonoBehaviour
{
	// Token: 0x060011DA RID: 4570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x31CED70", Offset = "0x31CD370", VA = "0x1831CED70")]
	private void Awake()
	{
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x31CEE50", Offset = "0x31CD450", VA = "0x1831CEE50")]
	private void Update()
	{
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x31CF3D0", Offset = "0x31CD9D0", VA = "0x1831CF3D0")]
	private void SetVisible(bool newVisible)
	{
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x31CF9B0", Offset = "0x31CDFB0", VA = "0x1831CF9B0")]
	private void UpdateCursor()
	{
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x31CFB60", Offset = "0x31CE160", VA = "0x1831CFB60")]
	private void UpdateSelectedIndex()
	{
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x31CFC30", Offset = "0x31CE230", VA = "0x1831CFC30")]
	public RadialMenu()
	{
	}

	// Token: 0x04001195 RID: 4501
	[Token(Token = "0x4001195")]
	[FieldOffset(Offset = "0x20")]
	public int SelectedIndex;

	// Token: 0x04001196 RID: 4502
	[Token(Token = "0x4001196")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 ExtraPositionOffset;

	// Token: 0x04001197 RID: 4503
	[Token(Token = "0x4001197")]
	[FieldOffset(Offset = "0x30")]
	public RadialButton[] OutsideButtons;

	// Token: 0x04001198 RID: 4504
	[Token(Token = "0x4001198")]
	[FieldOffset(Offset = "0x38")]
	public RadialButton CenterButton;

	// Token: 0x04001199 RID: 4505
	[Token(Token = "0x4001199")]
	[FieldOffset(Offset = "0x40")]
	public Hand SourceHand;

	// Token: 0x0400119A RID: 4506
	[Token(Token = "0x400119A")]
	[FieldOffset(Offset = "0x48")]
	public float RadialPosition;

	// Token: 0x0400119B RID: 4507
	[Token(Token = "0x400119B")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 SourceValues;

	// Token: 0x0400119C RID: 4508
	[Token(Token = "0x400119C")]
	[FieldOffset(Offset = "0x58")]
	public Transform Cursor;

	// Token: 0x0400119D RID: 4509
	[Token(Token = "0x400119D")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 CursorScale;

	// Token: 0x0400119E RID: 4510
	[Token(Token = "0x400119E")]
	[FieldOffset(Offset = "0x68")]
	public bool Manual;

	// Token: 0x0400119F RID: 4511
	[Token(Token = "0x400119F")]
	[FieldOffset(Offset = "0x6C")]
	public float SpeedMultiplier;

	// Token: 0x040011A0 RID: 4512
	[Token(Token = "0x40011A0")]
	[FieldOffset(Offset = "0x70")]
	public float CenterThreshold;

	// Token: 0x040011A1 RID: 4513
	[Token(Token = "0x40011A1")]
	[FieldOffset(Offset = "0x74")]
	public float IgnoreThreshold;

	// Token: 0x040011A2 RID: 4514
	[Token(Token = "0x40011A2")]
	[FieldOffset(Offset = "0x78")]
	public bool IsVisible;
}
