using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006EA RID: 1770
	[Token(Token = "0x20006EA")]
	public class StructureGhostSwapper : MonoBehaviour
	{
		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x0000DD58 File Offset: 0x0000BF58
		// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063D")]
		public bool IsEnabled
		{
			[Token(Token = "0x6002ED6")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002ED7")]
			[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED8")]
		[Address(RVA = "0x3456AF0", Offset = "0x34550F0", VA = "0x183456AF0")]
		public static void SetColor(Color color)
		{
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002ED9")]
		[Address(RVA = "0x3456C00", Offset = "0x3455200", VA = "0x183456C00")]
		public static void ResetColor()
		{
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDA")]
		[Address(RVA = "0x3456D00", Offset = "0x3455300", VA = "0x183456D00")]
		private void Reset()
		{
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x3456D90", Offset = "0x3455390", VA = "0x183456D90")]
		private void OnEnable()
		{
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDC")]
		[Address(RVA = "0x3456DA0", Offset = "0x34553A0", VA = "0x183456DA0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDD")]
		[Address(RVA = "0x3456DB0", Offset = "0x34553B0", VA = "0x183456DB0")]
		private void Initialise()
		{
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x3457510", Offset = "0x3455B10", VA = "0x183457510")]
		private void Enable(bool enable)
		{
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x34576F0", Offset = "0x3455CF0", VA = "0x1834576F0")]
		public StructureGhostSwapper()
		{
		}

		// Token: 0x040028A0 RID: 10400
		[Token(Token = "0x40028A0")]
		private const string _ghostShaderName = "Sons/Outline/StructuresGhostHLSL";

		// Token: 0x040028A1 RID: 10401
		[Token(Token = "0x40028A1")]
		[FieldOffset(Offset = "0x0")]
		private static Material _ghostMaterial;

		// Token: 0x040028A2 RID: 10402
		[Token(Token = "0x40028A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x040028A3 RID: 10403
		[Token(Token = "0x40028A3")]
		[FieldOffset(Offset = "0x28")]
		private Material[] _ghostedMaterials;

		// Token: 0x040028A4 RID: 10404
		[Token(Token = "0x40028A4")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInitialised;

		// Token: 0x040028A5 RID: 10405
		[Token(Token = "0x40028A5")]
		[FieldOffset(Offset = "0x38")]
		private List<Material> _originalMaterialList;

		// Token: 0x040028A6 RID: 10406
		[Token(Token = "0x40028A6")]
		[FieldOffset(Offset = "0x8")]
		[ColorUsage(false, true)]
		private static Color _originalColor;
	}
}
