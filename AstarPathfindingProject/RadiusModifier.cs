using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_radius_modifier.php")]
	[AddComponentMenu("Pathfinding/Modifiers/Radius Offset")]
	public class RadiusModifier : MonoModifier
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00005924 File Offset: 0x00003B24
		[Token(Token = "0x17000131")]
		public override int Order
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x6C2DD0", Offset = "0x6C13D0", VA = "0x1806C2DD0", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0000593C File Offset: 0x00003B3C
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x6C2DE0", Offset = "0x6C13E0", VA = "0x1806C2DE0")]
		private bool CalculateCircleInner(Vector3 p1, Vector3 p2, float r1, float r2, out float a, out float sigma)
		{
			return default(bool);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00005954 File Offset: 0x00003B54
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x6C2F30", Offset = "0x6C1530", VA = "0x1806C2F30")]
		private bool CalculateCircleOuter(Vector3 p1, Vector3 p2, float r1, float r2, out float a, out float sigma)
		{
			return default(bool);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0000596C File Offset: 0x00003B6C
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x6C30A0", Offset = "0x6C16A0", VA = "0x1806C30A0")]
		private RadiusModifier.TangentType CalculateTangentType(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
		{
			return (RadiusModifier.TangentType)0;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00005984 File Offset: 0x00003B84
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x6C3190", Offset = "0x6C1790", VA = "0x1806C3190")]
		private RadiusModifier.TangentType CalculateTangentTypeSimple(Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return (RadiusModifier.TangentType)0;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x6C3200", Offset = "0x6C1800", VA = "0x1806C3200", Slot = "17")]
		public override void Apply(Path p)
		{
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x6C32F0", Offset = "0x6C18F0", VA = "0x1806C32F0")]
		public List<Vector3> Apply(List<Vector3> vs)
		{
			return null;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x6C4590", Offset = "0x6C2B90", VA = "0x1806C4590")]
		public RadiusModifier()
		{
		}

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x30")]
		public float radius;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x34")]
		public float detail;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x38")]
		private float[] radi;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x40")]
		private float[] a1;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x48")]
		private float[] a2;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x50")]
		private bool[] dir;

		// Token: 0x020000D6 RID: 214
		[Token(Token = "0x20000D6")]
		[Flags]
		private enum TangentType
		{
			// Token: 0x0400050B RID: 1291
			[Token(Token = "0x400050B")]
			OuterRight = 1,
			// Token: 0x0400050C RID: 1292
			[Token(Token = "0x400050C")]
			InnerRightLeft = 2,
			// Token: 0x0400050D RID: 1293
			[Token(Token = "0x400050D")]
			InnerLeftRight = 4,
			// Token: 0x0400050E RID: 1294
			[Token(Token = "0x400050E")]
			OuterLeft = 8,
			// Token: 0x0400050F RID: 1295
			[Token(Token = "0x400050F")]
			Outer = 9,
			// Token: 0x04000510 RID: 1296
			[Token(Token = "0x4000510")]
			Inner = 6
		}
	}
}
