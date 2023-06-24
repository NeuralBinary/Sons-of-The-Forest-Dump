using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[AddComponentMenu("Sons/Items/Core/Item Renderable Tag")]
	public class ItemRenderableTag : MonoBehaviour
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x1700004E")]
		public int ItemId
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		public void SetItemId(int value)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ItemRenderableTag()
		{
		}

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ItemIdPicker(true)]
		private int _itemId;
	}
}
