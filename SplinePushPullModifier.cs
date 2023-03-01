using System;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;

// Token: 0x020001B1 RID: 433
[Token(Token = "0x20001B1")]
[RequireComponent(typeof(PathCreator))]
public class SplinePushPullModifier : PushPullRotationModifier
{
	// Token: 0x06000C3E RID: 3134 RVA: 0x00004E78 File Offset: 0x00003078
	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x2F72100", Offset = "0x2F71100", VA = "0x182F72100", Slot = "7")]
	protected override float GetPushPullStrengthAtPosition(Vector3 worldPosition)
	{
		return default(float);
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x00004E90 File Offset: 0x00003090
	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x2F71ED0", Offset = "0x2F70ED0", VA = "0x182F71ED0", Slot = "8")]
	protected override float GetModifierChance(Vector3 worldPosition)
	{
		return default(float);
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x00004EA8 File Offset: 0x000030A8
	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x2F71F60", Offset = "0x2F70F60", VA = "0x182F71F60", Slot = "6")]
	protected override Vector3 GetModifierPosition(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x2F71FD0", Offset = "0x2F70FD0", VA = "0x182F71FD0")]
	private VertexPath GetPath()
	{
		return null;
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x2F722B0", Offset = "0x2F712B0", VA = "0x182F722B0")]
	public SplinePushPullModifier()
	{
	}

	// Token: 0x04000AEE RID: 2798
	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0x40")]
	[Header("Spline Properties:")]
	[Tooltip("This is a normalized curve of the push(-)/pull(+) strength.")]
	[SerializeField]
	private AnimationCurve _pushPullStrengthCurve;

	// Token: 0x04000AEF RID: 2799
	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AnimationCurve _modifierChanceCurve;

	// Token: 0x04000AF0 RID: 2800
	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0x50")]
	private PathCreator _pathCreator;
}
