using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001AB RID: 427
[Token(Token = "0x20001AB")]
[ExecuteInEditMode]
public abstract class GreebleDefinitionModifier : MonoBehaviour
{
	// Token: 0x06000C2A RID: 3114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x2F65280", Offset = "0x2F64280", VA = "0x182F65280")]
	public static void GetGreebleDefinitionModifiersInLayers(GreebleDefinitionModifier.ModifierLayers modifierLayers, GreebleDefinitionModifier.GroupLayers groupLayers, out List<GreebleDefinitionModifier> outModifiers)
	{
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x23B3DD0", Offset = "0x23B2DD0", VA = "0x1823B3DD0")]
	private void Reset()
	{
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x2F654D0", Offset = "0x2F644D0", VA = "0x182F654D0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x2F65450", Offset = "0x2F64450", VA = "0x182F65450")]
	private void OnDisable()
	{
	}

	// Token: 0x06000C2E RID: 3118
	[Token(Token = "0x6000C2E")]
	public abstract void ApplyModification(ref GameObject affectedObject);

	// Token: 0x06000C2F RID: 3119
	[Token(Token = "0x6000C2F")]
	protected abstract void SetModifierLayer();

	// Token: 0x06000C30 RID: 3120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	protected GreebleDefinitionModifier()
	{
	}

	// Token: 0x04000ADE RID: 2782
	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Header("Modifier Properties:")]
	protected GreebleDefinitionModifier.ModifierLayers _modifierLayer;

	// Token: 0x04000ADF RID: 2783
	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected GreebleDefinitionModifier.GroupLayers _groupLayers;

	// Token: 0x04000AE0 RID: 2784
	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(-1f, 1f)]
	protected float _strengthMultiplier;

	// Token: 0x04000AE1 RID: 2785
	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<GreebleDefinitionModifier> _definitionModifiers;

	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	[Flags]
	public enum ModifierLayers
	{
		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		PushPull = 1
	}

	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	[Flags]
	public enum GroupLayers
	{
		// Token: 0x04000AE5 RID: 2789
		[Token(Token = "0x4000AE5")]
		Rivers = 1
	}

	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	public enum Type
	{
		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		Point,
		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		Spline
	}
}
