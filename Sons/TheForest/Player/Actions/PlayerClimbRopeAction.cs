using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.Player.Actions
{
	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	public class PlayerClimbRopeAction : MonoBehaviour
	{
		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x32C91F0", Offset = "0x32C77F0", VA = "0x1832C91F0")]
		private void Start()
		{
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x32C9320", Offset = "0x32C7920", VA = "0x1832C9320")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC5")]
		[Address(RVA = "0x32C93D0", Offset = "0x32C79D0", VA = "0x1832C93D0")]
		private void ListenForPlayerDeath(bool enable)
		{
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x32C9530", Offset = "0x32C7B30", VA = "0x1832C9530")]
		private void OnPlayerDied(object _)
		{
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
		private void ToggleLogs(bool onOff)
		{
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x32C96A0", Offset = "0x32C7CA0", VA = "0x1832C96A0")]
		private void SetIsClimbing(bool onOff)
		{
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x32C9780", Offset = "0x32C7D80", VA = "0x1832C9780")]
		public void EnterClimbRopeFromBottom(activateClimb activateClimb)
		{
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x32C9FB0", Offset = "0x32C85B0", VA = "0x1832C9FB0")]
		public void EnterClimbRopeFromTop(activateClimbTop activateClimbTop)
		{
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x32CA9F0", Offset = "0x32C8FF0", VA = "0x1832CA9F0")]
		private IEnumerator ClimbOnAtTopComplete()
		{
			return null;
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x32CAA80", Offset = "0x32C9080", VA = "0x1832CAA80")]
		private IEnumerator ClimbOffAtTopComplete()
		{
			return null;
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x32CAB10", Offset = "0x32C9110", VA = "0x1832CAB10")]
		public void ExitClimbRopeAtTop(Transform trn)
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x32CAF10", Offset = "0x32C9510", VA = "0x1832CAF10")]
		private bool ExitClimbRopeAtBottom(bool reset)
		{
			return default(bool);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x32CB570", Offset = "0x32C9B70", VA = "0x1832CB570")]
		private void resetTopExitTrigger()
		{
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x32CB6D0", Offset = "0x32C9CD0", VA = "0x1832CB6D0")]
		private void resetClimbRope()
		{
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x32CBB30", Offset = "0x32CA130", VA = "0x1832CBB30")]
		private IEnumerator blockRopeGroundCheck()
		{
			return null;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD2")]
		[Address(RVA = "0x32CBB70", Offset = "0x32CA170", VA = "0x1832CBB70")]
		private IEnumerator StickToRope(Transform ropeTransform)
		{
			return null;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x000084C0 File Offset: 0x000066C0
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0x32CBC70", Offset = "0x32CA270", VA = "0x1832CBC70")]
		private bool CheckForCeiling(bool exitAtTop = false)
		{
			return default(bool);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x32CC200", Offset = "0x32CA800", VA = "0x1832CC200")]
		private IEnumerator restorePlayerCollisions()
		{
			return null;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x32CC240", Offset = "0x32CA840", VA = "0x1832CC240")]
		public PlayerClimbRopeAction()
		{
		}

		// Token: 0x04001B4D RID: 6989
		[Token(Token = "0x4001B4D")]
		private const float HeightOffsetAfterClimbFromTopAnim = 2.05f;

		// Token: 0x04001B4E RID: 6990
		[Token(Token = "0x4001B4E")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("onRopeOffset")]
		[SerializeField]
		private float _stickToRopeOffset;

		// Token: 0x04001B4F RID: 6991
		[Token(Token = "0x4001B4F")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("ropeAttachOffset")]
		[SerializeField]
		private float _attachToBottomRopeOffset;

		// Token: 0x04001B50 RID: 6992
		[Token(Token = "0x4001B50")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _attachToRopeFromTopOffset;

		// Token: 0x04001B51 RID: 6993
		[Token(Token = "0x4001B51")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _dropDownOnRopeDistanceFromTop;

		// Token: 0x04001B52 RID: 6994
		[Token(Token = "0x4001B52")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _disconnectDistanceFromBottom;

		// Token: 0x04001B53 RID: 6995
		[Token(Token = "0x4001B53")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LayerMask _ceilingsLayers;

		// Token: 0x04001B54 RID: 6996
		[Token(Token = "0x4001B54")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _verbose;

		// Token: 0x04001B55 RID: 6997
		[Token(Token = "0x4001B55")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		[HideInInspector]
		private bool _isClimbing;

		// Token: 0x04001B56 RID: 6998
		[Token(Token = "0x4001B56")]
		[FieldOffset(Offset = "0x48")]
		private Transform _bottomTriggerTr;

		// Token: 0x04001B57 RID: 6999
		[Token(Token = "0x4001B57")]
		[FieldOffset(Offset = "0x50")]
		private Transform _currentRopeRoot;

		// Token: 0x04001B58 RID: 7000
		[Token(Token = "0x4001B58")]
		[FieldOffset(Offset = "0x58")]
		private bool _enteredFromTheTop;

		// Token: 0x04001B59 RID: 7001
		[Token(Token = "0x4001B59")]
		[FieldOffset(Offset = "0x60")]
		private Collider _exitTopTrigger;

		// Token: 0x04001B5A RID: 7002
		[Token(Token = "0x4001B5A")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 _onRopeAttachPos;

		// Token: 0x04001B5B RID: 7003
		[Token(Token = "0x4001B5B")]
		[FieldOffset(Offset = "0x78")]
		private PlayerInventory _player;
	}
}
