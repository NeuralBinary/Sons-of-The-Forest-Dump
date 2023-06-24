using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Items.Core;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000470 RID: 1136
	[Token(Token = "0x2000470")]
	[AddComponentMenu("Sons/Actions/Player Gathering Action")]
	public class PlayerGatheringAction : MonoBehaviour
	{
		// Token: 0x06001D5D RID: 7517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0x32D6F60", Offset = "0x32D5560", VA = "0x1832D6F60")]
		public void StartGathering(int gatheredItemId, GameObject gatheringToolAnimatedPrefab, GameObject gatheredAnimatedPrefab, float gatheredItemScale, PlayerGatheringAction.LocatorSide gatheringToolLocatorSide, PlayerGatheringAction.LocatorSide gatheredItemlocatorSide, Transform target, PlayerGatheringAction.OnGatheringComplete onGatheringCompleteCallback)
		{
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5E")]
		[Address(RVA = "0x32D7200", Offset = "0x32D5800", VA = "0x1832D7200")]
		private void OnItemActivated()
		{
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D5F")]
		[Address(RVA = "0x32D7240", Offset = "0x32D5840", VA = "0x1832D7240")]
		private IEnumerator GatheringRoutine()
		{
			return null;
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D60")]
		[Address(RVA = "0x32D72D0", Offset = "0x32D58D0", VA = "0x1832D72D0")]
		private void ClearPlayerState()
		{
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x32D78D0", Offset = "0x32D5ED0", VA = "0x1832D78D0")]
		private void CreateHeldInstance(PlayerGatheringAction.LocatorSide locator, GameObject itemPrefab, float itemScale, out GameObject itemInstance, out Animator animator)
		{
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x32D7AB0", Offset = "0x32D60B0", VA = "0x1832D7AB0")]
		private void DestroyHeldInstance(GameObject itemInstance)
		{
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D63")]
		[Address(RVA = "0x32D7BD0", Offset = "0x32D61D0", VA = "0x1832D7BD0")]
		private void InitializeHeldInstance(PlayerGatheringAction.LocatorSide locatorSide, GameObject heldPrefab, float itemScale, out GameObject heldInstance, out Animator heldAnimator)
		{
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D64")]
		[Address(RVA = "0x32D8350", Offset = "0x32D6950", VA = "0x1832D8350")]
		private void Update()
		{
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x32D85A0", Offset = "0x32D6BA0", VA = "0x1832D85A0")]
		private void UpdateHeldAnimator()
		{
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x2D1F140", Offset = "0x2D1D740", VA = "0x182D1F140")]
		public void TriggerDisableItem()
		{
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x32D8790", Offset = "0x32D6D90", VA = "0x1832D8790")]
		private static void SetRigidBodyLock(bool lockValue)
		{
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x32D8A70", Offset = "0x32D7070", VA = "0x1832D8A70")]
		public PlayerGatheringAction()
		{
		}

		// Token: 0x04001BB7 RID: 7095
		[Token(Token = "0x4001BB7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationEventReceiver _playerAnimEventReceiver;

		// Token: 0x04001BB8 RID: 7096
		[Token(Token = "0x4001BB8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _rightHeldItemLocator;

		// Token: 0x04001BB9 RID: 7097
		[Token(Token = "0x4001BB9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _leftHeldItemLocator;

		// Token: 0x04001BBA RID: 7098
		[Token(Token = "0x4001BBA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _offsetBackFromGatherTarget;

		// Token: 0x04001BBB RID: 7099
		[Token(Token = "0x4001BBB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _lerpTime;

		// Token: 0x04001BBC RID: 7100
		[Token(Token = "0x4001BBC")]
		[FieldOffset(Offset = "0x40")]
		private PlayerGatheringAction.OnGatheringComplete _onGatheringComplete;

		// Token: 0x04001BBD RID: 7101
		[Token(Token = "0x4001BBD")]
		[FieldOffset(Offset = "0x48")]
		private GameObject _gatheredItemAnimatedPrefab;

		// Token: 0x04001BBE RID: 7102
		[Token(Token = "0x4001BBE")]
		[FieldOffset(Offset = "0x50")]
		private GameObject _gatheringToolAnimatedPrefab;

		// Token: 0x04001BBF RID: 7103
		[Token(Token = "0x4001BBF")]
		[FieldOffset(Offset = "0x58")]
		private GameObject _gatheredItemInstance;

		// Token: 0x04001BC0 RID: 7104
		[Token(Token = "0x4001BC0")]
		[FieldOffset(Offset = "0x60")]
		private GameObject _gatheringToolInstance;

		// Token: 0x04001BC1 RID: 7105
		[Token(Token = "0x4001BC1")]
		[FieldOffset(Offset = "0x68")]
		private float _gatheredItemScale;

		// Token: 0x04001BC2 RID: 7106
		[Token(Token = "0x4001BC2")]
		[FieldOffset(Offset = "0x70")]
		private Animator _gatheredItemAnimator;

		// Token: 0x04001BC3 RID: 7107
		[Token(Token = "0x4001BC3")]
		[FieldOffset(Offset = "0x78")]
		private Animator _gatheringToolAnimator;

		// Token: 0x04001BC4 RID: 7108
		[Token(Token = "0x4001BC4")]
		[FieldOffset(Offset = "0x80")]
		private PlayerGatheringAction.LocatorSide _gatheredItemlocatorSide;

		// Token: 0x04001BC5 RID: 7109
		[Token(Token = "0x4001BC5")]
		[FieldOffset(Offset = "0x84")]
		private PlayerGatheringAction.LocatorSide _gatheringToolLocatorSide;

		// Token: 0x04001BC6 RID: 7110
		[Token(Token = "0x4001BC6")]
		[FieldOffset(Offset = "0x88")]
		private ItemData _gatheredItemData;

		// Token: 0x04001BC7 RID: 7111
		[Token(Token = "0x4001BC7")]
		[FieldOffset(Offset = "0x90")]
		private bool _disableItemTriggered;

		// Token: 0x04001BC8 RID: 7112
		[Token(Token = "0x4001BC8")]
		[FieldOffset(Offset = "0x91")]
		private bool _updateAnimators;

		// Token: 0x04001BC9 RID: 7113
		[Token(Token = "0x4001BC9")]
		[FieldOffset(Offset = "0x98")]
		private Transform _gatherableTransform;

		// Token: 0x04001BCA RID: 7114
		[Token(Token = "0x4001BCA")]
		[FieldOffset(Offset = "0xA0")]
		protected readonly ILayerBehaviourActivator[] FullBodyDisableSpineActivators;

		// Token: 0x02000471 RID: 1137
		// (Invoke) Token: 0x06001D6A RID: 7530
		[Token(Token = "0x2000471")]
		public delegate void OnGatheringComplete();

		// Token: 0x02000472 RID: 1138
		[Token(Token = "0x2000472")]
		public enum LocatorSide
		{
			// Token: 0x04001BCC RID: 7116
			[Token(Token = "0x4001BCC")]
			Right,
			// Token: 0x04001BCD RID: 7117
			[Token(Token = "0x4001BCD")]
			Left
		}
	}
}
