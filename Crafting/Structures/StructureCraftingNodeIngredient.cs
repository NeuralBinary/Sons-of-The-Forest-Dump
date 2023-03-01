using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007DA RID: 2010
	[Token(Token = "0x20007DA")]
	[Serializable]
	public class StructureCraftingNodeIngredient : MonoBehaviour
	{
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x0000F360 File Offset: 0x0000D560
		[Token(Token = "0x170006CC")]
		public int ItemId
		{
			[Token(Token = "0x600352F")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x0000F378 File Offset: 0x0000D578
		[Token(Token = "0x170006CD")]
		public bool RequiresAllPreviousIngredients
		{
			[Token(Token = "0x6003530")]
			[Address(RVA = "0x1EA0400", Offset = "0x1E9F400", VA = "0x181EA0400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003531")]
		[Address(RVA = "0x576710", Offset = "0x575710", VA = "0x180576710")]
		public void SetId(int id)
		{
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003532")]
		[Address(RVA = "0x2E9E170", Offset = "0x2E9D170", VA = "0x182E9E170")]
		private void OnValidate()
		{
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003533")]
		[Address(RVA = "0x2E9DE70", Offset = "0x2E9CE70", VA = "0x182E9DE70")]
		public void EnableCollidersAndBehaviours(bool enable)
		{
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003534")]
		[Address(RVA = "0x2E9E240", Offset = "0x2E9D240", VA = "0x182E9E240")]
		public StructureCraftingNodeIngredient()
		{
		}

		// Token: 0x04002DA5 RID: 11685
		[Token(Token = "0x4002DA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _itemId;

		// Token: 0x04002DA6 RID: 11686
		[Token(Token = "0x4002DA6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _requiresAllPreviousIngredients;

		// Token: 0x04002DA7 RID: 11687
		[Token(Token = "0x4002DA7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Collider> _colliders;

		// Token: 0x04002DA8 RID: 11688
		[Token(Token = "0x4002DA8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<MonoBehaviour> _activateIngredientRendererReceivers;
	}
}
