using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x200075D")]
	[CreateAssetMenu(fileName = "ItemAnchorLocalOffsetData", menuName = "Sons/Data/Items/ItemAnchorLocalOffsetData", order = 0)]
	public class ItemAnchorLocalOffsetData : ScriptableObject
	{
		// Token: 0x060032FA RID: 13050 RVA: 0x0000F468 File Offset: 0x0000D668
		[Token(Token = "0x60032FA")]
		[Address(RVA = "0x34AE6C0", Offset = "0x34ACCC0", VA = "0x1834AE6C0")]
		public bool TryGetAnchorLocalOffsetForItem(int itemId, out ItemAnchorLocalOffsetData.ItemAnchorLocalOffsetDataElement itemAnchorLocalOffset)
		{
			return default(bool);
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032FB")]
		[Address(RVA = "0x34AE7F0", Offset = "0x34ACDF0", VA = "0x1834AE7F0")]
		public ItemAnchorLocalOffsetData()
		{
		}

		// Token: 0x04002C01 RID: 11265
		[Token(Token = "0x4002C01")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ItemAnchorLocalOffsetData.ItemAnchorLocalOffsetDataElement> _anchorOffsets;

		// Token: 0x0200075E RID: 1886
		[Token(Token = "0x200075E")]
		[Serializable]
		public class ItemAnchorLocalOffsetDataElement
		{
			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x060032FC RID: 13052 RVA: 0x0000F480 File Offset: 0x0000D680
			[Token(Token = "0x1700068C")]
			public int ItemId
			{
				[Token(Token = "0x60032FC")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x060032FD RID: 13053 RVA: 0x0000F498 File Offset: 0x0000D698
			[Token(Token = "0x1700068D")]
			public Vector3 Position
			{
				[Token(Token = "0x60032FD")]
				[Address(RVA = "0xAA8B50", Offset = "0xAA7150", VA = "0x180AA8B50")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x060032FE RID: 13054 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
			[Token(Token = "0x1700068E")]
			public Quaternion Rotation
			{
				[Token(Token = "0x60032FE")]
				[Address(RVA = "0xAA8B70", Offset = "0xAA7170", VA = "0x180AA8B70")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x060032FF RID: 13055 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
			[Token(Token = "0x1700068F")]
			public Vector3 Scale
			{
				[Token(Token = "0x60032FF")]
				[Address(RVA = "0x62AC70", Offset = "0x629270", VA = "0x18062AC70")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06003300 RID: 13056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003300")]
			[Address(RVA = "0x34AE8B0", Offset = "0x34ACEB0", VA = "0x1834AE8B0")]
			public void Set(int itemId, Vector3 position, Quaternion rotation, Vector3 scale)
			{
			}

			// Token: 0x06003301 RID: 13057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003301")]
			[Address(RVA = "0x34AE8F0", Offset = "0x34ACEF0", VA = "0x1834AE8F0")]
			public ItemAnchorLocalOffsetDataElement()
			{
			}

			// Token: 0x04002C02 RID: 11266
			[Token(Token = "0x4002C02")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[ItemIdPicker(true)]
			private int _itemId;

			// Token: 0x04002C03 RID: 11267
			[Token(Token = "0x4002C03")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Vector3 _position;

			// Token: 0x04002C04 RID: 11268
			[Token(Token = "0x4002C04")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Quaternion _rotation;

			// Token: 0x04002C05 RID: 11269
			[Token(Token = "0x4002C05")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Vector3 _scale;
		}
	}
}
