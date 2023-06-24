using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015F RID: 351
[Token(Token = "0x200015F")]
[AddComponentMenu("Sons/Gameplay/RopeSetGroundHeight")]
public class RopeSetGroundHeight : MonoBehaviour
{
	// Token: 0x06000AAD RID: 2733 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0x36BAB20", Offset = "0x36B9120", VA = "0x1836BAB20")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0x36BABB0", Offset = "0x36B91B0", VA = "0x1836BABB0")]
	public void CalculateGroundTriggerHeight()
	{
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x36BB780", Offset = "0x36B9D80", VA = "0x1836BB780")]
	private void SetRopeTiling()
	{
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x36BBAE0", Offset = "0x36BA0E0", VA = "0x1836BBAE0")]
	public RopeSetGroundHeight()
	{
	}

	// Token: 0x0400090B RID: 2315
	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LayerMask floorLayers;

	// Token: 0x0400090C RID: 2316
	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject triggerBottom;

	// Token: 0x0400090D RID: 2317
	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _rope;

	// Token: 0x0400090E RID: 2318
	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool disableGroundHeightCheck;

	// Token: 0x0400090F RID: 2319
	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _minimumRopeLength;

	// Token: 0x04000910 RID: 2320
	[Token(Token = "0x4000910")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _maxRopeLengthCheck;

	// Token: 0x04000911 RID: 2321
	[Token(Token = "0x4000911")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _interactionHeightOffsetFromGround;

	// Token: 0x04000912 RID: 2322
	[Token(Token = "0x4000912")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _ropeExtraLength;

	// Token: 0x04000913 RID: 2323
	[Token(Token = "0x4000913")]
	[FieldOffset(Offset = "0x0")]
	private static MaterialPropertyBlock _mtp;

	// Token: 0x04000914 RID: 2324
	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int BaseColorMapSt;
}
