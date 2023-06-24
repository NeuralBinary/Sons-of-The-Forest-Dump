using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Crafting;
using UnityEngine;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x0200086E RID: 2158
	[Token(Token = "0x200086E")]
	public class CookingPotStewVisuals : MonoBehaviour
	{
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06003D9D RID: 15773 RVA: 0x00012C48 File Offset: 0x00010E48
		[Token(Token = "0x170007FD")]
		public bool IsUncooked
		{
			[Token(Token = "0x6003D9D")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9E")]
		[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
		public void SetUncooked(bool value)
		{
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D9F")]
		[Address(RVA = "0x35C3900", Offset = "0x35C1F00", VA = "0x1835C3900")]
		public void RefreshVisuals(CookingRecipe recipe, [Optional] List<CookingRecipe.CookingIngredient> currentIngredients)
		{
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA0")]
		[Address(RVA = "0x35C3FD0", Offset = "0x35C25D0", VA = "0x1835C3FD0")]
		private void ToggleLayoutItems()
		{
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA1")]
		[Address(RVA = "0x35C42E0", Offset = "0x35C28E0", VA = "0x1835C42E0")]
		private void RefreshSurfaceMaterialInstance()
		{
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA2")]
		[Address(RVA = "0x35C44F0", Offset = "0x35C2AF0", VA = "0x1835C44F0")]
		private void ResetWaterVisuals()
		{
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA3")]
		[Address(RVA = "0x35C4530", Offset = "0x35C2B30", VA = "0x1835C4530")]
		private void RefreshWaterVisuals(CookingRecipe cookingRecipe)
		{
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA4")]
		[Address(RVA = "0x35C4580", Offset = "0x35C2B80", VA = "0x1835C4580")]
		private void SetWaterSurfaceColor(Color colorValue, Color specularColorValue, float alphaValue)
		{
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA5")]
		[Address(RVA = "0x35C47A0", Offset = "0x35C2DA0", VA = "0x1835C47A0")]
		public void SetWaterMaterialInstance(Material waterMaterialInstance)
		{
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA6")]
		[Address(RVA = "0x35C4A40", Offset = "0x35C3040", VA = "0x1835C4A40")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DA7")]
		[Address(RVA = "0x35C4B70", Offset = "0x35C3170", VA = "0x1835C4B70")]
		public CookingPotStewVisuals()
		{
		}

		// Token: 0x040033F8 RID: 13304
		[Token(Token = "0x40033F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CraftingResultLayoutItemGroup> _layoutItemGroups;

		// Token: 0x040033F9 RID: 13305
		[Token(Token = "0x40033F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _surfaceRenderer;

		// Token: 0x040033FA RID: 13306
		[Token(Token = "0x40033FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _uncooked;

		// Token: 0x040033FB RID: 13307
		[Token(Token = "0x40033FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material _waterVisualsMaterialInstance;

		// Token: 0x040033FC RID: 13308
		[Token(Token = "0x40033FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int ColorMaterialNameId;

		// Token: 0x040033FD RID: 13309
		[Token(Token = "0x40033FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int SpecularColorMaterialNameId;

		// Token: 0x040033FE RID: 13310
		[Token(Token = "0x40033FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int AlphaMaterialNameId;

		// Token: 0x040033FF RID: 13311
		[Token(Token = "0x40033FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Color _defaultWaterColor;

		// Token: 0x04003400 RID: 13312
		[Token(Token = "0x4003400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color _defaultWaterSpecularColor;

		// Token: 0x04003401 RID: 13313
		[Token(Token = "0x4003401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _defaultWaterAlpha;
	}
}
