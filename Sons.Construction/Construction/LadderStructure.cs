using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	[AddComponentMenu("Sons/Construction/LadderStructure")]
	public class LadderStructure : Structure, ITargetablePlacement
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00008504 File Offset: 0x00006704
		[Token(Token = "0x17000332")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x25FC580", Offset = "0x25FAB80", VA = "0x1825FC580", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0000851C File Offset: 0x0000671C
		[Token(Token = "0x17000333")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000334")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x2ED1770", Offset = "0x2ECFD70", VA = "0x182ED1770", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000335")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x2ED17C0", Offset = "0x2ECFDC0", VA = "0x182ED17C0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000336")]
		public static Counter Counter
		{
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x2ED1810", Offset = "0x2ECFE10", VA = "0x182ED1810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x2ED1860", Offset = "0x2ECFE60", VA = "0x182ED1860", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00008534 File Offset: 0x00006734
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x2ED1870", Offset = "0x2ECFE70", VA = "0x182ED1870", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0000854C File Offset: 0x0000674C
		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x2E56600", Offset = "0x2E54C00", VA = "0x182E56600", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00008564 File Offset: 0x00006764
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x2ED18A0", Offset = "0x2ECFEA0", VA = "0x182ED18A0", Slot = "76")]
		public override Quaternion CalcNextElementRotation(StructureElement elementPrefab)
		{
			return default(Quaternion);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x2ED1970", Offset = "0x2ECFF70", VA = "0x182ED1970", Slot = "106")]
		public void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 pos, out Quaternion rot, out float lengthScale)
		{
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x2ED1860", Offset = "0x2ECFE60", VA = "0x182ED1860", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x2ED1860", Offset = "0x2ECFE60", VA = "0x182ED1860", Slot = "64")]
		public override void OnElementsChangedClient()
		{
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0000857C File Offset: 0x0000677C
		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x2ED21E0", Offset = "0x2ED07E0", VA = "0x182ED21E0")]
		private float CalcSupportHeight()
		{
			return 0f;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x2ED2250", Offset = "0x2ED0850", VA = "0x182ED2250")]
		private void RefreshTrigger()
		{
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x2ED26F0", Offset = "0x2ED0CF0", VA = "0x182ED26F0")]
		public LadderStructure()
		{
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00008594 File Offset: 0x00006794
		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x2ED2920", Offset = "0x2ED0F20", VA = "0x182ED2920")]
		[CompilerGenerated]
		internal static bool <CalcClosestElementPlacement>g__TryBrowseToNextPosition|17_0(StructureElement elementPrefab, float minLocalY, float maxLocalY, ref float localY, ref float nextOffset)
		{
			return default(bool);
		}

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x020001CA RID: 458
		[Token(Token = "0x20001CA")]
		public static class Utils
		{
			// Token: 0x06000D8C RID: 3468 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000D8C")]
			[Address(RVA = "0x2ED2A60", Offset = "0x2ED1060", VA = "0x182ED2A60")]
			public static void CalcLadderElementPositioningValues(StructureElement elementPrefab, float supportLength, ref float localY, out float minLocalY, out float maxLocalY, out float nextOffset)
			{
			}

			// Token: 0x06000D8D RID: 3469 RVA: 0x000085AC File Offset: 0x000067AC
			[Token(Token = "0x6000D8D")]
			[Address(RVA = "0x2ED2B90", Offset = "0x2ED1190", VA = "0x182ED2B90")]
			public static Vector3 CalcLadderPosFromSupport(WallStructure support1, WallDirections supportWallDir, StructureElement ladderElementPrefab)
			{
				return default(Vector3);
			}
		}
	}
}
