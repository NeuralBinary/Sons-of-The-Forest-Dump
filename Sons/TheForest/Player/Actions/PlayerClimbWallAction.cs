using System;
using Il2CppDummyDll;
using TheForest.Items.Inventory;
using UnityEngine;

namespace TheForest.Player.Actions
{
	// Token: 0x02000464 RID: 1124
	[Token(Token = "0x2000464")]
	public class PlayerClimbWallAction : MonoBehaviour
	{
		// Token: 0x06001D05 RID: 7429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D05")]
		[Address(RVA = "0x32CE810", Offset = "0x32CCE10", VA = "0x1832CE810")]
		private void enterClimbWall(Transform trn)
		{
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D06")]
		[Address(RVA = "0x32CEF20", Offset = "0x32CD520", VA = "0x1832CEF20")]
		private void enterClimbWallTop(Transform trn)
		{
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D07")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void setAttachPos()
		{
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void enableDoingClimb()
		{
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x32CF760", Offset = "0x32CDD60", VA = "0x1832CF760")]
		private void exitClimbWallTop(Transform trn)
		{
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x32CF930", Offset = "0x32CDF30", VA = "0x1832CF930")]
		private void exitClimbWallGround()
		{
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x32CFB00", Offset = "0x32CE100", VA = "0x1832CFB00")]
		private void resetClimbWall()
		{
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerClimbWallAction()
		{
		}

		// Token: 0x04001B78 RID: 7032
		[Token(Token = "0x4001B78")]
		[FieldOffset(Offset = "0x20")]
		public PlayerInventory _player;

		// Token: 0x04001B79 RID: 7033
		[Token(Token = "0x4001B79")]
		[FieldOffset(Offset = "0x28")]
		public float ropeAttachOffset;

		// Token: 0x04001B7A RID: 7034
		[Token(Token = "0x4001B7A")]
		[FieldOffset(Offset = "0x2C")]
		public float ropeAttachTopOffsetZ;

		// Token: 0x04001B7B RID: 7035
		[Token(Token = "0x4001B7B")]
		[FieldOffset(Offset = "0x30")]
		public float ropeAttachTopOffsetX;

		// Token: 0x04001B7C RID: 7036
		[Token(Token = "0x4001B7C")]
		[FieldOffset(Offset = "0x34")]
		public bool doingClimb;
	}
}
