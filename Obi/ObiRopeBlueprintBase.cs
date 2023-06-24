using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	public abstract class ObiRopeBlueprintBase : ObiActorBlueprint
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x000051EC File Offset: 0x000033EC
		[Token(Token = "0x1700018F")]
		public float interParticleDistance
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x2640F00", Offset = "0x263F500", VA = "0x182640F00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00005204 File Offset: 0x00003404
		[Token(Token = "0x17000190")]
		public float restLength
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x2811690", Offset = "0x280FC90", VA = "0x182811690")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x28116A0", Offset = "0x280FCA0", VA = "0x1828116A0")]
		public void OnEnable()
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x2811850", Offset = "0x280FE50", VA = "0x182811850")]
		public void OnDisable()
		{
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x28118E0", Offset = "0x280FEE0", VA = "0x1828118E0")]
		protected void ControlPointAdded(int index)
		{
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x2811930", Offset = "0x280FF30", VA = "0x182811930")]
		protected void ControlPointRenamed(int index)
		{
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x28119F0", Offset = "0x280FFF0", VA = "0x1828119F0")]
		protected void ControlPointRemoved(int index)
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x2811B60", Offset = "0x2810160", VA = "0x182811B60")]
		protected void CreateSimplices(int numSegments)
		{
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x2811C70", Offset = "0x2810270", VA = "0x182811C70", Slot = "17")]
		protected override IEnumerator Initialize()
		{
			return null;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x2811CB0", Offset = "0x28102B0", VA = "0x182811CB0")]
		protected ObiRopeBlueprintBase()
		{
		}

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x110")]
		[HideInInspector]
		[SerializeField]
		public ObiPath path;

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x118")]
		public float thickness;

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x11C")]
		[Range(0f, 1f)]
		public float resolution;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x120")]
		[HideInInspector]
		[SerializeField]
		protected float m_InterParticleDistance;

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		[HideInInspector]
		protected int totalParticles;

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[HideInInspector]
		protected float m_RestLength;

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x130")]
		[HideInInspector]
		public float[] restLengths;
	}
}
