using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	public struct ObiPathFrame
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x2817F20", Offset = "0x2816520", VA = "0x182817F20")]
		public ObiPathFrame(Vector3 position, Vector3 tangent, Vector3 normal, Vector3 binormal, Vector4 color, float thickness)
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x2817F80", Offset = "0x2816580", VA = "0x182817F80")]
		public void Reset()
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0000557C File Offset: 0x0000377C
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x2818090", Offset = "0x2816690", VA = "0x182818090")]
		public static ObiPathFrame operator +(ObiPathFrame c1, ObiPathFrame c2)
		{
			return default(ObiPathFrame);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00005594 File Offset: 0x00003794
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x28182B0", Offset = "0x28168B0", VA = "0x1828182B0")]
		public static ObiPathFrame operator *(float f, ObiPathFrame c)
		{
			return default(ObiPathFrame);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x2818480", Offset = "0x2816A80", VA = "0x182818480")]
		public static void WeightedSum(float w1, float w2, float w3, ref ObiPathFrame c1, ref ObiPathFrame c2, ref ObiPathFrame c3, ref ObiPathFrame sum)
		{
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x2818750", Offset = "0x2816D50", VA = "0x182818750")]
		public void SetTwist(float twist)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x2818860", Offset = "0x2816E60", VA = "0x182818860")]
		public void SetTwistAndTangent(float twist, Vector3 tangent)
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x2818AB0", Offset = "0x28170B0", VA = "0x182818AB0")]
		public void Transport(ObiPathFrame frame, float twist)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x2818E50", Offset = "0x2817450", VA = "0x182818E50")]
		public void Transport(Vector3 newPosition, Vector3 newTangent, float twist)
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x2819160", Offset = "0x2817760", VA = "0x182819160")]
		public void Transport(Vector3 newPosition, Vector3 newTangent, Vector3 newNormal, float twist)
		{
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x000055AC File Offset: 0x000037AC
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x2819300", Offset = "0x2817900", VA = "0x182819300")]
		public Matrix4x4 ToMatrix(ObiPathFrame.Axis mainAxis)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x2819450", Offset = "0x2817A50", VA = "0x182819450")]
		public void DebugDraw(float size)
		{
		}

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 position;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 tangent;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 normal;

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 binormal;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x30")]
		public Vector4 color;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		[FieldOffset(Offset = "0x40")]
		public float thickness;

		// Token: 0x020001FA RID: 506
		[Token(Token = "0x20001FA")]
		public enum Axis
		{
			// Token: 0x04000831 RID: 2097
			[Token(Token = "0x4000831")]
			X,
			// Token: 0x04000832 RID: 2098
			[Token(Token = "0x4000832")]
			Y,
			// Token: 0x04000833 RID: 2099
			[Token(Token = "0x4000833")]
			Z
		}
	}
}
