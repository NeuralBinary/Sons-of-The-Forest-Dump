using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[Serializable]
	public class TerrainDigCollisionGrid
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA308C0", Offset = "0xA2EEC0", VA = "0x180A308C0")]
		public void SetNodeSize(float value)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000284C File Offset: 0x00000A4C
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2FBD320", Offset = "0x2FBB920", VA = "0x182FBD320")]
		private bool IsDefaultBucketValue(TerrainDigCollisionGrid.CollisionDataPoint value)
		{
			return default(bool);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2FBD330", Offset = "0x2FBB930", VA = "0x182FBD330")]
		public void SetActive(int x, int y, float yHeight, float depth)
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2FBD770", Offset = "0x2FBBD70", VA = "0x182FBD770")]
		public void ExpandHeight(int newHeight)
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2FBD940", Offset = "0x2FBBF40", VA = "0x182FBD940")]
		public void PadShiftHeight(int shift)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public void ExpandWidth(int newWidth)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2FBDAC0", Offset = "0x2FBC0C0", VA = "0x182FBDAC0")]
		public void PadShiftWidth(int shift)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2FBDD60", Offset = "0x2FBC360", VA = "0x182FBDD60")]
		public void DrawGizmosSelected(Vector3 boundsMin)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2FBE280", Offset = "0x2FBC880", VA = "0x182FBE280")]
		public void RebuildMesh(Bounds bounds)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2FBF520", Offset = "0x2FBDB20", VA = "0x182FBF520")]
		private float CalculateTerrainHeight(int x, int y, Vector3 boundsMin)
		{
			return 0f;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public Mesh GetMesh()
		{
			return null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2FBF5B0", Offset = "0x2FBDBB0", VA = "0x182FBF5B0")]
		public void Dispose()
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
		public int GetWidth()
		{
			return 0;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
		public int GetHeight()
		{
			return 0;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2FBF690", Offset = "0x2FBDC90", VA = "0x182FBF690")]
		public TerrainDigCollisionGrid()
		{
		}

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x0")]
		private static TerrainDigCollisionGrid.CollisionDataPoint _defaultBucketValue;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _width;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _height;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _nodeSize;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x20")]
		private List<List<TerrainDigCollisionGrid.CollisionDataPoint>> _buckets;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Mesh _collisionMesh;

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		private struct CollisionDataPoint
		{
			// Token: 0x060001E4 RID: 484 RVA: 0x000028AC File Offset: 0x00000AAC
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x2FBF740", Offset = "0x2FBDD40", VA = "0x182FBF740")]
			public float GetTerrainHeightOffset()
			{
				return 0f;
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x2FBF760", Offset = "0x2FBDD60", VA = "0x182FBF760")]
			public CollisionDataPoint(float terrainHeight, int depth)
			{
			}

			// Token: 0x040001F2 RID: 498
			[Token(Token = "0x40001F2")]
			[FieldOffset(Offset = "0x0")]
			public bool IsSet;

			// Token: 0x040001F3 RID: 499
			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x4")]
			public float TerrainHeight;

			// Token: 0x040001F4 RID: 500
			[Token(Token = "0x40001F4")]
			[FieldOffset(Offset = "0x8")]
			public float Depth;
		}
	}
}
