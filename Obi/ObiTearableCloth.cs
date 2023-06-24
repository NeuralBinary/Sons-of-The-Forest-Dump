using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[AddComponentMenu("Physics/Obi/Obi Tearable Cloth", 901)]
	[RequireComponent(typeof(MeshFilter))]
	public class ObiTearableCloth : ObiClothBase
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000021")]
		public override ObiActorBlueprint sourceBlueprint
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000022")]
		public override ObiClothBlueprintBase clothBlueprintBase
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0", Slot = "60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000023")]
		public ObiTearableClothBlueprint clothBlueprint
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x273C500", Offset = "0x273AB00", VA = "0x18273C500")]
			set
			{
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000DB RID: 219 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060000DC RID: 220 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000001")]
		public event ObiTearableCloth.ClothTornCallback OnClothTorn
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x273C6D0", Offset = "0x273ACD0", VA = "0x18273C6D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x273C7C0", Offset = "0x273ADC0", VA = "0x18273C7C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x273C8B0", Offset = "0x273AEB0", VA = "0x18273C8B0", Slot = "28")]
		public override void LoadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x273C990", Offset = "0x273AF90", VA = "0x18273C990", Slot = "29")]
		public override void UnloadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x273CA90", Offset = "0x273B090", VA = "0x18273CA90")]
		private void SetupRuntimeConstraints()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x273CA90", Offset = "0x273B090", VA = "0x18273CA90", Slot = "20")]
		protected override void OnValidate()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x273CAF0", Offset = "0x273B0F0", VA = "0x18273CAF0", Slot = "32")]
		public override void Substep(float substepTime)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x273CB90", Offset = "0x273B190", VA = "0x18273CB90")]
		private void ApplyTearing(float substepTime)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x273D3C0", Offset = "0x273B9C0", VA = "0x18273D3C0")]
		public bool Tear(StructuralConstraint edge)
		{
			return default(bool);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x273D740", Offset = "0x273BD40", VA = "0x18273D740")]
		private bool TopologySplitAttempt(ref int splitActorIndex, ref int intactActorIndex, out Vector3 point, out Vector3 normal, List<HalfEdgeMesh.Face> updatedFaces, HashSet<int> updatedHalfEdges)
		{
			return default(bool);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x273DE30", Offset = "0x273C430", VA = "0x18273DE30")]
		private void SplitParticle(int splitActorIndex)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x273E030", Offset = "0x273C630", VA = "0x18273E030")]
		private void WeakenCutPoint(int splitActorIndex, Vector3 point, Vector3 normal)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x273E580", Offset = "0x273CB80", VA = "0x18273E580")]
		private void ClassifyFaces(HalfEdgeMesh.Vertex vertex, Plane plane, List<HalfEdgeMesh.Face> side1, List<HalfEdgeMesh.Face> side2)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x273EC20", Offset = "0x273D220", VA = "0x18273EC20")]
		private bool SplitTopologyAtVertex(int vertexIndex, Plane plane, List<HalfEdgeMesh.Face> updatedFaces, HashSet<int> updatedEdgeIndices)
		{
			return default(bool);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x273F800", Offset = "0x273DE00", VA = "0x18273F800")]
		private void UpdateTornDistanceConstraints(HashSet<int> updatedHalfEdges)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x273FC30", Offset = "0x273E230", VA = "0x18273FC30")]
		private void UpdateTornBendConstraints(int splitActorIndex)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x273FE70", Offset = "0x273E470", VA = "0x18273FE70", Slot = "61")]
		public override void UpdateDeformableTriangles()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void Update()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2740090", Offset = "0x273E690", VA = "0x182740090")]
		public ObiTearableCloth()
		{
		}

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_TearingPerfMarker;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0xE0")]
		public ObiTearableClothBlueprint m_TearableClothBlueprint;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0xE8")]
		private ObiTearableClothBlueprint m_TearableBlueprintInstance;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0xF0")]
		public bool tearingEnabled;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xF4")]
		public float tearResistanceMultiplier;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xF8")]
		public int tearRate;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xFC")]
		[Range(0f, 1f)]
		public float tearDebilitation;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x108")]
		private int btch;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x10C")]
		private int ctr;

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x060000F1 RID: 241
		[Token(Token = "0x200001A")]
		public delegate void ClothTornCallback(ObiTearableCloth cloth, ObiTearableCloth.ObiClothTornEventArgs tearInfo);

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x200001B")]
		public class ObiClothTornEventArgs
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2740160", Offset = "0x273E760", VA = "0x182740160")]
			public ObiClothTornEventArgs(StructuralConstraint edge, int particle, List<HalfEdgeMesh.Face> updatedFaces)
			{
			}

			// Token: 0x0400009A RID: 154
			[Token(Token = "0x400009A")]
			[FieldOffset(Offset = "0x10")]
			public StructuralConstraint edge;

			// Token: 0x0400009B RID: 155
			[Token(Token = "0x400009B")]
			[FieldOffset(Offset = "0x20")]
			public int particleIndex;

			// Token: 0x0400009C RID: 156
			[Token(Token = "0x400009C")]
			[FieldOffset(Offset = "0x28")]
			public List<HalfEdgeMesh.Face> updatedFaces;
		}
	}
}
