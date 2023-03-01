using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Player.Actions
{
	// Token: 0x02000468 RID: 1128
	[Token(Token = "0x2000468")]
	public class PlayerClimbRopeAction : MonoBehaviour
	{
		// Token: 0x06001C85 RID: 7301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x2CF8EF0", Offset = "0x2CF7EF0", VA = "0x182CF8EF0")]
		private void Start()
		{
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x2CF8D60", Offset = "0x2CF7D60", VA = "0x182CF8D60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x5F2460", Offset = "0x5F1460", VA = "0x1805F2460")]
		private void ToggleLogs(bool onOff)
		{
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x2CF8E10", Offset = "0x2CF7E10", VA = "0x182CF8E10")]
		private void SetIsClimbing(bool onOff)
		{
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x2CF73E0", Offset = "0x2CF63E0", VA = "0x182CF73E0")]
		public void EnterClimbRopeFromBottom(activateClimb activateClimb)
		{
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x2CF7B80", Offset = "0x2CF6B80", VA = "0x182CF7B80")]
		public void EnterClimbRopeFromTop(activateClimbTop activateClimbTop)
		{
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x2CF7370", Offset = "0x2CF6370", VA = "0x182CF7370")]
		private IEnumerator ClimbOnAtTopComplete()
		{
			return null;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8C")]
		[Address(RVA = "0x2CF7300", Offset = "0x2CF6300", VA = "0x182CF7300")]
		private IEnumerator ClimbOffAtTopComplete()
		{
			return null;
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8D")]
		[Address(RVA = "0x2CF8A30", Offset = "0x2CF7A30", VA = "0x182CF8A30")]
		public void ExitClimbRopeAtTop(Transform trn)
		{
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00008220 File Offset: 0x00006420
		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x2CF8580", Offset = "0x2CF7580", VA = "0x182CF8580")]
		private bool ExitClimbRopeAtBottom(bool reset)
		{
			return default(bool);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x2CF9420", Offset = "0x2CF8420", VA = "0x182CF9420")]
		private void resetTopExitTrigger()
		{
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x2CF90D0", Offset = "0x2CF80D0", VA = "0x182CF90D0")]
		private void resetClimbRope()
		{
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C91")]
		[Address(RVA = "0x2CF9080", Offset = "0x2CF8080", VA = "0x182CF9080")]
		private IEnumerator blockRopeGroundCheck()
		{
			return null;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C92")]
		[Address(RVA = "0x2CF8FD0", Offset = "0x2CF7FD0", VA = "0x182CF8FD0")]
		private IEnumerator StickToRope(Transform ropeTransform)
		{
			return null;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00008238 File Offset: 0x00006438
		[Token(Token = "0x6001C93")]
		[Address(RVA = "0x2CF6DF0", Offset = "0x2CF5DF0", VA = "0x182CF6DF0")]
		private bool CheckForCeiling(bool exitAtTop = false)
		{
			return default(bool);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C94")]
		[Address(RVA = "0x2CF94B0", Offset = "0x2CF84B0", VA = "0x182CF94B0")]
		private IEnumerator restorePlayerCollisions()
		{
			return null;
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C95")]
		[Address(RVA = "0x2CF9060", Offset = "0x2CF8060", VA = "0x182CF9060")]
		public PlayerClimbRopeAction()
		{
		}

		// Token: 0x04001B29 RID: 6953
		[Token(Token = "0x4001B29")]
		private const float HeightOffsetAfterClimbFromTopAnim = 2.05f;

		// Token: 0x04001B2A RID: 6954
		[Token(Token = "0x4001B2A")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("onRopeOffset")]
		[SerializeField]
		private float _stickToRopeOffset;

		// Token: 0x04001B2B RID: 6955
		[Token(Token = "0x4001B2B")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("ropeAttachOffset")]
		[SerializeField]
		private float _attachToBottomRopeOffset;

		// Token: 0x04001B2C RID: 6956
		[Token(Token = "0x4001B2C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _attachToRopeFromTopOffset;

		// Token: 0x04001B2D RID: 6957
		[Token(Token = "0x4001B2D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _dropDownOnRopeDistanceFromTop;

		// Token: 0x04001B2E RID: 6958
		[Token(Token = "0x4001B2E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _disconnectDistanceFromBottom;

		// Token: 0x04001B2F RID: 6959
		[Token(Token = "0x4001B2F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LayerMask _ceilingsLayers;

		// Token: 0x04001B30 RID: 6960
		[Token(Token = "0x4001B30")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _verbose;

		// Token: 0x04001B31 RID: 6961
		[Token(Token = "0x4001B31")]
		[FieldOffset(Offset = "0x41")]
		[HideInInspector]
		[SerializeField]
		private bool _isClimbing;

		// Token: 0x04001B32 RID: 6962
		[Token(Token = "0x4001B32")]
		[FieldOffset(Offset = "0x48")]
		private Transform _bottomTriggerTr;

		// Token: 0x04001B33 RID: 6963
		[Token(Token = "0x4001B33")]
		[FieldOffset(Offset = "0x50")]
		private Transform _currentRopeRoot;

		// Token: 0x04001B34 RID: 6964
		[Token(Token = "0x4001B34")]
		[FieldOffset(Offset = "0x58")]
		private bool _enteredFromTheTop;

		// Token: 0x04001B35 RID: 6965
		[Token(Token = "0x4001B35")]
		[FieldOffset(Offset = "0x60")]
		private Collider _exitTopTrigger;

		// Token: 0x04001B36 RID: 6966
		[Token(Token = "0x4001B36")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 _onRopeAttachPos;

		// Token: 0x04001B37 RID: 6967
		[Token(Token = "0x4001B37")]
		[FieldOffset(Offset = "0x78")]
		private PlayerInventory _player;
	}
}
