using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AE RID: 430
[Token(Token = "0x20001AE")]
public class PointPushPullModifier : PushPullRotationModifier
{
	// Token: 0x06000C8C RID: 3212 RVA: 0x00005040 File Offset: 0x00003240
	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x36E84A0", Offset = "0x36E6AA0", VA = "0x1836E84A0", Slot = "7")]
	protected override float GetPushPullStrengthAtPosition(Vector3 worldPosition)
	{
		return 0f;
	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x00005058 File Offset: 0x00003258
	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0", Slot = "8")]
	protected override float GetModifierChance(Vector3 worldPosition)
	{
		return 0f;
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x00005070 File Offset: 0x00003270
	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "6")]
	protected override Vector3 GetModifierPosition(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x36E8660", Offset = "0x36E6C60", VA = "0x1836E8660")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x36E8790", Offset = "0x36E6D90", VA = "0x1836E8790")]
	public PointPushPullModifier()
	{
	}

	// Token: 0x04000B14 RID: 2836
	[Token(Token = "0x4000B14")]
	[FieldOffset(Offset = "0x40")]
	[Header("Point Properties:")]
	[Range(-1f, 1f)]
	[SerializeField]
	private float _pushPullStrength;

	// Token: 0x04000B15 RID: 2837
	[Token(Token = "0x4000B15")]
	[FieldOffset(Offset = "0x44")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _modifierChance;
}
