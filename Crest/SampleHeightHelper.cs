using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class SampleHeightHelper
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x9CB820", Offset = "0x9C9E20", VA = "0x1809CB820")]
		public void Init(Vector3 i_queryPos, float i_minLength = 0f, bool allowMultipleCallsPerFrame = false, [Optional] UnityEngine.Object context)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x9CB860", Offset = "0x9C9E60", VA = "0x1809CB860")]
		public bool Sample(out float o_height)
		{
			return default(bool);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x9CBA40", Offset = "0x9CA040", VA = "0x1809CBA40")]
		public bool Sample(out float o_height, out Vector3 o_normal)
		{
			return default(bool);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x9CBCD0", Offset = "0x9CA2D0", VA = "0x1809CBCD0")]
		public bool Sample(out float o_height, out Vector3 o_normal, out Vector3 o_surfaceVel)
		{
			return default(bool);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x9CC000", Offset = "0x9CA600", VA = "0x1809CC000")]
		public bool Sample(out Vector3 o_displacementToPoint, out Vector3 o_normal, out Vector3 o_surfaceVel)
		{
			return default(bool);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x9CC300", Offset = "0x9CA900", VA = "0x1809CC300")]
		public SampleHeightHelper()
		{
		}

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3[] _queryPos;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3[] _queryResult;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3[] _queryResultNormal;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] _queryResultVel;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _minLength;
	}
}
