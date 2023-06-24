using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public abstract class RVOObstacle : VersionedMonoBehaviour
	{
		// Token: 0x06000AE3 RID: 2787
		[Token(Token = "0x6000AE3")]
		protected abstract void CreateObstacles();

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000AE4 RID: 2788
		[Token(Token = "0x1700017B")]
		protected abstract bool ExecuteInEditor { [Token(Token = "0x6000AE4")] get; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000AE5 RID: 2789
		[Token(Token = "0x1700017C")]
		protected abstract bool LocalCoordinates { [Token(Token = "0x6000AE5")] get; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000AE6 RID: 2790
		[Token(Token = "0x1700017D")]
		protected abstract bool StaticObstacle { [Token(Token = "0x6000AE6")] get; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000AE7 RID: 2791
		[Token(Token = "0x1700017E")]
		protected abstract float Height { [Token(Token = "0x6000AE7")] get; }

		// Token: 0x06000AE8 RID: 2792
		[Token(Token = "0x6000AE8")]
		protected abstract bool AreGizmosDirty();

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x725750", Offset = "0x723D50", VA = "0x180725750")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x725760", Offset = "0x723D60", VA = "0x180725760")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x725770", Offset = "0x723D70", VA = "0x180725770")]
		public void OnDrawGizmos(bool selected)
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x000069EC File Offset: 0x00004BEC
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x7266A0", Offset = "0x724CA0", VA = "0x1807266A0", Slot = "16")]
		protected virtual Matrix4x4 GetMatrix()
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x726800", Offset = "0x724E00", VA = "0x180726800")]
		public void OnDisable()
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x7269C0", Offset = "0x724FC0", VA = "0x1807269C0")]
		public void OnEnable()
		{
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x726BB0", Offset = "0x7251B0", VA = "0x180726BB0")]
		public void Start()
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x726D50", Offset = "0x725350", VA = "0x180726D50")]
		public void Update()
		{
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x726FA0", Offset = "0x7255A0", VA = "0x180726FA0")]
		protected void FindSimulator()
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x727180", Offset = "0x725780", VA = "0x180727180")]
		protected void AddObstacle(Vector3[] vertices, float height)
		{
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x727390", Offset = "0x725990", VA = "0x180727390")]
		private void AddObstacleInternal(Vector3[] vertices, float height)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x727520", Offset = "0x725B20", VA = "0x180727520")]
		private void WindCorrectly(Vector3[] vertices)
		{
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x727AA0", Offset = "0x7260A0", VA = "0x180727AA0")]
		protected RVOObstacle()
		{
		}

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x28")]
		public RVOObstacle.ObstacleVertexWinding obstacleMode;

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x2C")]
		public RVOLayer layer;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x30")]
		protected Simulator sim;

		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x38")]
		private List<ObstacleVertex> addedObstacles;

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector3[]> sourceObstacles;

		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0x48")]
		private bool gizmoDrawing;

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x50")]
		private List<Vector3[]> gizmoVerts;

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x58")]
		private RVOObstacle.ObstacleVertexWinding _obstacleMode;

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x5C")]
		private Matrix4x4 prevUpdateMatrix;

		// Token: 0x0200015E RID: 350
		[Token(Token = "0x200015E")]
		public enum ObstacleVertexWinding
		{
			// Token: 0x04000798 RID: 1944
			[Token(Token = "0x4000798")]
			KeepOut,
			// Token: 0x04000799 RID: 1945
			[Token(Token = "0x4000799")]
			KeepIn
		}
	}
}
