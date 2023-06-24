using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	[CreateAssetMenu(fileName = "rod blueprint", menuName = "Obi/Rod Blueprint", order = 141)]
	public class ObiRodBlueprint : ObiRopeBlueprintBase
	{
		// Token: 0x060009A8 RID: 2472 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x280BBE0", Offset = "0x280A1E0", VA = "0x18280BBE0", Slot = "17")]
		protected override IEnumerator Initialize()
		{
			return null;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x280BC70", Offset = "0x280A270", VA = "0x18280BC70", Slot = "18")]
		protected virtual IEnumerator CreateStretchShearConstraints(List<Vector3> particleNormals)
		{
			return null;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x280BD70", Offset = "0x280A370", VA = "0x18280BD70", Slot = "19")]
		protected virtual IEnumerator CreateBendTwistConstraints()
		{
			return null;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x280BE00", Offset = "0x280A400", VA = "0x18280BE00", Slot = "20")]
		protected virtual IEnumerator CreateChainConstraints()
		{
			return null;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x280BE90", Offset = "0x280A490", VA = "0x18280BE90")]
		public ObiRodBlueprint()
		{
		}

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x138")]
		public bool keepInitialShape;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		public const float DEFAULT_PARTICLE_MASS = 0.1f;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		public const float DEFAULT_PARTICLE_ROTATIONAL_MASS = 0.01f;
	}
}
