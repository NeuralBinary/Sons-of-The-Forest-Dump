using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000617 RID: 1559
	[Token(Token = "0x2000617")]
	public class PerishableItemUniqueMaterialSwap : MonoBehaviour
	{
		// Token: 0x060027EC RID: 10220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EC")]
		[Address(RVA = "0x2DC2010", Offset = "0x2DC1010", VA = "0x182DC2010")]
		public void SwapMaterialForState(PerishableItemData.State state)
		{
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027ED")]
		[Address(RVA = "0x2DC2100", Offset = "0x2DC1100", VA = "0x182DC2100")]
		public PerishableItemUniqueMaterialSwap()
		{
		}

		// Token: 0x040023D5 RID: 9173
		[Token(Token = "0x40023D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<PerishableItemUniqueMaterialSwap.StateMaterial> _stateMaterials;

		// Token: 0x040023D6 RID: 9174
		[Token(Token = "0x40023D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x02000618 RID: 1560
		[Token(Token = "0x2000618")]
		[Serializable]
		private class StateMaterial
		{
			// Token: 0x17000547 RID: 1351
			// (get) Token: 0x060027EE RID: 10222 RVA: 0x0000BA78 File Offset: 0x00009C78
			[Token(Token = "0x17000547")]
			public PerishableItemData.State State
			{
				[Token(Token = "0x60027EE")]
				[Address(RVA = "0x55E9A0", Offset = "0x55D9A0", VA = "0x18055E9A0")]
				get
				{
					return default(PerishableItemData.State);
				}
			}

			// Token: 0x17000548 RID: 1352
			// (get) Token: 0x060027EF RID: 10223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000548")]
			public Material Material
			{
				[Token(Token = "0x60027EF")]
				[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060027F0 RID: 10224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60027F0")]
			[Address(RVA = "0x1E5EE90", Offset = "0x1E5DE90", VA = "0x181E5EE90")]
			public StateMaterial()
			{
			}

			// Token: 0x040023D7 RID: 9175
			[Token(Token = "0x40023D7")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private PerishableItemData.State _state;

			// Token: 0x040023D8 RID: 9176
			[Token(Token = "0x40023D8")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Material _material;
		}
	}
}
