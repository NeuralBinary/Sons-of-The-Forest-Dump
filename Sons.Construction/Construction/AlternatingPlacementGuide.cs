using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	public class AlternatingPlacementGuide : IPlacementGuide
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00004ED4 File Offset: 0x000030D4
		[Token(Token = "0x17000226")]
		public UiMessages StagedUiMessage
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x2E34460", Offset = "0x2E32A60", VA = "0x182E34460", Slot = "4")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00004EEC File Offset: 0x000030EC
		[Token(Token = "0x17000227")]
		public bool AllowAlternatingPlacement
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00004F04 File Offset: 0x00003104
		[Token(Token = "0x17000228")]
		public bool AllowFreeSnap
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x2E33FD0", Offset = "0x2E325D0", VA = "0x182E33FD0", Slot = "7")]
		public void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x2E343F0", Offset = "0x2E329F0", VA = "0x182E343F0", Slot = "8")]
		public void ValidateGroundedPlacementPosition(ConstructionManager manager, Transform canvasTr, float distanceBetweenElements, ref Vector3 placePosition, out bool splitToNewCanvas)
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x2E34340", Offset = "0x2E32940", VA = "0x182E34340", Slot = "9")]
		public void CheckAxisSnapping(ref Vector3 axis)
		{
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public AlternatingPlacementGuide()
		{
		}

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x10")]
		private bool _foundValidLine;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 _siblingPos;
	}
}
