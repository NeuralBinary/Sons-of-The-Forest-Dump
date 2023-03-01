using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Physics;
using TheForest.Player.Actions;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x02000683 RID: 1667
	[Token(Token = "0x2000683")]
	[AddComponentMenu("Sons/Pickup/GatherablePickup")]
	public class GatherablePickup : PickUp
	{
		// Token: 0x06002A83 RID: 10883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x2DCD1A0", Offset = "0x2DCC1A0", VA = "0x182DCD1A0", Slot = "12")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A84")]
		[Address(RVA = "0x2DCD290", Offset = "0x2DCC290", VA = "0x182DCD290", Slot = "19")]
		protected override void OnSecondaryHoldInputMethodActive()
		{
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		[Token(Token = "0x6002A85")]
		[Address(RVA = "0x2DCD070", Offset = "0x2DCC070", VA = "0x182DCD070", Slot = "14")]
		protected override bool CanPlayerGather()
		{
			return default(bool);
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		[Token(Token = "0x6002A86")]
		[Address(RVA = "0x2DCD170", Offset = "0x2DCC170", VA = "0x182DCD170", Slot = "15")]
		protected override bool IsWaitingToActivate()
		{
			return default(bool);
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x2DCD740", Offset = "0x2DCC740", VA = "0x182DCD740", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x2DCD150", Offset = "0x2DCC150", VA = "0x182DCD150", Slot = "25")]
		protected override void Collect()
		{
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x0000C408 File Offset: 0x0000A608
		[Token(Token = "0x6002A89")]
		[Address(RVA = "0x2DCD580", Offset = "0x2DCC580", VA = "0x182DCD580")]
		private bool TryGather()
		{
			return default(bool);
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x2DCD1E0", Offset = "0x2DCC1E0", VA = "0x182DCD1E0")]
		private void OnGatheringCompleteCallback()
		{
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8B")]
		[Address(RVA = "0x2DCD2A0", Offset = "0x2DCC2A0", VA = "0x182DCD2A0", Slot = "26")]
		protected override void SpawnAfterPickup()
		{
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "13")]
		protected override void SetupLinkUi()
		{
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x2DCD820", Offset = "0x2DCC820", VA = "0x182DCD820")]
		public GatherablePickup()
		{
		}

		// Token: 0x04002600 RID: 9728
		[Token(Token = "0x4002600")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private PlayerGatheringAction.LocatorSide _gatheredItemlocatorSide;

		// Token: 0x04002601 RID: 9729
		[Token(Token = "0x4002601")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private PlayerGatheringAction.LocatorSide _gatheringToolLocatorSide;

		// Token: 0x04002602 RID: 9730
		[Token(Token = "0x4002602")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _gatheringToolAnimatedPrefab;

		// Token: 0x04002603 RID: 9731
		[Token(Token = "0x4002603")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _gatheredItemAnimatedPrefab;

		// Token: 0x04002604 RID: 9732
		[Token(Token = "0x4002604")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float _gatheredItemScale;

		// Token: 0x04002605 RID: 9733
		[Token(Token = "0x4002605")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private WaterLevelSensor _waterLevelSensor;

		// Token: 0x04002606 RID: 9734
		[Token(Token = "0x4002606")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _gatherOnClick;

		// Token: 0x04002607 RID: 9735
		[Token(Token = "0x4002607")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private float _delayActivation;

		// Token: 0x04002608 RID: 9736
		[Token(Token = "0x4002608")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private VailActor _skinnedActor;

		// Token: 0x04002609 RID: 9737
		[Token(Token = "0x4002609")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _spawnAttachedPrefab;

		// Token: 0x0400260A RID: 9738
		[Token(Token = "0x400260A")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Transform[] _attachPoints;

		// Token: 0x0400260B RID: 9739
		[Token(Token = "0x400260B")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent OnGatheringComplete;

		// Token: 0x0400260C RID: 9740
		[Token(Token = "0x400260C")]
		[FieldOffset(Offset = "0x148")]
		private bool _secondaryHoldInputMethodIsActive;

		// Token: 0x0400260D RID: 9741
		[Token(Token = "0x400260D")]
		[FieldOffset(Offset = "0x14C")]
		private float _activatedTime;
	}
}
