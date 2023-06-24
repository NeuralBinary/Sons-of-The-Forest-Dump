using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[ExecuteInEditMode]
	public abstract class GraphModifier : VersionedMonoBehaviour
	{
		// Token: 0x06000308 RID: 776 RVA: 0x00003A04 File Offset: 0x00001C04
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x658290", Offset = "0x656890", VA = "0x180658290")]
		public static bool SetDisableUpdates(bool newValue)
		{
			return default(bool);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		protected static List<T> GetModifiersOfType<T>() where T : GraphModifier
		{
			return null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x6582F0", Offset = "0x6568F0", VA = "0x1806582F0")]
		public static void FindAllModifiers()
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x6584A0", Offset = "0x656AA0", VA = "0x1806584A0")]
		public static void TriggerEvent(GraphModifier.EventType type)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x658A20", Offset = "0x657020", VA = "0x180658A20", Slot = "10")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x658A50", Offset = "0x657050", VA = "0x180658A50", Slot = "11")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x658A60", Offset = "0x657060", VA = "0x180658A60", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x658A80", Offset = "0x657080", VA = "0x180658A80")]
		private void ConfigureUniqueID()
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x658C40", Offset = "0x657240", VA = "0x180658C40")]
		private void AddToLinkedList()
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x658F30", Offset = "0x657530", VA = "0x180658F30")]
		private void RemoveFromLinkedList()
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x6594D0", Offset = "0x657AD0", VA = "0x1806594D0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "13")]
		public virtual void OnPostScan()
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		public virtual void OnPreScan()
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		public virtual void OnLatePostScan()
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		public virtual void OnPostCacheLoad()
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		public virtual void OnGraphsPreUpdate()
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "18")]
		public virtual void OnGraphsPostUpdate()
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x659550", Offset = "0x657B50", VA = "0x180659550", Slot = "8")]
		protected override void Reset()
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected GraphModifier()
		{
		}

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x0")]
		private static GraphModifier root;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x28")]
		private GraphModifier prev;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x30")]
		private GraphModifier next;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		protected ulong uniqueID;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x8")]
		protected static Dictionary<ulong, GraphModifier> usedIDs;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x10")]
		private static bool _disableUpdates;

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		public enum EventType
		{
			// Token: 0x04000236 RID: 566
			[Token(Token = "0x4000236")]
			PostScan = 1,
			// Token: 0x04000237 RID: 567
			[Token(Token = "0x4000237")]
			PreScan,
			// Token: 0x04000238 RID: 568
			[Token(Token = "0x4000238")]
			LatePostScan = 4,
			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000239")]
			PreUpdate = 8,
			// Token: 0x0400023A RID: 570
			[Token(Token = "0x400023A")]
			PostUpdate = 16,
			// Token: 0x0400023B RID: 571
			[Token(Token = "0x400023B")]
			PostCacheLoad = 32
		}
	}
}
