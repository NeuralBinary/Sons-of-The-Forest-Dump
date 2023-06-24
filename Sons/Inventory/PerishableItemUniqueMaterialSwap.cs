using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x0200062D RID: 1581
	[Token(Token = "0x200062D")]
	public class PerishableItemUniqueMaterialSwap : MonoBehaviour
	{
		// Token: 0x06002914 RID: 10516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002914")]
		[Address(RVA = "0x33E7ED0", Offset = "0x33E64D0", VA = "0x1833E7ED0")]
		public void SwapMaterialForState(PerishableItemData.State state)
		{
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002915")]
		[Address(RVA = "0x33E8000", Offset = "0x33E6600", VA = "0x1833E8000")]
		public PerishableItemUniqueMaterialSwap()
		{
		}

		// Token: 0x040024CB RID: 9419
		[Token(Token = "0x40024CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<PerishableItemUniqueMaterialSwap.StateMaterial> _stateMaterials;

		// Token: 0x040024CC RID: 9420
		[Token(Token = "0x40024CC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x0200062E RID: 1582
		[Token(Token = "0x200062E")]
		[Serializable]
		private class StateMaterial
		{
			// Token: 0x1700055F RID: 1375
			// (get) Token: 0x06002916 RID: 10518 RVA: 0x0000C228 File Offset: 0x0000A428
			[Token(Token = "0x1700055F")]
			public PerishableItemData.State State
			{
				[Token(Token = "0x6002916")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return PerishableItemData.State.None;
				}
			}

			// Token: 0x17000560 RID: 1376
			// (get) Token: 0x06002917 RID: 10519 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000560")]
			public Material Material
			{
				[Token(Token = "0x6002917")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002918 RID: 10520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002918")]
			[Address(RVA = "0x129C300", Offset = "0x129A900", VA = "0x18129C300")]
			public StateMaterial()
			{
			}

			// Token: 0x040024CD RID: 9421
			[Token(Token = "0x40024CD")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private PerishableItemData.State _state;

			// Token: 0x040024CE RID: 9422
			[Token(Token = "0x40024CE")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Material _material;
		}
	}
}
