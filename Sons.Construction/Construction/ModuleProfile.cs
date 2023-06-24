using System;
using Construction.Anim;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Construction
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[Serializable]
	public class ModuleProfile : IInputModeProvider, IStagedMessageOverrideProvider, IPlayerPlaceAnimProvider, IElementItemProvider, IPlaceElementProfile
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E0")]
		public ItemData ElementItemData
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E1")]
		public ElementProfile[] FilterToProfiles
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E2")]
		public ElementProfile ElementProfile
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E3")]
		public StructureElement ElementPrefab
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x2D779A0", Offset = "0x2D75FA0", VA = "0x182D779A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E4")]
		public ElementProfile ExtraElementProfile
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E5")]
		public PlayerAnimationData StagedPlayerAnim
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E6")]
		public PlayerAnimationData PlayerPlaceAnim
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E7")]
		public ElementPlaceAnimation ElementPlaceAnimation
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E8")]
		public AudioClipProfile PlacedElementAudioClip
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000E9")]
		public AudioClipProfile PlaceAnimBeganAudioClip
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000EA")]
		public AudioClipProfile PlaceAnimCompletedAudioClip
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000314C File Offset: 0x0000134C
		[Token(Token = "0x170000EB")]
		public ModuleProfile.InputModeOverrides InputMode
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40", Slot = "4")]
			get
			{
				return ModuleProfile.InputModeOverrides.AlwaysTwoSteps;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00003164 File Offset: 0x00001364
		[Token(Token = "0x170000EC")]
		public int SpawnCount
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x170000ED")]
		public float StageDelay
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x5F1D10", Offset = "0x5F0310", VA = "0x1805F1D10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x170000EE")]
		public float ForwardOffset
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x170000EF")]
		public float MaxPlaceDistance
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x23FC6E0", Offset = "0x23FACE0", VA = "0x1823FC6E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000292 RID: 658 RVA: 0x000031C4 File Offset: 0x000013C4
		[Token(Token = "0x170000F0")]
		public bool AllowAutoEquip
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000031DC File Offset: 0x000013DC
		[Token(Token = "0x170000F1")]
		public bool AllowDetachedPlacement
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x998F20", Offset = "0x997520", VA = "0x180998F20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000031F4 File Offset: 0x000013F4
		[Token(Token = "0x170000F2")]
		public PresetStructuresSubTypes PresetStructureSubType
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x784B50", Offset = "0x783150", VA = "0x180784B50")]
			get
			{
				return PresetStructuresSubTypes.Preset;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x170000F3")]
		public Decals PreviewDecal
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
			get
			{
				return Decals.FlatWhite;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00003224 File Offset: 0x00001424
		[Token(Token = "0x170000F4")]
		public UiMessages StagedMessageOverride
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x2D77A80", Offset = "0x2D76080", VA = "0x182D77A80", Slot = "5")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x2D77AC0", Offset = "0x2D760C0", VA = "0x182D77AC0")]
		public ModuleProfile()
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2D77AF0", Offset = "0x2D760F0", VA = "0x182D77AF0")]
		public ModuleProfile(ItemData item)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2D77B70", Offset = "0x2D76170", VA = "0x182D77B70")]
		public ModuleProfile(Types itemTypes)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000323C File Offset: 0x0000143C
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2D77BA0", Offset = "0x2D761A0", VA = "0x182D77BA0", Slot = "8")]
		public bool IsCompatible(ItemData item)
		{
			return default(bool);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void GetProfileRefFromPrefab()
		{
		}

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ItemData _elementItemData;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Types _itemTypes;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ElementProfile[] _filterToProfiles;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ElementProfile _prefabProfile;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Not mandatory, used by some modules to add features such as a sleep trigger to a tarp with stakes")]
		private ElementProfile _extraElementProfile;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ModuleProfile.InputModeOverrides _inputMode;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Decals _previewDecal;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PrimaryUiMessages _primaryStagedMessageOverride;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private SecondaryUiMessages _secondaryStagedMessageOverride;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int _spawnCount;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _stageDelay;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("For compatible modules, currently for place on ground modules only.")]
		private float _forwardOffset;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _maxplaceDistance;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _allowAutoEquip;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool _allowDetachedPlacement;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private PresetStructuresSubTypes _presetStructureSubType;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PlayerAnimationData _stagedPlayerAnim;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private PlayerAnimationData _playerPlaceAnim;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ElementPlaceAnimation _elementPlaceAnimation;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("_placedAudioClip")]
		[SerializeField]
		private AudioClipProfile _placedElementAudioClip;

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x80")]
		[FormerlySerializedAs("_placeAnimBeganAudiolip")]
		[SerializeField]
		private AudioClipProfile _placeAnimBeganAudioClip;

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioClipProfile _placeAnimCompletedAudiolip;

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		public enum InputModeOverrides
		{
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			UseManagerSetting = -1,
			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			AlwaysTwoSteps,
			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			HoldForOneStep = 2,
			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			TapForOneStep,
			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			TapSecondaryForOneStep,
			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			TapSecondaryForTwoStep,
			// Token: 0x040002A7 RID: 679
			[Token(Token = "0x40002A7")]
			TapMainOrAltTwoSteps,
			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			TapMainOrAltOneSteps
		}
	}
}
