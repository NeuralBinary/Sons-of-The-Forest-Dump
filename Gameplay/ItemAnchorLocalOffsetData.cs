using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000640 RID: 1600
	[Token(Token = "0x2000640")]
	[CreateAssetMenu(fileName = "ItemAnchorLocalOffsetData", menuName = "Sons/Data/Items/ItemAnchorLocalOffsetData", order = 0)]
	public class ItemAnchorLocalOffsetData : ScriptableObject
	{
		// Token: 0x0600291B RID: 10523 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x2DBB140", Offset = "0x2DBA140", VA = "0x182DBB140")]
		public bool TryGetAnchorLocalOffsetForItem(int itemId, out ItemAnchorLocalOffsetData.ItemAnchorLocalOffsetDataElement itemAnchorLocalOffset)
		{
			return default(bool);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x2DBB230", Offset = "0x2DBA230", VA = "0x182DBB230")]
		public ItemAnchorLocalOffsetData()
		{
		}

		// Token: 0x040024BD RID: 9405
		[Token(Token = "0x40024BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ItemAnchorLocalOffsetData.ItemAnchorLocalOffsetDataElement> _anchorOffsets;

		// Token: 0x02000641 RID: 1601
		[Token(Token = "0x2000641")]
		[Serializable]
		public class ItemAnchorLocalOffsetDataElement
		{
			// Token: 0x17000560 RID: 1376
			// (get) Token: 0x0600291D RID: 10525 RVA: 0x0000BDC0 File Offset: 0x00009FC0
			[Token(Token = "0x17000560")]
			public int ItemId
			{
				[Token(Token = "0x600291D")]
				[Address(RVA = "0x55E9A0", Offset = "0x55D9A0", VA = "0x18055E9A0")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x17000561 RID: 1377
			// (get) Token: 0x0600291E RID: 10526 RVA: 0x0000BDD8 File Offset: 0x00009FD8
			[Token(Token = "0x17000561")]
			public Vector3 Position
			{
				[Token(Token = "0x600291E")]
				[Address(RVA = "0x93FBE0", Offset = "0x93EBE0", VA = "0x18093FBE0")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000562 RID: 1378
			// (get) Token: 0x0600291F RID: 10527 RVA: 0x0000BDF0 File Offset: 0x00009FF0
			[Token(Token = "0x17000562")]
			public Quaternion Rotation
			{
				[Token(Token = "0x600291F")]
				[Address(RVA = "0x93FC00", Offset = "0x93EC00", VA = "0x18093FC00")]
				get
				{
					return default(Quaternion);
				}
			}

			// Token: 0x17000563 RID: 1379
			// (get) Token: 0x06002920 RID: 10528 RVA: 0x0000BE08 File Offset: 0x0000A008
			[Token(Token = "0x17000563")]
			public Vector3 Scale
			{
				[Token(Token = "0x6002920")]
				[Address(RVA = "0x5B2E90", Offset = "0x5B1E90", VA = "0x1805B2E90")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06002921 RID: 10529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002921")]
			[Address(RVA = "0x2DBB0A0", Offset = "0x2DBA0A0", VA = "0x182DBB0A0")]
			public void Set(int itemId, Vector3 position, Quaternion rotation, Vector3 scale)
			{
			}

			// Token: 0x06002922 RID: 10530 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002922")]
			[Address(RVA = "0x2DBB0E0", Offset = "0x2DBA0E0", VA = "0x182DBB0E0")]
			public ItemAnchorLocalOffsetDataElement()
			{
			}

			// Token: 0x040024BE RID: 9406
			[Token(Token = "0x40024BE")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(true)]
			[SerializeField]
			private int _itemId;

			// Token: 0x040024BF RID: 9407
			[Token(Token = "0x40024BF")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Vector3 _position;

			// Token: 0x040024C0 RID: 9408
			[Token(Token = "0x40024C0")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Quaternion _rotation;

			// Token: 0x040024C1 RID: 9409
			[Token(Token = "0x40024C1")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Vector3 _scale;
		}
	}
}
