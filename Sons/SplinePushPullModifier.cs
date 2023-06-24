using System;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;

// Token: 0x020001B0 RID: 432
[Token(Token = "0x20001B0")]
[RequireComponent(typeof(PathCreator))]
public class SplinePushPullModifier : PushPullRotationModifier
{
	// Token: 0x06000C98 RID: 3224 RVA: 0x000050A0 File Offset: 0x000032A0
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x36E9160", Offset = "0x36E7760", VA = "0x1836E9160", Slot = "7")]
	protected override float GetPushPullStrengthAtPosition(Vector3 worldPosition)
	{
		return 0f;
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x000050B8 File Offset: 0x000032B8
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x36E9340", Offset = "0x36E7940", VA = "0x1836E9340", Slot = "8")]
	protected override float GetModifierChance(Vector3 worldPosition)
	{
		return 0f;
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x000050D0 File Offset: 0x000032D0
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x36E9420", Offset = "0x36E7A20", VA = "0x1836E9420", Slot = "6")]
	protected override Vector3 GetModifierPosition(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x36E9490", Offset = "0x36E7A90", VA = "0x1836E9490")]
	private VertexPath GetPath()
	{
		return null;
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x36E9790", Offset = "0x36E7D90", VA = "0x1836E9790")]
	public SplinePushPullModifier()
	{
	}

	// Token: 0x04000B19 RID: 2841
	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0x40")]
	[Tooltip("This is a normalized curve of the push(-)/pull(+) strength.")]
	[SerializeField]
	[Header("Spline Properties:")]
	private AnimationCurve _pushPullStrengthCurve;

	// Token: 0x04000B1A RID: 2842
	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AnimationCurve _modifierChanceCurve;

	// Token: 0x04000B1B RID: 2843
	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x50")]
	private PathCreator _pathCreator;
}
