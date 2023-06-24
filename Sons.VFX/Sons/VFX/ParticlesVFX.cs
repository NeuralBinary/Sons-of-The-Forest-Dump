using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

namespace Sons.VFX
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public class ParticlesVFX : SingletonBehaviour<ParticlesVFX>
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3172500", Offset = "0x3170B00", VA = "0x183172500", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x31725C0", Offset = "0x3170BC0", VA = "0x1831725C0")]
		public static void Spawn(ParticleTypes type, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x31726A0", Offset = "0x3170CA0", VA = "0x1831726A0")]
		private void SpawnInternal(ParticlesVFX.ParticleGroupDefinition def, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x3172A90", Offset = "0x3171090", VA = "0x183172A90")]
		public ParticlesVFX()
		{
		}

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<ParticlesVFX.ParticleGroupDefinition> _particleDefinitions;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x30")]
		private SpawnPool _spawnPool;

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		[Serializable]
		public class ParticleGroupDefinition
		{
			// Token: 0x17000003 RID: 3
			// (get) Token: 0x060000AE RID: 174 RVA: 0x000020E2 File Offset: 0x000002E2
			[Token(Token = "0x17000003")]
			public List<GameObject> ParticlePrefabs
			{
				[Token(Token = "0x60000AE")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x060000AF RID: 175 RVA: 0x000020E8 File Offset: 0x000002E8
			[Token(Token = "0x17000004")]
			public int SpawnAmountMin
			{
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002100 File Offset: 0x00000300
			[Token(Token = "0x17000005")]
			public int SpawnAmountMax
			{
				[Token(Token = "0x60000B0")]
				[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002118 File Offset: 0x00000318
			[Token(Token = "0x17000006")]
			public float MinScale
			{
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002130 File Offset: 0x00000330
			[Token(Token = "0x17000007")]
			public float MaxScale
			{
				[Token(Token = "0x60000B2")]
				[Address(RVA = "0x5EA840", Offset = "0x5E8E40", VA = "0x1805EA840")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x3172AF0", Offset = "0x31710F0", VA = "0x183172AF0")]
			public ParticleGroupDefinition()
			{
			}

			// Token: 0x040000D2 RID: 210
			[Token(Token = "0x40000D2")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private List<GameObject> _prefabs;

			// Token: 0x040000D3 RID: 211
			[Token(Token = "0x40000D3")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _spawnAmountMin;

			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private int _spawnAmountMax;

			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _minScale;

			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x40000D6")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private float _maxScale;
		}
	}
}
