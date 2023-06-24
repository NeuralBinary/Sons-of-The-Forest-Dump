using System;
using Il2CppDummyDll;
using Shapes;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class ShapesDiscSync : MonoBehaviour
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x3017E70", Offset = "0x3016470", VA = "0x183017E70")]
		private void Update()
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x3017E80", Offset = "0x3016480", VA = "0x183017E80")]
		private void Refresh()
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ShapesDiscSync()
		{
		}

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Disc _source;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Disc _target;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _mirror;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _offsetStart;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _offsetEnd;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float CircleRadians;
	}
}
