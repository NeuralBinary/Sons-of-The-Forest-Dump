using System;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Inventory;
using Sons.TerrainDetail;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Weapon
{
	// Token: 0x020008D5 RID: 2261
	[Token(Token = "0x20008D5")]
	[AddComponentMenu("Sons/Weapon/RopeGunController")]
	public class RopeGunController : RangedWeaponController
	{
		// Token: 0x060040A3 RID: 16547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A3")]
		[Address(RVA = "0x3600E10", Offset = "0x35FF410", VA = "0x183600E10", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x00013C20 File Offset: 0x00011E20
		[Token(Token = "0x60040A4")]
		[Address(RVA = "0x3601190", Offset = "0x35FF790", VA = "0x183601190", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A5")]
		[Address(RVA = "0x3601230", Offset = "0x35FF830", VA = "0x183601230", Slot = "11")]
		protected override void Start()
		{
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A6")]
		[Address(RVA = "0x36015C0", Offset = "0x35FFBC0", VA = "0x1836015C0", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A7")]
		[Address(RVA = "0x3601E30", Offset = "0x3600430", VA = "0x183601E30", Slot = "25")]
		protected override void OnSecondaryAction(InputAction.CallbackContext context)
		{
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x3601FB0", Offset = "0x36005B0", VA = "0x183601FB0")]
		private void CancelRopePlacement()
		{
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x3602170", Offset = "0x3600770", VA = "0x183602170")]
		private void GenerateRope()
		{
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AA")]
		[Address(RVA = "0x3602890", Offset = "0x3600E90", VA = "0x183602890")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AB")]
		[Address(RVA = "0x3602960", Offset = "0x3600F60", VA = "0x183602960")]
		private void UpdateRopeClick()
		{
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AC")]
		[Address(RVA = "0x3602DA0", Offset = "0x36013A0", VA = "0x183602DA0")]
		private void UpdateRope()
		{
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x36034A0", Offset = "0x3601AA0", VA = "0x1836034A0")]
		private void HookupZipLineLogic()
		{
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x3603750", Offset = "0x3601D50", VA = "0x183603750", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x36038D0", Offset = "0x3601ED0", VA = "0x1836038D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x00013C38 File Offset: 0x00011E38
		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x3604670", Offset = "0x3602C70", VA = "0x183604670")]
		private bool HasValidTarget(Ray ray, out RaycastHit hitInfo)
		{
			return default(bool);
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x3604820", Offset = "0x3602E20", VA = "0x183604820")]
		public RopeGunController()
		{
		}

		// Token: 0x040035B8 RID: 13752
		[Token(Token = "0x40035B8")]
		private const string RopeAnchorBlockerTag = "RopeAnchorBlocker";

		// Token: 0x040035B9 RID: 13753
		[Token(Token = "0x40035B9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorMap;

		// Token: 0x040035BA RID: 13754
		[Token(Token = "0x40035BA")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[FormerlySerializedAs("_maxRange")]
		private float _maxFiringRange;

		// Token: 0x040035BB RID: 13755
		[Token(Token = "0x40035BB")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private LayerMask _ropeAnchorLayerMask;

		// Token: 0x040035BC RID: 13756
		[Token(Token = "0x40035BC")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private GameObject _ropeAsset;

		// Token: 0x040035BD RID: 13757
		[Token(Token = "0x40035BD")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GameObject _ropeAnchorStartAsset;

		// Token: 0x040035BE RID: 13758
		[Token(Token = "0x40035BE")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private GameObject _ropeAnchorEndAsset;

		// Token: 0x040035BF RID: 13759
		[Token(Token = "0x40035BF")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GameObject _visibleBolt;

		// Token: 0x040035C0 RID: 13760
		[Token(Token = "0x40035C0")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Transform _connectedRopeAnchor;

		// Token: 0x040035C1 RID: 13761
		[Token(Token = "0x40035C1")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Color _invalidPlacementColor;

		// Token: 0x040035C2 RID: 13762
		[Token(Token = "0x40035C2")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private float _ropeThicknessMultiplier;

		// Token: 0x040035C3 RID: 13763
		[Token(Token = "0x40035C3")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[EventRef]
		private string _ropeMovingClickEvent;

		// Token: 0x040035C4 RID: 13764
		[Token(Token = "0x40035C4")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private float _playerMovedThreshold;

		// Token: 0x040035C5 RID: 13765
		[Token(Token = "0x40035C5")]
		[FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		private float _anchorOffsetFromImpactPoint;

		// Token: 0x040035C6 RID: 13766
		[Token(Token = "0x40035C6")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private float _maxRopeLength;

		// Token: 0x040035C7 RID: 13767
		[Token(Token = "0x40035C7")]
		[FieldOffset(Offset = "0x1C4")]
		private float _currentRopeLength;

		// Token: 0x040035C8 RID: 13768
		[Token(Token = "0x40035C8")]
		[FieldOffset(Offset = "0x1C8")]
		private Transform _startAnchor;

		// Token: 0x040035C9 RID: 13769
		[Token(Token = "0x40035C9")]
		[FieldOffset(Offset = "0x1D0")]
		private Transform _endAnchor;

		// Token: 0x040035CA RID: 13770
		[Token(Token = "0x40035CA")]
		[FieldOffset(Offset = "0x1D8")]
		private Transform _targetPosition;

		// Token: 0x040035CB RID: 13771
		[Token(Token = "0x40035CB")]
		[FieldOffset(Offset = "0x1E0")]
		private WorldObjectLocatorHolder _worldObjectTarget;

		// Token: 0x040035CC RID: 13772
		[Token(Token = "0x40035CC")]
		[FieldOffset(Offset = "0x1E8")]
		private WorldObjectLocatorHolder _anchorAWordObject;

		// Token: 0x040035CD RID: 13773
		[Token(Token = "0x40035CD")]
		[FieldOffset(Offset = "0x1F0")]
		private WorldObjectLocatorHolder _anchorBWorldObject;

		// Token: 0x040035CE RID: 13774
		[Token(Token = "0x40035CE")]
		[FieldOffset(Offset = "0x1F8")]
		private Transform _ropeInstance;

		// Token: 0x040035CF RID: 13775
		[Token(Token = "0x40035CF")]
		[FieldOffset(Offset = "0x200")]
		private Material _ropeMaterial;

		// Token: 0x040035D0 RID: 13776
		[Token(Token = "0x40035D0")]
		[FieldOffset(Offset = "0x208")]
		private Vector2 _ropeTextureTiling;

		// Token: 0x040035D1 RID: 13777
		[Token(Token = "0x40035D1")]
		[FieldOffset(Offset = "0x210")]
		private Vector3 _lastPosition;

		// Token: 0x040035D2 RID: 13778
		[Token(Token = "0x40035D2")]
		[FieldOffset(Offset = "0x21C")]
		private bool _isValidPlacement;

		// Token: 0x040035D3 RID: 13779
		[Token(Token = "0x40035D3")]
		[FieldOffset(Offset = "0x21D")]
		private bool _hasValidTarget;

		// Token: 0x040035D4 RID: 13780
		[Token(Token = "0x40035D4")]
		[FieldOffset(Offset = "0x220")]
		private Color _originalRopeColor;

		// Token: 0x040035D5 RID: 13781
		[Token(Token = "0x40035D5")]
		[FieldOffset(Offset = "0x230")]
		private EventInstance _ropeMovingClickInstance;
	}
}
