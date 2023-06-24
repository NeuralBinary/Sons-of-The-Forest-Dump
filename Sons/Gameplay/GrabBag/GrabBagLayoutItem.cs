using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x0200084D RID: 2125
	[Token(Token = "0x200084D")]
	public class GrabBagLayoutItem : LayoutItem
	{
		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x00012678 File Offset: 0x00010878
		[Token(Token = "0x170007CC")]
		public bool IsValid
		{
			[Token(Token = "0x6003C71")]
			[Address(RVA = "0x2EFF410", Offset = "0x2EFDA10", VA = "0x182EFF410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C72")]
		[Address(RVA = "0x35A69D0", Offset = "0x35A4FD0", VA = "0x1835A69D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C73")]
		[Address(RVA = "0x35A6CF0", Offset = "0x35A52F0", VA = "0x1835A6CF0", Slot = "8")]
		protected override void OnMouseEnter()
		{
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C74")]
		[Address(RVA = "0x35A6D20", Offset = "0x35A5320", VA = "0x1835A6D20", Slot = "9")]
		protected override void OnMouseExit()
		{
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C75")]
		[Address(RVA = "0x35A6D90", Offset = "0x35A5390", VA = "0x1835A6D90", Slot = "10")]
		protected override void OnMouseOver()
		{
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C76")]
		[Address(RVA = "0x35A6E00", Offset = "0x35A5400", VA = "0x1835A6E00", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C77")]
		[Address(RVA = "0x35A6E10", Offset = "0x35A5410", VA = "0x1835A6E10")]
		public void GrayOutRenderable(bool grayedOut)
		{
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C78")]
		[Address(RVA = "0x35A7090", Offset = "0x35A5690", VA = "0x1835A7090", Slot = "11")]
		public override void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C79")]
		[Address(RVA = "0x35A70C0", Offset = "0x35A56C0", VA = "0x1835A70C0")]
		private void CacheOriginalMaterials()
		{
		}

		// Token: 0x06003C7A RID: 15482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7A")]
		[Address(RVA = "0x35A73C0", Offset = "0x35A59C0", VA = "0x1835A73C0")]
		private void GrayOutInit()
		{
		}

		// Token: 0x06003C7B RID: 15483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C7B")]
		[Address(RVA = "0x35A7920", Offset = "0x35A5F20", VA = "0x1835A7920")]
		public GrabBagLayoutItem()
		{
		}

		// Token: 0x04003324 RID: 13092
		[Token(Token = "0x4003324")]
		[FieldOffset(Offset = "0x0")]
		private static string _grayedOutShaderName;

		// Token: 0x04003325 RID: 13093
		[Token(Token = "0x4003325")]
		[FieldOffset(Offset = "0x8")]
		private static Shader _grayedOutShader;

		// Token: 0x04003326 RID: 13094
		[Token(Token = "0x4003326")]
		[FieldOffset(Offset = "0x68")]
		private List<List<Material>> _grayedOutMaterials;

		// Token: 0x04003327 RID: 13095
		[Token(Token = "0x4003327")]
		[FieldOffset(Offset = "0x70")]
		private List<List<Material>> _originalMaterials;

		// Token: 0x04003328 RID: 13096
		[Token(Token = "0x4003328")]
		[FieldOffset(Offset = "0x78")]
		private bool _greyOutMaterialIsInitialised;

		// Token: 0x04003329 RID: 13097
		[Token(Token = "0x4003329")]
		[FieldOffset(Offset = "0x79")]
		private bool _isValidIngredient;

		// Token: 0x0400332A RID: 13098
		[Token(Token = "0x400332A")]
		[FieldOffset(Offset = "0x7A")]
		private bool _isInitialized;
	}
}
