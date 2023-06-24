using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	public class VerticalPlacementGuide : IPlacementGuide
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00004E8C File Offset: 0x0000308C
		[Token(Token = "0x17000223")]
		public UiMessages StagedUiMessage
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x2E343E0", Offset = "0x2E329E0", VA = "0x182E343E0", Slot = "4")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00004EA4 File Offset: 0x000030A4
		[Token(Token = "0x17000224")]
		public bool AllowAlternatingPlacement
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00004EBC File Offset: 0x000030BC
		[Token(Token = "0x17000225")]
		public bool AllowFreeSnap
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2E33FD0", Offset = "0x2E325D0", VA = "0x182E33FD0", Slot = "7")]
		public void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x2E343F0", Offset = "0x2E329F0", VA = "0x182E343F0", Slot = "8")]
		public void ValidateGroundedPlacementPosition(ConstructionManager manager, Transform canvasTr, float distanceBetweenElements, ref Vector3 placePosition, out bool splitToNewCanvas)
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x2E34340", Offset = "0x2E32940", VA = "0x182E34340", Slot = "9")]
		public void CheckAxisSnapping(ref Vector3 axis)
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public VerticalPlacementGuide()
		{
		}

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x10")]
		private bool _foundValidLine;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 _siblingPos;
	}
}
