using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000205 RID: 517
[Token(Token = "0x2000205")]
public class LaserPointer : MonoBehaviour
{
	// Token: 0x06000DE7 RID: 3559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x2F8F8C0", Offset = "0x2F8E8C0", VA = "0x182F8F8C0")]
	private void Update()
	{
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x2F8F1A0", Offset = "0x2F8E1A0", VA = "0x182F8F1A0")]
	private void DoInventoryAndMenusUpdate()
	{
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x2F8F680", Offset = "0x2F8E680", VA = "0x182F8F680")]
	private void UpdateLaser()
	{
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x2F8F4E0", Offset = "0x2F8E4E0", VA = "0x182F8F4E0")]
	private void UpdateEnd()
	{
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x2F8F760", Offset = "0x2F8E760", VA = "0x182F8F760")]
	private void UpdateLayer()
	{
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x2F8FB40", Offset = "0x2F8EB40", VA = "0x182F8FB40")]
	public LaserPointer()
	{
	}

	// Token: 0x04000D07 RID: 3335
	[Token(Token = "0x4000D07")]
	[FieldOffset(Offset = "0x20")]
	public float Length;

	// Token: 0x04000D08 RID: 3336
	[Token(Token = "0x4000D08")]
	[FieldOffset(Offset = "0x28")]
	public Transform Reference;

	// Token: 0x04000D09 RID: 3337
	[Token(Token = "0x4000D09")]
	[FieldOffset(Offset = "0x30")]
	public Transform Laser;

	// Token: 0x04000D0A RID: 3338
	[Token(Token = "0x4000D0A")]
	[FieldOffset(Offset = "0x38")]
	public Transform End;

	// Token: 0x04000D0B RID: 3339
	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> PauseMenuObjects;

	// Token: 0x04000D0C RID: 3340
	[Token(Token = "0x4000D0C")]
	[FieldOffset(Offset = "0x48")]
	public float MaxCastDistance;

	// Token: 0x04000D0D RID: 3341
	[Token(Token = "0x4000D0D")]
	[FieldOffset(Offset = "0x4C")]
	public LayerMask InventoryCastLayers;

	// Token: 0x04000D0E RID: 3342
	[Token(Token = "0x4000D0E")]
	[FieldOffset(Offset = "0x50")]
	public LayerMask PlaceGhostCastLayers;

	// Token: 0x04000D0F RID: 3343
	[Token(Token = "0x4000D0F")]
	[FieldOffset(Offset = "0x54")]
	private bool _showEnd;

	// Token: 0x04000D10 RID: 3344
	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x0")]
	public static Vector3 LastRenderTextureHitViewportPos;
}
