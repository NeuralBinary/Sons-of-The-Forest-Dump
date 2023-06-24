using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using Sons.Gui;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Construction
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	[AddComponentMenu("Sons/Construction/PreviewManager")]
	public class PreviewManager : MonoBehaviour, IStructureDirtyReceiver
	{
		// Token: 0x0600077C RID: 1916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2E43DA0", Offset = "0x2E423A0", VA = "0x182E43DA0")]
		private void Awake()
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x2E445D0", Offset = "0x2E42BD0", VA = "0x182E445D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2E44620", Offset = "0x2E42C20", VA = "0x182E44620")]
		public void ShowPreview(Vector3 previewCenter, Vector3 size, Quaternion rot, Decals decal = Decals.FlatWhite, bool reUseActive = true, bool onTerrain = false, bool isInvalid = false)
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x2E44820", Offset = "0x2E42E20", VA = "0x182E44820")]
		public void ShowPreviewSecondary(Vector3 previewCenter, Vector3 size, Quaternion rot, Decals decal = Decals.FlatWhite, bool reUseActive = true, bool onTerrain = true)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2E449B0", Offset = "0x2E42FB0", VA = "0x182E449B0")]
		public void ShowLinePreviewPlace(Vector3 from, Vector3 to, Vector3 dir, float depth, bool reUseActive = true, bool onTerrain = false)
		{
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2E44E00", Offset = "0x2E43400", VA = "0x182E44E00")]
		public void ShowLinePreviewPlace(Vector3 previewCenter, float lineWidth, float depth, Quaternion rot, bool reUseActive = true, bool onTerrain = false)
		{
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x2E44F80", Offset = "0x2E43580", VA = "0x182E44F80")]
		public void ShowLinePreviewCut(Vector3 previewCenter, float lineWidth, float depth, Quaternion rot, bool reUseActive = true, bool onTerrain = false)
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x2E45140", Offset = "0x2E43740", VA = "0x182E45140")]
		public void ShowSquarePreviewPlace(Vector3 previewCenter, Vector3 size, Quaternion rot, bool reUseActive = true)
		{
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x2E453D0", Offset = "0x2E439D0", VA = "0x182E453D0")]
		public void ShowSquarePreviewCut(Vector3 previewCenter, Vector3 size, Quaternion rot, bool reUseActive = true)
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2E455B0", Offset = "0x2E43BB0", VA = "0x182E455B0")]
		public void ShowSquareOnTerrainPreviewPlace(Vector3 previewCenter, Vector3 size, Quaternion rot, bool reUseActive = true, bool isInvalid = false, bool dark = false)
		{
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x2E458C0", Offset = "0x2E43EC0", VA = "0x182E458C0")]
		public void HideSquarePreviewDashes()
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x2E45960", Offset = "0x2E43F60", VA = "0x182E45960")]
		public void HideLinePreviewPlace()
		{
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x2E459B0", Offset = "0x2E43FB0", VA = "0x182E459B0")]
		public void ShowItemPicker(Vector3 worldPosition)
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x2E45C10", Offset = "0x2E44210", VA = "0x182E45C10")]
		public void HideItemPicker()
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2E45E90", Offset = "0x2E44490", VA = "0x182E45E90")]
		public void OnRotateItemPicker(InputAction.CallbackContext context)
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2E45F00", Offset = "0x2E44500", VA = "0x182E45F00")]
		public void UpdateItemPicker(ConstructionManager manager, IReadOnlyList<ModuleProfile> profiles, out int outActiveProfileIndex)
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2E465A0", Offset = "0x2E44BA0", VA = "0x182E465A0")]
		public void ShowPreviewDashedLine3D(Vector3 fromPos, Vector3 toPos, bool reUseActive = true, bool isInvalid = false)
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2E466B0", Offset = "0x2E44CB0", VA = "0x182E466B0")]
		public void ShowPreviewDashedCircle3D(Vector3 center, float radius, Vector3 normal, bool onTerrain, bool reUseActive = true)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x2E46790", Offset = "0x2E44D90", VA = "0x182E46790")]
		public void HideDashedLine3D()
		{
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x2E46820", Offset = "0x2E44E20", VA = "0x182E46820")]
		public void ShowPreviewArrow(Vector3 arrowPos, Vector3 lookAtPos, ArrowTypes arrowType = ArrowTypes.Straight, bool reUseActive = true)
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x2E46940", Offset = "0x2E44F40", VA = "0x182E46940")]
		public void ShowPreviewArrow(Vector3 arrowPos, Vector3 lookAtPos, Vector3 lookAtUp, ArrowTypes arrowType = ArrowTypes.Straight, bool reUseActive = true)
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x2E46A40", Offset = "0x2E45040", VA = "0x182E46A40")]
		public void ShowPreviewArrowCentered(Vector3 arrowPos, Vector3 lookAtPos, ArrowTypes arrowType = ArrowTypes.Straight, bool reUseActive = true)
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x2E46B00", Offset = "0x2E45100", VA = "0x182E46B00")]
		public void ShowPreviewArrowCentered(Vector3 arrowPos, Vector3 lookAtPos, Vector3 lookAtUp, ArrowTypes arrowType = ArrowTypes.Straight, bool reUseActive = true)
		{
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2E46E40", Offset = "0x2E45440", VA = "0x182E46E40")]
		public void ShowPreviewArrow(Vector3 arrowPos, Quaternion arrowRot, ArrowTypes arrowType = ArrowTypes.Straight, bool reUseActive = true)
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2E46F00", Offset = "0x2E45500", VA = "0x182E46F00")]
		public void ShowPreviewArrowAnimated(Vector3 fromPos, Vector3 toPos, Quaternion fromRot, Quaternion toRot, ArrowTypes arrowType = ArrowTypes.Straight, bool reUseActive = true)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2E47010", Offset = "0x2E45610", VA = "0x182E47010")]
		public void ShowPreviewSplitArrows(Vector3 arrow1Pos, Vector3 arrow2Pos, Vector3 lookDir, Vector3 lookAtUp, SplitArrowTypes arrowType = SplitArrowTypes.Straight, bool reUseActive = true)
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x2E47130", Offset = "0x2E45730", VA = "0x182E47130")]
		public void HidePlacementArrow()
		{
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x2E47180", Offset = "0x2E45780", VA = "0x182E47180")]
		public void PlayPreviewAnimation(ClipTypes clipType, TweenTypes tweenType, Transform target)
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x2E47210", Offset = "0x2E45810", VA = "0x182E47210")]
		public void StopPreviewAnimation()
		{
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x2E47230", Offset = "0x2E45830", VA = "0x182E47230")]
		public Transform GetPreviewAnimationTarget()
		{
			return null;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x2E47370", Offset = "0x2E45970", VA = "0x182E47370")]
		public void ShowDetachedPlacement(Vector3 previewCenter, float lineWidth, float depth, Quaternion rot, bool reUseActive = true, bool onTerrain = true)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2E47460", Offset = "0x2E45A60", VA = "0x182E47460")]
		public void SetMultiSnappointTarget(Structure structure)
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x2E47480", Offset = "0x2E45A80", VA = "0x182E47480")]
		public void HideMultiSnappoint()
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2E474F0", Offset = "0x2E45AF0", VA = "0x182E474F0")]
		public void ShowBranching(IBranchingAction action, TargetInfo targetInfo, bool useBranchingLabel)
		{
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x2E47530", Offset = "0x2E45B30", VA = "0x182E47530")]
		public void ShowBranching(IBranchingAction action, StructureElement element, bool showBranchingLabel)
		{
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2E47570", Offset = "0x2E45B70", VA = "0x182E47570")]
		public void HideBranching()
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x2E47480", Offset = "0x2E45A80", VA = "0x182E47480")]
		public void IdleStateUpdate()
		{
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x2E475E0", Offset = "0x2E45BE0", VA = "0x182E475E0", Slot = "4")]
		private void OnStructureDirty(IStructure structure)
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x2E47800", Offset = "0x2E45E00", VA = "0x182E47800")]
		public void CleanupPreview()
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x2E47A60", Offset = "0x2E46060", VA = "0x182E47A60")]
		public void ClearAll(UiMessages uiMessages)
		{
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00005234 File Offset: 0x00003434
		[Token(Token = "0x17000245")]
		private bool UseOverrideUiMessage
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x2E47AC0", Offset = "0x2E460C0", VA = "0x182E47AC0")]
		private void InitUiMessageIdCache()
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x2E48890", Offset = "0x2E46E90", VA = "0x182E48890")]
		public void ToggleUI(UiMessages uiMessage)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x2E488D0", Offset = "0x2E46ED0", VA = "0x182E488D0")]
		public void ToggleUI(UiMessages uiMessage, Vector3 worldPos)
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2E48960", Offset = "0x2E46F60", VA = "0x182E48960")]
		private void ToggleUiInternal(UiMessages uiMessage)
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x2E48B70", Offset = "0x2E47170", VA = "0x182E48B70")]
		private void SetUiMessage(string id, bool onOff)
		{
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x2E48C90", Offset = "0x2E47290", VA = "0x182E48C90")]
		private void Set3DMode(bool in3D, Vector3 pos)
		{
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2E48CB0", Offset = "0x2E472B0", VA = "0x182E48CB0")]
		public void SetUiIcon(string id, ItemUiData uiData)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000524C File Offset: 0x0000344C
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2E48D60", Offset = "0x2E47360", VA = "0x182E48D60")]
		private bool TryGetUiMessage(string id, out GameObject instanceGo)
		{
			return default(bool);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2E49150", Offset = "0x2E47750", VA = "0x182E49150")]
		public PreviewManager()
		{
		}

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Preview")]
		private SnapPointPreviewManager _previewSnappoints;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PreviewAnimationManager _previewAnimation;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PreviewArrowManager _previewArrow;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PreviewDashedLine3DManager _previewDashedLine3D;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PreviewDashedLine3DManager _previewDashedLine3DInvalid;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PreviewDecalManager _previewDecal;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PreviewDecalManager _previewDecalInvalid;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private PreviewLineManager _previewDetachedPlacement;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PreviewLineManager _previewLinePlace;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private PreviewLineManager _previewLineCut;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PreviewDecalCircleManager _placeDecalCirclePreview;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PreviewSquareManager _previewSquarePlace;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private PreviewSquareManager _previewSquareCut;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PreviewSquareOnTerrainManager _previewSquareOnTerrainPlace;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private PreviewSquareOnTerrainManager _previewSquareOnTerrainPlaceInvalid;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private BranchingUIController _branchingUI;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0xA0")]
		private RawImageCarousel _itemPicker;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0xA8")]
		private PreviewManager.PreviewPool<PreviewArrowManager> _arrowPreviews;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0xB0")]
		private PreviewManager.PreviewPool<PreviewDashedLine3DManager> _dashedLine3DPreviews;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0xB8")]
		private PreviewManager.PreviewPool<PreviewDashedLine3DManager> _dashedLine3DInvalidPreviews;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0xC0")]
		private PreviewManager.PreviewPool<PreviewDecalManager> _decalPreviews;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0xC8")]
		private PreviewManager.PreviewPool<PreviewDecalManager> _decalInvalidPreviews;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0xD0")]
		private PreviewManager.PreviewPool<PreviewDecalManager> _decalPreviewsSecondary;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0xD8")]
		private PreviewManager.PreviewPool<PreviewLineManager> _detachedPlacementPreviews;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0xE0")]
		private PreviewManager.PreviewPool<PreviewLineManager> _placeLinePreviews;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0xE8")]
		private PreviewManager.PreviewPool<PreviewLineManager> _cutLinePreviews;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0xF0")]
		private PreviewManager.PreviewPool<PreviewDecalCircleManager> _placeDecalCirclePreviews;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0xF8")]
		private PreviewManager.PreviewPool<PreviewSquareManager> _placeSquarePreviews;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x100")]
		private PreviewManager.PreviewPool<PreviewSquareManager> _cutSquarePreviews;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x108")]
		private PreviewManager.PreviewPool<PreviewSquareOnTerrainManager> _placeSquareOnTerrainPreviews;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x110")]
		private PreviewManager.PreviewPool<PreviewSquareOnTerrainManager> _placeSquareOnTerrainInvalidPreviews;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x118")]
		private bool _in3D;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x11C")]
		private Vector3 _worldPos;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x128")]
		private UiMessages _lastUiMessage;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x130")]
		private readonly HashSet<UiMessages> _uiMessageIn3d;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x138")]
		private readonly Dictionary<UiMessages, string> _uiMessageIdCache;

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x140")]
		private readonly Dictionary<string, GameObject> _uiMessageCache;

		// Token: 0x040005BF RID: 1471
		[Token(Token = "0x40005BF")]
		[FieldOffset(Offset = "0x148")]
		private readonly Dictionary<UiMessageTemplates, GameObject> _uiMessageSlots;

		// Token: 0x040005C0 RID: 1472
		[Token(Token = "0x40005C0")]
		[FieldOffset(Offset = "0x150")]
		private UiMessages _activePrimaryMessage;

		// Token: 0x040005C1 RID: 1473
		[Token(Token = "0x40005C1")]
		[FieldOffset(Offset = "0x154")]
		private UiMessages _activeSecondaryMessage;

		// Token: 0x040005C2 RID: 1474
		[Token(Token = "0x40005C2")]
		[FieldOffset(Offset = "0x158")]
		private UiMessages _activeTertiaryMessage;

		// Token: 0x02000116 RID: 278
		[Token(Token = "0x2000116")]
		public class PreviewPool<T> where T : UnityEngine.Object, IPreviewManager
		{
			// Token: 0x060007AE RID: 1966 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007AE")]
			public PreviewPool(T prefab, Transform instancesParent)
			{
			}

			// Token: 0x060007AF RID: 1967 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60007AF")]
			public T GetInstance(bool reUseActive)
			{
				return null;
			}

			// Token: 0x060007B0 RID: 1968 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007B0")]
			public void PoolAllActiveInstances()
			{
			}

			// Token: 0x040005C3 RID: 1475
			[Token(Token = "0x40005C3")]
			[FieldOffset(Offset = "0x0")]
			private T _prefab;

			// Token: 0x040005C4 RID: 1476
			[Token(Token = "0x40005C4")]
			[FieldOffset(Offset = "0x0")]
			private Transform _instancesParent;

			// Token: 0x040005C5 RID: 1477
			[Token(Token = "0x40005C5")]
			[FieldOffset(Offset = "0x0")]
			private Queue<T> _placeSquarePreviewsActive;

			// Token: 0x040005C6 RID: 1478
			[Token(Token = "0x40005C6")]
			[FieldOffset(Offset = "0x0")]
			private Queue<T> _placeSquarePreviewsPooled;
		}
	}
}
