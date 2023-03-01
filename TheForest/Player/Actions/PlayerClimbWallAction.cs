using System;
using Il2CppDummyDll;
using TheForest.Items.Inventory;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000472 RID: 1138
	[Token(Token = "0x2000472")]
	public class PlayerClimbWallAction : MonoBehaviour
	{
		// Token: 0x06001CC5 RID: 7365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC5")]
		[Address(RVA = "0x2CF9A30", Offset = "0x2CF8A30", VA = "0x182CF9A30")]
		private void enterClimbWall(Transform trn)
		{
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x2CF9500", Offset = "0x2CF8500", VA = "0x182CF9500")]
		private void enterClimbWallTop(Transform trn)
		{
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void setAttachPos()
		{
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void enableDoingClimb()
		{
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x2CFA020", Offset = "0x2CF9020", VA = "0x182CFA020")]
		private void exitClimbWallTop(Transform trn)
		{
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x2CF9EE0", Offset = "0x2CF8EE0", VA = "0x182CF9EE0")]
		private void exitClimbWallGround()
		{
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x2CFA160", Offset = "0x2CF9160", VA = "0x182CFA160")]
		private void resetClimbWall()
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerClimbWallAction()
		{
		}

		// Token: 0x04001B54 RID: 6996
		[Token(Token = "0x4001B54")]
		[FieldOffset(Offset = "0x20")]
		public PlayerInventory _player;

		// Token: 0x04001B55 RID: 6997
		[Token(Token = "0x4001B55")]
		[FieldOffset(Offset = "0x28")]
		public float ropeAttachOffset;

		// Token: 0x04001B56 RID: 6998
		[Token(Token = "0x4001B56")]
		[FieldOffset(Offset = "0x2C")]
		public float ropeAttachTopOffsetZ;

		// Token: 0x04001B57 RID: 6999
		[Token(Token = "0x4001B57")]
		[FieldOffset(Offset = "0x30")]
		public float ropeAttachTopOffsetX;

		// Token: 0x04001B58 RID: 7000
		[Token(Token = "0x4001B58")]
		[FieldOffset(Offset = "0x34")]
		public bool doingClimb;
	}
}
