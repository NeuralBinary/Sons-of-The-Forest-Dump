using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	public abstract class ObiClothRendererBase : MonoBehaviour
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001BB RID: 443 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060001BC RID: 444 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000002")]
		public event ObiActor.ActorCallback OnRendererUpdated
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2754E90", Offset = "0x2753490", VA = "0x182754E90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2754F80", Offset = "0x2753580", VA = "0x182754F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000055")]
		public virtual HalfEdgeMesh topology
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2755070", Offset = "0x2753670", VA = "0x182755070", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002804 File Offset: 0x00000A04
		[Token(Token = "0x17000056")]
		public virtual Matrix4x4 renderMatrix
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x27550B0", Offset = "0x27536B0", VA = "0x1827550B0", Slot = "5")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x27551B0", Offset = "0x27537B0", VA = "0x1827551B0", Slot = "6")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2755330", Offset = "0x2753930", VA = "0x182755330", Slot = "7")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x27554C0", Offset = "0x2753AC0", VA = "0x1827554C0", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2755550", Offset = "0x2753B50", VA = "0x182755550", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x27555E0", Offset = "0x2753BE0", VA = "0x1827555E0", Slot = "10")]
		protected virtual void GetClothMeshData()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2755950", Offset = "0x2753F50", VA = "0x182755950", Slot = "11")]
		protected virtual void SetClothMeshData()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		protected virtual void OnBlueprintLoaded(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		protected virtual void OnBlueprintUnloaded(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		protected virtual void SetupUpdate()
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2755A80", Offset = "0x2754080", VA = "0x182755A80", Slot = "15")]
		protected virtual void UpdateActiveVertex(ObiSolver solver, int actorIndex, int meshVertexIndex)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		protected virtual void UpdateInactiveVertex(ObiSolver solver, int actorIndex, int meshVertexIndex)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2756360", Offset = "0x2754960", VA = "0x182756360", Slot = "17")]
		public virtual void UpdateRenderer(ObiActor actor)
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x27568D0", Offset = "0x2754ED0", VA = "0x1827568D0")]
		protected ObiClothRendererBase()
		{
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_UpdateClothRendererPerfMarker;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x20")]
		protected ObiClothBase cloth;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x28")]
		protected List<Vector3> restNormals;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x30")]
		protected List<Vector4> restTangents;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x38")]
		protected List<Vector3> clothVertices;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x40")]
		protected List<Vector3> clothNormals;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x48")]
		protected List<Vector4> clothTangents;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x50")]
		protected List<Color> clothColors;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x58")]
		public ObiClothRendererBase.TangentSpaceUpdateMode tangentSpaceUpdate;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x5C")]
		public bool transferParticleColors;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x68")]
		private Matrix4x4 space;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[NonSerialized]
		public Mesh clothMesh;

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		public enum TangentSpaceUpdateMode
		{
			// Token: 0x04000172 RID: 370
			[Token(Token = "0x4000172")]
			None,
			// Token: 0x04000173 RID: 371
			[Token(Token = "0x4000173")]
			CopyNormalsFromSimulation,
			// Token: 0x04000174 RID: 372
			[Token(Token = "0x4000174")]
			RecalculateNormalsFromMesh,
			// Token: 0x04000175 RID: 373
			[Token(Token = "0x4000175")]
			RecalculateNormalsAndTangentsFromMesh,
			// Token: 0x04000176 RID: 374
			[Token(Token = "0x4000176")]
			TransformNormalsAndTangents
		}
	}
}
