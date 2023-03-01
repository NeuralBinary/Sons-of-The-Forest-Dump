using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x0200047E RID: 1150
	[Token(Token = "0x200047E")]
	[AddComponentMenu("Sons/Actions/Player Gathering Action")]
	public class PlayerGatheringAction : MonoBehaviour
	{
		// Token: 0x06001D1C RID: 7452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1C")]
		[Address(RVA = "0x2CFE100", Offset = "0x2CFD100", VA = "0x182CFE100")]
		public void StartGathering(int gatheredItemId, GameObject gatheringToolAnimatedPrefab, GameObject gatheredAnimatedPrefab, float gatheredItemScale, PlayerGatheringAction.LocatorSide gatheringToolLocatorSide, PlayerGatheringAction.LocatorSide gatheredItemlocatorSide, Transform target, PlayerGatheringAction.OnGatheringComplete onGatheringCompleteCallback)
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1D")]
		[Address(RVA = "0x2CFDF20", Offset = "0x2CFCF20", VA = "0x182CFDF20")]
		private void OnItemActivated()
		{
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x2CFDAA0", Offset = "0x2CFCAA0", VA = "0x182CFDAA0")]
		private IEnumerator GatheringRoutine()
		{
			return null;
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x2CFD920", Offset = "0x2CFC920", VA = "0x182CFD920")]
		private void CreateHeldInstance(PlayerGatheringAction.LocatorSide locator, GameObject itemPrefab, float itemScale, out GameObject itemInstance, out Animator animator)
		{
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D20")]
		[Address(RVA = "0x2CFDA10", Offset = "0x2CFCA10", VA = "0x182CFDA10")]
		private void DestroyHeldInstance(GameObject itemInstance)
		{
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D21")]
		[Address(RVA = "0x2CFDB10", Offset = "0x2CFCB10", VA = "0x182CFDB10")]
		private void InitializeHeldInstance(PlayerGatheringAction.LocatorSide locatorSide, GameObject heldPrefab, float itemScale, out GameObject heldInstance, out Animator heldAnimator)
		{
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x2CFE410", Offset = "0x2CFD410", VA = "0x182CFE410")]
		private void Update()
		{
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x2CFE210", Offset = "0x2CFD210", VA = "0x182CFE210")]
		private void UpdateHeldAnimator()
		{
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D24")]
		[Address(RVA = "0x2CFE200", Offset = "0x2CFD200", VA = "0x182CFE200")]
		public void TriggerDisableItem()
		{
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D25")]
		[Address(RVA = "0x2CFDF60", Offset = "0x2CFCF60", VA = "0x182CFDF60")]
		private static void SetRigidBodyLock(bool lockValue)
		{
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x2CFE570", Offset = "0x2CFD570", VA = "0x182CFE570")]
		public PlayerGatheringAction()
		{
		}

		// Token: 0x04001B90 RID: 7056
		[Token(Token = "0x4001B90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationEventReceiver _playerAnimEventReceiver;

		// Token: 0x04001B91 RID: 7057
		[Token(Token = "0x4001B91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _rightHeldItemLocator;

		// Token: 0x04001B92 RID: 7058
		[Token(Token = "0x4001B92")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _leftHeldItemLocator;

		// Token: 0x04001B93 RID: 7059
		[Token(Token = "0x4001B93")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _offsetBackFromGatherTarget;

		// Token: 0x04001B94 RID: 7060
		[Token(Token = "0x4001B94")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _lerpTime;

		// Token: 0x04001B95 RID: 7061
		[Token(Token = "0x4001B95")]
		[FieldOffset(Offset = "0x40")]
		private PlayerGatheringAction.OnGatheringComplete _onGatheringComplete;

		// Token: 0x04001B96 RID: 7062
		[Token(Token = "0x4001B96")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _gatheredItemAnimatedPrefab;

		// Token: 0x04001B97 RID: 7063
		[Token(Token = "0x4001B97")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _gatheringToolAnimatedPrefab;

		// Token: 0x04001B98 RID: 7064
		[Token(Token = "0x4001B98")]
		[FieldOffset(Offset = "0x58")]
		private GameObject _gatheredItemInstance;

		// Token: 0x04001B99 RID: 7065
		[Token(Token = "0x4001B99")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _gatheringToolInstance;

		// Token: 0x04001B9A RID: 7066
		[Token(Token = "0x4001B9A")]
		[FieldOffset(Offset = "0x68")]
		private float _gatheredItemScale;

		// Token: 0x04001B9B RID: 7067
		[Token(Token = "0x4001B9B")]
		[FieldOffset(Offset = "0x70")]
		private Animator _gatheredItemAnimator;

		// Token: 0x04001B9C RID: 7068
		[Token(Token = "0x4001B9C")]
		[FieldOffset(Offset = "0x78")]
		private Animator _gatheringToolAnimator;

		// Token: 0x04001B9D RID: 7069
		[Token(Token = "0x4001B9D")]
		[FieldOffset(Offset = "0x80")]
		private PlayerGatheringAction.LocatorSide _gatheredItemlocatorSide;

		// Token: 0x04001B9E RID: 7070
		[Token(Token = "0x4001B9E")]
		[FieldOffset(Offset = "0x84")]
		private PlayerGatheringAction.LocatorSide _gatheringToolLocatorSide;

		// Token: 0x04001B9F RID: 7071
		[Token(Token = "0x4001B9F")]
		[FieldOffset(Offset = "0x88")]
		private ItemData _gatheredItemData;

		// Token: 0x04001BA0 RID: 7072
		[Token(Token = "0x4001BA0")]
		[FieldOffset(Offset = "0x90")]
		private bool _disableItemTriggered;

		// Token: 0x04001BA1 RID: 7073
		[Token(Token = "0x4001BA1")]
		[FieldOffset(Offset = "0x91")]
		private bool _updateAnimators;

		// Token: 0x04001BA2 RID: 7074
		[Token(Token = "0x4001BA2")]
		[FieldOffset(Offset = "0x98")]
		private Transform _gatherableTransform;

		// Token: 0x04001BA3 RID: 7075
		[Token(Token = "0x4001BA3")]
		[FieldOffset(Offset = "0xA0")]
		protected readonly ILayerBehaviourActivator[] FullBodyDisableSpineActivators;

		// Token: 0x0200047F RID: 1151
		// (Invoke) Token: 0x06001D28 RID: 7464
		[Token(Token = "0x200047F")]
		public delegate void OnGatheringComplete();

		// Token: 0x02000480 RID: 1152
		[Token(Token = "0x2000480")]
		public enum LocatorSide
		{
			// Token: 0x04001BA5 RID: 7077
			[Token(Token = "0x4001BA5")]
			Right,
			// Token: 0x04001BA6 RID: 7078
			[Token(Token = "0x4001BA6")]
			Left
		}
	}
}
