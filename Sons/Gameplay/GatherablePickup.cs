using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Physics;
using TheForest.Player.Actions;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x020007A5 RID: 1957
	[Token(Token = "0x20007A5")]
	[AddComponentMenu("Sons/Pickup/GatherablePickup")]
	public class GatherablePickup : PickUp
	{
		// Token: 0x0600348F RID: 13455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600348F")]
		[Address(RVA = "0x34CC8F0", Offset = "0x34CAEF0", VA = "0x1834CC8F0", Slot = "14")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003490")]
		[Address(RVA = "0x34CC960", Offset = "0x34CAF60", VA = "0x1834CC960", Slot = "21")]
		protected override void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x0000FB58 File Offset: 0x0000DD58
		[Token(Token = "0x6003491")]
		[Address(RVA = "0x34CC970", Offset = "0x34CAF70", VA = "0x1834CC970", Slot = "16")]
		protected override bool CanPlayerGather()
		{
			return default(bool);
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x0000FB70 File Offset: 0x0000DD70
		[Token(Token = "0x6003492")]
		[Address(RVA = "0x34CCA90", Offset = "0x34CB090", VA = "0x1834CCA90", Slot = "17")]
		protected override bool IsWaitingToActivate()
		{
			return default(bool);
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003493")]
		[Address(RVA = "0x34CCB00", Offset = "0x34CB100", VA = "0x1834CCB00", Slot = "18")]
		protected override void Update()
		{
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003494")]
		[Address(RVA = "0x34CCC80", Offset = "0x34CB280", VA = "0x1834CCC80", Slot = "27")]
		protected override void Collect()
		{
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x0000FB88 File Offset: 0x0000DD88
		[Token(Token = "0x6003495")]
		[Address(RVA = "0x34CCCA0", Offset = "0x34CB2A0", VA = "0x1834CCCA0")]
		private bool RayCastBlocked()
		{
			return default(bool);
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		[Token(Token = "0x6003496")]
		[Address(RVA = "0x34CD050", Offset = "0x34CB650", VA = "0x1834CD050")]
		private bool TryGather()
		{
			return default(bool);
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003497")]
		[Address(RVA = "0x34CD2F0", Offset = "0x34CB8F0", VA = "0x1834CD2F0")]
		private void OnGatheringCompleteCallback()
		{
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003498")]
		[Address(RVA = "0x34CD4D0", Offset = "0x34CBAD0", VA = "0x1834CD4D0", Slot = "28")]
		protected override void SpawnAfterPickup(bool isDynamic = false)
		{
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003499")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		protected override void SetupLinkUi()
		{
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600349A")]
		[Address(RVA = "0x34CD6F0", Offset = "0x34CBCF0", VA = "0x1834CD6F0")]
		public GatherablePickup()
		{
		}

		// Token: 0x04002D61 RID: 11617
		[Token(Token = "0x4002D61")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private PlayerGatheringAction.LocatorSide _gatheredItemlocatorSide;

		// Token: 0x04002D62 RID: 11618
		[Token(Token = "0x4002D62")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private PlayerGatheringAction.LocatorSide _gatheringToolLocatorSide;

		// Token: 0x04002D63 RID: 11619
		[Token(Token = "0x4002D63")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _gatheringToolAnimatedPrefab;

		// Token: 0x04002D64 RID: 11620
		[Token(Token = "0x4002D64")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _gatheredItemAnimatedPrefab;

		// Token: 0x04002D65 RID: 11621
		[Token(Token = "0x4002D65")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _gatheredItemScale;

		// Token: 0x04002D66 RID: 11622
		[Token(Token = "0x4002D66")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private WaterLevelSensor _waterLevelSensor;

		// Token: 0x04002D67 RID: 11623
		[Token(Token = "0x4002D67")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private bool _gatherOnClick;

		// Token: 0x04002D68 RID: 11624
		[Token(Token = "0x4002D68")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private float _delayActivation;

		// Token: 0x04002D69 RID: 11625
		[Token(Token = "0x4002D69")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private VailActor _skinnedActor;

		// Token: 0x04002D6A RID: 11626
		[Token(Token = "0x4002D6A")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GameObject _spawnAttachedPrefab;

		// Token: 0x04002D6B RID: 11627
		[Token(Token = "0x4002D6B")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Transform[] _attachPoints;

		// Token: 0x04002D6C RID: 11628
		[Token(Token = "0x4002D6C")]
		[FieldOffset(Offset = "0x150")]
		public UnityEvent OnGatheringComplete;

		// Token: 0x04002D6D RID: 11629
		[Token(Token = "0x4002D6D")]
		[FieldOffset(Offset = "0x158")]
		private bool _secondaryHoldInputMethodIsActive;

		// Token: 0x04002D6E RID: 11630
		[Token(Token = "0x4002D6E")]
		[FieldOffset(Offset = "0x15C")]
		private float _activatedTime;
	}
}
