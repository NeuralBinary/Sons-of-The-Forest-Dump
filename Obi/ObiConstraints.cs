using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	[Serializable]
	public abstract class ObiConstraints<T> : IObiConstraints where T : class, IObiConstraintsBatch
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000626")]
		public void Merge(ObiActor actor, IObiConstraints other)
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000627")]
		public IObiConstraintsBatch GetBatch(int i)
		{
			return null;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x6000628")]
		public int GetBatchCount()
		{
			return 0;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00003F8C File Offset: 0x0000218C
		[Token(Token = "0x6000629")]
		public int GetConstraintCount()
		{
			return 0;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00003FA4 File Offset: 0x000021A4
		[Token(Token = "0x600062A")]
		public int GetActiveConstraintCount()
		{
			return 0;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600062B")]
		public void DeactivateAllConstraints()
		{
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600062C")]
		public T GetFirstBatch()
		{
			return null;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00003FBC File Offset: 0x000021BC
		[Token(Token = "0x600062D")]
		public Oni.ConstraintType? GetConstraintType()
		{
			return null;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600062E")]
		public void Clear()
		{
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600062F")]
		public virtual T CreateBatch([Optional] T source)
		{
			return null;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000630")]
		public void AddBatch(T batch)
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00003FD4 File Offset: 0x000021D4
		[Token(Token = "0x6000631")]
		public bool RemoveBatch(T batch)
		{
			return default(bool);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00003FEC File Offset: 0x000021EC
		[Token(Token = "0x6000632")]
		public bool AddToSolver(ObiSolver solver)
		{
			return default(bool);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00004004 File Offset: 0x00002204
		[Token(Token = "0x6000633")]
		public bool RemoveFromSolver()
		{
			return default(bool);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000634")]
		protected ObiConstraints()
		{
		}

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		protected ObiSolver m_Solver;

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public List<T> batches;
	}
}
