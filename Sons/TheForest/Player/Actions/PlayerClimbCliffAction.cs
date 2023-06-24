using System;
using System.Collections;
using Il2CppDummyDll;
using TheForest.Items.Inventory;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000458 RID: 1112
	[Token(Token = "0x2000458")]
	public class PlayerClimbCliffAction : MonoBehaviour
	{
		// Token: 0x06001CB5 RID: 7349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x32C7530", Offset = "0x32C5B30", VA = "0x1832C7530")]
		private void enterClimbCliff(Transform trn)
		{
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x200AC50", Offset = "0x2009250", VA = "0x18200AC50")]
		private void setEnterClimbPos(Vector3 pos)
		{
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void enableDoingClimbCliff()
		{
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x32C80A0", Offset = "0x32C66A0", VA = "0x1832C80A0")]
		private void exitClimbCliffTop(Transform trn)
		{
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB9")]
		[Address(RVA = "0x32C82B0", Offset = "0x32C68B0", VA = "0x1832C82B0")]
		public void exitClimbCliffGround()
		{
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0x32C8750", Offset = "0x32C6D50", VA = "0x1832C8750")]
		private void resetClimbCliff()
		{
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0x32C8ED0", Offset = "0x32C74D0", VA = "0x1832C8ED0")]
		private IEnumerator forcePlayerDrag()
		{
			return null;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerClimbCliffAction()
		{
		}

		// Token: 0x04001B44 RID: 6980
		[Token(Token = "0x4001B44")]
		[FieldOffset(Offset = "0x20")]
		public PlayerInventory _player;

		// Token: 0x04001B45 RID: 6981
		[Token(Token = "0x4001B45")]
		[FieldOffset(Offset = "0x28")]
		public float ropeAttachOffset;

		// Token: 0x04001B46 RID: 6982
		[Token(Token = "0x4001B46")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 enterPos;

		// Token: 0x04001B47 RID: 6983
		[Token(Token = "0x4001B47")]
		[FieldOffset(Offset = "0x38")]
		public bool doingClimb;

		// Token: 0x04001B48 RID: 6984
		[Token(Token = "0x4001B48")]
		[FieldOffset(Offset = "0x39")]
		private bool forceRunning;
	}
}
