using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_procedural_world.php")]
	public class ProceduralWorld : MonoBehaviour
	{
		// Token: 0x06000B65 RID: 2917 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x734080", Offset = "0x732680", VA = "0x180734080")]
		private void Start()
		{
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x734190", Offset = "0x732790", VA = "0x180734190")]
		private void Update()
		{
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x734750", Offset = "0x732D50", VA = "0x180734750")]
		private IEnumerator GenerateTiles()
		{
			return null;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x7347E0", Offset = "0x732DE0", VA = "0x1807347E0")]
		public ProceduralWorld()
		{
		}

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x28")]
		public ProceduralWorld.ProceduralPrefab[] prefabs;

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x30")]
		public int range;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x34")]
		public int disableAsyncLoadWithinRange;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x38")]
		public float tileSize;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x3C")]
		public int subTiles;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x40")]
		public bool staticBatching;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x48")]
		private Queue<IEnumerator> tileGenerationQueue;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<Int2, ProceduralWorld.ProceduralTile> tiles;

		// Token: 0x0200016C RID: 364
		[Token(Token = "0x200016C")]
		public enum RotationRandomness
		{
			// Token: 0x0400082E RID: 2094
			[Token(Token = "0x400082E")]
			AllAxes,
			// Token: 0x0400082F RID: 2095
			[Token(Token = "0x400082F")]
			Y
		}

		// Token: 0x0200016D RID: 365
		[Token(Token = "0x200016D")]
		[Serializable]
		public class ProceduralPrefab
		{
			// Token: 0x06000B69 RID: 2921 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x7349E0", Offset = "0x732FE0", VA = "0x1807349E0")]
			public ProceduralPrefab()
			{
			}

			// Token: 0x04000830 RID: 2096
			[Token(Token = "0x4000830")]
			[FieldOffset(Offset = "0x10")]
			public GameObject prefab;

			// Token: 0x04000831 RID: 2097
			[Token(Token = "0x4000831")]
			[FieldOffset(Offset = "0x18")]
			public float density;

			// Token: 0x04000832 RID: 2098
			[Token(Token = "0x4000832")]
			[FieldOffset(Offset = "0x1C")]
			public float perlin;

			// Token: 0x04000833 RID: 2099
			[Token(Token = "0x4000833")]
			[FieldOffset(Offset = "0x20")]
			public float perlinPower;

			// Token: 0x04000834 RID: 2100
			[Token(Token = "0x4000834")]
			[FieldOffset(Offset = "0x24")]
			public Vector2 perlinOffset;

			// Token: 0x04000835 RID: 2101
			[Token(Token = "0x4000835")]
			[FieldOffset(Offset = "0x2C")]
			public float perlinScale;

			// Token: 0x04000836 RID: 2102
			[Token(Token = "0x4000836")]
			[FieldOffset(Offset = "0x30")]
			public float random;

			// Token: 0x04000837 RID: 2103
			[Token(Token = "0x4000837")]
			[FieldOffset(Offset = "0x34")]
			public ProceduralWorld.RotationRandomness randomRotation;

			// Token: 0x04000838 RID: 2104
			[Token(Token = "0x4000838")]
			[FieldOffset(Offset = "0x38")]
			public bool singleFixed;
		}

		// Token: 0x0200016E RID: 366
		[Token(Token = "0x200016E")]
		private class ProceduralTile
		{
			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00006D94 File Offset: 0x00004F94
			// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x17000197")]
			public bool destroyed
			{
				[Token(Token = "0x6000B6A")]
				[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000B6B")]
				[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000B6C RID: 2924 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x734A60", Offset = "0x733060", VA = "0x180734A60")]
			public ProceduralTile(ProceduralWorld world, int x, int z)
			{
			}

			// Token: 0x06000B6D RID: 2925 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x734B90", Offset = "0x733190", VA = "0x180734B90")]
			public IEnumerator Generate()
			{
				return null;
			}

			// Token: 0x06000B6E RID: 2926 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x734C20", Offset = "0x733220", VA = "0x180734C20")]
			public void ForceFinish()
			{
			}

			// Token: 0x06000B6F RID: 2927 RVA: 0x00006DAC File Offset: 0x00004FAC
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x734DF0", Offset = "0x7333F0", VA = "0x180734DF0")]
			private Vector3 RandomInside()
			{
				return default(Vector3);
			}

			// Token: 0x06000B70 RID: 2928 RVA: 0x00006DC4 File Offset: 0x00004FC4
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x734EC0", Offset = "0x7334C0", VA = "0x180734EC0")]
			private Vector3 RandomInside(float px, float pz)
			{
				return default(Vector3);
			}

			// Token: 0x06000B71 RID: 2929 RVA: 0x00006DDC File Offset: 0x00004FDC
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x734FA0", Offset = "0x7335A0", VA = "0x180734FA0")]
			private Quaternion RandomYRot(ProceduralWorld.ProceduralPrefab prefab)
			{
				return default(Quaternion);
			}

			// Token: 0x06000B72 RID: 2930 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x7351B0", Offset = "0x7337B0", VA = "0x1807351B0")]
			private IEnumerator InternalGenerate()
			{
				return null;
			}

			// Token: 0x06000B73 RID: 2931 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x735240", Offset = "0x733840", VA = "0x180735240")]
			public void Destroy()
			{
			}

			// Token: 0x04000839 RID: 2105
			[Token(Token = "0x4000839")]
			[FieldOffset(Offset = "0x10")]
			private int x;

			// Token: 0x0400083A RID: 2106
			[Token(Token = "0x400083A")]
			[FieldOffset(Offset = "0x14")]
			private int z;

			// Token: 0x0400083B RID: 2107
			[Token(Token = "0x400083B")]
			[FieldOffset(Offset = "0x18")]
			private System.Random rnd;

			// Token: 0x0400083C RID: 2108
			[Token(Token = "0x400083C")]
			[FieldOffset(Offset = "0x20")]
			private ProceduralWorld world;

			// Token: 0x0400083E RID: 2110
			[Token(Token = "0x400083E")]
			[FieldOffset(Offset = "0x30")]
			private Transform root;

			// Token: 0x0400083F RID: 2111
			[Token(Token = "0x400083F")]
			[FieldOffset(Offset = "0x38")]
			private IEnumerator ie;
		}
	}
}
