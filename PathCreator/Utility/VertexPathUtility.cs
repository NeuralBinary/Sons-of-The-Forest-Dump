using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PathCreation.Utility
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public static class VertexPathUtility
	{
		// Token: 0x06000097 RID: 151 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2834940", Offset = "0x2832F40", VA = "0x182834940")]
		public static VertexPathUtility.PathSplitData SplitBezierPathByAngleError(BezierPath bezierPath, float maxAngleError, float minVertexDst, float accuracy)
		{
			return null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x28354E0", Offset = "0x2833AE0", VA = "0x1828354E0")]
		public static VertexPathUtility.PathSplitData SplitBezierPathEvenly(BezierPath bezierPath, float spacing, float accuracy)
		{
			return null;
		}

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000015")]
		public class PathSplitData
		{
			// Token: 0x06000099 RID: 153 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x2836000", Offset = "0x2834600", VA = "0x182836000")]
			public PathSplitData()
			{
			}

			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			[FieldOffset(Offset = "0x10")]
			public List<Vector3> vertices;

			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			[FieldOffset(Offset = "0x18")]
			public List<Vector3> tangents;

			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x20")]
			public List<float> cumulativeLength;

			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x28")]
			public List<int> anchorVertexMap;

			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x30")]
			public MinMax3D minMax;
		}
	}
}
