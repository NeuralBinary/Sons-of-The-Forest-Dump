using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using Sons.Cutscenes;
using Sons.Gameplay;
using Sons.Loading;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x0200094F RID: 2383
	[Token(Token = "0x200094F")]
	[AddComponentMenu("Sons/Animation/GetToTheChopperCutscene")]
	public class GetToTheChopperCutscene : EndGameCutscene
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060044F1 RID: 17649 RVA: 0x00015048 File Offset: 0x00013248
		[Token(Token = "0x170008F0")]
		public override bool HandlePlayerAnimationMoveEvents
		{
			[Token(Token = "0x60044F1")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x00015060 File Offset: 0x00013260
		[Token(Token = "0x170008F1")]
		public override int PlayerCutsceneStartHash
		{
			[Token(Token = "0x60044F2")]
			[Address(RVA = "0x365B950", Offset = "0x3659F50", VA = "0x18365B950", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x00015078 File Offset: 0x00013278
		[Token(Token = "0x170008F2")]
		public override int TrackedAnimatorCutsceneStateHash
		{
			[Token(Token = "0x60044F3")]
			[Address(RVA = "0x365B9B0", Offset = "0x3659FB0", VA = "0x18365B9B0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0x365BA10", Offset = "0x365A010", VA = "0x18365BA10", Slot = "27")]
		internal override void UpdateHook()
		{
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x365BAA0", Offset = "0x365A0A0", VA = "0x18365BAA0")]
		private void DisableLookAts()
		{
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x365BB60", Offset = "0x365A160", VA = "0x18365BB60")]
		private void EnableLookAts(Transform lookAtTr)
		{
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F7")]
		[Address(RVA = "0x365BDB0", Offset = "0x365A3B0", VA = "0x18365BDB0")]
		private IEnumerator LerpWeights()
		{
			return null;
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F8")]
		[Address(RVA = "0x365BE40", Offset = "0x365A440", VA = "0x18365BE40")]
		private void InitLookAts()
		{
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00015090 File Offset: 0x00013290
		[Token(Token = "0x60044F9")]
		[Address(RVA = "0x365BF40", Offset = "0x365A540", VA = "0x18365BF40", Slot = "9")]
		public override bool Play()
		{
			return default(bool);
		}

		// Token: 0x060044FA RID: 17658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FA")]
		[Address(RVA = "0x365C0D0", Offset = "0x365A6D0", VA = "0x18365C0D0", Slot = "32")]
		internal override void CutsceneEnded(CutsceneState result)
		{
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x365C100", Offset = "0x365A700", VA = "0x18365C100")]
		private void ShowContinuePrompt()
		{
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FC")]
		[Address(RVA = "0x365C5C0", Offset = "0x365ABC0", VA = "0x18365C5C0")]
		private void EnableContinueColliders(bool value)
		{
		}

		// Token: 0x060044FD RID: 17661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FD")]
		[Address(RVA = "0x365C7B0", Offset = "0x365ADB0", VA = "0x18365C7B0")]
		public void SelectLeaveIsland()
		{
		}

		// Token: 0x060044FE RID: 17662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FE")]
		[Address(RVA = "0x365CA40", Offset = "0x365B040", VA = "0x18365CA40")]
		public void SelectContinue()
		{
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044FF")]
		[Address(RVA = "0x365CCD0", Offset = "0x365B2D0", VA = "0x18365CCD0")]
		private void SelectContinue(PickUp pickUp)
		{
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x365CCE0", Offset = "0x365B2E0", VA = "0x18365CCE0")]
		private void DisableTriggers()
		{
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004501")]
		[Address(RVA = "0x365D000", Offset = "0x365B600", VA = "0x18365D000")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004502")]
		[Address(RVA = "0x365D080", Offset = "0x365B680", VA = "0x18365D080")]
		public GetToTheChopperCutscene()
		{
		}

		// Token: 0x040047A0 RID: 18336
		[Token(Token = "0x40047A0")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		protected LayerMask _triggerLayerMask;

		// Token: 0x040047A1 RID: 18337
		[Token(Token = "0x40047A1")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GameObject _blackScreenCutGroup;

		// Token: 0x040047A2 RID: 18338
		[Token(Token = "0x40047A2")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private LoadScene _loadScene;

		// Token: 0x040047A3 RID: 18339
		[Token(Token = "0x40047A3")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[FormerlySerializedAs("_nextCutscene")]
		private ChopperExitCutscene _chopperExitCutscene;

		// Token: 0x040047A4 RID: 18340
		[Token(Token = "0x40047A4")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private ChopperGroupLeaveIsland _chopperGroupLeaveIslandCutscene;

		// Token: 0x040047A5 RID: 18341
		[Token(Token = "0x40047A5")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private GenericInteraction _escapeTrigger;

		// Token: 0x040047A6 RID: 18342
		[Token(Token = "0x40047A6")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private DroppedInventoryItemsPickup _droppedInventoryItemsPickup;

		// Token: 0x040047A7 RID: 18343
		[Token(Token = "0x40047A7")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private GameObject _droppedInventoryRoot;

		// Token: 0x040047A8 RID: 18344
		[Token(Token = "0x40047A8")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private List<Collider> _continueTriggerColliders;

		// Token: 0x040047A9 RID: 18345
		[Token(Token = "0x40047A9")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private LookAtIK _timmyLookAt;

		// Token: 0x040047AA RID: 18346
		[Token(Token = "0x40047AA")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private LookAtIK _timmysDadLookAt;

		// Token: 0x040047AB RID: 18347
		[Token(Token = "0x40047AB")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private float _blackScreenHoldDelay;

		// Token: 0x040047AC RID: 18348
		[Token(Token = "0x40047AC")]
		[FieldOffset(Offset = "0x1DC")]
		private float _startTime;

		// Token: 0x040047AD RID: 18349
		[Token(Token = "0x40047AD")]
		[FieldOffset(Offset = "0x1E0")]
		private bool _disabledInitialBlackScreen;
	}
}
