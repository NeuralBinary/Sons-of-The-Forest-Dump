using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	public abstract class ObiConstraintsBatch : IObiConstraintsBatch
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00003DC4 File Offset: 0x00001FC4
		[Token(Token = "0x1700009F")]
		public int constraintCount
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00003DDC File Offset: 0x00001FDC
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000A0")]
		public int activeConstraintCount
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0", Slot = "5")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x781500", Offset = "0x77FB00", VA = "0x180781500", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00003DF4 File Offset: 0x00001FF4
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000A1")]
		public virtual int initialActiveConstraintCount
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000", Slot = "20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600055B RID: 1371
		[Token(Token = "0x170000A2")]
		public abstract Oni.ConstraintType constraintType { [Token(Token = "0x600055B")] get; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600055C RID: 1372
		[Token(Token = "0x170000A3")]
		public abstract IConstraintsBatchImpl implementation { [Token(Token = "0x600055C")] get; }

		// Token: 0x0600055D RID: 1373 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x27B5290", Offset = "0x27B3890", VA = "0x1827B5290", Slot = "24")]
		public virtual void Merge(ObiActor actor, IObiConstraintsBatch other)
		{
		}

		// Token: 0x0600055E RID: 1374
		[Token(Token = "0x600055E")]
		protected abstract void SwapConstraints(int sourceIndex, int destIndex);

		// Token: 0x0600055F RID: 1375
		[Token(Token = "0x600055F")]
		public abstract void GetParticlesInvolved(int index, List<int> particles);

		// Token: 0x06000560 RID: 1376
		[Token(Token = "0x6000560")]
		public abstract void AddToSolver(ObiSolver solver);

		// Token: 0x06000561 RID: 1377
		[Token(Token = "0x6000561")]
		public abstract void RemoveFromSolver(ObiSolver solver);

		// Token: 0x06000562 RID: 1378 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "29")]
		protected virtual void CopyConstraint(ObiConstraintsBatch batch, int constraintIndex)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x27B5330", Offset = "0x27B3930", VA = "0x1827B5330")]
		private void InnerSwapConstraints(int sourceIndex, int destIndex)
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x27B54D0", Offset = "0x27B3AD0", VA = "0x1827B54D0")]
		protected void RegisterConstraint()
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x27B55C0", Offset = "0x27B3BC0", VA = "0x1827B55C0", Slot = "30")]
		public virtual void Clear()
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00003E0C File Offset: 0x0000200C
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x27B5650", Offset = "0x27B3C50", VA = "0x1827B5650")]
		public int GetConstraintIndex(int constraintId)
		{
			return 0;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00003E24 File Offset: 0x00002024
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x27B56E0", Offset = "0x27B3CE0", VA = "0x1827B56E0")]
		public bool IsConstraintActive(int index)
		{
			return default(bool);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00003E3C File Offset: 0x0000203C
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x27B56F0", Offset = "0x27B3CF0", VA = "0x1827B56F0", Slot = "15")]
		public bool ActivateConstraint(int constraintIndex)
		{
			return default(bool);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00003E54 File Offset: 0x00002054
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x27B5720", Offset = "0x27B3D20", VA = "0x1827B5720", Slot = "14")]
		public bool DeactivateConstraint(int constraintIndex)
		{
			return default(bool);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x27B5750", Offset = "0x27B3D50", VA = "0x1827B5750", Slot = "16")]
		public void DeactivateAllConstraints()
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x27B5760", Offset = "0x27B3D60", VA = "0x1827B5760")]
		public void RemoveConstraint(int constraintIndex)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x27B5860", Offset = "0x27B3E60", VA = "0x1827B5860", Slot = "19")]
		public void ParticlesSwapped(int index, int newIndex)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x27B5940", Offset = "0x27B3F40", VA = "0x1827B5940")]
		protected ObiConstraintsBatch()
		{
		}

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		protected List<int> m_IDs;

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		protected List<int> m_IDToIndex;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		protected int m_ConstraintCount;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		protected int m_ActiveConstraintCount;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		protected int m_InitialActiveConstraintCount;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public ObiNativeIntList particleIndices;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public ObiNativeFloatList lambdas;
	}
}
