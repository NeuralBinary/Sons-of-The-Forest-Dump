using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007DE RID: 2014
	[Token(Token = "0x20007DE")]
	public class StructureGhostSwapper : MonoBehaviour
	{
		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06003541 RID: 13633 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		// (set) Token: 0x06003542 RID: 13634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CE")]
		public bool IsEnabled
		{
			[Token(Token = "0x6003541")]
			[Address(RVA = "0x5F2450", Offset = "0x5F1450", VA = "0x1805F2450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003542")]
			[Address(RVA = "0x5F2460", Offset = "0x5F1460", VA = "0x1805F2460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003543")]
		[Address(RVA = "0x2EA58F0", Offset = "0x2EA48F0", VA = "0x182EA58F0")]
		public static void SetColor(Color color)
		{
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003544")]
		[Address(RVA = "0x2EA5800", Offset = "0x2EA4800", VA = "0x182EA5800")]
		public static void ResetColor()
		{
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003545")]
		[Address(RVA = "0x2EA58A0", Offset = "0x2EA48A0", VA = "0x182EA58A0")]
		private void Reset()
		{
		}

		// Token: 0x06003546 RID: 13638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003546")]
		[Address(RVA = "0x2EA57F0", Offset = "0x2EA47F0", VA = "0x182EA57F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003547")]
		[Address(RVA = "0x2EA57E0", Offset = "0x2EA47E0", VA = "0x182EA57E0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003548")]
		[Address(RVA = "0x2EA5460", Offset = "0x2EA4460", VA = "0x182EA5460")]
		private void Initialise()
		{
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003549")]
		[Address(RVA = "0x2EA5340", Offset = "0x2EA4340", VA = "0x182EA5340")]
		private void Enable(bool enable)
		{
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600354A")]
		[Address(RVA = "0x2EA59A0", Offset = "0x2EA49A0", VA = "0x182EA59A0")]
		public StructureGhostSwapper()
		{
		}

		// Token: 0x04002DBD RID: 11709
		[Token(Token = "0x4002DBD")]
		private const string _ghostShaderName = "Sons/Outline/StructuresGhostHLSL";

		// Token: 0x04002DBE RID: 11710
		[Token(Token = "0x4002DBE")]
		[FieldOffset(Offset = "0x0")]
		private static Material _ghostMaterial;

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x28")]
		private Material[] _ghostedMaterials;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInitialised;

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x38")]
		private List<Material> _originalMaterialList;

		// Token: 0x04002DC3 RID: 11715
		[Token(Token = "0x4002DC3")]
		[FieldOffset(Offset = "0x8")]
		[ColorUsage(false, true)]
		private static Color _originalColor;
	}
}
