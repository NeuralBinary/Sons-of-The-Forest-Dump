using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B0 RID: 432
[Token(Token = "0x20001B0")]
public abstract class PushPullRotationModifier : GreebleDefinitionModifier
{
	// Token: 0x06000C37 RID: 3127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x2F70BE0", Offset = "0x2F6FBE0", VA = "0x182F70BE0", Slot = "4")]
	public override void ApplyModification(ref GameObject affectedObject)
	{
	}

	// Token: 0x06000C38 RID: 3128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x2AD1B50", Offset = "0x2AD0B50", VA = "0x182AD1B50", Slot = "5")]
	protected override void SetModifierLayer()
	{
	}

	// Token: 0x06000C39 RID: 3129 RVA: 0x00004E60 File Offset: 0x00003060
	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x2F70DB0", Offset = "0x2F6FDB0", VA = "0x182F70DB0")]
	public Quaternion CalculateRotation(Transform affectedTransform)
	{
		return default(Quaternion);
	}

	// Token: 0x06000C3A RID: 3130
	[Token(Token = "0x6000C3A")]
	protected abstract Vector3 GetModifierPosition(Vector3 worldPosition);

	// Token: 0x06000C3B RID: 3131
	[Token(Token = "0x6000C3B")]
	protected abstract float GetPushPullStrengthAtPosition(Vector3 worldPosition);

	// Token: 0x06000C3C RID: 3132
	[Token(Token = "0x6000C3C")]
	protected abstract float GetModifierChance(Vector3 worldPosition);

	// Token: 0x06000C3D RID: 3133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x2F71070", Offset = "0x2F70070", VA = "0x182F71070")]
	protected PushPullRotationModifier()
	{
	}

	// Token: 0x04000AEB RID: 2795
	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x30")]
	[Header("PushPull Properties:")]
	[SerializeField]
	[Min(1f)]
	protected float _effectiveRange;

	// Token: 0x04000AEC RID: 2796
	[Token(Token = "0x4000AEC")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Tooltip("If enabled, the resulting strength will be randomized from 0 to the specified push pull strength.")]
	protected bool _randomizeStrength;

	// Token: 0x04000AED RID: 2797
	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected AnimationCurve _falloffStrength;
}
