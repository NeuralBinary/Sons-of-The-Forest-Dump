using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	public class CirclePlacementGuide : IPlacementGuide
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x17000217")]
		public UiMessages StagedUiMessage
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x2E312D0", Offset = "0x2E2F8D0", VA = "0x182E312D0", Slot = "4")]
			get
			{
				return UiMessages.None;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x17000218")]
		public bool AllowAlternatingPlacement
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x17000219")]
		public bool AllowFreeSnap
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x2E312E0", Offset = "0x2E2F8E0", VA = "0x182E312E0", Slot = "7")]
		public void ShowStagedPreview(ConstructionManager manager, TargetInfo targetInfo, ModuleState state)
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x2E31480", Offset = "0x2E2FA80", VA = "0x182E31480", Slot = "9")]
		public void CheckAxisSnapping(ref Vector3 axis)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x2E318F0", Offset = "0x2E2FEF0", VA = "0x182E318F0", Slot = "8")]
		public void ValidateGroundedPlacementPosition(ConstructionManager manager, Transform canvasTr, float distanceBetweenElements, ref Vector3 placePosition, out bool splitToNewCanvas)
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x2E32000", Offset = "0x2E30600", VA = "0x182E32000")]
		private bool TryValidateCircleGuideConditions(ConstructionManager manager, Vector3 placePos, float radius, Vector3 center)
		{
			return default(bool);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00004D6C File Offset: 0x00002F6C
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x2E32090", Offset = "0x2E30690", VA = "0x182E32090")]
		private static bool CheckCircleCenterIsInFront(ConstructionManager manager, Vector3 placePos, Vector3 center)
		{
			return default(bool);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CirclePlacementGuide()
		{
		}

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 _circleCenter;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x1C")]
		private float _circleRadius;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x20")]
		private bool _foundValidCircle;
	}
}
