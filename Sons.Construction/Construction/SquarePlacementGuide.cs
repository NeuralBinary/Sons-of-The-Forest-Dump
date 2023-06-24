using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	public class SquarePlacementGuide : IPlacementGuide
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00004DFC File Offset: 0x00002FFC
		[Token(Token = "0x1700021D")]
		public UiMessages StagedUiMessage
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x2E312D0", Offset = "0x2E2F8D0", VA = "0x182E312D0", Slot = "4")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00004E14 File Offset: 0x00003014
		[Token(Token = "0x1700021E")]
		public bool AllowAlternatingPlacement
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00004E2C File Offset: 0x0000302C
		[Token(Token = "0x1700021F")]
		public bool AllowFreeSnap
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2E33FB0", Offset = "0x2E325B0", VA = "0x182E33FB0", Slot = "8")]
		public void ValidateGroundedPlacementPosition(ConstructionManager manager, Transform canvasTr, float distanceBetweenElements, ref Vector3 placePosition, out bool splitToNewCanvas)
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2E31480", Offset = "0x2E2FA80", VA = "0x182E31480", Slot = "9")]
		public void CheckAxisSnapping(ref Vector3 axis)
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SquarePlacementGuide()
		{
		}
	}
}
