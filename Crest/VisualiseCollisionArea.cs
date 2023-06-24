using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class VisualiseCollisionArea : MonoBehaviour
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x9CC7F0", Offset = "0x9CADF0", VA = "0x1809CC7F0")]
		private void Update()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x9CCE40", Offset = "0x9CB440", VA = "0x1809CCE40")]
		public static void DebugDrawCross(Vector3 pos, float r, Color col, float duration = 0f)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x9CD4A0", Offset = "0x9CBAA0", VA = "0x1809CD4A0")]
		public VisualiseCollisionArea()
		{
		}

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _objectWidth;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x28")]
		private float[] _resultHeights;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float s_radius;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int s_steps;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x30")]
		private Vector3[] _samplePositions;
	}
}
