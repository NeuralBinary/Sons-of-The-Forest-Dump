using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	[Serializable]
	public class FillGrabsStructureModule : ConstructionModule, IOnStructureDynamicSnapPointModule, IDynamicSnapPointModule, IConstructionModule
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0000815C File Offset: 0x0000635C
		[Token(Token = "0x17000305")]
		public override UiMessages StagedUiMessages
		{
			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x6C2DD0", Offset = "0x6C13D0", VA = "0x1806C2DD0", Slot = "43")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00008174 File Offset: 0x00006374
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000306")]
		private bool SwapTargetToFirstGrabsSupport
		{
			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C8D")]
			[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0000818C File Offset: 0x0000638C
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000307")]
		private bool BurnTargetAfterGrabTriggerIfInvalid
		{
			[Token(Token = "0x6000C8E")]
			[Address(RVA = "0x2866320", Offset = "0x2864920", VA = "0x182866320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x2A894E0", Offset = "0x2A87AE0", VA = "0x182A894E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x2EC7B60", Offset = "0x2EC6160", VA = "0x182EC7B60")]
		public FillGrabsStructureModule(ModuleProfileDatabase profileDatabase, bool swapTargetToFirstGrabsSupport, bool burnTargetAfterGrabTriggerIfInvalid)
		{
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000081A4 File Offset: 0x000063A4
		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "52")]
		public override bool ValidateFilters(TargetInfo targetInfo, ModuleProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x000081BC File Offset: 0x000063BC
		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x2EC7C80", Offset = "0x2EC6280", VA = "0x182EC7C80", Slot = "77")]
		public bool TryStage(ModuleState state)
		{
			return default(bool);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x2EC7E50", Offset = "0x2EC6450", VA = "0x182EC7E50", Slot = "57")]
		protected override void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000081D4 File Offset: 0x000063D4
		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x2EC8420", Offset = "0x2EC6A20", VA = "0x182EC8420")]
		private bool TryGetSnapPointFromGrabsStructure(TargetInfo targetInfo, ModuleState state, out bool isGrabsTrigger, out Vector3 snapPos, out Vector3 placeAxis, out Structure editingStructure)
		{
			return default(bool);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x2EC8A60", Offset = "0x2EC7060", VA = "0x182EC8A60", Slot = "71")]
		public override void OnPlace(TargetInfo targetInfo, ModuleProfile profile, int placementMode)
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000081EC File Offset: 0x000063EC
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x2EC90E0", Offset = "0x2EC76E0", VA = "0x182EC90E0")]
		[CompilerGenerated]
		internal static bool <TryGetSnapPointFromGrabsStructure>g__TryFindGrabsSupport|15_0(IStructure structure, List<IStructure> checkedStructures, out Structure grabsSupport)
		{
			return default(bool);
		}

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x70")]
		private List<IStructure> _checkedStructures;
	}
}
