using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000160 RID: 352
[Token(Token = "0x2000160")]
[AddComponentMenu("Sons/Gameplay/RopeSetGroundHeight")]
public class RopeSetGroundHeight : MonoBehaviour
{
	// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A5D")]
	[Address(RVA = "0x2F4D390", Offset = "0x2F4C390", VA = "0x182F4D390")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5E")]
	[Address(RVA = "0x2F4CA20", Offset = "0x2F4BA20", VA = "0x182F4CA20")]
	public void CalculateGroundTriggerHeight()
	{
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x2F4D1B0", Offset = "0x2F4C1B0", VA = "0x182F4D1B0")]
	private void SetRopeTiling()
	{
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x2F4D450", Offset = "0x2F4C450", VA = "0x182F4D450")]
	public RopeSetGroundHeight()
	{
	}

	// Token: 0x040008EA RID: 2282
	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LayerMask floorLayers;

	// Token: 0x040008EB RID: 2283
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject triggerBottom;

	// Token: 0x040008EC RID: 2284
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _rope;

	// Token: 0x040008ED RID: 2285
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool disableGroundHeightCheck;

	// Token: 0x040008EE RID: 2286
	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _minimumRopeLength;

	// Token: 0x040008EF RID: 2287
	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _maxRopeLengthCheck;

	// Token: 0x040008F0 RID: 2288
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _interactionHeightOffsetFromGround;

	// Token: 0x040008F1 RID: 2289
	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _ropeExtraLength;

	// Token: 0x040008F2 RID: 2290
	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x0")]
	private static MaterialPropertyBlock _mtp;

	// Token: 0x040008F3 RID: 2291
	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int BaseColorMapSt;
}
