using System;
using Ballistics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000038")]
public class BloodSplatter : MonoBehaviour
{
	// Token: 0x06000173 RID: 371 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x2F7E290", Offset = "0x2F7C890", VA = "0x182F7E290")]
	private void OnEnable()
	{
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x2F7E330", Offset = "0x2F7C930", VA = "0x182F7E330")]
	private void OnDisable()
	{
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2F7E400", Offset = "0x2F7CA00", VA = "0x182F7E400")]
	private void OnImpact(SurfaceImpactInfo surfaceImpactInfo)
	{
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x2F7EA90", Offset = "0x2F7D090", VA = "0x182F7EA90")]
	public BloodSplatter()
	{
	}

	// Token: 0x04000178 RID: 376
	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _rangeMetres;

	// Token: 0x04000179 RID: 377
	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _bloodSprayConeAngleDegrees;

	// Token: 0x0400017A RID: 378
	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _splatterCount;

	// Token: 0x0400017B RID: 379
	[Token(Token = "0x400017B")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private LayerMask _layerMask;

	// Token: 0x0400017C RID: 380
	[Token(Token = "0x400017C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ProjectileImpactObject _impactObject;
}
