using System;
using Ballistics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000038")]
public class BloodSplatter : MonoBehaviour
{
	// Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x299D1A0", Offset = "0x299C1A0", VA = "0x18299D1A0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x299D0F0", Offset = "0x299C0F0", VA = "0x18299D0F0")]
	private void OnDisable()
	{
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x299D250", Offset = "0x299C250", VA = "0x18299D250")]
	private void OnImpact(SurfaceImpactInfo surfaceImpactInfo)
	{
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x299D790", Offset = "0x299C790", VA = "0x18299D790")]
	public BloodSplatter()
	{
	}

	// Token: 0x04000174 RID: 372
	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _rangeMetres;

	// Token: 0x04000175 RID: 373
	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _bloodSprayConeAngleDegrees;

	// Token: 0x04000176 RID: 374
	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _splatterCount;

	// Token: 0x04000177 RID: 375
	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private LayerMask _layerMask;

	// Token: 0x04000178 RID: 376
	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ProjectileImpactObject _impactObject;
}
