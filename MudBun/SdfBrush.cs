using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x020000AE RID: 174
	[Token(Token = "0x20000AE")]
	[Serializable]
	public struct SdfBrush
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x24116A0", Offset = "0x240FCA0", VA = "0x1824116A0")]
		public static SdfBrush New()
		{
			return default(SdfBrush);
		}

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int Stride;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x0")]
		public int Type;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x4")]
		public int Operator;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x8")]
		public int Proxy;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0xC")]
		public int Index;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x1C")]
		public float Blend;

		// Token: 0x0400036D RID: 877
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion Rotation;

		// Token: 0x0400036E RID: 878
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 Size;

		// Token: 0x0400036F RID: 879
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x3C")]
		public float Radius;

		// Token: 0x04000370 RID: 880
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x40")]
		public Vector4 Data0;

		// Token: 0x04000371 RID: 881
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x50")]
		public Vector4 Data1;

		// Token: 0x04000372 RID: 882
		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0x60")]
		public Vector4 Data2;

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x70")]
		public Vector4 Data3;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0x80")]
		public Bits32 Flags;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x84")]
		public int MaterialIndex;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x88")]
		public int BoneIndex;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x8C")]
		public int Padding0;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x90")]
		public float Hash;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x94")]
		public float Padding1;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x98")]
		public float Padding2;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x9C")]
		public float Padding3;

		// Token: 0x020000AF RID: 175
		[Token(Token = "0x20000AF")]
		public enum TypeEnum
		{
			// Token: 0x0400037D RID: 893
			[Token(Token = "0x400037D")]
			Nop = -1,
			// Token: 0x0400037E RID: 894
			[Token(Token = "0x400037E")]
			GroupStart = -2,
			// Token: 0x0400037F RID: 895
			[Token(Token = "0x400037F")]
			GroupEnd = -3,
			// Token: 0x04000380 RID: 896
			[Token(Token = "0x4000380")]
			Box = 0,
			// Token: 0x04000381 RID: 897
			[Token(Token = "0x4000381")]
			Sphere,
			// Token: 0x04000382 RID: 898
			[Token(Token = "0x4000382")]
			Cylinder,
			// Token: 0x04000383 RID: 899
			[Token(Token = "0x4000383")]
			Torus,
			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			SolidAngle,
			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			Particle = 100,
			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			ParticleSystem,
			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000387")]
			UniformNoise,
			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000388")]
			CurveSimple,
			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000389")]
			CurveFull,
			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400038A")]
			FishEye = 200,
			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400038B")]
			Pinch,
			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400038C")]
			Twist,
			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400038D")]
			Quantize,
			// Token: 0x0400038E RID: 910
			[Token(Token = "0x400038E")]
			Onion = 300,
			// Token: 0x0400038F RID: 911
			[Token(Token = "0x400038F")]
			NoiseModifier
		}

		// Token: 0x020000B0 RID: 176
		[Token(Token = "0x20000B0")]
		public enum OperatorEnum
		{
			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000391")]
			Union,
			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			Subtract,
			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000393")]
			Intersect,
			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000394")]
			Dye,
			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4000395")]
			CullInside,
			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4000396")]
			CullOutside,
			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000397")]
			NoOp = -1
		}

		// Token: 0x020000B1 RID: 177
		[Token(Token = "0x20000B1")]
		public enum BoundaryShapeEnum
		{
			// Token: 0x04000399 RID: 921
			[Token(Token = "0x4000399")]
			Box,
			// Token: 0x0400039A RID: 922
			[Token(Token = "0x400039A")]
			Sphere,
			// Token: 0x0400039B RID: 923
			[Token(Token = "0x400039B")]
			Cylinder,
			// Token: 0x0400039C RID: 924
			[Token(Token = "0x400039C")]
			Torus,
			// Token: 0x0400039D RID: 925
			[Token(Token = "0x400039D")]
			SolidAngle
		}

		// Token: 0x020000B2 RID: 178
		[Token(Token = "0x20000B2")]
		public enum NoiseTypeEnum
		{
			// Token: 0x0400039F RID: 927
			[Token(Token = "0x400039F")]
			Perlin = -1,
			// Token: 0x040003A0 RID: 928
			[Token(Token = "0x40003A0")]
			BakedPerlin,
			// Token: 0x040003A1 RID: 929
			[Token(Token = "0x40003A1")]
			Triangle
		}

		// Token: 0x020000B3 RID: 179
		[Token(Token = "0x20000B3")]
		public enum FlagBit
		{
			// Token: 0x040003A3 RID: 931
			[Token(Token = "0x40003A3")]
			Hidden,
			// Token: 0x040003A4 RID: 932
			[Token(Token = "0x40003A4")]
			FlipX,
			// Token: 0x040003A5 RID: 933
			[Token(Token = "0x40003A5")]
			MirrorX,
			// Token: 0x040003A6 RID: 934
			[Token(Token = "0x40003A6")]
			CountAsBone,
			// Token: 0x040003A7 RID: 935
			[Token(Token = "0x40003A7")]
			CreateMirroredBone,
			// Token: 0x040003A8 RID: 936
			[Token(Token = "0x40003A8")]
			ContributeMaterial,
			// Token: 0x040003A9 RID: 937
			[Token(Token = "0x40003A9")]
			LockNoisePosition,
			// Token: 0x040003AA RID: 938
			[Token(Token = "0x40003AA")]
			SphericalNoiseCoordinates
		}
	}
}
