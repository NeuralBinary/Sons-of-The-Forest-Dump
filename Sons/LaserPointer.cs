using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000204 RID: 516
[Token(Token = "0x2000204")]
public class LaserPointer : MonoBehaviour
{
	// Token: 0x06000E42 RID: 3650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E42")]
	[Address(RVA = "0x3715D90", Offset = "0x3714390", VA = "0x183715D90")]
	private void Update()
	{
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E43")]
	[Address(RVA = "0x3715DE0", Offset = "0x37143E0", VA = "0x183715DE0")]
	private void DoInventoryAndMenusUpdate()
	{
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E44")]
	[Address(RVA = "0x3716260", Offset = "0x3714860", VA = "0x183716260")]
	private void UpdateLaser()
	{
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E45")]
	[Address(RVA = "0x3716480", Offset = "0x3714A80", VA = "0x183716480")]
	private void UpdateEnd()
	{
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E46")]
	[Address(RVA = "0x37167C0", Offset = "0x3714DC0", VA = "0x1837167C0")]
	private void UpdateLayer()
	{
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E47")]
	[Address(RVA = "0x37169B0", Offset = "0x3714FB0", VA = "0x1837169B0")]
	public LaserPointer()
	{
	}

	// Token: 0x04000D36 RID: 3382
	[Token(Token = "0x4000D36")]
	[FieldOffset(Offset = "0x20")]
	public float Length;

	// Token: 0x04000D37 RID: 3383
	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0x28")]
	public Transform Reference;

	// Token: 0x04000D38 RID: 3384
	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x30")]
	public Transform Laser;

	// Token: 0x04000D39 RID: 3385
	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x38")]
	public Transform End;

	// Token: 0x04000D3A RID: 3386
	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x40")]
	public List<GameObject> PauseMenuObjects;

	// Token: 0x04000D3B RID: 3387
	[Token(Token = "0x4000D3B")]
	[FieldOffset(Offset = "0x48")]
	public float MaxCastDistance;

	// Token: 0x04000D3C RID: 3388
	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x4C")]
	public LayerMask InventoryCastLayers;

	// Token: 0x04000D3D RID: 3389
	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x50")]
	public LayerMask PlaceGhostCastLayers;

	// Token: 0x04000D3E RID: 3390
	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x54")]
	private bool _showEnd;

	// Token: 0x04000D3F RID: 3391
	[Token(Token = "0x4000D3F")]
	[FieldOffset(Offset = "0x0")]
	public static Vector3 LastRenderTextureHitViewportPos;
}
