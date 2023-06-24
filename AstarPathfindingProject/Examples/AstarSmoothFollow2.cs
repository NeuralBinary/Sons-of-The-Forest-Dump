using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_astar_smooth_follow2.php")]
	public class AstarSmoothFollow2 : MonoBehaviour
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x654900", Offset = "0x652F00", VA = "0x180654900")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x655080", Offset = "0x653680", VA = "0x180655080")]
		public AstarSmoothFollow2()
		{
		}

		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x40008A9")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		[FieldOffset(Offset = "0x28")]
		public float distance;

		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		[FieldOffset(Offset = "0x2C")]
		public float height;

		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		[FieldOffset(Offset = "0x30")]
		public float damping;

		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		[FieldOffset(Offset = "0x34")]
		public bool smoothRotation;

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x35")]
		public bool followBehind;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x38")]
		public float rotationDamping;

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x3C")]
		public bool staticOffset;
	}
}
