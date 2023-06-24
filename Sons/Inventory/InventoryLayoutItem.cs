using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	public class InventoryLayoutItem : LayoutItem
	{
		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x0000BD30 File Offset: 0x00009F30
		[Token(Token = "0x17000543")]
		public bool IsValidIngredient
		{
			[Token(Token = "0x60027FF")]
			[Address(RVA = "0x252E5D0", Offset = "0x252CBD0", VA = "0x18252E5D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x33D0D80", Offset = "0x33CF380", VA = "0x1833D0D80")]
		public void BlockInteraction(bool shouldBlock)
		{
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x33D0D90", Offset = "0x33CF390", VA = "0x1833D0D90", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x33D0E90", Offset = "0x33CF490", VA = "0x1833D0E90", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x33D0EC0", Offset = "0x33CF4C0", VA = "0x1833D0EC0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x33D0F00", Offset = "0x33CF500", VA = "0x1833D0F00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x33D0F10", Offset = "0x33CF510", VA = "0x1833D0F10")]
		private void ClearMaterials()
		{
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x33D1000", Offset = "0x33CF600", VA = "0x1833D1000")]
		private void ClearOriginalMaterials()
		{
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x33D1060", Offset = "0x33CF660", VA = "0x1833D1060")]
		private void ClearSheenMaterials()
		{
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x33D10C0", Offset = "0x33CF6C0", VA = "0x1833D10C0")]
		private void ClearGrayedMaterials()
		{
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x33D1120", Offset = "0x33CF720", VA = "0x1833D1120")]
		private static void ClearInstancedMaterials(ref List<List<Material>> sourceMaterialList)
		{
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x33D14A0", Offset = "0x33CFAA0", VA = "0x1833D14A0", Slot = "8")]
		protected override void OnMouseEnter()
		{
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x33D14F0", Offset = "0x33CFAF0", VA = "0x1833D14F0", Slot = "9")]
		protected override void OnMouseExit()
		{
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x33D1590", Offset = "0x33CFB90", VA = "0x1833D1590", Slot = "10")]
		protected override void OnMouseOver()
		{
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x33D1640", Offset = "0x33CFC40", VA = "0x1833D1640")]
		public void ValidateItemForCrafting(int unused = 0)
		{
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x33D21D0", Offset = "0x33D07D0", VA = "0x1833D21D0", Slot = "12")]
		public override void OnAddedToLayoutGroup()
		{
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280F")]
		[Address(RVA = "0x33D2200", Offset = "0x33D0800", VA = "0x1833D2200")]
		public void GrayOutRenderable(bool grayedOut)
		{
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002810")]
		[Address(RVA = "0x33D2490", Offset = "0x33D0A90", VA = "0x1833D2490")]
		public void SheenRenderable(bool shouldApplySheen)
		{
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x33D27D0", Offset = "0x33D0DD0", VA = "0x1833D27D0", Slot = "11")]
		public override void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x33D2830", Offset = "0x33D0E30", VA = "0x1833D2830")]
		private void CacheOriginalMaterials()
		{
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x33D2B30", Offset = "0x33D1130", VA = "0x1833D2B30")]
		private void GrayOutInit()
		{
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x33D3090", Offset = "0x33D1690", VA = "0x1833D3090")]
		private void SheenInit()
		{
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x33D3570", Offset = "0x33D1B70", VA = "0x1833D3570")]
		public void EnableCraftingEvents()
		{
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x33D3710", Offset = "0x33D1D10", VA = "0x1833D3710")]
		public void DisableCraftingEvents()
		{
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x33D3920", Offset = "0x33D1F20", VA = "0x1833D3920")]
		public InventoryLayoutItem()
		{
		}

		// Token: 0x0400243C RID: 9276
		[Token(Token = "0x400243C")]
		[FieldOffset(Offset = "0x0")]
		private static string _grayedOutShaderName;

		// Token: 0x0400243D RID: 9277
		[Token(Token = "0x400243D")]
		[FieldOffset(Offset = "0x8")]
		private static Shader _grayedOutShader;

		// Token: 0x0400243E RID: 9278
		[Token(Token = "0x400243E")]
		[FieldOffset(Offset = "0x68")]
		private List<List<Material>> _originalMaterials;

		// Token: 0x0400243F RID: 9279
		[Token(Token = "0x400243F")]
		[FieldOffset(Offset = "0x70")]
		private List<List<Material>> _grayedOutMaterials;

		// Token: 0x04002440 RID: 9280
		[Token(Token = "0x4002440")]
		[FieldOffset(Offset = "0x78")]
		private List<List<Material>> _sheenMaterials;

		// Token: 0x04002441 RID: 9281
		[Token(Token = "0x4002441")]
		[FieldOffset(Offset = "0x80")]
		private bool _greyOutMaterialIsInitialised;

		// Token: 0x04002442 RID: 9282
		[Token(Token = "0x4002442")]
		[FieldOffset(Offset = "0x81")]
		private bool _sheenMaterialIsInitialised;

		// Token: 0x04002443 RID: 9283
		[Token(Token = "0x4002443")]
		[FieldOffset(Offset = "0x82")]
		private bool _isValidCraftingIngredient;

		// Token: 0x04002444 RID: 9284
		[Token(Token = "0x4002444")]
		[FieldOffset(Offset = "0x83")]
		private bool _sheenIsApplied;

		// Token: 0x04002445 RID: 9285
		[Token(Token = "0x4002445")]
		[FieldOffset(Offset = "0x84")]
		private bool _shouldDisableWhenMouseMoves;

		// Token: 0x04002446 RID: 9286
		[Token(Token = "0x4002446")]
		[FieldOffset(Offset = "0x85")]
		private bool _interactionBlocked;

		// Token: 0x04002447 RID: 9287
		[Token(Token = "0x4002447")]
		[FieldOffset(Offset = "0x86")]
		private bool _isInitialized;

		// Token: 0x04002448 RID: 9288
		[Token(Token = "0x4002448")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int BaseColorMapId;
	}
}
