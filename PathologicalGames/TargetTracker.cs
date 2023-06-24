using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[AddComponentMenu("Path-o-logical/TargetPro/TargetTracker")]
	public class TargetTracker : MonoBehaviour
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00002A30 File Offset: 0x00000C30
		// (set) Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public TargetTracker.SORTING_STYLES sortingStyle
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return TargetTracker.SORTING_STYLES.None;
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x28D13B0", Offset = "0x28CF9B0", VA = "0x1828D13B0")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002A48 File Offset: 0x00000C48
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public Vector3 range
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x28D1490", Offset = "0x28CFA90", VA = "0x1828D1490")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x28D14B0", Offset = "0x28CFAB0", VA = "0x1828D14B0")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00002A60 File Offset: 0x00000C60
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public TargetTracker.PERIMETER_SHAPES perimeterShape
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
			get
			{
				return TargetTracker.PERIMETER_SHAPES.Capsule;
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x28D1590", Offset = "0x28CFB90", VA = "0x1828D1590")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00002A78 File Offset: 0x00000C78
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public Vector3 perimeterPositionOffset
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x6D15B0", Offset = "0x6CFBB0", VA = "0x1806D15B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x28D1660", Offset = "0x28CFC60", VA = "0x1828D1660")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00002A90 File Offset: 0x00000C90
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		public Vector3 perimeterRotationOffset
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x28D17F0", Offset = "0x28CFDF0", VA = "0x1828D17F0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x28D1810", Offset = "0x28CFE10", VA = "0x1828D1810")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00002AA8 File Offset: 0x00000CA8
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public int perimeterLayer
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x28D1A40", Offset = "0x28D0040", VA = "0x1828D1A40")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x17000069")]
		public Color defaultGizmoColor
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x28D1BB0", Offset = "0x28D01B0", VA = "0x1828D1BB0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000285 RID: 645 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public Perimeter perimeter
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000287 RID: 647 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700006B")]
		public virtual TargetList targets
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x28D1BD0", Offset = "0x28D01D0", VA = "0x1828D1BD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x28D1F50", Offset = "0x28D0550", VA = "0x1828D1F50", Slot = "5")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x28D2510", Offset = "0x28D0B10", VA = "0x1828D2510")]
		private void UpdatePerimeterShape()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x28D27D0", Offset = "0x28D0DD0", VA = "0x1828D27D0")]
		private void UpdatePerimeterRange()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x28D2B40", Offset = "0x28D1140", VA = "0x1828D2B40")]
		public Vector3 GetNormalizedRange()
		{
			return default(Vector3);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x28D2C20", Offset = "0x28D1220", VA = "0x1828D2C20", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x28D2C80", Offset = "0x28D1280", VA = "0x1828D2C80", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x28D2DA0", Offset = "0x28D13A0", VA = "0x1828D2DA0")]
		public void AddOnPostSortDelegate(TargetTracker.OnPostSortDelegate del)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x8DD110", Offset = "0x8DB710", VA = "0x1808DD110")]
		public void SetOnPostSortDelegate(TargetTracker.OnPostSortDelegate del)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x28D2E90", Offset = "0x28D1490", VA = "0x1828D2E90")]
		public void RemoveOnPostSortDelegate(TargetTracker.OnPostSortDelegate del)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x28D2F80", Offset = "0x28D1580", VA = "0x1828D2F80")]
		public TargetTracker()
		{
		}

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x20")]
		public int numberOfTargets;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TargetTracker.SORTING_STYLES _sortingStyle;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x28")]
		public float sortInterval;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _range;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x38")]
		public LayerMask targetLayers;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TargetTracker.PERIMETER_SHAPES _perimeterShape;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 _perimeterPositionOffset;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector3 _perimeterRotationOffset;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int _perimeterLayer;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x5C")]
		public DEBUG_LEVELS debugLevel;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x60")]
		public bool drawGizmo;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x64")]
		public Color gizmoColor;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x74")]
		public bool overrideGizmoVisibility;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x80")]
		protected TargetList _targets;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x88")]
		public Transform xform;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x90")]
		protected TargetTracker.OnPostSortDelegate onPostSortDelegates;

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		public enum PERIMETER_SHAPES
		{
			// Token: 0x04000165 RID: 357
			[Token(Token = "0x4000165")]
			Capsule,
			// Token: 0x04000166 RID: 358
			[Token(Token = "0x4000166")]
			Box,
			// Token: 0x04000167 RID: 359
			[Token(Token = "0x4000167")]
			Sphere
		}

		// Token: 0x0200005D RID: 93
		[Token(Token = "0x200005D")]
		public enum SORTING_STYLES
		{
			// Token: 0x04000169 RID: 361
			[Token(Token = "0x4000169")]
			None,
			// Token: 0x0400016A RID: 362
			[Token(Token = "0x400016A")]
			Nearest,
			// Token: 0x0400016B RID: 363
			[Token(Token = "0x400016B")]
			Farthest,
			// Token: 0x0400016C RID: 364
			[Token(Token = "0x400016C")]
			NearestToDestination,
			// Token: 0x0400016D RID: 365
			[Token(Token = "0x400016D")]
			FarthestFromDestination,
			// Token: 0x0400016E RID: 366
			[Token(Token = "0x400016E")]
			MostPowerful,
			// Token: 0x0400016F RID: 367
			[Token(Token = "0x400016F")]
			LeastPowerful
		}

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000293 RID: 659
		[Token(Token = "0x200005E")]
		public delegate void OnPostSortDelegate(TargetList targets);

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x200005F")]
		public interface iTargetComparer : IComparer<Target>
		{
			// Token: 0x06000296 RID: 662
			[Token(Token = "0x6000296")]
			int Compare(Target targetA, Target targetB);
		}

		// Token: 0x02000060 RID: 96
		[Token(Token = "0x2000060")]
		public class TargetComparer : TargetTracker.iTargetComparer, IComparer<Target>
		{
			// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x28D3160", Offset = "0x28D1760", VA = "0x1828D3160")]
			public TargetComparer(TargetTracker.SORTING_STYLES sortStyle, Transform perimeterPos)
			{
			}

			// Token: 0x06000298 RID: 664 RVA: 0x00002AF0 File Offset: 0x00000CF0
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x28D31C0", Offset = "0x28D17C0", VA = "0x1828D31C0", Slot = "5")]
			public int Compare(Target targetA, Target targetB)
			{
				return 0;
			}

			// Token: 0x04000170 RID: 368
			[Token(Token = "0x4000170")]
			[FieldOffset(Offset = "0x10")]
			private Transform perimeterPos;

			// Token: 0x04000171 RID: 369
			[Token(Token = "0x4000171")]
			[FieldOffset(Offset = "0x18")]
			private TargetTracker.SORTING_STYLES sortStyle;
		}
	}
}
