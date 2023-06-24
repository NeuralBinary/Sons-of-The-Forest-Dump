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
	// Token: 0x02000822 RID: 2082
	[Token(Token = "0x2000822")]
	[AddComponentMenu("Sons/Gameplay/Ziplines/ZipLineController")]
	public class ZipLineController : BoltEntityBehaviourWrapper<IZiplineControllerState>
	{
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06003A94 RID: 14996 RVA: 0x00011EE0 File Offset: 0x000100E0
		[Token(Token = "0x170007A0")]
		public Vector3 AnchorAPosition
		{
			[Token(Token = "0x6003A94")]
			[Address(RVA = "0x3574390", Offset = "0x3572990", VA = "0x183574390")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x00011EF8 File Offset: 0x000100F8
		[Token(Token = "0x170007A1")]
		public Vector3 AnchorBPosition
		{
			[Token(Token = "0x6003A95")]
			[Address(RVA = "0x3574470", Offset = "0x3572A70", VA = "0x183574470")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06003A96 RID: 14998 RVA: 0x00011F10 File Offset: 0x00010110
		[Token(Token = "0x170007A2")]
		public bool CanBeDismantled
		{
			[Token(Token = "0x6003A96")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A97")]
		[Address(RVA = "0x3574550", Offset = "0x3572B50", VA = "0x183574550")]
		private void Start()
		{
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A98")]
		[Address(RVA = "0x3574750", Offset = "0x3572D50", VA = "0x183574750", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A99")]
		[Address(RVA = "0x3574F00", Offset = "0x3573500", VA = "0x183574F00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9A")]
		[Address(RVA = "0x3574FB0", Offset = "0x35735B0", VA = "0x183574FB0")]
		private void UpdateCanBeDismantled()
		{
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9B")]
		[Address(RVA = "0x3575120", Offset = "0x3573720", VA = "0x183575120")]
		private void UpdateAnchorPositions()
		{
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9C")]
		[Address(RVA = "0x3575400", Offset = "0x3573A00", VA = "0x183575400")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9D")]
		[Address(RVA = "0x3575940", Offset = "0x3573F40", VA = "0x183575940")]
		private void OnDisable()
		{
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9E")]
		[Address(RVA = "0x3575960", Offset = "0x3573F60", VA = "0x183575960")]
		public void Initialize(Vector3 anchorAPosition, Vector3 anchorBPosition, bool canBeDismantled)
		{
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A9F")]
		[Address(RVA = "0x3576960", Offset = "0x3574F60", VA = "0x183576960")]
		public void InitializeTreeAnchors(WorldLocatorId anchorAWorldLocatorId, WorldLocatorId anchorBWorldLocatorId)
		{
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA0")]
		[Address(RVA = "0x3576A40", Offset = "0x3575040", VA = "0x183576A40")]
		public void ChainZipLineControllerToAnchorA(ZipLineController zipLineController)
		{
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA1")]
		[Address(RVA = "0x3576AB0", Offset = "0x35750B0", VA = "0x183576AB0")]
		public void ChainZipLineControllerToAnchorB(ZipLineController zipLineController)
		{
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x00011F28 File Offset: 0x00010128
		[Token(Token = "0x6003AA2")]
		[Address(RVA = "0x3576B20", Offset = "0x3575120", VA = "0x183576B20")]
		public Vector3 CalculateClosestPointOnRope(Vector3 otherPoint)
		{
			return default(Vector3);
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x00011F40 File Offset: 0x00010140
		[Token(Token = "0x6003AA3")]
		[Address(RVA = "0x35770E0", Offset = "0x35756E0", VA = "0x1835770E0")]
		private bool PlayerCanGrabZipLine()
		{
			return default(bool);
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA4")]
		[Address(RVA = "0x35771F0", Offset = "0x35757F0", VA = "0x1835771F0")]
		public void ConnectFromAnotherZipline(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA5")]
		[Address(RVA = "0x35775B0", Offset = "0x3575BB0", VA = "0x1835775B0")]
		private void OnActivateZipLine(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AA6")]
		[Address(RVA = "0x3578250", Offset = "0x3576850", VA = "0x183578250")]
		public void NetworkAttachItem(int itemId, Vector3 position, Vector3 direction)
		{
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA7")]
		[Address(RVA = "0x3578780", Offset = "0x3576D80", VA = "0x183578780")]
		public ZipLineAnchor GetClosestAnchor(Vector3 position)
		{
			return null;
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA8")]
		[Address(RVA = "0x3578A90", Offset = "0x3577090", VA = "0x183578A90")]
		public ZipLineAnchor GetFarthestAnchor(Vector3 position)
		{
			return null;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AA9")]
		[Address(RVA = "0x3578DA0", Offset = "0x35773A0", VA = "0x183578DA0")]
		private ZipLineAnchor GetDestinationAnchor(Vector3 position, Vector3 direction)
		{
			return null;
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x00011F58 File Offset: 0x00010158
		[Token(Token = "0x6003AAA")]
		[Address(RVA = "0x3578E40", Offset = "0x3577440", VA = "0x183578E40")]
		public bool TryAttachToAnotherZipline(ZipLineController.Hook hook)
		{
			return default(bool);
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAB")]
		[Address(RVA = "0x35791B0", Offset = "0x35777B0", VA = "0x1835791B0")]
		private void ShowUI(bool show)
		{
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAC")]
		[Address(RVA = "0x3579660", Offset = "0x3577C60", VA = "0x183579660")]
		private void OnFocused()
		{
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAD")]
		[Address(RVA = "0x3579990", Offset = "0x3577F90", VA = "0x183579990")]
		private void OnUnFocused()
		{
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAE")]
		[Address(RVA = "0x3579B20", Offset = "0x3578120", VA = "0x183579B20")]
		public void InitAnchorLinkers()
		{
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AAF")]
		[Address(RVA = "0x3579BA0", Offset = "0x35781A0", VA = "0x183579BA0")]
		private void UpdateHooks()
		{
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x00011F70 File Offset: 0x00010170
		[Token(Token = "0x6003AB0")]
		[Address(RVA = "0x357AA60", Offset = "0x3579060", VA = "0x18357AA60")]
		public Vector3 GetDownwardDirection()
		{
			return default(Vector3);
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AB1")]
		[Address(RVA = "0x357AC50", Offset = "0x3579250", VA = "0x18357AC50")]
		public ZipLineController.Hook CreateAndAttachToHook(Transform riderTransform, ZipLineAnchor destinationAnchor, float initialForce = 0f, bool repositionRider = true, bool riderIsAPlayer = true)
		{
			return null;
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AB2")]
		[Address(RVA = "0x357B990", Offset = "0x3579F90", VA = "0x18357B990")]
		public void DetachFromHook(Transform transformToDetach)
		{
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x00011F88 File Offset: 0x00010188
		[Token(Token = "0x6003AB3")]
		[Address(RVA = "0x357BDE0", Offset = "0x357A3E0", VA = "0x18357BDE0")]
		private bool CanClearGround(Vector3 targetPosition, float requiredClearance)
		{
			return default(bool);
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AB4")]
		[Address(RVA = "0x357C010", Offset = "0x357A610", VA = "0x18357C010")]
		private void CreateAndPlayAudioEventInstance(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AB5")]
		[Address(RVA = "0x357C250", Offset = "0x357A850", VA = "0x18357C250")]
		private static void OnHookDetached(ZipLineController.Hook hook)
		{
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AB6")]
		[Address(RVA = "0x357C4D0", Offset = "0x357AAD0", VA = "0x18357C4D0")]
		public ZipLineController()
		{
		}

		// Token: 0x040031DD RID: 12765
		[Token(Token = "0x40031DD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BaseColorMap;

		// Token: 0x040031DE RID: 12766
		[Token(Token = "0x40031DE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ZipLineAnchor _anchorA;

		// Token: 0x040031DF RID: 12767
		[Token(Token = "0x40031DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ZipLineAnchor _anchorB;

		// Token: 0x040031E0 RID: 12768
		[Token(Token = "0x40031E0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _canBeDismantled;

		// Token: 0x040031E1 RID: 12769
		[Token(Token = "0x40031E1")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _anchorOffsetFromImpactPoint;

		// Token: 0x040031E2 RID: 12770
		[Token(Token = "0x40031E2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _ropeLengthCentreOffsetScalar;

		// Token: 0x040031E3 RID: 12771
		[Token(Token = "0x40031E3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _rope;

		// Token: 0x040031E4 RID: 12772
		[Token(Token = "0x40031E4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _connectionPoint;

		// Token: 0x040031E5 RID: 12773
		[Token(Token = "0x40031E5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LinkUiElement _uiInteraction;

		// Token: 0x040031E6 RID: 12774
		[Token(Token = "0x40031E6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LinkUiElement _canNotAttachUiElement;

		// Token: 0x040031E7 RID: 12775
		[Token(Token = "0x40031E7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Texture _playerRiderIcon;

		// Token: 0x040031E8 RID: 12776
		[Token(Token = "0x40031E8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Texture _playerRiderIconOutline;

		// Token: 0x040031E9 RID: 12777
		[Token(Token = "0x40031E9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _shouldDaisiyChainZipline;

		// Token: 0x040031EA RID: 12778
		[Token(Token = "0x40031EA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ZipLineController _ziplineConnectionForAnchorA;

		// Token: 0x040031EB RID: 12779
		[Token(Token = "0x40031EB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ZipLineController _ziplineConnectionForAnchorB;

		// Token: 0x040031EC RID: 12780
		[Token(Token = "0x40031EC")]
		[FieldOffset(Offset = "0x98")]
		private bool _isFocused;

		// Token: 0x040031ED RID: 12781
		[Token(Token = "0x40031ED")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 _ropeCentrePoint;

		// Token: 0x040031EE RID: 12782
		[Token(Token = "0x40031EE")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 _ropeDirection;

		// Token: 0x040031EF RID: 12783
		[Token(Token = "0x40031EF")]
		[FieldOffset(Offset = "0xB4")]
		private float _ropeLength;

		// Token: 0x040031F0 RID: 12784
		[Token(Token = "0x40031F0")]
		[FieldOffset(Offset = "0xB8")]
		private Collider _ropeTrigger;

		// Token: 0x040031F1 RID: 12785
		[Token(Token = "0x40031F1")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 _ropeVector;

		// Token: 0x040031F2 RID: 12786
		[Token(Token = "0x40031F2")]
		[FieldOffset(Offset = "0xCC")]
		private bool _connectingToAnotherZipline;

		// Token: 0x040031F3 RID: 12787
		[Token(Token = "0x40031F3")]
		[FieldOffset(Offset = "0xD0")]
		private float _initialForceAtConnection;

		// Token: 0x040031F4 RID: 12788
		[Token(Token = "0x40031F4")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float _accelerationForce;

		// Token: 0x040031F5 RID: 12789
		[Token(Token = "0x40031F5")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float _maxVelocity;

		// Token: 0x040031F6 RID: 12790
		[Token(Token = "0x40031F6")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[FormerlySerializedAs("_groundClearance")]
		private float _playerGroundClearance;

		// Token: 0x040031F7 RID: 12791
		[Token(Token = "0x40031F7")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float _itemGroundClearance;

		// Token: 0x040031F8 RID: 12792
		[Token(Token = "0x40031F8")]
		[FieldOffset(Offset = "0xE4")]
		[FormerlySerializedAs("_evacuationDistanceToDestination")]
		[SerializeField]
		private float _playerEvacuationDistanceToDestination;

		// Token: 0x040031F9 RID: 12793
		[Token(Token = "0x40031F9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _itemEvacuationDistanceToDestination;

		// Token: 0x040031FA RID: 12794
		[Token(Token = "0x40031FA")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private LayerMask _collideMask;

		// Token: 0x040031FB RID: 12795
		[Token(Token = "0x40031FB")]
		[FieldOffset(Offset = "0xF0")]
		[EventRef]
		[SerializeField]
		private string _riderAttachedEvent;

		// Token: 0x040031FC RID: 12796
		[Token(Token = "0x40031FC")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[EventRef]
		private string _rideAlongLoopEvent;

		// Token: 0x040031FD RID: 12797
		[Token(Token = "0x40031FD")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<ZipLineController.Hook> _hooks;

		// Token: 0x040031FE RID: 12798
		[Token(Token = "0x40031FE")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<int> _hooksToDetach;

		// Token: 0x040031FF RID: 12799
		[Token(Token = "0x40031FF")]
		[FieldOffset(Offset = "0x110")]
		private float _maxVelocitySqr;

		// Token: 0x04003200 RID: 12800
		[Token(Token = "0x4003200")]
		[FieldOffset(Offset = "0x118")]
		private RaycastHit[] _raycastHits;

		// Token: 0x02000823 RID: 2083
		[Token(Token = "0x2000823")]
		public class Hook
		{
			// Token: 0x06003AB8 RID: 15032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AB8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Hook()
			{
			}

			// Token: 0x04003201 RID: 12801
			[Token(Token = "0x4003201")]
			[FieldOffset(Offset = "0x10")]
			public EventInstance _audioEvent;

			// Token: 0x04003202 RID: 12802
			[Token(Token = "0x4003202")]
			[FieldOffset(Offset = "0x18")]
			public ZipLineAnchor _destination;

			// Token: 0x04003203 RID: 12803
			[Token(Token = "0x4003203")]
			[FieldOffset(Offset = "0x20")]
			public Transform _hookTarget;

			// Token: 0x04003204 RID: 12804
			[Token(Token = "0x4003204")]
			[FieldOffset(Offset = "0x28")]
			public Transform _hookTransform;

			// Token: 0x04003205 RID: 12805
			[Token(Token = "0x4003205")]
			[FieldOffset(Offset = "0x30")]
			public Rigidbody _rigidbody;

			// Token: 0x04003206 RID: 12806
			[Token(Token = "0x4003206")]
			[FieldOffset(Offset = "0x38")]
			public bool _reachedDestination;

			// Token: 0x04003207 RID: 12807
			[Token(Token = "0x4003207")]
			[FieldOffset(Offset = "0x39")]
			public bool _riderIsAPlayer;

			// Token: 0x04003208 RID: 12808
			[Token(Token = "0x4003208")]
			[FieldOffset(Offset = "0x40")]
			public Action<ZipLineController.Hook> OnDetached;
		}
	}
}
