using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000692 RID: 1682
	[Token(Token = "0x2000692")]
	public class ProjectileNetworkProxy : EntityBehaviour<IProjectileState>
	{
		// Token: 0x06002B10 RID: 11024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B10")]
		[Address(RVA = "0x2DDE0B0", Offset = "0x2DDD0B0", VA = "0x182DDE0B0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B11")]
		[Address(RVA = "0x2DDEB40", Offset = "0x2DDDB40", VA = "0x182DDEB40")]
		public void SetStickTarget(Transform target)
		{
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x2DDEC00", Offset = "0x2DDDC00", VA = "0x182DDEC00")]
		private void StickToTarget()
		{
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0x2DDE480", Offset = "0x2DDD480", VA = "0x182DDE480")]
		private void OnStickToTarget()
		{
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x2DDF2B0", Offset = "0x2DDE2B0", VA = "0x182DDF2B0")]
		public ProjectileNetworkProxy()
		{
		}

		// Token: 0x0400269C RID: 9884
		[Token(Token = "0x400269C")]
		[FieldOffset(Offset = "0x28")]
		private Transform _stickToTarget;

		// Token: 0x0400269D RID: 9885
		[Token(Token = "0x400269D")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _stickOffsetPos;

		// Token: 0x0400269E RID: 9886
		[Token(Token = "0x400269E")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion _stickOffsetRot;

		// Token: 0x0400269F RID: 9887
		[Token(Token = "0x400269F")]
		[FieldOffset(Offset = "0x4C")]
		private bool _hasBeenStuck;
	}
}
