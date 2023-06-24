using System;
using System.Collections.Generic;
using Construction;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Construction.Branching
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Serializable]
	public class BranchingElementData
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000021")]
		public ItemData Item
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000022")]
		public StructureElement Prefab
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000023")]
		public ElementPlaceAnimationClip ElementPlaceAnim
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000024")]
		public AudioClipProfile PlacedElementAudioClip
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x17000025")]
		public Vector3 PositionOffset
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x17000026")]
		public Vector3 RelativeRotationAxis
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1E13580", Offset = "0x1E11B80", VA = "0x181E13580")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x17000027")]
		public float RelativeRotationAngles
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000028")]
		public IReadOnlyCollection<ElementTransformationBranchingAction> Transformations
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2D5C360", Offset = "0x2D5A960", VA = "0x182D5C360")]
		public bool Matches(ItemData item)
		{
			return default(bool);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2D5C490", Offset = "0x2D5AA90", VA = "0x182D5C490")]
		public bool Matches(ItemData item, uint elementId)
		{
			return default(bool);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2D5C5D0", Offset = "0x2D5ABD0", VA = "0x182D5C5D0")]
		public bool Matches(StructureElement prefab)
		{
			return default(bool);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2D5C820", Offset = "0x2D5AE20", VA = "0x182D5C820")]
		public bool TryGetTransformation(IAimRayProvider aimRayProvider, ItemData item, StructureElement loadedElementInstance, out ElementTransformationBranchingAction transformation)
		{
			return default(bool);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BranchingElementData()
		{
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ItemData _item;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StructureElement _prefab;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StructureElement[] _additionalPrefabs;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ElementPlaceAnimationClip _elementPlaceAnim;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClipProfile _placedElementAudioClip;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 _positionOffset;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector3 _relativeRotationAxis;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _relativeRotationAngles;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ElementTransformationBranchingAction[] _transformations;
	}
}
