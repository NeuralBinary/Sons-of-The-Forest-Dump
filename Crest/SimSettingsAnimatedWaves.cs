using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[CreateAssetMenu(fileName = "SimSettingsAnimatedWaves", menuName = "Crest/Animated Waves Sim Settings", order = 10000)]
	public class SimSettingsAnimatedWaves : SimSettingsBase
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x17000070")]
		public float AttenuationInShallows
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x17000071")]
		public SimSettingsAnimatedWaves.CollisionSources CollisionSource
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return SimSettingsAnimatedWaves.CollisionSources.None;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x17000072")]
		public int MaxQueryCount
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x9FA1E0", Offset = "0x9F87E0", VA = "0x1809FA1E0")]
		public ICollProvider CreateCollisionProvider()
		{
			return null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x9FA3B0", Offset = "0x9F89B0", VA = "0x1809FA3B0")]
		public IFlowProvider CreateFlowProvider(OceanRenderer ocean)
		{
			return null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x9FA520", Offset = "0x9F8B20", VA = "0x1809FA520")]
		public SimSettingsAnimatedWaves()
		{
		}

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("How much waves are dampened in shallow water.")]
		private float _attenuationInShallows;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("Where to obtain ocean shape on CPU for physics / gameplay.")]
		private SimSettingsAnimatedWaves.CollisionSources _collisionSource;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Maximum number of wave queries that can be performed when using ComputeShaderQueries.")]
		[PredicatedField("_collisionSource", true, 2)]
		[SerializeField]
		private int _maxQueryCount;

		// Token: 0x02000050 RID: 80
		[Token(Token = "0x2000050")]
		public enum CollisionSources
		{
			// Token: 0x0400015D RID: 349
			[Token(Token = "0x400015D")]
			None,
			// Token: 0x0400015E RID: 350
			[Token(Token = "0x400015E")]
			GerstnerWavesCPU,
			// Token: 0x0400015F RID: 351
			[Token(Token = "0x400015F")]
			ComputeShaderQueries
		}
	}
}
