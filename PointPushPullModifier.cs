using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AF RID: 431
[Token(Token = "0x20001AF")]
public class PointPushPullModifier : PushPullRotationModifier
{
	// Token: 0x06000C32 RID: 3122 RVA: 0x00004E18 File Offset: 0x00003018
	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x2F70A00", Offset = "0x2F6FA00", VA = "0x182F70A00", Slot = "7")]
	protected override float GetPushPullStrengthAtPosition(Vector3 worldPosition)
	{
		return default(float);
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x00004E30 File Offset: 0x00003030
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x20103A0", Offset = "0x200F3A0", VA = "0x1820103A0", Slot = "8")]
	protected override float GetModifierChance(Vector3 worldPosition)
	{
		return default(float);
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x00004E48 File Offset: 0x00003048
	[Token(Token = "0x6000C34")]
	[Address(RVA = "0x2294B70", Offset = "0x2293B70", VA = "0x182294B70", Slot = "6")]
	protected override Vector3 GetModifierPosition(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x2F70B60", Offset = "0x2F6FB60", VA = "0x182F70B60")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x2F70BD0", Offset = "0x2F6FBD0", VA = "0x182F70BD0")]
	public PointPushPullModifier()
	{
	}

	// Token: 0x04000AE9 RID: 2793
	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x40")]
	[Header("Point Properties:")]
	[Range(-1f, 1f)]
	[SerializeField]
	private float _pushPullStrength;

	// Token: 0x04000AEA RID: 2794
	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x44")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _modifierChance;
}
