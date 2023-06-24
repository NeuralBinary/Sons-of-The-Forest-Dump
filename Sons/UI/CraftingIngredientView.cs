using System;
using Il2CppDummyDll;
using Sons.Crafting;
using Sons.Items.Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.UI
{
	// Token: 0x020004F2 RID: 1266
	[Token(Token = "0x20004F2")]
	[AddComponentMenu("Sons/UI/CraftingIngredientView")]
	public class CraftingIngredientView : MonoBehaviour
	{
		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x00009A98 File Offset: 0x00007C98
		[Token(Token = "0x17000488")]
		public CraftingIngredientView.State CurrentState
		{
			[Token(Token = "0x6002127")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return CraftingIngredientView.State.Missing;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002128 RID: 8488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000489")]
		public ItemData ItemData
		{
			[Token(Token = "0x6002128")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x3323EC0", Offset = "0x33224C0", VA = "0x183323EC0")]
		public void Initialize(ItemData itemData, CraftingIngredient ingredient, string prefix, int minCountToShow)
		{
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212A")]
		[Address(RVA = "0x2FAD760", Offset = "0x2FABD60", VA = "0x182FAD760")]
		public CraftingIngredientView()
		{
		}

		// Token: 0x04001EC3 RID: 7875
		[Token(Token = "0x4001EC3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CraftingIngredientView.State _state;

		// Token: 0x04001EC4 RID: 7876
		[Token(Token = "0x4001EC4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RawImage _icon;

		// Token: 0x04001EC5 RID: 7877
		[Token(Token = "0x4001EC5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RawImage _outline;

		// Token: 0x04001EC6 RID: 7878
		[Token(Token = "0x4001EC6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _amount;

		// Token: 0x04001EC7 RID: 7879
		[Token(Token = "0x4001EC7")]
		[FieldOffset(Offset = "0x40")]
		private ItemData _itemData;

		// Token: 0x020004F3 RID: 1267
		[Token(Token = "0x20004F3")]
		public enum State
		{
			// Token: 0x04001EC9 RID: 7881
			[Token(Token = "0x4001EC9")]
			Missing,
			// Token: 0x04001ECA RID: 7882
			[Token(Token = "0x4001ECA")]
			Available,
			// Token: 0x04001ECB RID: 7883
			[Token(Token = "0x4001ECB")]
			Complete
		}
	}
}
