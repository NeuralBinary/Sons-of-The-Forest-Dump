using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006E6 RID: 1766
	[Token(Token = "0x20006E6")]
	[Serializable]
	public class StructureCraftingNodeIngredient : MonoBehaviour
	{
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x0000DD10 File Offset: 0x0000BF10
		[Token(Token = "0x1700063B")]
		public int ItemId
		{
			[Token(Token = "0x6002EC4")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x0000DD28 File Offset: 0x0000BF28
		[Token(Token = "0x1700063C")]
		public bool RequiresAllPreviousIngredients
		{
			[Token(Token = "0x6002EC5")]
			[Address(RVA = "0x21FA640", Offset = "0x21F8C40", VA = "0x1821FA640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		public void SetId(int id)
		{
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC7")]
		[Address(RVA = "0x3455890", Offset = "0x3453E90", VA = "0x183455890")]
		private void OnValidate()
		{
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC8")]
		[Address(RVA = "0x3455B10", Offset = "0x3454110", VA = "0x183455B10")]
		public void EnableCollidersAndBehaviours(bool enable)
		{
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EC9")]
		[Address(RVA = "0x3455EF0", Offset = "0x34544F0", VA = "0x183455EF0")]
		public StructureCraftingNodeIngredient()
		{
		}

		// Token: 0x04002888 RID: 10376
		[Token(Token = "0x4002888")]
		[FieldOffset(Offset = "0x20")]
		[ItemIdPicker(true)]
		[SerializeField]
		private int _itemId;

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _requiresAllPreviousIngredients;

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Collider> _colliders;

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<MonoBehaviour> _activateIngredientRendererReceivers;
	}
}
