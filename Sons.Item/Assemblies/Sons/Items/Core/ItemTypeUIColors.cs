using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Assemblies.Sons.Items.Core
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[CreateAssetMenu(fileName = "NewItemTypeUIColors", menuName = "Sons/Data/Items/ItemTypeUIColors", order = 0)]
	public class ItemTypeUIColors : ScriptableObject
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x30B2A10", Offset = "0x30B1010", VA = "0x1830B2A10")]
		public ItemTypeUIColors()
		{
		}

		// Token: 0x04000210 RID: 528
		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x18")]
		public Color _titleColor;

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x28")]
		public Color _descriptionColor;
	}
}
