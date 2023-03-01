using System;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR.InteractionSystem;

// Token: 0x020002A8 RID: 680
[Token(Token = "0x20002A8")]
public class RadialMenu : MonoBehaviour
{
	// Token: 0x060011A5 RID: 4517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x2B85FB0", Offset = "0x2B84FB0", VA = "0x182B85FB0")]
	private void Awake()
	{
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x2B86500", Offset = "0x2B85500", VA = "0x182B86500")]
	private void Update()
	{
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x2B86030", Offset = "0x2B85030", VA = "0x182B86030")]
	private void SetVisible(bool newVisible)
	{
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x2B86380", Offset = "0x2B85380", VA = "0x182B86380")]
	private void UpdateCursor()
	{
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x2B86430", Offset = "0x2B85430", VA = "0x182B86430")]
	private void UpdateSelectedIndex()
	{
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x2B868E0", Offset = "0x2B858E0", VA = "0x182B868E0")]
	public RadialMenu()
	{
	}

	// Token: 0x0400116E RID: 4462
	[Token(Token = "0x400116E")]
	[FieldOffset(Offset = "0x20")]
	public int SelectedIndex;

	// Token: 0x0400116F RID: 4463
	[Token(Token = "0x400116F")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 ExtraPositionOffset;

	// Token: 0x04001170 RID: 4464
	[Token(Token = "0x4001170")]
	[FieldOffset(Offset = "0x30")]
	public RadialButton[] OutsideButtons;

	// Token: 0x04001171 RID: 4465
	[Token(Token = "0x4001171")]
	[FieldOffset(Offset = "0x38")]
	public RadialButton CenterButton;

	// Token: 0x04001172 RID: 4466
	[Token(Token = "0x4001172")]
	[FieldOffset(Offset = "0x40")]
	public Hand SourceHand;

	// Token: 0x04001173 RID: 4467
	[Token(Token = "0x4001173")]
	[FieldOffset(Offset = "0x48")]
	public float RadialPosition;

	// Token: 0x04001174 RID: 4468
	[Token(Token = "0x4001174")]
	[FieldOffset(Offset = "0x4C")]
	public Vector2 SourceValues;

	// Token: 0x04001175 RID: 4469
	[Token(Token = "0x4001175")]
	[FieldOffset(Offset = "0x58")]
	public Transform Cursor;

	// Token: 0x04001176 RID: 4470
	[Token(Token = "0x4001176")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 CursorScale;

	// Token: 0x04001177 RID: 4471
	[Token(Token = "0x4001177")]
	[FieldOffset(Offset = "0x68")]
	public bool Manual;

	// Token: 0x04001178 RID: 4472
	[Token(Token = "0x4001178")]
	[FieldOffset(Offset = "0x6C")]
	public float SpeedMultiplier;

	// Token: 0x04001179 RID: 4473
	[Token(Token = "0x4001179")]
	[FieldOffset(Offset = "0x70")]
	public float CenterThreshold;

	// Token: 0x0400117A RID: 4474
	[Token(Token = "0x400117A")]
	[FieldOffset(Offset = "0x74")]
	public float IgnoreThreshold;

	// Token: 0x0400117B RID: 4475
	[Token(Token = "0x400117B")]
	[FieldOffset(Offset = "0x78")]
	public bool IsVisible;
}
