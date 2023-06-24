using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	[CreateAssetMenu(fileName = "rope blueprint", menuName = "Obi/Rope Blueprint", order = 140)]
	public class ObiRopeBlueprint : ObiRopeBlueprintBase
	{
		// Token: 0x060009C5 RID: 2501 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x280EFE0", Offset = "0x280D5E0", VA = "0x18280EFE0", Slot = "17")]
		protected override IEnumerator Initialize()
		{
			return null;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x280F070", Offset = "0x280D670", VA = "0x18280F070", Slot = "18")]
		protected virtual IEnumerator CreateDistanceConstraints()
		{
			return null;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x280F100", Offset = "0x280D700", VA = "0x18280F100", Slot = "19")]
		protected virtual IEnumerator CreateBendingConstraints()
		{
			return null;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x280F190", Offset = "0x280D790", VA = "0x18280F190")]
		public ObiRopeBlueprint()
		{
		}

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x138")]
		public int pooledParticles;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		public const float DEFAULT_PARTICLE_MASS = 0.1f;
	}
}
