using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	public class StraightPlacementGuide : IPlacementGuide
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00004E44 File Offset: 0x00003044
		[Token(Token = "0x17000220")]
		public UiMessages StagedUiMessage
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x2E33FC0", Offset = "0x2E325C0", VA = "0x182E33FC0", Slot = "4")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00004E5C File Offset: 0x0000305C
		[Token(Token = "0x17000221")]
		public bool AllowAlternatingPlacement
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00004E74 File Offset: 0x00003074
		[Token(Token = "0x17000222")]
		public bool AllowFreeSnap
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2E33FD0", Offset = "0x2E325D0", VA = "0x182E33FD0", Slot = "7")]
		public void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x2E342D0", Offset = "0x2E328D0", VA = "0x182E342D0", Slot = "8")]
		public void ValidateGroundedPlacementPosition(ConstructionManager manager, Transform canvasTr, float distanceBetweenElements, ref Vector3 placePosition, out bool splitToNewCanvas)
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2E34340", Offset = "0x2E32940", VA = "0x182E34340", Slot = "9")]
		public void CheckAxisSnapping(ref Vector3 axis)
		{
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public StraightPlacementGuide()
		{
		}

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x10")]
		private bool _foundValidLine;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 _siblingPos;
	}
}
