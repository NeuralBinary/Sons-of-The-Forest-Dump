using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007C3 RID: 1987
	[Token(Token = "0x20007C3")]
	public class ProjectileNetworkProxy : EntityBehaviour<IProjectileState>
	{
		// Token: 0x0600359A RID: 13722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359A")]
		[Address(RVA = "0x34E4310", Offset = "0x34E2910", VA = "0x1834E4310", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x34E48C0", Offset = "0x34E2EC0", VA = "0x1834E48C0")]
		public void SetStickTarget(Transform target)
		{
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359C")]
		[Address(RVA = "0x34E49F0", Offset = "0x34E2FF0", VA = "0x1834E49F0")]
		private void StickToTarget()
		{
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359D")]
		[Address(RVA = "0x34E5340", Offset = "0x34E3940", VA = "0x1834E5340")]
		private void OnStickToTarget()
		{
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359E")]
		[Address(RVA = "0x34E5B50", Offset = "0x34E4150", VA = "0x1834E5B50")]
		public ProjectileNetworkProxy()
		{
		}

		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		[FieldOffset(Offset = "0x28")]
		private Transform _stickToTarget;

		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _stickOffsetPos;

		// Token: 0x04002E4F RID: 11855
		[Token(Token = "0x4002E4F")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion _stickOffsetRot;

		// Token: 0x04002E50 RID: 11856
		[Token(Token = "0x4002E50")]
		[FieldOffset(Offset = "0x4C")]
		private bool _hasBeenStuck;
	}
}
