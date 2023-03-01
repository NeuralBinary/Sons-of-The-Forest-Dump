using System;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Gui.Input;
using Sons.Multiplayer;
using Sons.TerrainDetail;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Gameplay.ZipLines
{
	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x20006D6")]
	[AddComponentMenu("Sons/Gameplay/Ziplines/ZipLineController")]
	public class ZipLineController : BoltEntityBehaviourWrapper<IZiplineControllerState>
	{
		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x1700059D")]
		public Vector3 AnchorAPosition
		{
			[Token(Token = "0x6002CB1")]
			[Address(RVA = "0x2E02A10", Offset = "0x2E01A10", VA = "0x182E02A10")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[Token(Token = "0x1700059E")]
		public Vector3 AnchorBPosition
		{
			[Token(Token = "0x6002CB2")]
			[Address(RVA = "0x2E02A60", Offset = "0x2E01A60", VA = "0x182E02A60")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[Token(Token = "0x1700059F")]
		public bool CanBeDismantled
		{
			[Token(Token = "0x6002CB3")]
			[Address(RVA = "0x5F2450", Offset = "0x5F1450", VA = "0x1805F2450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB4")]
		[Address(RVA = "0x2E01A90", Offset = "0x2E00A90", VA = "0x182E01A90")]
		private void Start()
		{
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB5")]
		[Address(RVA = "0x2DFD4B0", Offset = "0x2DFC4B0", VA = "0x182DFD4B0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB6")]
		[Address(RVA = "0x2E00E30", Offset = "0x2DFFE30", VA = "0x182E00E30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB7")]
		[Address(RVA = "0x2E01F20", Offset = "0x2E00F20", VA = "0x182E01F20")]
		private void UpdateCanBeDismantled()
		{
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB8")]
		[Address(RVA = "0x2E01D00", Offset = "0x2E00D00", VA = "0x182E01D00")]
		private void UpdateAnchorPositions()
		{
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB9")]
		[Address(RVA = "0x2DFFCE0", Offset = "0x2DFECE0", VA = "0x182DFFCE0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBA")]
		[Address(RVA = "0x2E011A0", Offset = "0x2E001A0", VA = "0x182E011A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBB")]
		[Address(RVA = "0x2DFF2F0", Offset = "0x2DFE2F0", VA = "0x182DFF2F0")]
		public void Initialize(Vector3 anchorAPosition, Vector3 anchorBPosition, bool canBeDismantled)
		{
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBC")]
		[Address(RVA = "0x2DFF1F0", Offset = "0x2DFE1F0", VA = "0x182DFF1F0")]
		public void InitializeTreeAnchors(WorldLocatorId anchorATreeId, WorldLocatorId anchorBTreeId)
		{
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBD")]
		[Address(RVA = "0x2DFDF00", Offset = "0x2DFCF00", VA = "0x182DFDF00")]
		public void ChainZipLineControllerToAnchorA(ZipLineController zipLineController)
		{
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBE")]
		[Address(RVA = "0x2DFDF20", Offset = "0x2DFCF20", VA = "0x182DFDF20")]
		public void ChainZipLineControllerToAnchorB(ZipLineController zipLineController)
		{
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x6002CBF")]
		[Address(RVA = "0x2DFD940", Offset = "0x2DFC940", VA = "0x182DFD940")]
		public Vector3 CalculateClosestPointOnRope(Vector3 otherPoint)
		{
			return default(Vector3);
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x6002CC0")]
		[Address(RVA = "0x2E017A0", Offset = "0x2E007A0", VA = "0x182E017A0")]
		private bool PlayerCanGrabZipLine()
		{
			return default(bool);
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC1")]
		[Address(RVA = "0x2DFDF40", Offset = "0x2DFCF40", VA = "0x182DFDF40")]
		public void ConnectFromAnotherZipline(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC2")]
		[Address(RVA = "0x2E00470", Offset = "0x2DFF470", VA = "0x182E00470")]
		private void OnActivateZipLine(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC3")]
		[Address(RVA = "0x2E00010", Offset = "0x2DFF010", VA = "0x182E00010")]
		public void NetworkAttachItem(int itemId, Vector3 position, Vector3 direction)
		{
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC4")]
		[Address(RVA = "0x2DFEBC0", Offset = "0x2DFDBC0", VA = "0x182DFEBC0")]
		public ZipLineAnchor GetClosestAnchor(Vector3 position)
		{
			return null;
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC5")]
		[Address(RVA = "0x2DFEF70", Offset = "0x2DFDF70", VA = "0x182DFEF70")]
		public ZipLineAnchor GetFarthestAnchor(Vector3 position)
		{
			return null;
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x2DFEDE0", Offset = "0x2DFDDE0", VA = "0x182DFEDE0")]
		private ZipLineAnchor GetDestinationAnchor(Vector3 position, Vector3 direction)
		{
			return null;
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x2E01B90", Offset = "0x2E00B90", VA = "0x182E01B90")]
		public bool TryAttachToAnotherZipline(ZipLineController.Hook hook)
		{
			return default(bool);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x2E018C0", Offset = "0x2E008C0", VA = "0x182E018C0")]
		private void ShowUI(bool show)
		{
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CC9")]
		[Address(RVA = "0x2E01210", Offset = "0x2E00210", VA = "0x182E01210")]
		private void OnFocused()
		{
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCA")]
		[Address(RVA = "0x2E01630", Offset = "0x2E00630", VA = "0x182E01630")]
		private void OnUnFocused()
		{
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x2DFF190", Offset = "0x2DFE190", VA = "0x182DFF190")]
		public void InitAnchorLinkers()
		{
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCC")]
		[Address(RVA = "0x2E01FD0", Offset = "0x2E00FD0", VA = "0x182E01FD0")]
		private void UpdateHooks()
		{
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x2DFEE80", Offset = "0x2DFDE80", VA = "0x182DFEE80")]
		public Vector3 GetDownwardDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x2DFE1A0", Offset = "0x2DFD1A0", VA = "0x182DFE1A0")]
		public ZipLineController.Hook CreateAndAttachToHook(Transform riderTransform, ZipLineAnchor destinationAnchor, float initialForce = 0f, bool repositionRider = true, bool riderIsAPlayer = true)
		{
			return null;
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CCF")]
		[Address(RVA = "0x2DFE8E0", Offset = "0x2DFD8E0", VA = "0x182DFE8E0")]
		public void DetachFromHook(Transform transformToDetach)
		{
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x0000CD38 File Offset: 0x0000AF38
		[Token(Token = "0x6002CD0")]
		[Address(RVA = "0x2DFDD40", Offset = "0x2DFCD40", VA = "0x182DFDD40")]
		private bool CanClearGround(Vector3 targetPosition, float requiredClearance)
		{
			return default(bool);
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD1")]
		[Address(RVA = "0x2DFE750", Offset = "0x2DFD750", VA = "0x182DFE750")]
		private void CreateAndPlayAudioEventInstance(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD2")]
		[Address(RVA = "0x2E01510", Offset = "0x2E00510", VA = "0x182E01510")]
		private static void OnHookDetached(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CD3")]
		[Address(RVA = "0x2E028F0", Offset = "0x2E018F0", VA = "0x182E028F0")]
		public ZipLineController()
		{
		}

		// Token: 0x040027FF RID: 10239
		[Token(Token = "0x40027FF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorMap;

		// Token: 0x04002800 RID: 10240
		[Token(Token = "0x4002800")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ZipLineAnchor _anchorA;

		// Token: 0x04002801 RID: 10241
		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ZipLineAnchor _anchorB;

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _canBeDismantled;

		// Token: 0x04002803 RID: 10243
		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _anchorOffsetFromImpactPoint;

		// Token: 0x04002804 RID: 10244
		[Token(Token = "0x4002804")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _ropeLengthCentreOffsetScalar;

		// Token: 0x04002805 RID: 10245
		[Token(Token = "0x4002805")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _rope;

		// Token: 0x04002806 RID: 10246
		[Token(Token = "0x4002806")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _connectionPoint;

		// Token: 0x04002807 RID: 10247
		[Token(Token = "0x4002807")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LinkUiElement _uiInteraction;

		// Token: 0x04002808 RID: 10248
		[Token(Token = "0x4002808")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LinkUiElement _canNotAttachUiElement;

		// Token: 0x04002809 RID: 10249
		[Token(Token = "0x4002809")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Texture _playerRiderIcon;

		// Token: 0x0400280A RID: 10250
		[Token(Token = "0x400280A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Texture _playerRiderIconOutline;

		// Token: 0x0400280B RID: 10251
		[Token(Token = "0x400280B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Texture _logRiderIcon;

		// Token: 0x0400280C RID: 10252
		[Token(Token = "0x400280C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Texture _logRiderIconOutline;

		// Token: 0x0400280D RID: 10253
		[Token(Token = "0x400280D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _shouldDaisiyChainZipline;

		// Token: 0x0400280E RID: 10254
		[Token(Token = "0x400280E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ZipLineController _ziplineConnectionForAnchorA;

		// Token: 0x0400280F RID: 10255
		[Token(Token = "0x400280F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ZipLineController _ziplineConnectionForAnchorB;

		// Token: 0x04002810 RID: 10256
		[Token(Token = "0x4002810")]
		[FieldOffset(Offset = "0xA8")]
		private bool _isFocused;

		// Token: 0x04002811 RID: 10257
		[Token(Token = "0x4002811")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 _ropeCentrePoint;

		// Token: 0x04002812 RID: 10258
		[Token(Token = "0x4002812")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 _ropeDirection;

		// Token: 0x04002813 RID: 10259
		[Token(Token = "0x4002813")]
		[FieldOffset(Offset = "0xC4")]
		private float _ropeLength;

		// Token: 0x04002814 RID: 10260
		[Token(Token = "0x4002814")]
		[FieldOffset(Offset = "0xC8")]
		private Collider _ropeTrigger;

		// Token: 0x04002815 RID: 10261
		[Token(Token = "0x4002815")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 _ropeVector;

		// Token: 0x04002816 RID: 10262
		[Token(Token = "0x4002816")]
		[FieldOffset(Offset = "0xDC")]
		private bool _connectingToAnotherZipline;

		// Token: 0x04002817 RID: 10263
		[Token(Token = "0x4002817")]
		[FieldOffset(Offset = "0xE0")]
		private float _initialForceAtConnection;

		// Token: 0x04002818 RID: 10264
		[Token(Token = "0x4002818")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private float _accelerationForce;

		// Token: 0x04002819 RID: 10265
		[Token(Token = "0x4002819")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _maxVelocity;

		// Token: 0x0400281A RID: 10266
		[Token(Token = "0x400281A")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[FormerlySerializedAs("_groundClearance")]
		private float _playerGroundClearance;

		// Token: 0x0400281B RID: 10267
		[Token(Token = "0x400281B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _itemGroundClearance;

		// Token: 0x0400281C RID: 10268
		[Token(Token = "0x400281C")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[FormerlySerializedAs("_evacuationDistanceToDestination")]
		private float _playerEvacuationDistanceToDestination;

		// Token: 0x0400281D RID: 10269
		[Token(Token = "0x400281D")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private float _itemEvacuationDistanceToDestination;

		// Token: 0x0400281E RID: 10270
		[Token(Token = "0x400281E")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private LayerMask _collideMask;

		// Token: 0x0400281F RID: 10271
		[Token(Token = "0x400281F")]
		[FieldOffset(Offset = "0x100")]
		[EventRef]
		[SerializeField]
		private string _riderAttachedEvent;

		// Token: 0x04002820 RID: 10272
		[Token(Token = "0x4002820")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[EventRef]
		private string _rideAlongLoopEvent;

		// Token: 0x04002821 RID: 10273
		[Token(Token = "0x4002821")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<ZipLineController.Hook> _hooks;

		// Token: 0x04002822 RID: 10274
		[Token(Token = "0x4002822")]
		[FieldOffset(Offset = "0x118")]
		private readonly List<int> _hooksToDetach;

		// Token: 0x04002823 RID: 10275
		[Token(Token = "0x4002823")]
		[FieldOffset(Offset = "0x120")]
		private float _maxVelocitySqr;

		// Token: 0x04002824 RID: 10276
		[Token(Token = "0x4002824")]
		[FieldOffset(Offset = "0x128")]
		private RaycastHit[] _raycastHits;

		// Token: 0x020006D7 RID: 1751
		[Token(Token = "0x20006D7")]
		public class Hook
		{
			// Token: 0x06002CD5 RID: 11477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002CD5")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public Hook()
			{
			}

			// Token: 0x04002825 RID: 10277
			[Token(Token = "0x4002825")]
			[FieldOffset(Offset = "0x10")]
			public EventInstance _audioEvent;

			// Token: 0x04002826 RID: 10278
			[Token(Token = "0x4002826")]
			[FieldOffset(Offset = "0x18")]
			public ZipLineAnchor _destination;

			// Token: 0x04002827 RID: 10279
			[Token(Token = "0x4002827")]
			[FieldOffset(Offset = "0x20")]
			public Transform _hookTarget;

			// Token: 0x04002828 RID: 10280
			[Token(Token = "0x4002828")]
			[FieldOffset(Offset = "0x28")]
			public Transform _hookTransform;

			// Token: 0x04002829 RID: 10281
			[Token(Token = "0x4002829")]
			[FieldOffset(Offset = "0x30")]
			public Rigidbody _rigidbody;

			// Token: 0x0400282A RID: 10282
			[Token(Token = "0x400282A")]
			[FieldOffset(Offset = "0x38")]
			public bool _reachedDestination;

			// Token: 0x0400282B RID: 10283
			[Token(Token = "0x400282B")]
			[FieldOffset(Offset = "0x39")]
			public bool _riderIsAPlayer;

			// Token: 0x0400282C RID: 10284
			[Token(Token = "0x400282C")]
			[FieldOffset(Offset = "0x40")]
			public Action<ZipLineController.Hook> OnDetached;
		}
	}
}
