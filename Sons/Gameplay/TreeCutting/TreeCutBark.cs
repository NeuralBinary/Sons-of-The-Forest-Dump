using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.TreeCutting
{
	// Token: 0x0200082C RID: 2092
	[Token(Token = "0x200082C")]
	public class TreeCutBark : MonoBehaviour
	{
		// Token: 0x06003AED RID: 15085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AED")]
		[Address(RVA = "0x3582530", Offset = "0x3580B30", VA = "0x183582530")]
		private void Refresh()
		{
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEE")]
		[Address(RVA = "0x3582540", Offset = "0x3580B40", VA = "0x183582540")]
		public void CheckRemove()
		{
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AEF")]
		[Address(RVA = "0x3582940", Offset = "0x3580F40", VA = "0x183582940")]
		private void DoRemove()
		{
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF0")]
		[Address(RVA = "0x3582D10", Offset = "0x3581310", VA = "0x183582D10")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AF1")]
		[Address(RVA = "0x3583550", Offset = "0x3581B50", VA = "0x183583550")]
		public TreeCutBark()
		{
		}

		// Token: 0x0400322F RID: 12847
		[Token(Token = "0x400322F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _lifespan;

		// Token: 0x04003230 RID: 12848
		[Token(Token = "0x4003230")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxPhysicsDepenetrationVelocity;

		// Token: 0x04003231 RID: 12849
		[Token(Token = "0x4003231")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Collider _colliderTarget;

		// Token: 0x04003232 RID: 12850
		[Token(Token = "0x4003232")]
		[FieldOffset(Offset = "0x30")]
		private float _boundsSize;
	}
}
