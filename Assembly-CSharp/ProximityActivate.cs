using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000038")]
public class ProximityActivate : MonoBehaviour
{
	// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x5E14D0", Offset = "0x5DFAD0", VA = "0x1805E14D0")]
	private void Start()
	{
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x5E1820", Offset = "0x5DFE20", VA = "0x1805E1820")]
	private bool IsTargetNear()
	{
		return default(bool);
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x5E1DF0", Offset = "0x5E03F0", VA = "0x1805E1DF0")]
	private void Update()
	{
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x5E2580", Offset = "0x5E0B80", VA = "0x1805E2580")]
	public ProximityActivate()
	{
	}

	// Token: 0x040001A3 RID: 419
	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x20")]
	public Transform distanceActivator;

	// Token: 0x040001A4 RID: 420
	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x28")]
	public Transform lookAtActivator;

	// Token: 0x040001A5 RID: 421
	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x30")]
	public float distance;

	// Token: 0x040001A6 RID: 422
	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x38")]
	public Transform activator;

	// Token: 0x040001A7 RID: 423
	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x40")]
	public bool activeState;

	// Token: 0x040001A8 RID: 424
	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x48")]
	public CanvasGroup target;

	// Token: 0x040001A9 RID: 425
	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x50")]
	public bool lookAtCamera;

	// Token: 0x040001AA RID: 426
	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x51")]
	public bool enableInfoPanel;

	// Token: 0x040001AB RID: 427
	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x58")]
	public GameObject infoIcon;

	// Token: 0x040001AC RID: 428
	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x60")]
	private float alpha;

	// Token: 0x040001AD RID: 429
	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x68")]
	public CanvasGroup infoPanel;

	// Token: 0x040001AE RID: 430
	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x70")]
	private Quaternion originRotation;

	// Token: 0x040001AF RID: 431
	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x80")]
	private Quaternion targetRotation;
}
