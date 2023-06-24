using System;
using System.Runtime.CompilerServices;
using Construction.Anim;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using Sons.Items.Core;

namespace Construction
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	[Serializable]
	public class ModuleState
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x17000070")]
		public int PlacementMode
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x2D68180", Offset = "0x2D66780", VA = "0x182D68180")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000071")]
		public ModuleProfile ActiveProfile
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000072")]
		public IAnimatableIngredient NextPresetIngredient
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000134 RID: 308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000073")]
		public IBranchingAction BranchingAction
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000074")]
		public PlayerAnimationData ActivePlayerPlaceAnimation
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2D681E0", Offset = "0x2D667E0", VA = "0x182D681E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000075")]
		public ItemData ActiveElementItemData
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2D682E0", Offset = "0x2D668E0", VA = "0x182D682E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000137 RID: 311 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x17000076")]
		public bool AllowAutoEquip
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2D68370", Offset = "0x2D66970", VA = "0x182D68370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000077")]
		public StructureElement PlacingElementPrefab
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2D683F0", Offset = "0x2D669F0", VA = "0x182D683F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000139 RID: 313 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x17000078")]
		public ModuleProfile.InputModeOverrides InputMode
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2D68470", Offset = "0x2D66A70", VA = "0x182D68470")]
			get
			{
				return ModuleProfile.InputModeOverrides.AlwaysTwoSteps;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x17000079")]
		public UiMessages StagedMessageOverride
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2D684D0", Offset = "0x2D66AD0", VA = "0x182D684D0")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x1700007A")]
		public bool RequireCompletedStructureMessage
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public void SetPlacementModeGroup(IPlacementModeGroup placementModeGroup)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2D68530", Offset = "0x2D66B30", VA = "0x182D68530")]
		public void SetPlacementModeOverride(int placementMode)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2121560", Offset = "0x211FB60", VA = "0x182121560")]
		public void ResetPlacementModeOverride()
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2D68540", Offset = "0x2D66B40", VA = "0x182D68540")]
		public void SetProfile(ModuleProfile profile)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetNextPresetIngredient(IAnimatableIngredient nextPresetIngredient)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
		public void SetBranchingAction(IBranchingAction branchingAction)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2D686A0", Offset = "0x2D66CA0", VA = "0x182D686A0")]
		public bool IsItemCompatible(ItemData item)
		{
			return default(bool);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2D687B0", Offset = "0x2D66DB0", VA = "0x182D687B0")]
		private IPlaceElementProfile GetPlaceElementProvider()
		{
			return null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2D68800", Offset = "0x2D66E00", VA = "0x182D68800")]
		private IElementItemProvider GetElementItemProvider()
		{
			return null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2D68850", Offset = "0x2D66E50", VA = "0x182D68850")]
		private IInputModeProvider GetInputModeProvider()
		{
			return null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2D68870", Offset = "0x2D66E70", VA = "0x182D68870")]
		private IPlayerPlaceAnimProvider GetPlayerPlaceAnimProvider()
		{
			return null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2D68850", Offset = "0x2D66E50", VA = "0x182D68850")]
		private IStagedMessageOverrideProvider GetStagedMessageOverrideProvider()
		{
			return null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
		public void SetRequireCompletedMessage(bool requiresCompletedStructureMessage)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2121560", Offset = "0x211FB60", VA = "0x182121560")]
		public ModuleState()
		{
		}

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x10")]
		private IPlacementModeGroup _placementModeGroup;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x18")]
		private ModuleProfile _profile;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x20")]
		private bool _requiresCompletedStructureMessage;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x24")]
		private int _placementModeOverride;
	}
}
