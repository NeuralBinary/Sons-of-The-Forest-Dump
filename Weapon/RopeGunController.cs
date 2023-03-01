using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.TerrainDetail;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x02000865 RID: 2149
	[Token(Token = "0x2000865")]
	[AddComponentMenu("Sons/Weapon/RopeGunController")]
	public class RopeGunController : RangedWeaponController
	{
		// Token: 0x06003980 RID: 14720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003980")]
		[Address(RVA = "0x2EDAA40", Offset = "0x2ED9A40", VA = "0x182EDAA40", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		[Token(Token = "0x6003981")]
		[Address(RVA = "0x2EDABA0", Offset = "0x2ED9BA0", VA = "0x182EDABA0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003982")]
		[Address(RVA = "0x2EDB790", Offset = "0x2EDA790", VA = "0x182EDB790", Slot = "11")]
		protected override void Start()
		{
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003983")]
		[Address(RVA = "0x2ED9C50", Offset = "0x2ED8C50", VA = "0x182ED9C50", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003984")]
		[Address(RVA = "0x2EDB6B0", Offset = "0x2EDA6B0", VA = "0x182EDB6B0", Slot = "24")]
		protected override void OnSecondaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003985")]
		[Address(RVA = "0x2ED9B70", Offset = "0x2ED8B70", VA = "0x182ED9B70")]
		private void CancelRopePlacement()
		{
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003986")]
		[Address(RVA = "0x2EDA3D0", Offset = "0x2ED93D0", VA = "0x182EDA3D0")]
		private void GenerateRope()
		{
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003987")]
		[Address(RVA = "0x2EDA360", Offset = "0x2ED9360", VA = "0x182EDA360")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003988")]
		[Address(RVA = "0x2EDB910", Offset = "0x2EDA910", VA = "0x182EDB910")]
		private void UpdateRopeClick()
		{
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003989")]
		[Address(RVA = "0x2EDBC20", Offset = "0x2EDAC20", VA = "0x182EDBC20")]
		private void UpdateRope()
		{
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x2EDA910", Offset = "0x2ED9910", VA = "0x182EDA910")]
		private void HookupZipLineLogic()
		{
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398B")]
		[Address(RVA = "0x2EDB560", Offset = "0x2EDA560", VA = "0x182EDB560", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x2EDAC50", Offset = "0x2ED9C50", VA = "0x182EDAC50")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		[Token(Token = "0x600398D")]
		[Address(RVA = "0x2EDA820", Offset = "0x2ED9820", VA = "0x182EDA820")]
		private bool HasValidTarget(Ray ray, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398E")]
		[Address(RVA = "0x2EDC0D0", Offset = "0x2EDB0D0", VA = "0x182EDC0D0")]
		public RopeGunController()
		{
		}

		// Token: 0x040030EF RID: 12527
		[Token(Token = "0x40030EF")]
		private const string RopeAnchorBlockerTag = "RopeAnchorBlocker";

		// Token: 0x040030F0 RID: 12528
		[Token(Token = "0x40030F0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorMap;

		// Token: 0x040030F1 RID: 12529
		[Token(Token = "0x40030F1")]
		[FieldOffset(Offset = "0x168")]
		[FormerlySerializedAs("_maxRange")]
		[SerializeField]
		private float _maxFiringRange;

		// Token: 0x040030F2 RID: 12530
		[Token(Token = "0x40030F2")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private LayerMask _ropeAnchorLayerMask;

		// Token: 0x040030F3 RID: 12531
		[Token(Token = "0x40030F3")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _ropeAsset;

		// Token: 0x040030F4 RID: 12532
		[Token(Token = "0x40030F4")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GameObject _ropeAnchorStartAsset;

		// Token: 0x040030F5 RID: 12533
		[Token(Token = "0x40030F5")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private GameObject _ropeAnchorEndAsset;

		// Token: 0x040030F6 RID: 12534
		[Token(Token = "0x40030F6")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GameObject _visibleBolt;

		// Token: 0x040030F7 RID: 12535
		[Token(Token = "0x40030F7")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Transform _connectedRopeAnchor;

		// Token: 0x040030F8 RID: 12536
		[Token(Token = "0x40030F8")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Color _invalidPlacementColor;

		// Token: 0x040030F9 RID: 12537
		[Token(Token = "0x40030F9")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private float _ropeThicknessMultiplier;

		// Token: 0x040030FA RID: 12538
		[Token(Token = "0x40030FA")]
		[FieldOffset(Offset = "0x1B0")]
		[EventRef]
		[SerializeField]
		private string _ropeMovingClickEvent;

		// Token: 0x040030FB RID: 12539
		[Token(Token = "0x40030FB")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private float _playerMovedThreshold;

		// Token: 0x040030FC RID: 12540
		[Token(Token = "0x40030FC")]
		[FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		private float _anchorOffsetFromImpactPoint;

		// Token: 0x040030FD RID: 12541
		[Token(Token = "0x40030FD")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private float _maxRopeLength;

		// Token: 0x040030FE RID: 12542
		[Token(Token = "0x40030FE")]
		[FieldOffset(Offset = "0x1C4")]
		private float _currentRopeLength;

		// Token: 0x040030FF RID: 12543
		[Token(Token = "0x40030FF")]
		[FieldOffset(Offset = "0x1C8")]
		private Transform _startAnchor;

		// Token: 0x04003100 RID: 12544
		[Token(Token = "0x4003100")]
		[FieldOffset(Offset = "0x1D0")]
		private Transform _endAnchor;

		// Token: 0x04003101 RID: 12545
		[Token(Token = "0x4003101")]
		[FieldOffset(Offset = "0x1D8")]
		private Transform _targetPosition;

		// Token: 0x04003102 RID: 12546
		[Token(Token = "0x4003102")]
		[FieldOffset(Offset = "0x1E0")]
		private WorldObjectLocatorHolder _targetTree;

		// Token: 0x04003103 RID: 12547
		[Token(Token = "0x4003103")]
		[FieldOffset(Offset = "0x1E8")]
		private WorldObjectLocatorHolder _anchorATree;

		// Token: 0x04003104 RID: 12548
		[Token(Token = "0x4003104")]
		[FieldOffset(Offset = "0x1F0")]
		private WorldObjectLocatorHolder _anchorBTree;

		// Token: 0x04003105 RID: 12549
		[Token(Token = "0x4003105")]
		[FieldOffset(Offset = "0x1F8")]
		private Transform _ropeInstance;

		// Token: 0x04003106 RID: 12550
		[Token(Token = "0x4003106")]
		[FieldOffset(Offset = "0x200")]
		private Material _ropeMaterial;

		// Token: 0x04003107 RID: 12551
		[Token(Token = "0x4003107")]
		[FieldOffset(Offset = "0x208")]
		private Vector2 _ropeTextureTiling;

		// Token: 0x04003108 RID: 12552
		[Token(Token = "0x4003108")]
		[FieldOffset(Offset = "0x210")]
		private Vector3 _lastPosition;

		// Token: 0x04003109 RID: 12553
		[Token(Token = "0x4003109")]
		[FieldOffset(Offset = "0x21C")]
		private bool _isValidPlacement;

		// Token: 0x0400310A RID: 12554
		[Token(Token = "0x400310A")]
		[FieldOffset(Offset = "0x21D")]
		private bool _hasValidTarget;

		// Token: 0x0400310B RID: 12555
		[Token(Token = "0x400310B")]
		[FieldOffset(Offset = "0x220")]
		private Color _originalRopeColor;

		// Token: 0x0400310C RID: 12556
		[Token(Token = "0x400310C")]
		[FieldOffset(Offset = "0x230")]
		private EventInstance _ropeMovingClickInstance;
	}
}
