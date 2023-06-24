using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class LightningMeshSurfaceScript : LightningBoltPrefabScriptBase
	{
		// Token: 0x0600014F RID: 335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA47DC0", Offset = "0xA463C0", VA = "0x180A47DC0")]
		private void CheckMesh()
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA48170", Offset = "0xA46770", VA = "0x180A48170", Slot = "9")]
		protected override LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA48250", Offset = "0xA46850", VA = "0x180A48250", Slot = "11")]
		protected virtual void PopulateSourcePoints(List<Vector3> points)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA48270", Offset = "0xA46870", VA = "0x180A48270")]
		public void CreateRandomLightningPath(List<Vector3> points)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA477E0", Offset = "0xA45DE0", VA = "0x180A477E0", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA48860", Offset = "0xA46E60", VA = "0x180A48860", Slot = "7")]
		protected override void Update()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA488D0", Offset = "0xA46ED0", VA = "0x180A488D0", Slot = "4")]
		public override void CreateLightningBolt(LightningBoltParameters parameters)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA48AA0", Offset = "0xA470A0", VA = "0x180A48AA0")]
		public LightningMeshSurfaceScript()
		{
		}

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x1F0")]
		[Header("Lightning Mesh Properties")]
		[Tooltip("The mesh filter. You must assign a mesh filter in order to create lightning on the mesh.")]
		public MeshFilter MeshFilter;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x1F8")]
		[Tooltip("The mesh collider. This is used to get random points on the mesh.")]
		public Collider MeshCollider;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x200")]
		[SingleLine("Random range that the point will offset from the mesh, using the normal of the chosen point to offset")]
		public RangeOfFloats MeshOffsetRange;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x208")]
		[Header("Lightning Path Properties")]
		[SingleLine("Range for points in the lightning path")]
		public RangeOfIntegers PathLengthCount;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x210")]
		[SingleLine("Range for minimum distance between points in the lightning path")]
		public RangeOfFloats MinimumPathDistanceRange;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x218")]
		[Tooltip("The maximum distance between mesh points. When walking the mesh, if a point is greater than this, the path direction is reversed. This tries to avoid paths crossing between mesh points that are not actually physically touching.")]
		public float MaximumPathDistance;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x21C")]
		private float maximumPathDistanceSquared;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x220")]
		[Tooltip("Whether to use spline interpolation between the path points. Paths must be at least 4 points long to be splined.")]
		public bool Spline;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x224")]
		[Tooltip("For spline. the distance hint for each spline segment. Set to <= 0 to use the generations to determine how many spline segments to use. If > 0, it will be divided by Generations before being applied. This value is a guideline and is approximate, and not uniform on the spline.")]
		public float DistancePerSegmentHint;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x228")]
		private readonly List<Vector3> sourcePoints;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x230")]
		private Mesh previousMesh;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x238")]
		private MeshHelper meshHelper;
	}
}
