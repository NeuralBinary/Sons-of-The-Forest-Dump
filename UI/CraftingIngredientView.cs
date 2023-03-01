using System;
using Il2CppDummyDll;
using Sons.Crafting;
using Sons.Items.Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.UI
{
	// Token: 0x020004F3 RID: 1267
	[Token(Token = "0x20004F3")]
	[AddComponentMenu("Sons/UI/CraftingIngredientView")]
	public class CraftingIngredientView : MonoBehaviour
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x17000476")]
		public CraftingIngredientView.State CurrentState
		{
			[Token(Token = "0x6002074")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return CraftingIngredientView.State.Missing;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000477")]
		public ItemData ItemData
		{
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002076")]
		[Address(RVA = "0x2D26500", Offset = "0x2D25500", VA = "0x182D26500")]
		public void Initialize(ItemData itemData, CraftingIngredient ingredient)
		{
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002077")]
		[Address(RVA = "0x29D4D10", Offset = "0x29D3D10", VA = "0x1829D4D10")]
		public CraftingIngredientView()
		{
		}

		// Token: 0x04001E34 RID: 7732
		[Token(Token = "0x4001E34")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CraftingIngredientView.State _state;

		// Token: 0x04001E35 RID: 7733
		[Token(Token = "0x4001E35")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RawImage _icon;

		// Token: 0x04001E36 RID: 7734
		[Token(Token = "0x4001E36")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RawImage _outline;

		// Token: 0x04001E37 RID: 7735
		[Token(Token = "0x4001E37")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _amount;

		// Token: 0x04001E38 RID: 7736
		[Token(Token = "0x4001E38")]
		[FieldOffset(Offset = "0x40")]
		private ItemData _itemData;

		// Token: 0x020004F4 RID: 1268
		[Token(Token = "0x20004F4")]
		public enum State
		{
			// Token: 0x04001E3A RID: 7738
			[Token(Token = "0x4001E3A")]
			Missing,
			// Token: 0x04001E3B RID: 7739
			[Token(Token = "0x4001E3B")]
			Available,
			// Token: 0x04001E3C RID: 7740
			[Token(Token = "0x4001E3C")]
			Complete
		}
	}
}
