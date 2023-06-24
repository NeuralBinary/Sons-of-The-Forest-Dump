using System;
using Construction.Anim;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	[CreateAssetMenu(menuName = "Sons/Construction/NotchingDataGrid")]
	public class NotchingDataGrid : ScriptableObject
	{
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x000093EC File Offset: 0x000075EC
		[Token(Token = "0x17000386")]
		public Types NotchingItemType
		{
			[Token(Token = "0x6000F40")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return (Types)0;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000387")]
		public PlayerAnimationData PlaceAnim
		{
			[Token(Token = "0x6000F41")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00009404 File Offset: 0x00007604
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x2EFB960", Offset = "0x2EF9F60", VA = "0x182EFB960")]
		public bool HasMissingNotches(StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x0000941C File Offset: 0x0000761C
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x2EFB9D0", Offset = "0x2EF9FD0", VA = "0x182EFB9D0")]
		public bool TryFindNearestMissingNotchPos(StructureElement element, Vector3 nearPos, out Vector3 notchWorldPos, out Quaternion notchWorldRot)
		{
			return default(bool);
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00009434 File Offset: 0x00007634
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x2EFBCC0", Offset = "0x2EFA2C0", VA = "0x182EFBCC0")]
		public bool TryFindNearestMissingNotchElement(StructureElement element, Vector3 nearPos, out StructureElement notchedElement)
		{
			return default(bool);
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0000944C File Offset: 0x0000764C
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x2EFBE60", Offset = "0x2EFA460", VA = "0x182EFBE60")]
		public bool TryFindElementForNotches(Notches notches, out StructureElement notchedElement)
		{
			return default(bool);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00009464 File Offset: 0x00007664
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x2EFBFF0", Offset = "0x2EFA5F0", VA = "0x182EFBFF0")]
		private bool TryFindNearestMissingNotch(StructureElement element, Vector3 nearPos, out NotchingDataGrid.NotchDefinition closestNotchDefinition)
		{
			return default(bool);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public NotchingDataGrid()
		{
		}

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private NotchingDataGrid.NotchDefinition[] _definitions;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NotchingDataGrid.NotchedElement[] _elements;

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Types _notchingItemType;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PlayerAnimationData _placeAnim;

		// Token: 0x020001FC RID: 508
		[Token(Token = "0x20001FC")]
		[Serializable]
		public class NotchDefinition
		{
			// Token: 0x17000388 RID: 904
			// (get) Token: 0x06000F48 RID: 3912 RVA: 0x0000947C File Offset: 0x0000767C
			[Token(Token = "0x17000388")]
			public Notches Num
			{
				[Token(Token = "0x6000F48")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return Notches.None;
				}
			}

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x06000F49 RID: 3913 RVA: 0x00009494 File Offset: 0x00007694
			[Token(Token = "0x17000389")]
			public Vector3 LocalPos
			{
				[Token(Token = "0x6000F49")]
				[Address(RVA = "0xAA8B50", Offset = "0xAA7150", VA = "0x180AA8B50")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06000F4A RID: 3914 RVA: 0x000094AC File Offset: 0x000076AC
			[Token(Token = "0x1700038A")]
			public Vector3 LocalAxis
			{
				[Token(Token = "0x6000F4A")]
				[Address(RVA = "0x29A0830", Offset = "0x299EE30", VA = "0x1829A0830")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x06000F4B RID: 3915 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000F4B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public NotchDefinition()
			{
			}

			// Token: 0x0400082F RID: 2095
			[Token(Token = "0x400082F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Notches _num;

			// Token: 0x04000830 RID: 2096
			[Token(Token = "0x4000830")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Vector3 _localPos;

			// Token: 0x04000831 RID: 2097
			[Token(Token = "0x4000831")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Vector3 _localAxis;
		}

		// Token: 0x020001FD RID: 509
		[Token(Token = "0x20001FD")]
		[Serializable]
		public class NotchedElement
		{
			// Token: 0x1700038B RID: 907
			// (get) Token: 0x06000F4C RID: 3916 RVA: 0x000094C4 File Offset: 0x000076C4
			[Token(Token = "0x1700038B")]
			public Notches Mask
			{
				[Token(Token = "0x6000F4C")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return Notches.None;
				}
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700038C")]
			public StructureElement Prefab
			{
				[Token(Token = "0x6000F4D")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000F4E RID: 3918 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000F4E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public NotchedElement()
			{
			}

			// Token: 0x04000832 RID: 2098
			[Token(Token = "0x4000832")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Notches _mask;

			// Token: 0x04000833 RID: 2099
			[Token(Token = "0x4000833")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private StructureElement _prefab;
		}
	}
}
