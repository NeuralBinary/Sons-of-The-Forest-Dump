using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200037A RID: 890
	[Token(Token = "0x200037A")]
	public class DSparseGrid3<ElemType> : IGrid3 where ElemType : class, IGridElement3
	{
		// Token: 0x06001D3D RID: 7485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D3D")]
		public DSparseGrid3(ElemType toDuplicate)
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x000148C4 File Offset: 0x00012AC4
		[Token(Token = "0x6001D3E")]
		public bool Has(Vector3i index)
		{
			return default(bool);
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001D3F")]
		public ElemType Get(Vector3i index, bool allocateIfMissing = true)
		{
			return null;
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x000148DC File Offset: 0x00012ADC
		[Token(Token = "0x6001D40")]
		public bool Free(Vector3i index)
		{
			return default(bool);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D41")]
		public void FreeAll()
		{
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x000148F4 File Offset: 0x00012AF4
		[Token(Token = "0x17000468")]
		public int Count
		{
			[Token(Token = "0x6001D42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0001490C File Offset: 0x00012B0C
		[Token(Token = "0x17000469")]
		public double Density
		{
			[Token(Token = "0x6001D43")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00014924 File Offset: 0x00012B24
		[Token(Token = "0x1700046A")]
		public AxisAlignedBox3i BoundsInclusive
		{
			[Token(Token = "0x6001D44")]
			get
			{
				return default(AxisAlignedBox3i);
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x0001493C File Offset: 0x00012B3C
		[Token(Token = "0x1700046B")]
		public Vector3i Dimensions
		{
			[Token(Token = "0x6001D45")]
			get
			{
				return default(Vector3i);
			}
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001D46")]
		public IEnumerable<Vector3i> AllocatedIndices()
		{
			return null;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001D47")]
		public IEnumerable<KeyValuePair<Vector3i, ElemType>> Allocated()
		{
			return null;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001D48")]
		private ElemType allocate(Vector3i index)
		{
			return null;
		}

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0x0")]
		private ElemType exemplar;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<Vector3i, ElemType> elements;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0x0")]
		private AxisAlignedBox3i bounds;
	}
}
