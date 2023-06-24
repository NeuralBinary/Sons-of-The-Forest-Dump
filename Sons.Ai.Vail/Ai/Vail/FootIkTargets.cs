using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	[DefaultExecutionOrder(-1)]
	public class FootIkTargets : MonoBehaviour
	{
		// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x2B4D9D0", Offset = "0x2B4BFD0", VA = "0x182B4D9D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x2B4E1D0", Offset = "0x2B4C7D0", VA = "0x182B4E1D0")]
		public FootIkTargets()
		{
		}

		// Token: 0x040005C3 RID: 1475
		[Token(Token = "0x40005C3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _rayStartHeight;

		// Token: 0x040005C4 RID: 1476
		[Token(Token = "0x40005C4")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _offsetY;

		// Token: 0x040005C5 RID: 1477
		[Token(Token = "0x40005C5")]
		[FieldOffset(Offset = "0x28")]
		private bool _active;

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<FootIkTargets.IKTarget> _ikTargets;

		// Token: 0x020000BA RID: 186
		[Token(Token = "0x20000BA")]
		[Serializable]
		private struct IKTarget
		{
			// Token: 0x040005C7 RID: 1479
			[Token(Token = "0x40005C7")]
			[FieldOffset(Offset = "0x0")]
			public Transform Transform;

			// Token: 0x040005C8 RID: 1480
			[Token(Token = "0x40005C8")]
			[FieldOffset(Offset = "0x8")]
			public Transform IkTarget;

			// Token: 0x040005C9 RID: 1481
			[Token(Token = "0x40005C9")]
			[FieldOffset(Offset = "0x10")]
			public float MaxOffsetUp;

			// Token: 0x040005CA RID: 1482
			[Token(Token = "0x40005CA")]
			[FieldOffset(Offset = "0x14")]
			public float MaxOffsetDown;
		}
	}
}
