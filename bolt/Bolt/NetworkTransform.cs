using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[Documentation]
	public class NetworkTransform
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000117")]
		public Transform Transform
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x17000118")]
		public Vector3 Position
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x781540", Offset = "0x77FB40", VA = "0x180781540")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x17000119")]
		public Quaternion Rotation
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x8F5080", Offset = "0x8F3680", VA = "0x1808F5080")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetExtrapolationClamper(Func<BoltEntity, Vector3, Vector3> clamper)
		{
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x8F5090", Offset = "0x8F3690", VA = "0x1808F5090")]
		public void SetTransforms(Transform simulate)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x8F50A0", Offset = "0x8F36A0", VA = "0x1808F50A0")]
		public void SetTransforms(Transform simulate, Transform render)
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x8F5430", Offset = "0x8F3A30", VA = "0x1808F5430")]
		public NetworkTransform()
		{
		}

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x10")]
		internal Transform Render;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x18")]
		internal Transform Simulate;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x20")]
		internal Func<BoltEntity, Vector3, Vector3> Clamper;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x28")]
		internal DoubleBuffer<Vector3> RenderDoubleBufferPosition;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x40")]
		internal DoubleBuffer<Quaternion> RenderDoubleBufferRotation;
	}
}
