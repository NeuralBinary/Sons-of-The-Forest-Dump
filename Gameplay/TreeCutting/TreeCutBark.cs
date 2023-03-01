using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x020006E0 RID: 1760
	[Token(Token = "0x20006E0")]
	public class TreeCutBark : MonoBehaviour
	{
		// Token: 0x06002D0B RID: 11531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x2E15580", Offset = "0x2E14580", VA = "0x182E15580")]
		private void Refresh()
		{
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0C")]
		[Address(RVA = "0x2E14E60", Offset = "0x2E13E60", VA = "0x182E14E60")]
		public void CheckRemove()
		{
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0D")]
		[Address(RVA = "0x2E15070", Offset = "0x2E14070", VA = "0x182E15070")]
		private void DoRemove()
		{
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0x2E15230", Offset = "0x2E14230", VA = "0x182E15230")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x2E15590", Offset = "0x2E14590", VA = "0x182E15590")]
		public TreeCutBark()
		{
		}

		// Token: 0x04002853 RID: 10323
		[Token(Token = "0x4002853")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _lifespan;

		// Token: 0x04002854 RID: 10324
		[Token(Token = "0x4002854")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxPhysicsDepenetrationVelocity;

		// Token: 0x04002855 RID: 10325
		[Token(Token = "0x4002855")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Collider _colliderTarget;

		// Token: 0x04002856 RID: 10326
		[Token(Token = "0x4002856")]
		[FieldOffset(Offset = "0x30")]
		private float _boundsSize;
	}
}
