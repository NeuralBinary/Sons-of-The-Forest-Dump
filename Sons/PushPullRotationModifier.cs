using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AF RID: 431
[Token(Token = "0x20001AF")]
public abstract class PushPullRotationModifier : GreebleDefinitionModifier
{
	// Token: 0x06000C91 RID: 3217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x36E87A0", Offset = "0x36E6DA0", VA = "0x1836E87A0", Slot = "4")]
	public override void ApplyModification(ref GameObject affectedObject)
	{
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x30EF1F0", Offset = "0x30ED7F0", VA = "0x1830EF1F0", Slot = "5")]
	protected override void SetModifierLayer()
	{
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x00005088 File Offset: 0x00003288
	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x36E8AB0", Offset = "0x36E70B0", VA = "0x1836E8AB0")]
	public Quaternion CalculateRotation(Transform affectedTransform)
	{
		return default(Quaternion);
	}

	// Token: 0x06000C94 RID: 3220
	[Token(Token = "0x6000C94")]
	protected abstract Vector3 GetModifierPosition(Vector3 worldPosition);

	// Token: 0x06000C95 RID: 3221
	[Token(Token = "0x6000C95")]
	protected abstract float GetPushPullStrengthAtPosition(Vector3 worldPosition);

	// Token: 0x06000C96 RID: 3222
	[Token(Token = "0x6000C96")]
	protected abstract float GetModifierChance(Vector3 worldPosition);

	// Token: 0x06000C97 RID: 3223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x36E8F90", Offset = "0x36E7590", VA = "0x1836E8F90")]
	protected PushPullRotationModifier()
	{
	}

	// Token: 0x04000B16 RID: 2838
	[Token(Token = "0x4000B16")]
	[FieldOffset(Offset = "0x30")]
	[Min(1f)]
	[Header("PushPull Properties:")]
	[SerializeField]
	protected float _effectiveRange;

	// Token: 0x04000B17 RID: 2839
	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Tooltip("If enabled, the resulting strength will be randomized from 0 to the specified push pull strength.")]
	protected bool _randomizeStrength;

	// Token: 0x04000B18 RID: 2840
	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected AnimationCurve _falloffStrength;
}
