using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020006C9 RID: 1737
	[Token(Token = "0x20006C9")]
	public class IngredientLayoutItem : LayoutItem
	{
		// Token: 0x06002DD4 RID: 11732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD4")]
		[Address(RVA = "0x343FA40", Offset = "0x343E040", VA = "0x18343FA40")]
		private void Awake()
		{
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x343FBC0", Offset = "0x343E1C0", VA = "0x18343FBC0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0x3440540", Offset = "0x343EB40", VA = "0x183440540", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x3440600", Offset = "0x343EC00", VA = "0x183440600")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x3440630", Offset = "0x343EC30", VA = "0x183440630", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x34407A0", Offset = "0x343EDA0", VA = "0x1834407A0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0x3440970", Offset = "0x343EF70", VA = "0x183440970", Slot = "11")]
		public override void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0x3440990", Offset = "0x343EF90", VA = "0x183440990")]
		public void OnCraftBegin(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDC")]
		[Address(RVA = "0x3441460", Offset = "0x343FA60", VA = "0x183441460")]
		public void OnCraftComplete(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x3441580", Offset = "0x343FB80", VA = "0x183441580")]
		private void AddAnimator()
		{
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDE")]
		[Address(RVA = "0x3441740", Offset = "0x343FD40", VA = "0x183441740", Slot = "8")]
		protected override void OnMouseEnter()
		{
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDF")]
		[Address(RVA = "0x34417B0", Offset = "0x343FDB0", VA = "0x1834417B0")]
		public IngredientLayoutItem()
		{
		}

		// Token: 0x0400281A RID: 10266
		[Token(Token = "0x400281A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _resetTransformAfterCraftAnimation;

		// Token: 0x0400281B RID: 10267
		[Token(Token = "0x400281B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<int> _resetChildNodeIndicies;

		// Token: 0x0400281C RID: 10268
		[Token(Token = "0x400281C")]
		[FieldOffset(Offset = "0x78")]
		public bool ShouldHaveAnimator;

		// Token: 0x0400281D RID: 10269
		[Token(Token = "0x400281D")]
		[FieldOffset(Offset = "0x80")]
		private Animator _craftingAnimator;

		// Token: 0x0400281E RID: 10270
		[Token(Token = "0x400281E")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 _storedLocalPosition;

		// Token: 0x0400281F RID: 10271
		[Token(Token = "0x400281F")]
		[FieldOffset(Offset = "0x94")]
		private Quaternion _storedLocalRotation;

		// Token: 0x04002820 RID: 10272
		[Token(Token = "0x4002820")]
		[FieldOffset(Offset = "0xA4")]
		private bool _doDelayedReset;
	}
}
