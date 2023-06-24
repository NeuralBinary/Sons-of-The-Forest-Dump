using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[AddComponentMenu("Physics/Obi/Obi SkinnedCloth", 902)]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class ObiSkinnedCloth : ObiClothBase, ITetherConstraintsUser
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700001B")]
		public override ObiActorBlueprint sourceBlueprint
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700001C")]
		public override ObiClothBlueprintBase clothBlueprintBase
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0", Slot = "60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002384 File Offset: 0x00000584
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700001D")]
		public bool tetherConstraintsEnabled
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x27394A0", Offset = "0x2737AA0", VA = "0x1827394A0", Slot = "62")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x273A230", Offset = "0x2738830", VA = "0x18273A230", Slot = "63")]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700001E")]
		public float tetherCompliance
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x1342A20", Offset = "0x1341020", VA = "0x181342A20", Slot = "64")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x273A250", Offset = "0x2738850", VA = "0x18273A250", Slot = "65")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000023B4 File Offset: 0x000005B4
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700001F")]
		public float tetherScale
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1342C10", Offset = "0x1341210", VA = "0x181342C10", Slot = "66")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x273A270", Offset = "0x2738870", VA = "0x18273A270", Slot = "67")]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000020")]
		public ObiSkinnedClothBlueprint skinnedClothBlueprint
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x273A290", Offset = "0x2738890", VA = "0x18273A290")]
			set
			{
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x273A460", Offset = "0x2738A60", VA = "0x18273A460", Slot = "28")]
		public override void LoadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x273A710", Offset = "0x2738D10", VA = "0x18273A710", Slot = "20")]
		protected override void OnValidate()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x273A710", Offset = "0x2738D10", VA = "0x18273A710")]
		private void SetupRuntimeConstraints()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x273A780", Offset = "0x2738D80", VA = "0x18273A780", Slot = "18")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x273A910", Offset = "0x2738F10", VA = "0x18273A910", Slot = "19")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x273AA70", Offset = "0x2739070", VA = "0x18273AA70")]
		private void CreateBakedMeshIfNeeded()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x273AC70", Offset = "0x2739270", VA = "0x18273AC70")]
		private void SetTargetSkin()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x273BDE0", Offset = "0x273A3E0", VA = "0x18273BDE0", Slot = "31")]
		public override void BeginStep(float stepTime)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x273C130", Offset = "0x273A730", VA = "0x18273C130")]
		public ObiSkinnedCloth()
		{
		}

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_SetTargetSkinPerfMarker;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker m_SortSkinInputsPerfMarker;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker m_SetSkinInputsPerfMarker;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker m_BakeMeshPerfMarker;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		protected ObiSkinnedClothBlueprint m_SkinnedClothBlueprint;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		protected bool _tetherConstraintsEnabled;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		protected float _tetherCompliance;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Range(0.1f, 2f)]
		protected float _tetherScale;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0xF8")]
		private SkinnedMeshRenderer skin;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x100")]
		[HideInInspector]
		public List<Vector3> bakedVertices;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public List<Vector3> bakedNormals;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x110")]
		[HideInInspector]
		public List<Vector4> bakedTangents;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x118")]
		[HideInInspector]
		public Mesh bakedMesh;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x120")]
		private Vector3[] sortedPoints;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x128")]
		private Vector3[] sortedNormals;
	}
}
