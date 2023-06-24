using System;
using Assemblies.Sons.VFX;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.VFX
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[AddComponentMenu("Sons/VFX/BeachWaveVFXTimePass")]
	public class BeachWaveVFXTimePass : MonoBehaviour
	{
		// Token: 0x06000067 RID: 103 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x316BE90", Offset = "0x316A490", VA = "0x18316BE90")]
		public float RemainingLoopTime()
		{
			return 0f;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BeachWaveVFXTimePass()
		{
		}

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BeachWaveVFX _beachWaveVFX;
	}
}
