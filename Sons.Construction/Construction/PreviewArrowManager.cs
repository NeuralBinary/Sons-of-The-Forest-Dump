using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	[AddComponentMenu("Sons/Construction/PreviewArrowManager")]
	public class PreviewArrowManager : MonoBehaviour, IPreviewManager
	{
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x0000521C File Offset: 0x0000341C
		[Token(Token = "0x17000244")]
		public float ArrowLength
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x2E3DB00", Offset = "0x2E3C100", VA = "0x182E3DB00")]
		private void Awake()
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x2E3DC50", Offset = "0x2E3C250", VA = "0x182E3DC50")]
		private void Update()
		{
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x2E3E0E0", Offset = "0x2E3C6E0", VA = "0x182E3E0E0")]
		internal void ShowAnimated(ArrowTypes arrowType, Vector3 fromPos, Vector3 toPos, Quaternion fromRot, Quaternion toRot)
		{
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x2E3E550", Offset = "0x2E3CB50", VA = "0x182E3E550")]
		internal void Show(ArrowTypes arrowType, Vector3 arrowPos, Vector3 lookAtPos, Vector3 lookAtUp)
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x2E3E7A0", Offset = "0x2E3CDA0", VA = "0x182E3E7A0")]
		internal void Show(ArrowTypes arrowType, Vector3 arrowPos, Quaternion arrowRot)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x2E3E9D0", Offset = "0x2E3CFD0", VA = "0x182E3E9D0")]
		internal void ShowSplit(Vector3 leftArrowPos, Vector3 rightArrowPos, Vector3 lookDir, Vector3 lookAtUp, SplitArrowTypes arrowType = SplitArrowTypes.Straight)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2E3F370", Offset = "0x2E3D970", VA = "0x182E3F370")]
		internal void HideSplitArrow()
		{
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x2E3F6D0", Offset = "0x2E3DCD0", VA = "0x182E3F6D0", Slot = "4")]
		public void Hide()
		{
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x2E3F8E0", Offset = "0x2E3DEE0", VA = "0x182E3F8E0")]
		private void SetActiveArrow(Transform arrowTr, Tweener arrowTween)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2E3FBF0", Offset = "0x2E3E1F0", VA = "0x182E3FBF0")]
		private void SetActiveSplitArrows(SplitArrowTypes arrowType)
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PreviewArrowManager()
		{
		}

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Settings")]
		private float _arrowsLength;

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x28")]
		[Header("Regular")]
		[SerializeField]
		private Transform[] _placementArrows;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Tweener[] _placementArrowsTween;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x38")]
		[Header("Split")]
		[SerializeField]
		private Transform[] _leftPlacementArrows;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform[] _rightPlacementArrows;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _placementArrowLeft;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _placementArrowRight;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Tweener _splitArrowTween;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 _arrowFromPos;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _arrowToPos;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion _arrowFromRot;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x88")]
		private Quaternion _arrowToRot;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 _splitArrowMiddlePos;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 _splitLeftArrowMiddlePos;

		// Token: 0x04000561 RID: 1377
		[Token(Token = "0x4000561")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 _splitRightArrowMiddlePos;

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 _leftArrowPos;

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 _rightArrowPos;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0xD8")]
		private Transform _initialParent;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0xE0")]
		private Transform _activeArrow;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0xE8")]
		private Transform _activeLeftArrow;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0xF0")]
		private Transform _activeRightArrow;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0xF8")]
		private Tweener _activeTweener;
	}
}
