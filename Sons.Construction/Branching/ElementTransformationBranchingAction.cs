using System;
using Construction;
using Construction.Anim;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Construction.Branching
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Serializable]
	public class ElementTransformationBranchingAction : IItemSpecificBranchingAction, IBranchingAction, IInputModeProvider, IStagedMessageOverrideProvider, IItemTypeSpecificBranchingAction, IPlaceElementProfile, IPlayerPlaceAnimProvider, IElementItemProvider, IElementItemTypeProvider
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public string DisplayName
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x17000002")]
		public BranchingActionTypes Type
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return BranchingActionTypes.Cut;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000003")]
		public ItemData ElementItemData
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2D59EE0", Offset = "0x2D584E0", VA = "0x182D59EE0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x17000004")]
		public HeldItemBehaviours HeldItemBehaviour
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
			get
			{
				return HeldItemBehaviours.PromptEquipIfNotEquipped;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000005")]
		public BranchingElementData Target
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2D59F00", Offset = "0x2D58500", VA = "0x182D59F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x17000006")]
		public BranchingActionPreviewTypes PreviewType
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x7849B0", Offset = "0x782FB0", VA = "0x1807849B0", Slot = "6")]
			get
			{
				return BranchingActionPreviewTypes.None;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x17000007")]
		public Vector3 RelativePos
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x62AC70", Offset = "0x629270", VA = "0x18062AC70", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x17000008")]
		public Vector3 RelativeLookAxis
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2D59F20", Offset = "0x2D58520", VA = "0x182D59F20", Slot = "8")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x17000009")]
		public Vector3 PreviewSize
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x620480", Offset = "0x61EA80", VA = "0x180620480", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x1700000A")]
		public bool DynamicOrientation
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x1700000B")]
		public bool AllowAutoEquip
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2D59F40", Offset = "0x2D58540", VA = "0x182D59F40", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x1700000C")]
		public ModuleProfile.InputModeOverrides InputMode
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "14")]
			get
			{
				return ModuleProfile.InputModeOverrides.AlwaysTwoSteps;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x1700000D")]
		public UiMessages StagedMessageOverride
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40", Slot = "15")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x1700000E")]
		public bool UseCutItem
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2D59F50", Offset = "0x2D58550", VA = "0x182D59F50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x1700000F")]
		public bool ConsumesItem
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x2D59F70", Offset = "0x2D58570", VA = "0x182D59F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x17000010")]
		public bool ReplaceElementWithBranchingElement
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2D59F90", Offset = "0x2D58590", VA = "0x182D59F90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x17000011")]
		public bool KeepElementPosition
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2D59FB0", Offset = "0x2D585B0", VA = "0x182D59FB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x17000012")]
		public bool AddFromTemplate
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2D59FD0", Offset = "0x2D585D0", VA = "0x182D59FD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000013")]
		private StructureElement ElementPrefab
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2D59FF0", Offset = "0x2D585F0", VA = "0x182D59FF0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000014")]
		private ElementPlaceAnimation ElementPlaceAnimation
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000015")]
		private AudioClipProfile PlacedElementAudioClip
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000016")]
		private PlayerAnimationData PlayerPlaceAnim
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x17000017")]
		public Types ItemType
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "24")]
			get
			{
				return (Types)0;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2D5A020", Offset = "0x2D58620", VA = "0x182D5A020", Slot = "25")]
		public bool IsCompatible(ItemData item)
		{
			return default(bool);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2D5A210", Offset = "0x2D58810", VA = "0x182D5A210", Slot = "10")]
		public Vector3 GetWorldPosFor(StructureElement element)
		{
			return default(Vector3);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2D5A430", Offset = "0x2D58A30", VA = "0x182D5A430")]
		public Vector3 GetWorldPosFor(TargetInfo targetInfo)
		{
			return default(Vector3);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2D5A740", Offset = "0x2D58D40", VA = "0x182D5A740", Slot = "11")]
		public bool TryExecute(IItemSource itemSource, ILoadItemReceiver itemLoader)
		{
			return default(bool);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2D5A910", Offset = "0x2D58F10", VA = "0x182D5A910", Slot = "12")]
		public bool TryExecute(IItemSource itemSource, StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2D5B2F0", Offset = "0x2D598F0", VA = "0x182D5B2F0", Slot = "13")]
		public bool CheckIsValid(IItemSource itemSource, StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ElementTransformationBranchingAction()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _displayName;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BranchingActionTypes _type;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemData _item;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Types _itemType;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private HeldItemBehaviours _heldItemBehaviour;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _relativePos;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 _relativeLookAxis;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UiMessages _stagedMessageOverride;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private BranchingActionPreviewTypes _previewType;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 _previewSize;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BranchingElementDataAsset _target;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ElementPlaceAnimation _elementPlaceAnimation;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PlayerAnimationData _playerPlaceAnimation;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _dynamicOrientation;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _spawnOffset;
	}
}
