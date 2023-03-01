using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Items.Inventory;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000466 RID: 1126
	[Token(Token = "0x2000466")]
	public class PlayerClimbCliffAction : MonoBehaviour
	{
		// Token: 0x06001C77 RID: 7287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0x2CF5B90", Offset = "0x2CF4B90", VA = "0x182CF5B90")]
		private void enterClimbCliff(Transform trn)
		{
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x1CE9160", Offset = "0x1CE8160", VA = "0x181CE9160")]
		private void setEnterClimbPos(Vector3 pos)
		{
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void enableDoingClimbCliff()
		{
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x2CF66B0", Offset = "0x2CF56B0", VA = "0x182CF66B0")]
		private void exitClimbCliffTop(Transform trn)
		{
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x2CF6310", Offset = "0x2CF5310", VA = "0x182CF6310")]
		public void exitClimbCliffGround()
		{
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x2CF68B0", Offset = "0x2CF58B0", VA = "0x182CF68B0")]
		private void resetClimbCliff()
		{
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0x2CF6840", Offset = "0x2CF5840", VA = "0x182CF6840")]
		private IEnumerator forcePlayerDrag()
		{
			return null;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerClimbCliffAction()
		{
		}

		// Token: 0x04001B20 RID: 6944
		[Token(Token = "0x4001B20")]
		[FieldOffset(Offset = "0x20")]
		public PlayerInventory _player;

		// Token: 0x04001B21 RID: 6945
		[Token(Token = "0x4001B21")]
		[FieldOffset(Offset = "0x28")]
		public float ropeAttachOffset;

		// Token: 0x04001B22 RID: 6946
		[Token(Token = "0x4001B22")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 enterPos;

		// Token: 0x04001B23 RID: 6947
		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x38")]
		public bool doingClimb;

		// Token: 0x04001B24 RID: 6948
		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x39")]
		private bool forceRunning;
	}
}
