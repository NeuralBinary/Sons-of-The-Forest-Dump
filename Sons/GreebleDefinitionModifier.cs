using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AA RID: 426
[Token(Token = "0x20001AA")]
[ExecuteInEditMode]
public abstract class GreebleDefinitionModifier : MonoBehaviour
{
	// Token: 0x06000C84 RID: 3204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x36E8040", Offset = "0x36E6640", VA = "0x1836E8040")]
	public static void GetGreebleDefinitionModifiersInLayers(GreebleDefinitionModifier.ModifierLayers modifierLayers, GreebleDefinitionModifier.GroupLayers groupLayers, out List<GreebleDefinitionModifier> outModifiers)
	{
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x2830D10", Offset = "0x282F310", VA = "0x182830D10")]
	private void Reset()
	{
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x36E8280", Offset = "0x36E6880", VA = "0x1836E8280")]
	private void OnEnable()
	{
	}

	// Token: 0x06000C87 RID: 3207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x36E8350", Offset = "0x36E6950", VA = "0x1836E8350")]
	private void OnDisable()
	{
	}

	// Token: 0x06000C88 RID: 3208
	[Token(Token = "0x6000C88")]
	public abstract void ApplyModification(ref GameObject affectedObject);

	// Token: 0x06000C89 RID: 3209
	[Token(Token = "0x6000C89")]
	protected abstract void SetModifierLayer();

	// Token: 0x06000C8A RID: 3210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	protected GreebleDefinitionModifier()
	{
	}

	// Token: 0x04000B09 RID: 2825
	[Token(Token = "0x4000B09")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Header("Modifier Properties:")]
	protected GreebleDefinitionModifier.ModifierLayers _modifierLayer;

	// Token: 0x04000B0A RID: 2826
	[Token(Token = "0x4000B0A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected GreebleDefinitionModifier.GroupLayers _groupLayers;

	// Token: 0x04000B0B RID: 2827
	[Token(Token = "0x4000B0B")]
	[FieldOffset(Offset = "0x28")]
	[Range(-1f, 1f)]
	[SerializeField]
	protected float _strengthMultiplier;

	// Token: 0x04000B0C RID: 2828
	[Token(Token = "0x4000B0C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<GreebleDefinitionModifier> _definitionModifiers;

	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	[Flags]
	public enum ModifierLayers
	{
		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4000B0E")]
		PushPull = 1
	}

	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	[Flags]
	public enum GroupLayers
	{
		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		Rivers = 1
	}

	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	public enum Type
	{
		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		Point,
		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		Spline
	}
}
