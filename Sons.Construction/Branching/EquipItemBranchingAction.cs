using System;
using System.Runtime.CompilerServices;
using Construction;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Construction.Branching
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Serializable]
	public class EquipItemBranchingAction : IBranchingAction, IInputModeProvider, IStagedMessageOverrideProvider
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000018")]
		public string DisplayName
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000023 RID: 35 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x17000019")]
		public BranchingActionPreviewTypes PreviewType
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return BranchingActionPreviewTypes.None;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x1700001A")]
		public Vector3 RelativePos
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2D5B680", Offset = "0x2D59C80", VA = "0x182D5B680", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x1700001B")]
		public Vector3 RelativeLookAxis
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x282CEB0", Offset = "0x282B4B0", VA = "0x18282CEB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x1700001C")]
		public Vector3 PreviewSize
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x781510", Offset = "0x77FB10", VA = "0x180781510", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x1700001D")]
		public ModuleProfile.InputModeOverrides InputMode
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "13")]
			get
			{
				return ModuleProfile.InputModeOverrides.AlwaysTwoSteps;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x1700001E")]
		public UiMessages StagedMessageOverride
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "14")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2D5B690", Offset = "0x2D59C90", VA = "0x182D5B690")]
		private void InitInstance(int id)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2D5B810", Offset = "0x2D59E10", VA = "0x182D5B810")]
		public void TryInit(ElementTransformationBranchingAction transformation)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2D5BB60", Offset = "0x2D5A160", VA = "0x182D5BB60")]
		private void SetDisplayName()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2D5BC00", Offset = "0x2D5A200", VA = "0x182D5BC00", Slot = "9")]
		public Vector3 GetWorldPosFor(StructureElement element)
		{
			return default(Vector3);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2D5BD70", Offset = "0x2D5A370", VA = "0x182D5BD70", Slot = "10")]
		public bool TryExecute(IItemSource itemSource, ILoadItemReceiver itemLoader)
		{
			return default(bool);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2D5BDD0", Offset = "0x2D5A3D0", VA = "0x182D5BDD0", Slot = "11")]
		public bool TryExecute(IItemSource itemSource, StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
		public bool CheckIsValid(IItemSource itemSource, StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public EquipItemBranchingAction()
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x38")]
		private ItemInstance _itemInstance;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x40")]
		private ElementTransformationBranchingAction _goalTransformation;
	}
}
