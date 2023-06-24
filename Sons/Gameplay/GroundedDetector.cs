using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000743 RID: 1859
	[Token(Token = "0x2000743")]
	public class GroundedDetector : MonoBehaviour
	{
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x0000F0D8 File Offset: 0x0000D2D8
		[Token(Token = "0x1700067D")]
		public bool IsGrounded
		{
			[Token(Token = "0x60031B1")]
			[Address(RVA = "0x9DD210", Offset = "0x9DB810", VA = "0x1809DD210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B2")]
		[Address(RVA = "0x348FA00", Offset = "0x348E000", VA = "0x18348FA00")]
		private void LateUpdate()
		{
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B3")]
		[Address(RVA = "0x348FAB0", Offset = "0x348E0B0", VA = "0x18348FAB0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B4")]
		[Address(RVA = "0x348FBE0", Offset = "0x348E1E0", VA = "0x18348FBE0")]
		private void OnCollisionStay(Collision collisionInfo)
		{
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B5")]
		[Address(RVA = "0x348FD10", Offset = "0x348E310", VA = "0x18348FD10")]
		private void CheckGrounded()
		{
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031B6")]
		[Address(RVA = "0x348FE00", Offset = "0x348E400", VA = "0x18348FE00")]
		public GroundedDetector()
		{
		}

		// Token: 0x04002AE2 RID: 10978
		[Token(Token = "0x4002AE2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LayerMask _groundLayerMask;

		// Token: 0x04002AE3 RID: 10979
		[Token(Token = "0x4002AE3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _groundedTimeout;

		// Token: 0x04002AE4 RID: 10980
		[Token(Token = "0x4002AE4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _delayBetweenSwitch;

		// Token: 0x04002AE5 RID: 10981
		[Token(Token = "0x4002AE5")]
		[FieldOffset(Offset = "0x2C")]
		private bool _grounded;

		// Token: 0x04002AE6 RID: 10982
		[Token(Token = "0x4002AE6")]
		[FieldOffset(Offset = "0x2D")]
		private bool _groundHitDetected;

		// Token: 0x04002AE7 RID: 10983
		[Token(Token = "0x4002AE7")]
		[FieldOffset(Offset = "0x30")]
		private float _lastGroundedTime;

		// Token: 0x04002AE8 RID: 10984
		[Token(Token = "0x4002AE8")]
		[FieldOffset(Offset = "0x34")]
		private int _lastGroundedFrame;
	}
}
