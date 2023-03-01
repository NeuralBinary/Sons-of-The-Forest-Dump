using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x020006FF RID: 1791
	[Token(Token = "0x20006FF")]
	public class GrabBagLayoutItem : LayoutItem
	{
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		[Token(Token = "0x170005C9")]
		public bool IsValid
		{
			[Token(Token = "0x6002E7A")]
			[Address(RVA = "0x27E34A0", Offset = "0x27E24A0", VA = "0x1827E34A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E7B")]
		[Address(RVA = "0x2E11630", Offset = "0x2E10630", VA = "0x182E11630", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E7C")]
		[Address(RVA = "0x2E118C0", Offset = "0x2E108C0", VA = "0x182E118C0", Slot = "8")]
		protected override void OnMouseEnter()
		{
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E7D")]
		[Address(RVA = "0x2E118F0", Offset = "0x2E108F0", VA = "0x182E118F0", Slot = "9")]
		protected override void OnMouseExit()
		{
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E7E")]
		[Address(RVA = "0x2E11900", Offset = "0x2E10900", VA = "0x182E11900", Slot = "10")]
		protected override void OnMouseOver()
		{
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0x2E11910", Offset = "0x2E10910", VA = "0x182E11910", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E80")]
		[Address(RVA = "0x2E11430", Offset = "0x2E10430", VA = "0x182E11430")]
		public void GrayOutRenderable(bool grayedOut)
		{
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E81")]
		[Address(RVA = "0x2E11600", Offset = "0x2E10600", VA = "0x182E11600", Slot = "11")]
		public override void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E82")]
		[Address(RVA = "0x2E10D70", Offset = "0x2E0FD70", VA = "0x182E10D70")]
		private void CacheOriginalMaterials()
		{
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E83")]
		[Address(RVA = "0x2E10FB0", Offset = "0x2E0FFB0", VA = "0x182E10FB0")]
		private void GrayOutInit()
		{
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E84")]
		[Address(RVA = "0x2E11990", Offset = "0x2E10990", VA = "0x182E11990")]
		public GrabBagLayoutItem()
		{
		}

		// Token: 0x0400293D RID: 10557
		[Token(Token = "0x400293D")]
		[FieldOffset(Offset = "0x0")]
		private static string _grayedOutShaderName;

		// Token: 0x0400293E RID: 10558
		[Token(Token = "0x400293E")]
		[FieldOffset(Offset = "0x8")]
		private static Shader _grayedOutShader;

		// Token: 0x0400293F RID: 10559
		[Token(Token = "0x400293F")]
		[FieldOffset(Offset = "0x68")]
		private List<List<Material>> _grayedOutMaterials;

		// Token: 0x04002940 RID: 10560
		[Token(Token = "0x4002940")]
		[FieldOffset(Offset = "0x70")]
		private List<List<Material>> _originalMaterials;

		// Token: 0x04002941 RID: 10561
		[Token(Token = "0x4002941")]
		[FieldOffset(Offset = "0x78")]
		private bool _greyOutMaterialIsInitialised;

		// Token: 0x04002942 RID: 10562
		[Token(Token = "0x4002942")]
		[FieldOffset(Offset = "0x79")]
		private bool _isValidIngredient;

		// Token: 0x04002943 RID: 10563
		[Token(Token = "0x4002943")]
		[FieldOffset(Offset = "0x7A")]
		private bool _isInitialized;
	}
}
